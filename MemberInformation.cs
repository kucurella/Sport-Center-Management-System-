using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Database_Project
{
    public partial class MemberInformation : Form
    {
        public MemberInformation()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-A6MKNLU;Initial Catalog=SportCenter;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Members", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MemberNo"].ToString();
                ekle.SubItems.Add(oku["MemberID"].ToString());
                ekle.SubItems.Add(oku["Name"].ToString());
                ekle.SubItems.Add(oku["Surname"].ToString());
                ekle.SubItems.Add(oku["PhoneNumber"].ToString());
                ekle.SubItems.Add(oku["MailAddress"].ToString());
                ekle.SubItems.Add(oku["MembershipLevel"].ToString());
                ekle.SubItems.Add(oku["PersonalTrainer"].ToString());
                ekle.SubItems.Add(oku["StartDate"].ToString());
                ekle.SubItems.Add(oku["ExpiryDate"].ToString());
                ekle.SubItems.Add(oku["TotalAmount"].ToString());
                ekle.SubItems.Add(oku["Password"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void Goldverilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select * from Members where MembershipLevel like '%Gold%'", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();

            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["MemberNo"].ToString();
                ekle.SubItems.Add(oku2["MemberID"].ToString());
                ekle.SubItems.Add(oku2["Name"].ToString());
                ekle.SubItems.Add(oku2["Surname"].ToString());
                ekle.SubItems.Add(oku2["PhoneNumber"].ToString());
                ekle.SubItems.Add(oku2["MailAddress"].ToString());
                ekle.SubItems.Add(oku2["MembershipLevel"].ToString());
                ekle.SubItems.Add(oku2["PersonalTrainer"].ToString());
                ekle.SubItems.Add(oku2["StartDate"].ToString());
                ekle.SubItems.Add(oku2["ExpiryDate"].ToString());
                ekle.SubItems.Add(oku2["TotalAmount"].ToString());
                ekle.SubItems.Add(oku2["Password"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Goldverilerigoster();
        }


        private void Normalverilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Members where MembershipLevel like '%Normal%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MemberNo"].ToString();
                ekle.SubItems.Add(oku["MemberID"].ToString());
                ekle.SubItems.Add(oku["Name"].ToString());
                ekle.SubItems.Add(oku["Surname"].ToString());
                ekle.SubItems.Add(oku["PhoneNumber"].ToString());
                ekle.SubItems.Add(oku["MailAddress"].ToString());
                ekle.SubItems.Add(oku["MembershipLevel"].ToString());
                ekle.SubItems.Add(oku["PersonalTrainer"].ToString());
                ekle.SubItems.Add(oku["StartDate"].ToString());
                ekle.SubItems.Add(oku["ExpiryDate"].ToString());
                ekle.SubItems.Add(oku["TotalAmount"].ToString());
                ekle.SubItems.Add(oku["Password"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Normalverilerigoster();
        }



        private void SilverVerilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Members where MembershipLevel like '%Silver%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MemberNo"].ToString();
                ekle.SubItems.Add(oku["MemberID"].ToString());
                ekle.SubItems.Add(oku["Name"].ToString());
                ekle.SubItems.Add(oku["Surname"].ToString());
                ekle.SubItems.Add(oku["PhoneNumber"].ToString());
                ekle.SubItems.Add(oku["MailAddress"].ToString());
                ekle.SubItems.Add(oku["MembershipLevel"].ToString());
                ekle.SubItems.Add(oku["PersonalTrainer"].ToString());
                ekle.SubItems.Add(oku["StartDate"].ToString());
                ekle.SubItems.Add(oku["ExpiryDate"].ToString());
                ekle.SubItems.Add(oku["TotalAmount"].ToString());
                ekle.SubItems.Add(oku["Password"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            SilverVerilerigoster();
        }

          //ID ye göre arama
        private void button5_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Members where MemberID like '%"+txtAramaID.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MemberNo"].ToString();
                ekle.SubItems.Add(oku["MemberID"].ToString());
                ekle.SubItems.Add(oku["Name"].ToString());
                ekle.SubItems.Add(oku["Surname"].ToString());
                ekle.SubItems.Add(oku["PhoneNumber"].ToString());
                ekle.SubItems.Add(oku["MailAddress"].ToString());
                ekle.SubItems.Add(oku["MembershipLevel"].ToString());
                ekle.SubItems.Add(oku["PersonalTrainer"].ToString());
                ekle.SubItems.Add(oku["StartDate"].ToString());
                ekle.SubItems.Add(oku["ExpiryDate"].ToString());
                ekle.SubItems.Add(oku["TotalAmount"].ToString());
                ekle.SubItems.Add(oku["Password"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();


        }

        //Name göre arama
        private void btnAramaName_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Members where Name like '%" +txtAramaName.Text + "%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MemberNo"].ToString();
                ekle.SubItems.Add(oku["MemberID"].ToString());
                ekle.SubItems.Add(oku["Name"].ToString());
                ekle.SubItems.Add(oku["Surname"].ToString());
                ekle.SubItems.Add(oku["PhoneNumber"].ToString());
                ekle.SubItems.Add(oku["MailAddress"].ToString());
                ekle.SubItems.Add(oku["MembershipLevel"].ToString());
                ekle.SubItems.Add(oku["PersonalTrainer"].ToString());
                ekle.SubItems.Add(oku["StartDate"].ToString());
                ekle.SubItems.Add(oku["ExpiryDate"].ToString());
                ekle.SubItems.Add(oku["TotalAmount"].ToString());
                ekle.SubItems.Add(oku["Password"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();

        }
    }
}
