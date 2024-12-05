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
    public partial class Sekreter_Giris : Form
    {
        public Sekreter_Giris()
        {
            InitializeComponent();
        }
        SqlConnection b = new SqlConnection("Data Source=DESKTOP-L2ORHG2\\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SekreterGiris sekretergiris = new SekreterGiris();
            sekretergiris.Tckimlik = textBox1.Text;
            sekretergiris.Sifre = textBox2.Text;
            b.Open();
            SqlCommand komut = new SqlCommand("Select*From Sekreter where SekreterTc=@p1 and SekreterSifre=@p2", b);
            komut.Parameters.AddWithValue("@p1", sekretergiris.Tckimlik);
            komut.Parameters.AddWithValue("@p2", sekretergiris.Sifre);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Sekreter_Islem frm = new Sekreter_Islem();
                frm.kullan = sekretergiris.Tckimlik;
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

        private void Sekreter_Giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

        }

        private void Sekreter_Giris_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 11;
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
    }
}
