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
    
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source= DESKTOP-GFRI39B ;Initial Catalog=ucak_bilet_otomasyon;Integrated Security=True");

        SqlCommand komut = new SqlCommand();

        public Form2()
        {
            InitializeComponent();
        }

        private void ucusdetay_Click(object sender, EventArgs e)
        {
            ucus_verilerigoster();
        }
        
    
        private void ucus_verilerigoster()
        {
            ucusdetaylistview.Items.Clear();
            con.Open();
            komut.Connection = con;
            
            komut.CommandText = "Select u.ucusno, u.Nereden, u.Nereye, u.Tarih, u.Saat, u.Varis, p.pilotAdSoyad, p.pilottc as ptc, p.pilottelno , p.sirket, ucak.ucakkapasite , ucak.ucakmarka From Ucus_goster as u inner join (pilot as p inner join ucak on ucak.ucakid=p.ucakid) on u.ucusno=p.ucusno where u.ucusno='" + ucusnosorgula.Text + "'";

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["ucusno"].ToString();
                ekle.SubItems.Add(oku["Nereden"].ToString());
                ekle.SubItems.Add(oku["Nereye"].ToString());
                ekle.SubItems.Add(oku["Tarih"].ToString());
                ekle.SubItems.Add(oku["Saat"].ToString());
                ekle.SubItems.Add(oku["Varis"].ToString());
                ekle.SubItems.Add(oku["pilotAdSoyad"].ToString());
                ekle.SubItems.Add(oku["ptc"].ToString());
                ekle.SubItems.Add(oku["pilottelno"].ToString());
                ekle.SubItems.Add(oku["sirket"].ToString());
                ekle.SubItems.Add(oku["ucakkapasite"].ToString());
                ekle.SubItems.Add(oku["ucakmarka"].ToString());
                ucusdetaylistview.Items.Add(ekle);
            }
            con.Close();
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}
