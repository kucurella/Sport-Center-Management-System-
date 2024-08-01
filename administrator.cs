using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class administrator : Form
    {
        public administrator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            GroupLessons go = new GroupLessons();
            go.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MemberInformation fr = new MemberInformation();
            fr.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateOrDelete mr = new UpdateOrDelete();
            mr.Show(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonalTrainer ss = new PersonalTrainer();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowChatcs mm = new ShowChatcs();
            mm.Show();
        }
    }
}
