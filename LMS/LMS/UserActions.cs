using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class UserActions : Form
    {
        public UserActions()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (option1.Checked == true)
            {
                UserReport UR = new UserReport();
                UR.Show();

            }
            if (option2.Checked == true)
            {
                UserSearch US = new UserSearch();
                US.Show();
            }
            if (option3.Checked == true)
            {
                ReturnBook RB = new ReturnBook();
                RB.Show();

            }

        }

        private void option1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void option3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void option2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void option4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
