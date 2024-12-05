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
    public partial class Doktor_Islem : Form
    {
        public string tc { get; set; }
        public Doktor_Islem()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L2ORHG2\\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            Doktoril doktoril = new Doktoril();
            doktoril.Iller = label10.Text;
            Doktor doktor = new Doktor();
            doktor.Brans = label7.Text;
            baglanti.Open();
            string select = "Select * from Randevu where Randevuİl=@p1 and RandevuKlinik=@p2 ";
            SqlCommand komut = new SqlCommand(select, baglanti);
            komut.Parameters.AddWithValue("@p1", doktoril.Iller);
            komut.Parameters.AddWithValue("@p2", doktor.Brans);
            SqlDataAdapter randevu = new SqlDataAdapter(komut);
            DataTable randevular = new DataTable();
            randevu.Fill(randevular);
            dataGridView1.DataSource = randevular;
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

                Duyuru duyuru = new Duyuru();
            duyuru.sehirid = label10.Text;
                duyuru.Show();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Doktor_Islem_Load(object sender, EventArgs e)
        {
            label8.Text = tc;
            DoktorGiris doktorgiris = new DoktorGiris();
            doktorgiris.Tckimlik = label8.Text;  
            baglanti.Open();
            SqlCommand ad = new SqlCommand("select * from Doktor where DoktorTc=@a1", baglanti);
            ad.Parameters.AddWithValue("@a1", doktorgiris.Tckimlik);
            SqlDataReader dr = ad.ExecuteReader();
            if (dr.Read())
            {
                label5.Text = dr[2].ToString();
                label6.Text = dr[3].ToString();
                label7.Text = dr[4].ToString();
                label10.Text = dr[6].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            string select = "Select * from Randevu where Randevuİl=@p1 and RandevuKlinik=@p2 ";
            SqlCommand komut = new SqlCommand(select, baglanti);
            komut.Parameters.AddWithValue("@p1", label10.Text);
            komut.Parameters.AddWithValue("@p2", label7.Text);
            SqlDataAdapter randevu = new SqlDataAdapter(komut);
            DataTable randevular = new DataTable();
            randevu.Fill(randevular);
            dataGridView1.DataSource = randevular;
            baglanti.Close();

        }

        private void Doktor_Islem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
