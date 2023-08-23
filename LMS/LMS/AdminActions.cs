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
    public partial class AdminActions : Form
    {
        public AdminActions()
        {
            InitializeComponent();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (option1.Checked == true)
            {
                AddRemoveStudent ARS = new AddRemoveStudent();
                ARS.Show();
            }
            if (option2.Checked == true)
            {
                AddRemoveBook ARB = new AddRemoveBook();
                ARB.Show();
            }
            if (option3.Checked == true)
            {
                AdminSearch SR = new AdminSearch();
                SR.Show();
            }
            if (option5.Checked==true)
            {
                ManageCategories MC = new ManageCategories();
                MC.Show();
            }
            if (option6.Checked == true)
            {
                AdminReport AR = new AdminReport();
                AR.Show();
            }
        }

        private void option1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void option3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void option4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void option2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ManageCatBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
