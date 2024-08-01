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
    public partial class GroupLessons : Form
    {
        public GroupLessons()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-A6MKNLU;Initial Catalog=SportCenter;Integrated Security=True");


        private void Yogagoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Yoga", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["No"].ToString();
                ekle.SubItems.Add(oku["MemberName"].ToString());
                ekle.SubItems.Add(oku["MemberSurname"].ToString());
                ekle.SubItems.Add(oku["MemberID"].ToString());
                ekle.SubItems.Add(oku["LessonTeacher"].ToString());
                

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void btnYoga_Click(object sender, EventArgs e)
        {
            Yogagoster();
        }


        private void Cyclegoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Cycling", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["No"].ToString();
                ekle.SubItems.Add(oku["MemberName"].ToString());
                ekle.SubItems.Add(oku["MemberSurname"].ToString());
                ekle.SubItems.Add(oku["MemberID"].ToString());
                ekle.SubItems.Add(oku["LessonTeacher"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }
        private void btnCycle_Click(object sender, EventArgs e)
        {
            Cyclegoster();
        }


        private void Stretchgoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Stretching", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["No"].ToString();
                ekle.SubItems.Add(oku["MemberName"].ToString());
                ekle.SubItems.Add(oku["MemberSurname"].ToString());
                ekle.SubItems.Add(oku["MemberID"].ToString());
                ekle.SubItems.Add(oku["LessonTeacher"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void btnStretch_Click(object sender, EventArgs e)
        {
            Stretchgoster();
        }


        private void KickBoxgoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from KickBoks", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["No"].ToString();
                ekle.SubItems.Add(oku["MemberName"].ToString());
                ekle.SubItems.Add(oku["MemberSurname"].ToString());
                ekle.SubItems.Add(oku["MemberID"].ToString());
                ekle.SubItems.Add(oku["LessonTeacher"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void btnKickBox_Click(object sender, EventArgs e)
        {
            KickBoxgoster();
        }


        private void Pilatesgoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Pilates", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["No"].ToString();
                ekle.SubItems.Add(oku["MemberName"].ToString());
                ekle.SubItems.Add(oku["MemberSurname"].ToString());
                ekle.SubItems.Add(oku["MemberID"].ToString());
                ekle.SubItems.Add(oku["LessonTeacher"].ToString());


                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }

        private void btnPilates_Click(object sender, EventArgs e)
        {
            Pilatesgoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Yoga (MemberName,MemberSurname,MemberID,LessonTeacher) values('" + txtName.Text + "','" + txtSurname.Text + "','" + txtMemberID.Text + "','" + txtLessonTeacher.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Member Added!");


        }

        private void button2_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Cycling (MemberName,MemberSurname,MemberID,LessonTeacher) values('" + txtName.Text + "','" + txtSurname.Text + "','" + txtMemberID.Text + "','" + txtLessonTeacher.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Member Added!");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stretching (MemberName,MemberSurname,MemberID,LessonTeacher) values('" + txtName.Text + "','" + txtSurname.Text + "','" + txtMemberID.Text + "','" + txtLessonTeacher.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Member Added!");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KickBoks (MemberName,MemberSurname,MemberID,LessonTeacher) values('" + txtName.Text + "','" + txtSurname.Text + "','" + txtMemberID.Text + "','" + txtLessonTeacher.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Member Added");
        }

        private void button5_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Pilates (MemberName,MemberSurname,MemberID,LessonTeacher) values('" + txtName.Text + "','" + txtSurname.Text + "','" + txtMemberID.Text + "','" + txtLessonTeacher.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Member Added");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Yoga where MemberID=(" + txtDelete.Text + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Cycling where MemberID=(" + txtDelete.Text + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Stretching where MemberID=(" + txtDelete.Text + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from KickBoks where MemberID=(" + txtDelete.Text + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Pilates where MemberID=(" + txtDelete.Text + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
