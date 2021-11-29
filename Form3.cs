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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source= DESKTOP-GFRI39B ;Initial Catalog=ucak_bilet_otomasyon;Integrated Security=True");

        SqlCommand komut = new SqlCommand();
        public Form3()
        {
            InitializeComponent();
        }
        private void bilet_verilerigoster()
        {
            biletlistview.Items.Clear();
            con.Open();

            komut.Connection = con;
            komut.CommandText = "Select y.AdSoyad, y.TC, y.ucusno as ucno, u.Nereden, u.Nereye, b.kgkapasite From  yolcu_bilgi as y inner join (Ucus_goster as u  inner join bagaj as b on b.ucusno=u.ucusno) on u.ucusno=y.ucusno where y.TC='" + tc.Text + "'and y.ucusno='"+ucusno.Text+"'";

            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["ucno"].ToString());
                ekle.SubItems.Add(oku["Nereden"].ToString());
                ekle.SubItems.Add(oku["Nereye"].ToString());
                ekle.SubItems.Add(oku["kgkapasite"].ToString());
                biletlistview.Items.Add(ekle);
            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void biletdetay_Click(object sender, EventArgs e)
        {
            bilet_verilerigoster();
        }

        private void geridon_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }
    }
}
