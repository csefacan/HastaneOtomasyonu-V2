using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Hasta_Giris : Form
    {
        public Hasta_Giris()
        {
            InitializeComponent();
        }
        SqlConnection b = new SqlConnection("Data Source=DESKTOP-L2ORHG2\\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            HastaGiris hastagiris = new HastaGiris();
            hastagiris.Tckimlik = textBox1.Text;
            hastagiris.Sifre = textBox2.Text;
            b.Open();
            SqlCommand komut = new SqlCommand("Select*From Hasta where HastaTc=@p1 and Sifre=@p2", b);
            komut.Parameters.AddWithValue("@p1", hastagiris.Tckimlik);
            komut.Parameters.AddWithValue("@p2", hastagiris.Sifre);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Hasta_Islem frm = new Hasta_Islem();
                frm.kullanıcı = hastagiris.Tckimlik;
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Tekrar Deneyiniz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            b.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Sifremi_Unuttum frm = new Sifremi_Unuttum();
            frm.Show();
            

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Kayit frm = new Kayit();
            frm.Show();

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

        private void Hasta_Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "T.C Kimlik")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "T.C Kimlik";
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.PasswordChar = '*';
            }
        }
        char? none = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Şifre";
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bu karakterin TextBox'a yazılmasını engeller.
            }
        }

        private void Hasta_Giris_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 11;
        }
    }
}
