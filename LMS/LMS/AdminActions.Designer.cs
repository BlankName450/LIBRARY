
namespace LMS
{
    partial class AdminActions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminActions));
            this.NextBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.option6 = new System.Windows.Forms.RadioButton();
            this.option5 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.Tan;
            this.NextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(614, 313);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(149, 69);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.option6);
            this.groupBox1.Controls.Add(this.option5);
            this.groupBox1.Controls.Add(this.option3);
            this.groupBox1.Controls.Add(this.option1);
            this.groupBox1.Controls.Add(this.option2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 295);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select An Option :";
            // 
            // option6
            // 
            this.option6.AutoSize = true;
            this.option6.BackColor = System.Drawing.Color.Transparent;
            this.option6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option6.ForeColor = System.Drawing.Color.Transparent;
            this.option6.Location = new System.Drawing.Point(6, 223);
            this.option6.Name = "option6";
            this.option6.Size = new System.Drawing.Size(193, 33);
            this.option6.TabIndex = 6;
            this.option6.TabStop = true;
            this.option6.Text = "Admin Report";
            this.option6.UseVisualStyleBackColor = false;
            this.option6.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // option5
            // 
            this.option5.AutoSize = true;
            this.option5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option5.Location = new System.Drawing.Point(6, 170);
            this.option5.Name = "option5";
            this.option5.Size = new System.Drawing.Size(262, 33);
            this.option5.TabIndex = 5;
            this.option5.TabStop = true;
            this.option5.Text = "Manage Categories";
            this.option5.UseVisualStyleBackColor = true;
            this.option5.CheckedChanged += new System.EventHandler(this.ManageCatBtn_CheckedChanged);
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3.Location = new System.Drawing.Point(6, 127);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(183, 33);
            this.option3.TabIndex = 4;
            this.option3.TabStop = true;
            this.option3.Text = "Search Book";
            this.option3.UseVisualStyleBackColor = true;
            this.option3.CheckedChanged += new System.EventHandler(this.option3_CheckedChanged);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1.Location = new System.Drawing.Point(6, 42);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(280, 33);
            this.option1.TabIndex = 0;
            this.option1.TabStop = true;
            this.option1.Text = "Add/Remove Student";
            this.option1.UseVisualStyleBackColor = true;
            this.option1.CheckedChanged += new System.EventHandler(this.option1_CheckedChanged);
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2.Location = new System.Drawing.Point(6, 87);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(251, 33);
            this.option2.TabIndex = 1;
            this.option2.TabStop = true;
            this.option2.Text = "Add/Remove Book";
            this.option2.UseVisualStyleBackColor = true;
            this.option2.CheckedChanged += new System.EventHandler(this.option2_CheckedChanged);
            // 
            // AdminActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS.Properties.Resources.book_library_with_open_textbook_1150_5924;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(775, 394);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminActions";
            this.Text = "AdminActions";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton option5;
        private System.Windows.Forms.RadioButton option6;
    }
}