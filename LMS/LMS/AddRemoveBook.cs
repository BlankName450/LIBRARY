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
    public partial class AddRemoveBook : Form
    {
        LibMSEntities context = new LibMSEntities();
        public AddRemoveBook()
        {
            InitializeComponent();
            CategoryBox.DataSource = context.Categories.ToList();
            CategoryBox.DisplayMember = "Title";
        }

        private void AddRemoveBook_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            LibMSEntities context = new LibMSEntities();
            Book book = new Book();
            book.ISBN = AddISBNBox.Text;
            book.Title = AddTitleBox.Text;
            book.Author = AddAuthorBox.Text;
            book.Category = CategoryBox.Text;
            book.Quantity = Convert.ToInt32(AddQtyBox.Text);
            context.Books.Add(book);
            context.SaveChanges();
            MessageBox.Show($"{AddTitleBox.Text} Book Added!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibMSEntities context = new LibMSEntities();
            var book = context.Books.Where(x => x.ISBN == RemoveISBNBox.Text).FirstOrDefault();
            RemoveTitleBox.Text = book.Title;
            RemoveCatBox.Text = book.Category;
            AvailableBox.Text = Convert.ToString(book.Quantity);
            RemoveCatBox.ReadOnly = true;
            RemoveTitleBox.ReadOnly = true;
            AvailableBox.ReadOnly = true;

        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            LibMSEntities context = new LibMSEntities();
            var book = context.Books.Where(x => x.ISBN == RemoveISBNBox.Text).FirstOrDefault();
            var bookqty = book.Quantity - Convert.ToInt32(RemoveQtyBox.Text);
            book.Quantity = bookqty;
            context.SaveChanges();
            MessageBox.Show($"{RemoveTitleBox.Text} Book Removed!");
            
        }

        private void AvailableBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
