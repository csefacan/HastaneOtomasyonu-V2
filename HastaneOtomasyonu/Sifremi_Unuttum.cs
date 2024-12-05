using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HastaneOtomasyonu
{
    public partial class Sifremi_Unuttum : Form
    {
        public Sifremi_Unuttum()
        {
            InitializeComponent();
        }
        SqlConnection güncelle = new SqlConnection("Data Source=DESKTOP-L2ORHG2\\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            HastaGiris hastagiris = new HastaGiris();
            hastagiris.Tckimlik = textBox3.Text;
            hastagiris.Sifre = textBox1.Text;
            güncelle.Open();
            SqlCommand güncel = new SqlCommand("Update Hasta Set Sifre=@a1 where HastaTc=@a2 ", güncelle);
            güncel.Parameters.AddWithValue("@a1", hastagiris.Sifre);
            güncel.Parameters.AddWithValue("@a2", hastagiris.Tckimlik);
            if (string.IsNullOrWhiteSpace(hastagiris.Tckimlik))
            {

                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                güncelle.Close();
                return;
            }
            if (textBox1.Text != textBox2.Text)
            {
                MessageBox.Show("İki Şifre Aynı Değil!", "Yanlış Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                güncelle.Close();
                return;
            }
            if (hastagiris.Tckimlik.Length < 11)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                güncelle.Close();
                return;
            }
            if (hastagiris.Sifre.Length < 8)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                güncelle.Close();
                return;
            }
            else
            {
                MessageBox.Show("Şifre Başarıyla Değişmiştir!", "Şifre");
                güncel.ExecuteNonQuery();
                güncelle.Close();
            }

            this.Hide();

        }

        private void Sifremi_Unuttum_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int minLength = 8;

            if (textBox1.Text.Length < minLength)
            {
                label4.Text = $"Şifre en az {minLength} karakter olmalı."; // Uyarı etiketi
                label4.ForeColor = Color.Red;  // Kırmızı renkte hata
            }
            else
            {
                label4.Text = "";  // Şifre uzunluğu uygunsa hata mesajını temizle
            }
        }

        private void Sifremi_Unuttum_Load(object sender, EventArgs e)
        {
            textBox3.MaxLength = 11;
        }


        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bu karakterin TextBox'a yazılmasını engeller.
            }
        }

    }
}
