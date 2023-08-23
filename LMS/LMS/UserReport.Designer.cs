
namespace LMS
{
    partial class UserReport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label studentIdLabel;
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.libUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libMSDataSet = new LMS.LibMSDataSet();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.studentIdTextBox = new System.Windows.Forms.TextBox();
            this.libUsersTableAdapter = new LMS.LibMSDataSetTableAdapters.LibUsersTableAdapter();
            this.tableAdapterManager = new LMS.LibMSDataSetTableAdapters.TableAdapterManager();
            studentIdLabel = new System.Windows.Forms.Label();
            userNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // studentIdLabel
            // 
            studentIdLabel.AutoSize = true;
            studentIdLabel.Location = new System.Drawing.Point(6, 157);
            studentIdLabel.Name = "studentIdLabel";
            studentIdLabel.Size = new System.Drawing.Size(163, 32);
            studentIdLabel.TabIndex = 19;
            studentIdLabel.Text = "Student Id:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(6, 67);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(174, 32);
            userNameLabel.TabIndex = 20;
            userNameLabel.Text = "User Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(6, 250);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(156, 32);
            passwordLabel.TabIndex = 21;
            passwordLabel.Text = "Password:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(userNameLabel);
            this.groupBox1.Controls.Add(this.userNameTextBox);
            this.groupBox1.Controls.Add(studentIdLabel);
            this.groupBox1.Controls.Add(this.studentIdTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 356);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Tan;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libUsersBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(186, 247);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(226, 38);
            this.passwordTextBox.TabIndex = 22;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // libUsersBindingSource
            // 
            this.libUsersBindingSource.DataMember = "LibUsers";
            this.libUsersBindingSource.DataSource = this.libMSDataSet;
            // 
            // libMSDataSet
            // 
            this.libMSDataSet.DataSetName = "LibMSDataSet";
            this.libMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.Tan;
            this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libUsersBindingSource, "UserName", true));
            this.userNameTextBox.Location = new System.Drawing.Point(186, 67);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.ReadOnly = true;
            this.userNameTextBox.Size = new System.Drawing.Size(226, 38);
            this.userNameTextBox.TabIndex = 21;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            // 
            // studentIdTextBox
            // 
            this.studentIdTextBox.BackColor = System.Drawing.Color.Tan;
            this.studentIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libUsersBindingSource, "StudentId", true));
            this.studentIdTextBox.Location = new System.Drawing.Point(186, 157);
            this.studentIdTextBox.Name = "studentIdTextBox";
            this.studentIdTextBox.ReadOnly = true;
            this.studentIdTextBox.Size = new System.Drawing.Size(226, 38);
            this.studentIdTextBox.TabIndex = 20;
            this.studentIdTextBox.TextChanged += new System.EventHandler(this.studentIdTextBox_TextChanged);
            // 
            // libUsersTableAdapter
            // 
            this.libUsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LibUsersTableAdapter = this.libUsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = LMS.LibMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UserReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LMS.Properties.Resources.book_library_with_open_textbook_1150_5924;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 380);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserReport";
            this.Text = "User Report";
            this.Load += new System.EventHandler(this.UserReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private LibMSDataSet libMSDataSet;
        private System.Windows.Forms.BindingSource libUsersBindingSource;
        private LibMSDataSetTableAdapters.LibUsersTableAdapter libUsersTableAdapter;
        private LibMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox studentIdTextBox;
    }
}