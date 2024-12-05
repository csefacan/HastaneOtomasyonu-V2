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
    public partial class Degistir : Form
    {
        public string tc { get; set; }
        public Degistir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L2ORHG2\\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            HastaGiris hastagiris = new HastaGiris();
            hastagiris.Tckimlik = maskedTextBox1.Text;
            hastagiris.Sifre = textBox3.Text;
            Hastail hastail = new Hastail();
            hastail.Tarih = dateTimePicker1.Value;
            Hasta hasta = new Hasta();
            hasta.Isim = textBox1.Text;
            hasta.Soyisim = textBox2.Text;
            hasta.Telefon = maskedTextBox2.Text;
            hasta.Dy = comboBox2.Text;
            hasta.Cinsiyet = comboBox1.Text;

            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Hasta Set Sifre=@a1, HastaAdı=@a2, HastaSoyadı=@a3,HastaTelefon=@a4, HastaDogum_Yeri=@a5, HastaDogum_Tarihi=@a6, HastaCinsiyet=@a7  where HastaTc=@a8", baglanti);
            guncelle.Parameters.AddWithValue("@a8", hastagiris.Tckimlik);
            guncelle.Parameters.AddWithValue("@a2", hasta.Isim);
            guncelle.Parameters.AddWithValue("@a3", hasta.Soyisim);
            guncelle.Parameters.AddWithValue("@a4", hasta.Telefon);
            guncelle.Parameters.AddWithValue("@a5", hasta.Dy);
            guncelle.Parameters.AddWithValue("@a6", hastail.Tarih);
            if (hastail.Tarih == DateTime.Now.Date || hastail.Tarih > DateTime.Now.Date)
            {
                MessageBox.Show("Geçerli Bir Tarih Seçiniz!");
                baglanti.Close();
                return;
            }

            guncelle.Parameters.AddWithValue("@a7", hasta.Cinsiyet);
            guncelle.Parameters.AddWithValue("@a1", hastagiris.Sifre);
            if (hastagiris.Sifre.Length < 8)
            {

                baglanti.Close();
                return;
            }
            else
            {
                MessageBox.Show("Değişiklik Başarıyla Olmuştur", "Değişiklik");
                guncelle.ExecuteNonQuery();
                baglanti.Close();
            }
 

        }

        private void Degistir_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutlar = new SqlCommand("Select * from iller ", baglanti);
            SqlDataReader r = komutlar.ExecuteReader();
            while (r.Read())
            {
                comboBox2.Items.Add(r[1]);
            }
            baglanti.Close();
            maskedTextBox1.Text = tc;

            baglanti.Open();
            SqlCommand ad = new SqlCommand("select * from Hasta where HastaTc=@a1", baglanti);
            ad.Parameters.AddWithValue("@a1", maskedTextBox1.Text);
            SqlDataReader dr = ad.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[2].ToString();
                textBox2.Text = dr[3].ToString();
                maskedTextBox2.Text = dr[4].ToString();
                comboBox2.Text = dr[5].ToString();
                dateTimePicker1.Text = dr[6].ToString();
                comboBox1.Text = dr[7].ToString();
                textBox3.Text = dr[8].ToString();

            }
            baglanti.Close();

        }

        private void Degistir_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Application.OpenForms["Hasta_Islem"].Show();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int minLength = 8;
            HastaGiris hastagiris = new HastaGiris();
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

        private void maskedTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Bu karakterin TextBox'a yazılmasını engeller.
            }
        }
    }
}
