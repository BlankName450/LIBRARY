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
    public partial class ReturnBook : Form
    {
        LibMSEntities context = new LibMSEntities();
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            if (IdBox.Text != string.Empty && NameBox.Text != string.Empty)
            {

                var LoanBookByStudent = context.LoanBooks.Where(x => x.ISBN == IsbnBox.Text && x.LoanReturn == false).FirstOrDefault();
                LoanBookByStudent.LoanReturn = true;
                var book = context.Books.Where(x => x.ISBN == IsbnBox.Text).FirstOrDefault();
                book.Quantity += 1;
                context.SaveChanges();
                MessageBox.Show("Book Returned!");
            }
            else
            {
                MessageBox.Show("Return Failed");
            }
        
        }
    }
}
