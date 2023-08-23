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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            LibMSEntities context = new LibMSEntities();
            Category category = new Category();
            category.Title = AddCatBox.Text;
            context.Categories.Add(category);
            context.SaveChanges();
            MessageBox.Show($"New Category ({AddCatBox.Text}) Added!");



        }
    }
}
