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

    public partial class Sekreter_Islem : Form
    {
        public string kullan { get; set; }
        public Sekreter_Islem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L2ORHG2\\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True");
        void Poliklink()
        {
            baglanti.Open();
            SqlCommand komutlar = new SqlCommand("Select * from Poliklinik ", baglanti);
            SqlDataReader r = komutlar.ExecuteReader();
            while (r.Read())
            {
                comboBox1.Items.Add(r[1]);
            }
            baglanti.Close();
        }
        void ad()
        {
            label4.Text = kullan;
            SekreterGiris sekreterGiris = new SekreterGiris();
            sekreterGiris.Tckimlik = label4.Text;
            baglanti.Open();
            SqlCommand ad = new SqlCommand("select * from Sekreter where SekreterTc=@a1", baglanti);
            ad.Parameters.AddWithValue("@a1", sekreterGiris.Tckimlik);
            SqlDataReader dr = ad.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = dr[2].ToString();
                label6.Text = dr[3].ToString();
                label12.Text = dr[5].ToString();
            }
            baglanti.Close();
        }

        private void Sekreter_Islem_Load(object sender, EventArgs e)
        {
            this.ActiveControl = maskedTextBox1;
            Poliklink();
            ad();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutlar = new SqlCommand("insert into Duyuru(Duyuru,sehirid) values (@p1,@p2)", baglanti);
            komutlar.Parameters.AddWithValue("@p1", textBox1.Text);
            komutlar.Parameters.AddWithValue("@p2", label12.Text);
            komutlar.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sekreteril sekreteril = new Sekreteril();
            sekreteril.Iller = label12.Text.ToString();
            sekreteril.Klinik = comboBox1.Text;
            sekreteril.Tarih = dateTimePicker1.Value;
            sekreteril.Saat = maskedTextBox2.Text.Trim();
            sekreteril.Hastatc = maskedTextBox1.Text;
            baglanti.Open();
            SqlCommand komutlar = new SqlCommand("insert into Randevu(Randevuİl, RandevuKlinik, RandevuTarih, RandevuSaat, HastaTc) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komutlar.Parameters.AddWithValue("@p1", sekreteril.Iller);
            komutlar.Parameters.AddWithValue("@p2", sekreteril.Klinik);
            komutlar.Parameters.AddWithValue("@p5", sekreteril.Hastatc);
            komutlar.Parameters.AddWithValue("@p4", sekreteril.Saat);
            if (string.IsNullOrWhiteSpace(sekreteril.Iller) ||
               string.IsNullOrWhiteSpace(sekreteril.Klinik) ||
               string.IsNullOrWhiteSpace(sekreteril.Hastatc) ||
               string.IsNullOrWhiteSpace(sekreteril.Saat))

            {

                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                baglanti.Close();
                return;
            }
                if (TimeSpan.TryParse(sekreteril.Saat, out TimeSpan saat))
                {

                }
                else
                {
                    // Hatalı format
                    MessageBox.Show("Geçersiz saat formatı. Lütfen doğru formatta girin!");
                    baglanti.Close();
                    return;
                }
                komutlar.Parameters.AddWithValue("@p3", sekreteril.Tarih);
                if (sekreteril.Tarih == DateTime.Now.Date || sekreteril.Tarih > DateTime.Now.Date)
                {

                    komutlar.ExecuteNonQuery();
                    baglanti.Close();

                }
                else
                {
                    MessageBox.Show("Geçerli Bir Tarih Seçiniz!");
                    baglanti.Close();
                    return;

                }
                MessageBox.Show("Randevu Kaydedildi!");

            }

            private void button3_Click(object sender, EventArgs e)
            {
                this.Close();
                Application.Exit();

            }


            private void Sekreter_Islem_FormClosed(object sender, FormClosedEventArgs e)
            {
                Application.Exit();
            }
        
    } 
}
