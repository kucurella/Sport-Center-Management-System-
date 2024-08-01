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
    public partial class GoldMemberForm : Form
    {
        public GoldMemberForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-A6MKNLU;Initial Catalog=SportCenter;Integrated Security=True");

        static public string ıd3;

        private void GoldMemberForm_Load(object sender, EventArgs e)
        {
            Chat.chatID = ıd3;
            memberID.Text = ıd3;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Members where MemberID=(" + ıd3 + ")", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                memberID.Text = oku["memberID"].ToString();
                labelName.Text = oku["Name"].ToString();
                labelSurname.Text = oku["Surname"].ToString();
                labelPhoneNo.Text = oku["PhoneNumber"].ToString();
                labelMail.Text = oku["MailAddress"].ToString();
                labelMemberLevel.Text = oku["MembershipLevel"].ToString();
                labelPersonalT.Text = oku["PersonalTrainer"].ToString();
                labelStartDate.Text = oku["StartDate"].ToString();
                labelExpiryDate.Text = oku["ExpiryDate"].ToString();
                labelAmount.Text = oku["TotalAmount"].ToString();
                labelPassword.Text = oku["Password"].ToString();
            }
            baglanti.Close();

        }

        private void ChatNormal_Click(object sender, EventArgs e)
        {
            Chat go = new Chat();
            go.Show();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Members set PersonalTrainer='" + comboBox1.Text + "' where MemberID="+ ıd3+"", baglanti);
            SqlCommand komut2 = new SqlCommand("update PersonalTrainer set PersonalTrainerName='" + comboBox1.Text + "',MembersIDs='"+ ıd3 +"'", baglanti);
            komut.ExecuteNonQuery();
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("DONE!");
        }

        private void buttonYoga_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Yoga (MemberName,MemberSurname,MemberID,LessonTeacher) values('" + labelName.Text + "','" + labelSurname.Text + "','" + memberID.Text+ "','"+comboBoxPtYoga.Text+"')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("DONE!");
        }

        private void buttonStretching_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Stretching (MemberName,MemberSurname,MemberID,LessonTeacher) values('" + labelName.Text + "','" + labelSurname.Text + "','" + memberID.Text + "','" + comboBoxStret.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("DONE!");
        }

        private void buttonBox_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into KickBoks(MemberName,MemberSurname,MemberID,LessonTeacher) values('" + labelName.Text + "','" + labelSurname.Text + "','" + memberID.Text + "','" + comboBoxKickBox.Text+ "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("DONE!");
        }

        private void buttonCycling_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Cycling (MemberName,MemberSurname,MemberID,LessonTeacher) values('" + labelName.Text + "','" + labelSurname.Text + "','" + memberID.Text + "','" + comboBoxCycling.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("DONE!");
        }

        private void buttonPilates_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Pilates (MemberName,MemberSurname,MemberID,LessonTeacher) values('" + labelName.Text + "','" + labelSurname.Text + "','" + memberID.Text + "','" + comboBoxPilates.Text+ "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("DONE!");
        }
    }
}
