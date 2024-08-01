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
    public partial class NormalMemberForm : Form
    {
        public NormalMemberForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-A6MKNLU;Initial Catalog=SportCenter;Integrated Security=True");


        static public string ıd;

        private void NormalMemberForm_Load(object sender, EventArgs e)
        {
            Chat.chatID = ıd;
            memberID.Text = ıd;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Members where MemberID=("+ ıd+ ")", baglanti);
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
    }
}
