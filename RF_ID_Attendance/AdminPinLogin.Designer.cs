namespace RF_ID_Attendance
{
    partial class AdminPinLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPinLogin));
            this.label3 = new System.Windows.Forms.Label();
            this.Enterpinbtn = new System.Windows.Forms.Button();
            this.Pinpasstxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Pin:";
            // 
            // Enterpinbtn
            // 
            this.Enterpinbtn.BackColor = System.Drawing.Color.Maroon;
            this.Enterpinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enterpinbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterpinbtn.ForeColor = System.Drawing.Color.White;
            this.Enterpinbtn.Location = new System.Drawing.Point(171, 137);
            this.Enterpinbtn.Name = "Enterpinbtn";
            this.Enterpinbtn.Size = new System.Drawing.Size(250, 40);
            this.Enterpinbtn.TabIndex = 2;
            this.Enterpinbtn.Text = "Enter Pin";
            this.Enterpinbtn.UseVisualStyleBackColor = false;
            this.Enterpinbtn.Click += new System.EventHandler(this.Enterpinbtn_Click);
            // 
            // Pinpasstxt
            // 
            this.Pinpasstxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pinpasstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pinpasstxt.Location = new System.Drawing.Point(202, 92);
            this.Pinpasstxt.Margin = new System.Windows.Forms.Padding(4);
            this.Pinpasstxt.MaxLength = 9;
            this.Pinpasstxt.Name = "Pinpasstxt";
            this.Pinpasstxt.PasswordChar = '*';
            this.Pinpasstxt.Size = new System.Drawing.Size(200, 26);
            this.Pinpasstxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 31);
            this.label1.TabIndex = 41;
            this.label1.Text = "Enter Pin";
            // 
            // AdminPinLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Enterpinbtn);
            this.Controls.Add(this.Pinpasstxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPinLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Enter Pin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPinLogin_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Enterpinbtn;
        private System.Windows.Forms.TextBox Pinpasstxt;
        private System.Windows.Forms.Label label1;
    }
}