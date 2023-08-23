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
    public partial class UserReport : Form
    {
        public UserReport()
        {
            InitializeComponent();
        }

        private void libUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.libUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libMSDataSet);

        }

        private void UserReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libMSDataSet.LibUsers' table. You can move, or remove it, as needed.
            this.libUsersTableAdapter.Fill(this.libMSDataSet.LibUsers);

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
