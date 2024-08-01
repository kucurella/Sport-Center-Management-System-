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
    public partial class UpdateOrDelete : Form
    {
        public UpdateOrDelete()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-A6MKNLU;Initial Catalog=SportCenter;Integrated Security=True");

        private void showdata()
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
            showdata();

        }
        int no= 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            no = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            TxtID.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtName.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TxtSurname.Text = listView1.SelectedItems[0].SubItems[3].Text;
            maskTxtPhone.Text = listView1.SelectedItems[0].SubItems[4].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
            comboBoxLevel.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtPt.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dtmStart.Text = listView1.SelectedItems[0].SubItems[8].Text;
            dtmExpiry.Text = listView1.SelectedItems[0].SubItems[9].Text;
            TxtAmount.Text = listView1.SelectedItems[0].SubItems[10].Text;
            txtPassword.Text = listView1.SelectedItems[0].SubItems[11].Text;

            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Members where MemberNo=(" + no + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            showdata();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtID.Clear();
            TxtName.Clear();
            TxtSurname.Clear();
            maskTxtPhone.Clear();
            TxtMail.Clear();
            comboBoxLevel.Text = "";
            txtPt.Clear();
            dtmStart.Text = "";
            dtmExpiry.Text = "";
            TxtAmount.Clear();
            txtPassword.Clear();

        }

       

        private void dtmExpiry_ValueChanged(object sender, EventArgs e)
        {
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("update Members set MemberID='" + TxtID.Text + "', Name='" + TxtName.Text + "',Surname='" + TxtSurname.Text + "',PhoneNumber='" + maskTxtPhone.Text + "',MailAddress='" + TxtMail.Text + "',MembershipLevel='" + comboBoxLevel.Text + "',PersonalTrainer='" + txtPt.Text + "',StartDate='" + dtmStart.Value.ToString("yyyy-MM-dd") + "',ExpiryDate='" + dtmExpiry.Value.ToString("yyyy-MM-dd") + "',TotalAmount='" + TxtAmount.Text + "',Password='" + txtPassword.Text + "' where MemberNo=" + no + "", baglanti);
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update PersonalTrainer set PersonalTrainerName='" + txtPt.Text + "' where MembersIDs like '%"+ TxtID.Text +"%'", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            showdata();
        }
    }
}
