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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-A6MKNLU;Initial Catalog=SportCenter;Integrated Security=True");

        //ÜYE kaydederken pt seçimi
        private void buttonPt1_Click(object sender, EventArgs e)
        {
            txtPt.Text = "Mehmet Ali";

        }

        private void buttonPt2_Click(object sender, EventArgs e)
        {
            txtPt.Text = "Serda Kılıç";
        }

        private void buttonPt3_Click(object sender, EventArgs e)
        {
            txtPt.Text = "Mustafa Özsöz";
        }

        private void buttonPt4_Click(object sender, EventArgs e)
        {
            txtPt.Text = "Bengisu Yıldız";
        }

        private void buttonPt5_Click(object sender, EventArgs e)
        {
            txtPt.Text = "Murat Alper";
        }

        private void buttonPt6_Click(object sender, EventArgs e)
        {
            txtPt.Text = "İbrahim Çelik";
        }

        private void buttonPt7_Click(object sender, EventArgs e)
        {
            txtPt.Text = "Gamze Yıldız";
        }

        private void buttonPt8_Click(object sender, EventArgs e)
        {
            txtPt.Text = "Melisa Atlas";
        }

        private void buttonNone_Click(object sender, EventArgs e)
        {
            txtPt.Text = "NONE";
        }

        //Tarih/ ücret hesaplama
        private void dtmExpiry_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime baslangıc = Convert.ToDateTime(dtmStart.Text);
            DateTime bitis = Convert.ToDateTime(dtmExpiry.Text);

            TimeSpan sonuc;
            sonuc = bitis - baslangıc;
            label11.Text = sonuc.TotalDays.ToString();

            if (comboBoxLevel.Text == "Normal" && txtPt.Text == "NONE")
            {
                ucret = Convert.ToInt32(label11.Text) * 20;
                txtAmount.Text = ucret.ToString();
            }
            else if(comboBoxLevel.Text=="Normal"&& txtPt.Text != "NONE")
            {
                ucret = Convert.ToInt32(label11.Text) * 25;
                txtAmount.Text = ucret.ToString();
            }
            else if(comboBoxLevel.Text=="Silver"&& txtPt.Text == "NONE")
            {
                ucret = Convert.ToInt32(label11.Text) * 30;
                txtAmount.Text = ucret.ToString();
            }
            else if(comboBoxLevel.Text=="Silver"&& txtPt.Text != "NONE")
            {
                ucret = Convert.ToInt32(label11.Text) * 40;
                txtAmount.Text = ucret.ToString();
            }
            else if(comboBoxLevel.Text=="Gold"&& txtPt.Text == "NONE")
            {
                ucret = Convert.ToInt32(label11.Text) * 50;
                txtAmount.Text = ucret.ToString();
            }
            else if(comboBoxLevel.Text=="Gold"&& txtPt.Text != "NONE")
            {
                ucret = Convert.ToInt32(label11.Text) * 60;
                txtAmount.Text = ucret.ToString();
            }


        }

        //Müsteri Ekleme
        private void buttonSave_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Members (MemberID,Name,Surname,PhoneNumber,MailAddress,MembershipLevel,PersonalTrainer,StartDate,ExpiryDate,TotalAmount,Password) values('" + TxtID.Text + "','" + TxtName.Text + "','" + TxtSurname.Text + "','"+maskTxtPhone.Text+"','"+TxtMail.Text+"','"+comboBoxLevel.Text+"','"+txtPt.Text+"','"+dtmStart.Value.ToString("yyyy-MM-dd")+"','"+dtmExpiry.Value.ToString("yyyy-MM-dd")+"','"+txtAmount.Text+"','"+txtPassword.Text+"')" ,baglanti);
           // SqlCommand komut2 = new SqlCommand("insert into PersonalTrainer(PersonalTrainerName,MembersIDs) values('" + txtPt.Text + "','" + TxtID.Text + "')", baglanti);
            komut.ExecuteNonQuery();
           // komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Member Addition Successful!");
        }
    }
}
