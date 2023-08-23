
namespace LMS
{
    partial class UserActions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserActions));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.NextBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.option3);
            this.groupBox1.Controls.Add(this.option2);
            this.groupBox1.Controls.Add(this.option1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select an option :";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.Location = new System.Drawing.Point(6, 147);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(178, 33);
            this.option3.TabIndex = 2;
            this.option3.TabStop = true;
            this.option3.Text = "Return Book";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.CheckedChanged += new System.EventHandler(this.option3_CheckedChanged);
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.Location = new System.Drawing.Point(6, 99);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(248, 33);
            this.option2.TabIndex = 1;
            this.option2.TabStop = true;
            this.option2.Text = "Search/Loan Book";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.CheckedChanged += new System.EventHandler(this.option2_CheckedChanged);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.BackColor = System.Drawing.Color.Transparent;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(6, 55);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(177, 33);
            this.option1.TabIndex = 0;
            this.option1.TabStop = true;
            this.option1.Text = "View Report";
            this.option1.UseVisualStyleBackColor = false;
            this.option1.CheckedChanged += new System.EventHandler(this.option1_CheckedChanged);
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.Tan;
            this.NextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NextBtn.Location = new System.Drawing.Point(416, 280);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(137, 70);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources.book_library_with_open_textbook_1150_5924;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(565, 358);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserActions";
            this.Text = "UserActions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.Button NextBtn;
    }
}