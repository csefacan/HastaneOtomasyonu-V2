using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneOtomasyonu
{
    public partial class Doktor_Giris : Form
    {
        public Doktor_Giris()
        {
            InitializeComponent();
        }
        SqlConnection b = new SqlConnection("Data Source=DESKTOP-L2ORHG2\\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            DoktorGiris doktorgiris = new DoktorGiris();
            doktorgiris.Tckimlik = textBox1.Text;
            doktorgiris.Sifre = textBox2.Text;

            b.Open();
            SqlCommand komut = new SqlCommand("Select*From Doktor where DoktorTc=@p1 and DoktorSifre=@p2", b);
            komut.Parameters.AddWithValue("@p1", doktorgiris.Tckimlik);
            komut.Parameters.AddWithValue("@p2", doktorgiris.Sifre);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Doktor_Islem frm = new Doktor_Islem();
                frm.tc = doktorgiris.Tckimlik;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tekrar Deneyiniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            b.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }

        }

        private void Doktor_Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Doktor_Giris_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 11;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bu karakterin TextBox'a yazılmasını engeller.
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text =="T.C Kimlik")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                textBox1.Text = "T.C Kimlik";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
            }
        }
        char? none = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                textBox2.Text = "Şifre";
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }
    }
}
