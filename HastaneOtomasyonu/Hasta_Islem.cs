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
    public partial class Hasta_Islem : Form
    {
        public string kullanıcı { get; set; }

        public Hasta_Islem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L2ORHG2\\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Hastail hastail = new Hastail();
            hastail.Ill= comboBox1.Text;
            hastail.Klinik = comboBox3.Text;
            hastail.Tarih = dateTimePicker1.Value;
            hastail.Saat = maskedTextBox1.Text.Trim();
            HastaGiris hastaGiris = new HastaGiris();
            hastaGiris.Tckimlik = label4.Text.ToString();
            baglanti.Open();
            SqlCommand komutlar = new SqlCommand("insert into Randevu(Randevuİl, RandevuKlinik, RandevuTarih, RandevuSaat, HastaTc) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komutlar.Parameters.AddWithValue("@p1", hastail.Ill);
            komutlar.Parameters.AddWithValue("@p2", hastail.Klinik);
            komutlar.Parameters.AddWithValue("@p5", hastaGiris.Tckimlik); ;
            komutlar.Parameters.AddWithValue("@p4", hastail.Saat);
            if (string.IsNullOrWhiteSpace(hastail.Ill.ToString()) ||
               string.IsNullOrWhiteSpace(hastail.Klinik))
            {

                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                baglanti.Close();
                return;
            }
            if (TimeSpan.TryParse(hastail.Saat, out TimeSpan saat))
            {
            }
            else
            {
                MessageBox.Show("Geçersiz saat formatı. Lütfen doğru formatta girin!");
                baglanti.Close();
                return;
            }
            komutlar.Parameters.AddWithValue("@p3", hastail.Tarih);
            if (hastail.Tarih == DateTime.Now.Date || hastail.Tarih > DateTime.Now.Date)
            {
                MessageBox.Show("Randevu Başarıyla Alınmıştır");
                komutlar.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Geçerli Bir Tarih Seçiniz!");
                baglanti.Close();
                return;
            } 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HastaGiris hastagiris = new HastaGiris();
            hastagiris.Tckimlik = label4.Text;
            baglanti.Open();
            string select = "Select * from Randevu where HastaTc=@p1 ";
            SqlCommand komut = new SqlCommand(select, baglanti);
            komut.Parameters.AddWithValue("@p1", hastagiris.Tckimlik);
            SqlDataAdapter randevu = new SqlDataAdapter(komut);
            DataTable randevular = new DataTable();
            randevu.Fill(randevular);
            dataGridView2.DataSource = randevular;
            baglanti.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaGiris hastagiris = new HastaGiris();
            hastagiris.Tckimlik = label4.Text;
            Degistir frm = new Degistir();
            frm.tc = hastagiris.Tckimlik;
            frm.Show();

            //form değiştirme

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Hasta_Islem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void il()
        {

            baglanti.Open();
            SqlCommand komutlar = new SqlCommand("Select * from iller ", baglanti);
            SqlDataReader r = komutlar.ExecuteReader();
            while (r.Read())
            {

                comboBox1.Items.Add(r[1]);
            }
            baglanti.Close();
        }

        void hastabilgi()
        {
            label4.Text = kullanıcı;
            HastaGiris hastagiris = new HastaGiris();
            hastagiris.Tckimlik = label4.Text;

            baglanti.Open();
            SqlCommand ad = new SqlCommand("select * from Hasta where HastaTc=@a1", baglanti);
            ad.Parameters.AddWithValue("@a1", hastagiris.Tckimlik);
            SqlDataReader dr = ad.ExecuteReader();
            if (dr.Read())
            {
                label3.Text = dr[2].ToString();
                label6.Text = dr[3].ToString();
            }
            baglanti.Close();
        }

        void datagrid()
        {
            HastaGiris hastagiris = new HastaGiris();
            hastagiris.Tckimlik = label4.Text;
            baglanti.Open();
            string select = "Select * from Randevu where HastaTc=@p1 ";
            SqlCommand komut = new SqlCommand(select, baglanti);
            komut.Parameters.AddWithValue("@p1", hastagiris.Tckimlik);
            SqlDataAdapter randevu = new SqlDataAdapter(komut);
            DataTable randevular = new DataTable();
            randevu.Fill(randevular);
            dataGridView2.DataSource = randevular;
            baglanti.Close();
        }

        private void Hasta_Islem_Load(object sender, EventArgs e)
        {

            il();
            hastabilgi();
            datagrid();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Hastail hastail = new Hastail();
            hastail.Iller = comboBox1.SelectedIndex;
            comboBox2.Items.Clear();
            comboBox2.Text = string.Empty;
            comboBox3.Items.Clear();
            comboBox3.Text = string.Empty;
            baglanti.Open();
            SqlCommand komutlar = new SqlCommand("Select * from Hastane where sehirid=@a1 ", baglanti);
            komutlar.Parameters.AddWithValue("@a1", hastail.Iller + 1);
            SqlDataReader r = komutlar.ExecuteReader();
            while (r.Read())
            {
                comboBox2.Items.Add(r[4]);
            }
            baglanti.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();
            comboBox3.Text = string.Empty;
            baglanti.Open();
            SqlCommand komutlar = new SqlCommand("Select * from Poliklinik ", baglanti);
            SqlDataReader r = komutlar.ExecuteReader();
            while (r.Read())
            {
                comboBox3.Items.Add(r[1]);
            }
            baglanti.Close();

        }
    }
}
