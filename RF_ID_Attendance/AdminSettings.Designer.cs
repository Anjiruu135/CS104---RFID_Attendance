namespace RF_ID_Attendance
{
    partial class AdminSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSettings));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.ResetPassbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.aylistcmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sy2lbl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddAYbtn = new System.Windows.Forms.Button();
            this.RemoveAYbtn = new System.Windows.Forms.Button();
            this.Sy1lbl = new System.Windows.Forms.TextBox();
            this.datelbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RF_ID_Attendance.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1070, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Backbtn);
            this.groupBox1.Controls.Add(this.ResetPassbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.aylistcmb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Sy2lbl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.AddAYbtn);
            this.groupBox1.Controls.Add(this.RemoveAYbtn);
            this.groupBox1.Controls.Add(this.Sy1lbl);
            this.groupBox1.Controls.Add(this.datelbl);
            this.groupBox1.Controls.Add(this.timelbl);
            this.groupBox1.Location = new System.Drawing.Point(305, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 375);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(204, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 40);
            this.button1.TabIndex = 54;
            this.button1.Text = "Reset Pin";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Maroon;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.Color.White;
            this.Backbtn.Location = new System.Drawing.Point(24, 326);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(200, 32);
            this.Backbtn.TabIndex = 7;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // ResetPassbtn
            // 
            this.ResetPassbtn.BackColor = System.Drawing.Color.IndianRed;
            this.ResetPassbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetPassbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetPassbtn.ForeColor = System.Drawing.Color.White;
            this.ResetPassbtn.Location = new System.Drawing.Point(204, 196);
            this.ResetPassbtn.Name = "ResetPassbtn";
            this.ResetPassbtn.Size = new System.Drawing.Size(225, 40);
            this.ResetPassbtn.TabIndex = 6;
            this.ResetPassbtn.Text = "Reset Password";
            this.ResetPassbtn.UseVisualStyleBackColor = false;
            this.ResetPassbtn.Click += new System.EventHandler(this.ResetPassbtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Academic Year:";
            // 
            // aylistcmb
            // 
            this.aylistcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aylistcmb.FormattingEnabled = true;
            this.aylistcmb.Location = new System.Drawing.Point(204, 144);
            this.aylistcmb.Name = "aylistcmb";
            this.aylistcmb.Size = new System.Drawing.Size(191, 26);
            this.aylistcmb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 51;
            this.label1.Text = "to";
            // 
            // Sy2lbl
            // 
            this.Sy2lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sy2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sy2lbl.Location = new System.Drawing.Point(320, 85);
            this.Sy2lbl.Margin = new System.Windows.Forms.Padding(4);
            this.Sy2lbl.Name = "Sy2lbl";
            this.Sy2lbl.Size = new System.Drawing.Size(75, 26);
            this.Sy2lbl.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Academic Year:";
            // 
            // AddAYbtn
            // 
            this.AddAYbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.AddAYbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAYbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAYbtn.ForeColor = System.Drawing.Color.White;
            this.AddAYbtn.Location = new System.Drawing.Point(412, 82);
            this.AddAYbtn.Name = "AddAYbtn";
            this.AddAYbtn.Size = new System.Drawing.Size(180, 32);
            this.AddAYbtn.TabIndex = 3;
            this.AddAYbtn.Text = "Add A.Y.";
            this.AddAYbtn.UseVisualStyleBackColor = false;
            this.AddAYbtn.Click += new System.EventHandler(this.AddAYbtn_Click);
            // 
            // RemoveAYbtn
            // 
            this.RemoveAYbtn.BackColor = System.Drawing.Color.Maroon;
            this.RemoveAYbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveAYbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveAYbtn.ForeColor = System.Drawing.Color.White;
            this.RemoveAYbtn.Location = new System.Drawing.Point(412, 140);
            this.RemoveAYbtn.Name = "RemoveAYbtn";
            this.RemoveAYbtn.Size = new System.Drawing.Size(180, 32);
            this.RemoveAYbtn.TabIndex = 5;
            this.RemoveAYbtn.Text = "Remove A.Y.";
            this.RemoveAYbtn.UseVisualStyleBackColor = false;
            this.RemoveAYbtn.Click += new System.EventHandler(this.RemoveAYbtn_Click);
            // 
            // Sy1lbl
            // 
            this.Sy1lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Sy1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sy1lbl.Location = new System.Drawing.Point(204, 85);
            this.Sy1lbl.Margin = new System.Windows.Forms.Padding(4);
            this.Sy1lbl.Name = "Sy1lbl";
            this.Sy1lbl.Size = new System.Drawing.Size(75, 26);
            this.Sy1lbl.TabIndex = 1;
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.Location = new System.Drawing.Point(6, 23);
            this.datelbl.Name = "datelbl";
            this.datelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datelbl.Size = new System.Drawing.Size(48, 20);
            this.datelbl.TabIndex = 33;
            this.datelbl.Text = "Date ";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(6, 48);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(43, 20);
            this.timelbl.TabIndex = 32;
            this.timelbl.Text = "Time";
            // 
            // AdminSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::RF_ID_Attendance.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminSettings_FormClosed);
            this.Load += new System.EventHandler(this.AdminSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.TextBox Sy2lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddAYbtn;
        private System.Windows.Forms.Button RemoveAYbtn;
        private System.Windows.Forms.TextBox Sy1lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetPassbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox aylistcmb;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button button1;
    }
}