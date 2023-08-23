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
    public partial class AdminReport : Form
    {
        public AdminReport()
        {
            InitializeComponent();
        }

        private void libMSAdminBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.libMSAdminBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libMSDataSet1);

        }

        private void AdminReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libMSDataSet1.LibMSAdmin' table. You can move, or remove it, as needed.
            this.libMSAdminTableAdapter.Fill(this.libMSDataSet1.LibMSAdmin);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
