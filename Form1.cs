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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-A6MKNLU;Initial Catalog=SportCenter;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        bool isThere;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string ID = txtUserName.Text;
            string Password = textPassword.Text;
            

            baglanti.Open();
            SqlCommand command = new SqlCommand("Select *from Admin", baglanti);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (ID == reader["AdminID"].ToString().TrimEnd() && Password==reader["AdminPassword"].ToString().TrimEnd())
                {
                    isThere = true;
                    break;
                }
                else
                {
                    isThere = false;
                }
            }
            baglanti.Close();

            if (isThere)
            {
                administrator git = new administrator();
                git.Show();
            }
            else
            {
                MessageBox.Show("Admin not found!");
            }

        }

        
        private void btnMemberLogin_Click(object sender, EventArgs e)
        {

            string ID = txtUserName.Text;
            string Password = textPassword.Text;
            

            baglanti.Open();
            SqlCommand command = new SqlCommand("Select *from Members", baglanti);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
                    if (ID == reader["MemberID"].ToString().TrimEnd() && Password == reader["Password"].ToString().TrimEnd() && "Normal" == reader["MembershipLevel"].ToString().TrimEnd())
                    {
                        NormalMemberForm git = new NormalMemberForm();
                    NormalMemberForm.ıd = ID;
                    git.Show();
                    
                        break;
                    }

                    else if (ID == reader["MemberID"].ToString().TrimEnd() && Password == reader["Password"].ToString().TrimEnd() && "Silver" == reader["MembershipLevel"].ToString().TrimEnd())
                    {
                        SilverMemberForm git2 = new SilverMemberForm();
                    SilverMemberForm.ıd2 = ID;
                        git2.Show();
                        break;

                    }
                    else if (ID == reader["MemberID"].ToString().TrimEnd() && Password == reader["Password"].ToString().TrimEnd() && "Gold" == reader["MembershipLevel"].ToString().TrimEnd())
                    {
                        GoldMemberForm git3 = new GoldMemberForm();
                    GoldMemberForm.ıd3 = ID;
                        git3.Show();
                        break;
                    }
                  
               
            }
           
            baglanti.Close();

           
        }
    }
}
