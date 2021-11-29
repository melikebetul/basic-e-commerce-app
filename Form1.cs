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
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source= DESKTOP-GFRI39B ;Initial Catalog=ucak_bilet_otomasyon;Integrated Security=True");
       
        private void ucusgor_Click(object sender, EventArgs e)
        {
            ucus_verilerigoster();
            ucusno.Text = uc;
        }

        SqlCommand komut = new SqlCommand();
        String uc = "";

        private void ucus_verilerigoster()
        {
            ucuslistview.Items.Clear();
            con.Open();
            
            komut.Connection = con;
            komut.CommandText = "Select * From Ucus_goster where Nereden='" + nereden.Text + "' and Nereye='"+nereye.Text+ "'and Tarih='" + tarih.Text + "'";

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["Ucusno"].ToString();
                uc = oku["Ucusno"].ToString(); 
                ekle.SubItems.Add(oku["Nereden"].ToString());
                ekle.SubItems.Add(oku["Nereye"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ucuslistview.Items.Add(ekle);
            }
            con.Close();

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            komut.CommandText = "yolcu_ekle";
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@AdSoyad", ad.Text);
            komut.Parameters.AddWithValue("@dg", dg.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", cnsyt.Text);
            komut.Parameters.AddWithValue("@Telno", tel.Text);
            komut.Parameters.AddWithValue("@TC", tc.Text);
            komut.Parameters.AddWithValue("@HESkodu", hes.Text);
            komut.Parameters.AddWithValue("@email", email.Text);
            komut.Parameters.AddWithValue("@ucusno", uc);
            
            komut.Connection = con;
            con.Open();
            komut.ExecuteNonQuery();
            komut.Parameters.Clear();
            komut.CommandType = CommandType.Text;
            verilerigoster();
            con.Close();
        }
        private void verilerigoster(){
            yolculistview.Items.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand();
           komut.Connection = con;
            komut.CommandText = "Select y.AdSoyad, y.dg, y.Cinsiyet, y.Telno, y.TC, y.HESkodu, y.email, y.ucusno as ucno, u.Nereden, u.Nereye From yolcu_bilgi as y inner join Ucus_goster as u on y.ucusno=u.ucusno";
            SqlDataReader oku = komut.ExecuteReader();
            
            
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["dg"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telno"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["HESkodu"].ToString());
                ekle.SubItems.Add(oku["email"].ToString());
                ekle.SubItems.Add(oku["ucno"].ToString());
                ekle.SubItems.Add(oku["Nereden"].ToString());
                ekle.SubItems.Add(oku["Nereye"].ToString());

                yolculistview.Items.Add(ekle);
            
            } 
            con.Close();

            
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void iptal_Click(object sender, EventArgs e)
        {
            
            komut.CommandText = "update_yolcu";
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@TC", tc.Text);
            

            komut.Connection = con;
            con.Open();
            komut.ExecuteNonQuery();
            komut.Parameters.Clear();
            komut.CommandType = CommandType.Text;
            verilerigoster();
            con.Close();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
           
            komut.CommandText = "update_yolcu";
            komut.CommandType = CommandType.StoredProcedure;
            komut.Parameters.AddWithValue("@AdSoyad", ad.Text);
            komut.Parameters.AddWithValue("@dg", dg.Text);
            komut.Parameters.AddWithValue("@Cinsiyet", cnsyt.Text);
            komut.Parameters.AddWithValue("@Telno", tel.Text);
            komut.Parameters.AddWithValue("@TC", tc.Text);
            komut.Parameters.AddWithValue("@HESkodu", hes.Text);
            komut.Parameters.AddWithValue("@email", email.Text);
            komut.Parameters.AddWithValue("@ucusno", uc);

            komut.Connection = con;
            con.Open();
            komut.ExecuteNonQuery();
            komut.Parameters.Clear();
            komut.CommandType = CommandType.Text;
            verilerigoster();
            con.Close();
        }

        private void ucusno_TextChanged(object sender, EventArgs e)
        {
            ucusno.Text = uc;
            ucusno.Enabled=false;
        }

        private void form2gec_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }

        private void biletsorgula_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            this.Hide();
            frm3.Show();
        }

        private void rezervasyon_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            this.Hide();
            frm4.Show();
        }
    }
}
