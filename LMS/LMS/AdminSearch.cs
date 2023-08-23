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
    public partial class AdminSearch : Form
    {
        LibMSEntities context = new LibMSEntities();
        public AdminSearch()
        {
            InitializeComponent();
            CategoryBox.DataSource = context.Categories.ToList();
            CategoryBox.DisplayMember = "Title";
        }

        private void ResultsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            ResultsGrid.AutoGenerateColumns = false;
            var books = context.Books.Where(x => x.Title == TitleBox.Text || x.Category == CategoryBox.Text).ToList();
            ResultsGrid.DataSource = books;
        }

        private void AdminSearch_Load(object sender, EventArgs e)
        {

        }
    }
}
