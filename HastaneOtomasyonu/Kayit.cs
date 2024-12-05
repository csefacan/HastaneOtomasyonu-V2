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

namespace HastaneOtomasyonu
{
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }
        SqlConnection ekle = new SqlConnection("Data Source=DESKTOP-L2ORHG2\\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            hasta.Isim = textBox1.Text;
            hasta.Soyisim = textBox2.Text;
            hasta.Telefon = maskedTextBox2.Text;
            hasta.Dy = comboBox1.Text;
            Hastail hastail = new Hastail();
            hastail.Tarih = dateTimePicker1.Value;



            hasta.Cinsiyet = comboBox2.Text;


            HastaGiris hastagiris = new HastaGiris();
            hastagiris.Tckimlik = textBox4.Text;
            hastagiris.Sifre = textBox3.Text;

            ekle.Open();
            SqlCommand komutlar = new SqlCommand("insert into Hasta(HastaTc,HastaAdı,HastaSoyadı, HastaTelefon, HastaDogum_Yeri, HastaDogum_Tarihi,HastaCinsiyet, Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", ekle);
            komutlar.Parameters.AddWithValue("@p1", hastagiris.Tckimlik);
            komutlar.Parameters.AddWithValue("@p2", hasta.Isim);
            komutlar.Parameters.AddWithValue("@p3", hasta.Soyisim);
            komutlar.Parameters.AddWithValue("@p4", hasta.Telefon);
            komutlar.Parameters.AddWithValue("@p5", hasta.Dy);
            komutlar.Parameters.AddWithValue("@p6", hastail.Tarih);
            komutlar.Parameters.AddWithValue("@p7", hasta.Cinsiyet);
            komutlar.Parameters.AddWithValue("@p8", hastagiris.Sifre);
            
            if (string.IsNullOrWhiteSpace(hastagiris.Tckimlik) ||
                string.IsNullOrWhiteSpace(hasta.Isim) ||
                string.IsNullOrWhiteSpace(hasta.Soyisim) ||
                string.IsNullOrWhiteSpace(hasta.Telefon) ||
                string.IsNullOrWhiteSpace(hasta.Dy) ||
                string.IsNullOrWhiteSpace(hasta.Cinsiyet) ||
                string.IsNullOrWhiteSpace(hastagiris.Sifre)
                )
            {
                
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ekle.Close();
                return;
            }
            if(hastagiris.Tckimlik.Length<11)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ekle.Close();
                return;
            }
            if (hastail.Tarih == DateTime.Now.Date || hastail.Tarih > DateTime.Now.Date)
            {
                MessageBox.Show("Geçerli Bir Tarih Seçiniz!");
                ekle.Close();
                return;
            }
            if (hastagiris.Sifre.Length < 8)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ekle.Close();
                return;
            }
            else
            {
                MessageBox.Show("Kayıt başarılı!");
                komutlar.ExecuteNonQuery();
                ekle.Close();
            }

            this.Hide();

        }

        private void Kayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();

        }

        private void Kayit_Load(object sender, EventArgs e)
        {
            textBox4.MaxLength = 11;
            ekle.Open();
            SqlCommand komutlar = new SqlCommand("Select * from iller ", ekle);
            SqlDataReader r = komutlar.ExecuteReader();
            while (r.Read())
            {
                comboBox1.Items.Add(r[1]);
            }
            ekle.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int minLength = 8;

            if (textBox3.Text.Length < minLength)
            {
                label9.Text = $"Şifre en az {minLength} karakter olmalı."; // Uyarı etiketi
                label9.ForeColor = Color.Red;  // Kırmızı renkte hata
            }
            else
            {
                label9.Text = "";  // Şifre uzunluğu uygunsa hata mesajını temizle
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "T.C Kimlik")
            {
                textBox4.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "T.C Kimlik";
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bu karakterin TextBox'a yazılmasını engeller.
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "İsim")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "İsim";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bu karakterin TextBox'a yazılmasını engeller.
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Soyisim")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Soyisim";
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bu karakterin TextBox'a yazılmasını engeller.
            }
        }

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bu karakterin TextBox'a yazılmasını engeller.
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Şifre")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Şifre";
            }
        }

    }
}
