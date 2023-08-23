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
    public partial class UserSearch : Form
    {
        LibMSEntities context = new LibMSEntities();
        public UserSearch()
        {
            
            InitializeComponent();
            CategoryBox.DataSource = context.Categories.ToList();
            CategoryBox.DisplayMember = "Title";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        { 
            ResultsGrid.AutoGenerateColumns = false;
            var books = context.Books.Where(x => x.Title == TitleBox.Text || x.Category == CategoryBox.Text||x.Author== AuthorBox.Text).ToList();
            ResultsGrid.DataSource = books;
        }

        private void ResultsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var isbn = ResultsGrid.Rows[e.RowIndex].Cells[0].Value;
            var title = ResultsGrid.Rows[e.RowIndex].Cells[1].Value;
            var author = ResultsGrid.Rows[e.RowIndex].Cells[2].Value;
            var category = ResultsGrid.Rows[e.RowIndex].Cells[3].Value;
            var quantity = ResultsGrid.Rows[e.RowIndex].Cells[4].Value;
            LoanTitleBox.Text = title.ToString();
            AvailableBox.Text = quantity.ToString();
            CatBox.Text = category.ToString();
            ISBNBox.Text = isbn.ToString();
            AuthorBox.Text = author.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (IdBox.Text != string.Empty && NameBox.Text != string.Empty)
            {
                LoanBook book = new LoanBook();
                book.ISBN = ISBNBox.Text;
                book.StudentId = IdBox.Text;
                book.StudentName = NameBox.Text;
                book.LoanReturn = false;
                var onebook = context.Books.Where(x => x.ISBN == ISBNBox.Text).FirstOrDefault();
                onebook.Quantity -= 1;
                context.LoanBooks.Add(book);
                context.SaveChanges();
                MessageBox.Show($"Book ({LoanTitleBox.Text}) Loaned!");
                if (onebook.Quantity == 0)
                {
                    MessageBox.Show("Book isn't available");
                }
            }
            
            else
            {
                MessageBox.Show("Loan Failed");
            }
        }

        private void LoanBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
