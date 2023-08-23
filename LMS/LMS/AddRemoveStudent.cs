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
    public partial class AddRemoveStudent : Form
    {
        LibMSEntities context = new LibMSEntities();
        public AddRemoveStudent()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (AddStudentNameBox.Text != string.Empty && AddStudentPassBox.Text != string.Empty && AddStudentIdBox.Text != string.Empty)
            {
                
                LibUser student = new LibUser();
                student.UserName = AddStudentNameBox.Text;
                student.Password = AddStudentPassBox.Text;
                student.StudentId = AddStudentIdBox.Text;
                context.LibUsers.Add(student);
                context.SaveChanges();
                MessageBox.Show($"{AddStudentNameBox.Text} Added Successfully!");
            }
            else
            {
                MessageBox.Show("Adding Student Failed");
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            var student = context.LibUsers.Where(x => x.StudentId == RemoveStudentIdBox.Text).FirstOrDefault();
            context.LibUsers.Remove(student);
            context.SaveChanges();
            MessageBox.Show($"{RemoveStudentNameBox.Text} Removed Successfully!");

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            var student = context.LibUsers.Where(x => x.StudentId == RemoveStudentIdBox.Text).FirstOrDefault();
            RemoveStudentNameBox.Text = student.UserName;
            RemoveStudentNameBox.ReadOnly = true;

        }
    }
}
