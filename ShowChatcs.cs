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
    public partial class ShowChatcs : Form
    {
        public ShowChatcs()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-A6MKNLU;Initial Catalog=SportCenter;Integrated Security=True");
        private void ShowChatcs_Load(object sender, EventArgs e)
        {
            
           
                listView1.Items.Clear();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select * from Chat", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = oku["no"].ToString();
                    ekle.SubItems.Add(oku["MembersID"].ToString());
                    ekle.SubItems.Add(oku["Chat"].ToString());
                   

                    listView1.Items.Add(ekle);

                }
                baglanti.Close();
            
        }
    }
}
