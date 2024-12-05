using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class Duyuru : Form
    {
        public string sehirid { get; set; }
        public Duyuru()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L2ORHG2\\MSSQLSERVER01;Initial Catalog=Hastane;Integrated Security=True");
        private void Duyuru_Load(object sender, EventArgs e)
        {
            label1.Text = sehirid;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            baglanti.Open();
            string select = "Select * from Duyuru where sehirid=@p1";
            SqlCommand komut = new SqlCommand(select, baglanti);
            komut.Parameters.AddWithValue("@p1", label1.Text);
            SqlDataAdapter duyuru = new SqlDataAdapter(komut);
            DataTable duyurular = new DataTable();
            duyuru.Fill(duyurular);
            dataGridView1.DataSource = duyurular;
            baglanti.Close();

        }
    }
}
