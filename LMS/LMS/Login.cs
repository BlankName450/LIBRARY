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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            LibMSEntities content = new LibMSEntities();
            if (UsrTxt.Text != string.Empty && PassTxt.Text != string.Empty)
            {
                var user = content.LibMSAdmins.Where(x => x.UserName.Equals(UsrTxt.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(PassTxt.Text))
                    {
                        AdminActions AA=new AdminActions();
                        AA.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password !");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username !");
                }

            }
        }

        private void UserLogin_Click(object sender, EventArgs e)
        {
            LibMSEntities content = new LibMSEntities();
            if (UsrTxt.Text != string.Empty && PassTxt.Text != string.Empty)
            {
                var user = content.LibUsers.Where(x => x.UserName.Equals(UsrTxt.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.Password.Equals(PassTxt.Text))
                    {
                        UserActions UA = new UserActions();
                        UA.Show();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Password");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username");
                }

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void UsrTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
