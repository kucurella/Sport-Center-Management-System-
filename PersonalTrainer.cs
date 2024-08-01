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
    public partial class PersonalTrainer : Form
    {
        public PersonalTrainer()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-A6MKNLU;Initial Catalog=SportCenter;Integrated Security=True");
       
        private void ListeGoster()
        {
            
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PersonalTrainer", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["PersonalTrainerName"].ToString());
                ekle.SubItems.Add(oku["MembersIDs"].ToString());
                
              

                listView1.Items.Add(ekle);
              

            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListeGoster();
            
        }

        private void buttonPt1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PersonalTrainer where PersonalTrainerName like '%Mehmet Ali%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["PersonalTrainerName"].ToString());
                ekle.SubItems.Add(oku["MembersIDs"].ToString());
               

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void buttonPt5_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PersonalTrainer where PersonalTrainerName like '%Murat Alper%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["PersonalTrainerName"].ToString());
                ekle.SubItems.Add(oku["MembersIDs"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void buttonPt2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PersonalTrainer where PersonalTrainerName like '%Serda Kılıç%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["PersonalTrainerName"].ToString());
                ekle.SubItems.Add(oku["MembersIDs"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void buttonPt3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PersonalTrainer where PersonalTrainerName like '%Mustafa Özsöz%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["PersonalTrainerName"].ToString());
                ekle.SubItems.Add(oku["MembersIDs"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void buttonPt4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PersonalTrainer where PersonalTrainerName like '%Bengisu Yıldız%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["PersonalTrainerName"].ToString());
                ekle.SubItems.Add(oku["MembersIDs"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void buttonPt6_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PersonalTrainer where PersonalTrainerName like '%İbrahim Çelik%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["PersonalTrainerName"].ToString());
                ekle.SubItems.Add(oku["MembersIDs"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void buttonPt7_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PersonalTrainer where PersonalTrainerName like '%Gamze Yıldız%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["PersonalTrainerName"].ToString());
                ekle.SubItems.Add(oku["MembersIDs"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void buttonPt8_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PersonalTrainer where PersonalTrainerName like '%Melisa Atlas%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["no"].ToString();
                ekle.SubItems.Add(oku["PersonalTrainerName"].ToString());
                ekle.SubItems.Add(oku["MembersIDs"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
    }
}
