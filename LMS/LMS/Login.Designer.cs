
namespace LMS
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.usrlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.UsrTxt = new System.Windows.Forms.TextBox();
            this.PassTxt = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.UserLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(194, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // usrlbl
            // 
            this.usrlbl.AutoSize = true;
            this.usrlbl.BackColor = System.Drawing.Color.Transparent;
            this.usrlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrlbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.usrlbl.Location = new System.Drawing.Point(6, 87);
            this.usrlbl.Name = "usrlbl";
            this.usrlbl.Size = new System.Drawing.Size(109, 20);
            this.usrlbl.TabIndex = 1;
            this.usrlbl.Text = "UserName :";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.BackColor = System.Drawing.Color.Transparent;
            this.passlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlbl.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.passlbl.Location = new System.Drawing.Point(6, 142);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(103, 20);
            this.passlbl.TabIndex = 2;
            this.passlbl.Text = "Password :";
            // 
            // UsrTxt
            // 
            this.UsrTxt.BackColor = System.Drawing.Color.Tan;
            this.UsrTxt.Location = new System.Drawing.Point(125, 87);
            this.UsrTxt.Name = "UsrTxt";
            this.UsrTxt.Size = new System.Drawing.Size(191, 22);
            this.UsrTxt.TabIndex = 3;
            this.UsrTxt.TextChanged += new System.EventHandler(this.UsrTxt_TextChanged);
            // 
            // PassTxt
            // 
            this.PassTxt.BackColor = System.Drawing.Color.Tan;
            this.PassTxt.Location = new System.Drawing.Point(125, 142);
            this.PassTxt.Name = "PassTxt";
            this.PassTxt.Size = new System.Drawing.Size(191, 22);
            this.PassTxt.TabIndex = 4;
            this.PassTxt.UseSystemPasswordChar = true;
            this.PassTxt.TextChanged += new System.EventHandler(this.PassTxt_TextChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Tan;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.Black;
            this.loginbtn.Location = new System.Drawing.Point(346, 71);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(83, 58);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "Admin Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // UserLogin
            // 
            this.UserLogin.BackColor = System.Drawing.Color.Tan;
            this.UserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogin.Location = new System.Drawing.Point(346, 142);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(83, 57);
            this.UserLogin.TabIndex = 6;
            this.UserLogin.Text = "User Login";
            this.UserLogin.UseVisualStyleBackColor = false;
            this.UserLogin.Click += new System.EventHandler(this.UserLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::LMS.Properties.Resources.book_library_with_open_textbook_1150_5924;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 233);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.UsrTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usrlbl);
            this.Controls.Add(this.PassTxt);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usrlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.TextBox UsrTxt;
        private System.Windows.Forms.TextBox PassTxt;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button UserLogin;
    }
}

