using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Etüt_proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti=new SqlConnection(@"Data Source = 10.0.2.15; Initial Catalog = Etut; Integrated Security = True");

        void derslistesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * From tbldersler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmdDers.ValueMember = "DERSID";
            CmdDers.DisplayMember = "DERSAD";
            CmdDers.DataSource = dt;
        }

        //ETÜT LİSTESİ
        void etutlistesi()
        {
            SqlDataAdapter da3 = new SqlDataAdapter("execute etut", baglanti);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView1.DataSource = dt3;
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            derslistesi();
            etutlistesi();
        }

        private void CmdDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT * FROM TBLOGRETMEN WHERE BRANS =" + CmdDers.SelectedValue, baglanti);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            CmdOgretmen.ValueMember = "OGRTID";
            CmdOgretmen.DisplayMember = "AD";
            CmdOgretmen.DataSource = dt2;
        }
      
        private void BtnEtut_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tbletut (dersıd,ogretmenıd,tarıh,SAAT) values (@p1,@p2,@p3,@p4)", baglanti);
            komut.Parameters.AddWithValue("@p1", CmdDers.SelectedValue);
            komut.Parameters.AddWithValue("@p2", CmdOgretmen.SelectedValue);
            komut.Parameters.AddWithValue("@p3", MskTarih.Text);
            komut.Parameters.AddWithValue("@p4", MskSaat.Text);

            komut.ExecuteNonQuery();


            baglanti.Close();

            MessageBox.Show("Etüt Oluşturuldu", "Bilgi", MessageBoxButtons.OK
                , MessageBoxIcon.Information);

          


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            TxtEtutId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnEtutVer_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update tbletut set ogrencııd=@p1,durum=@p2 where ıd=@p3",
                baglanti);

            komut.Parameters.AddWithValue("@p1", TextOgrenciid.Text);
            komut.Parameters.AddWithValue("@p2", "True");
            komut.Parameters.AddWithValue("@p3", TxtEtutId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Etüt Öğrenciye Verildi", "Bilgi", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }

        private void BtnFotoraf_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void BtnOgrenciEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLOGRENCİ (ad,soyad,fotograf,sınıf,telefon,maıl) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", Txtsoyad1.Text);
            komut.Parameters.AddWithValue("@p3", pictureBox1.ImageLocation);
            komut.Parameters.AddWithValue("@p4", TxtSinif.Text);
            komut.Parameters.AddWithValue("@p5", Txtsoyad1.Text);
            komut.Parameters.AddWithValue("@p6", TxtMail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Öğrenci Sisteme Kaydedildi", "Bilgi"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
