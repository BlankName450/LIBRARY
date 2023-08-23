
namespace LMS
{
    partial class AdminReport
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
            System.Windows.Forms.Label userNameLabel1;
            System.Windows.Forms.Label passwordLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.libMSAdminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libMSDataSet1 = new LMS.LibMSDataSet1();
            this.userNameTextBox1 = new System.Windows.Forms.TextBox();
            this.libMSAdminTableAdapter = new LMS.LibMSDataSet1TableAdapters.LibMSAdminTableAdapter();
            this.tableAdapterManager = new LMS.LibMSDataSet1TableAdapters.TableAdapterManager();
            userNameLabel1 = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libMSAdminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libMSDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel1
            // 
            userNameLabel1.AutoSize = true;
            userNameLabel1.Location = new System.Drawing.Point(6, 98);
            userNameLabel1.Name = "userNameLabel1";
            userNameLabel1.Size = new System.Drawing.Size(174, 32);
            userNameLabel1.TabIndex = 22;
            userNameLabel1.Text = "User Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(5, 178);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(156, 32);
            passwordLabel.TabIndex = 23;
            passwordLabel.Text = "Password:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tan;
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.passwordTextBox);
            this.groupBox1.Controls.Add(userNameLabel1);
            this.groupBox1.Controls.Add(this.userNameTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 356);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin Details :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.Tan;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libMSAdminBindingSource, "Password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(186, 178);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(294, 38);
            this.passwordTextBox.TabIndex = 24;
            // 
            // libMSAdminBindingSource
            // 
            this.libMSAdminBindingSource.DataMember = "LibMSAdmin";
            this.libMSAdminBindingSource.DataSource = this.libMSDataSet1;
            // 
            // libMSDataSet1
            // 
            this.libMSDataSet1.DataSetName = "LibMSDataSet1";
            this.libMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userNameTextBox1
            // 
            this.userNameTextBox1.BackColor = System.Drawing.Color.Tan;
            this.userNameTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.libMSAdminBindingSource, "UserName", true));
            this.userNameTextBox1.Location = new System.Drawing.Point(186, 98);
            this.userNameTextBox1.Name = "userNameTextBox1";
            this.userNameTextBox1.ReadOnly = true;
            this.userNameTextBox1.Size = new System.Drawing.Size(294, 38);
            this.userNameTextBox1.TabIndex = 23;
            // 
            // libMSAdminTableAdapter
            // 
            this.libMSAdminTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LibMSAdminTableAdapter = this.libMSAdminTableAdapter;
            this.tableAdapterManager.UpdateOrder = LMS.LibMSDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AdminReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources.book_library_with_open_textbook_1150_5924;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 381);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminReport";
            this.Text = "AdminReport";
            this.Load += new System.EventHandler(this.AdminReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libMSAdminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libMSDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private LibMSDataSet1 libMSDataSet1;
        private System.Windows.Forms.BindingSource libMSAdminBindingSource;
        private LibMSDataSet1TableAdapters.LibMSAdminTableAdapter libMSAdminTableAdapter;
        private LibMSDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox userNameTextBox1;
    }
}