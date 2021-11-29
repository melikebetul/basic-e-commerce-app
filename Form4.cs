using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source= DESKTOP-GFRI39B ;Initial Catalog=ucak_bilet_otomasyon;Integrated Security=True");

        SqlCommand komut = new SqlCommand();
        
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void geridon_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
        int i = 0;
        private int rez_id_ata()
        {
            Random ras = new Random();
            i = ras.Next(0,1000);

            return i;
        }
        int kno;
        
        private int koltukno_ata()
        {
            
            Random ras = new Random();
            kno = ras.Next(0, 150);

            return kno;
        }
        String r_id = "";
        private void rezervasyonyap_Click(object sender, EventArgs e)
        {
            
            kno += 1;

            komut.CommandText = "rezervasyonyap";
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@yolcutc",yolcutc.Text);
            komut.Parameters.AddWithValue("@kolotukno", koltukno_ata());
            

            komut.Connection = con;
            con.Open();
            komut.ExecuteNonQuery();
            komut.Parameters.Clear();
            komut.CommandType = CommandType.Text;
            verilerigoster();
            con.Close();

        }
        
        private void verilerigoster()
        {
            rezlistview.Items.Clear();
            con.Open();
            
           komut.Connection = con;
            komut.CommandText = "Select r.rez_id, r.koltukno, u.Saat, u.Varis, u.Tarih, u.Nereden, u.Nereye, u.fiyat,y.TC, u.ucusno  From ucus_goster as u inner join( yolcu_bilgi as y inner join rezervasyon as r on r.yolcutc=y.TC)  on y.ucusno=u.ucusno";
            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["rez_id"].ToString();
                r_id= oku["rez_id"].ToString();
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["ucusno"].ToString());
                
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["Nereden"].ToString());
                ekle.SubItems.Add(oku["Nereye"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
                
                ekle.SubItems.Add(oku["koltukno"].ToString());

                rezlistview.Items.Add(ekle);

            }
            odemerezid.Text = r_id;
            con.Close();
        }

        private void odemerezid_TextChanged(object sender, EventArgs e)
        {
            
            odemerezid.Text = r_id;
            odemerezid.Enabled = false;
        }

        private void odemeyap_Click(object sender, EventArgs e)
        {
            con.Open();
    
            

            komut.CommandText = "odemeyap";
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@rez_id", odemerezid.Text);
            komut.Parameters.AddWithValue("@hesapno", hesapno.Text);
            komut.Parameters.AddWithValue("@hesapsifre", cvv.Text);
            komut.Parameters.AddWithValue("@kartisim", kartisim.Text);


            komut.Connection = con;
            con.Open();
            komut.ExecuteNonQuery();
            komut.Parameters.Clear();
            komut.CommandType = CommandType.Text;
            verilerigoster();
            con.Close();
            odeme_verilerigoster();

        }

        private void odeme_verilerigoster()
        {
            odemelistview.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = con;
           
            komut.CommandText = "Select r.rez_id, y.TC, y.ucusno, o.kartisim, o.hesapno, u.fiyat  From ucus_goster as u inner join( yolcu_bilgi as y inner join( rezervasyon as r  inner join odeme as o on r.rez_id=o.rez_id )on r.yolcutc=y.TC)  on y.ucusno=u.ucusno";
            SqlDataReader oku = komut.ExecuteReader();
            
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["rez_id"].ToString();
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["ucusno"].ToString());

                ekle.SubItems.Add(oku["kartisim"].ToString());
                ekle.SubItems.Add(oku["hesapno"].ToString());
                ekle.SubItems.Add(oku["fiyat"].ToString());
              
                odemelistview.Items.Add(ekle);

            }
            odemerezid.Text = r_id;
            con.Close();
        }
    }
}
