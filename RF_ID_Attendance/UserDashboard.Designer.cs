namespace RF_ID_Attendance
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            this.Exitbtn = new System.Windows.Forms.Button();
            this.Studentlistbtn = new System.Windows.Forms.Button();
            this.Attendancebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datelbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.Attendancepicbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.No3lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.No2lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.No1lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Exitbtn
            // 
            this.Exitbtn.BackColor = System.Drawing.Color.IndianRed;
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.Color.White;
            this.Exitbtn.Location = new System.Drawing.Point(16, 659);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(166, 32);
            this.Exitbtn.TabIndex = 5;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = false;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Studentlistbtn
            // 
            this.Studentlistbtn.BackColor = System.Drawing.Color.Maroon;
            this.Studentlistbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Studentlistbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentlistbtn.ForeColor = System.Drawing.Color.White;
            this.Studentlistbtn.Location = new System.Drawing.Point(60, 227);
            this.Studentlistbtn.Name = "Studentlistbtn";
            this.Studentlistbtn.Size = new System.Drawing.Size(250, 40);
            this.Studentlistbtn.TabIndex = 0;
            this.Studentlistbtn.Text = "View Student List";
            this.Studentlistbtn.UseVisualStyleBackColor = false;
            this.Studentlistbtn.Click += new System.EventHandler(this.Studentlistbtn_Click);
            // 
            // Attendancebtn
            // 
            this.Attendancebtn.BackColor = System.Drawing.Color.Maroon;
            this.Attendancebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attendancebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendancebtn.ForeColor = System.Drawing.Color.White;
            this.Attendancebtn.Location = new System.Drawing.Point(60, 273);
            this.Attendancebtn.Name = "Attendancebtn";
            this.Attendancebtn.Size = new System.Drawing.Size(250, 40);
            this.Attendancebtn.TabIndex = 1;
            this.Attendancebtn.Text = "View Attendance";
            this.Attendancebtn.UseVisualStyleBackColor = false;
            this.Attendancebtn.Click += new System.EventHandler(this.Attendancebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "WMSU ID Attendance";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.Location = new System.Drawing.Point(12, 10);
            this.datelbl.Name = "datelbl";
            this.datelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datelbl.Size = new System.Drawing.Size(48, 20);
            this.datelbl.TabIndex = 44;
            this.datelbl.Text = "Date ";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(12, 35);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(43, 20);
            this.timelbl.TabIndex = 43;
            this.timelbl.Text = "Time";
            // 
            // Attendancepicbtn
            // 
            this.Attendancepicbtn.BackColor = System.Drawing.Color.Maroon;
            this.Attendancepicbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Attendancepicbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendancepicbtn.ForeColor = System.Drawing.Color.White;
            this.Attendancepicbtn.Location = new System.Drawing.Point(60, 319);
            this.Attendancepicbtn.Name = "Attendancepicbtn";
            this.Attendancepicbtn.Size = new System.Drawing.Size(250, 40);
            this.Attendancepicbtn.TabIndex = 2;
            this.Attendancepicbtn.Text = "Attendance Scanner";
            this.Attendancepicbtn.UseVisualStyleBackColor = false;
            this.Attendancepicbtn.Click += new System.EventHandler(this.Attendancepicbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.Loginbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Attendancepicbtn);
            this.groupBox1.Controls.Add(this.Exitbtn);
            this.groupBox1.Controls.Add(this.Studentlistbtn);
            this.groupBox1.Controls.Add(this.Attendancebtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 712);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.OrangeRed;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(60, 365);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(250, 40);
            this.Loginbtn.TabIndex = 7;
            this.Loginbtn.Text = "Login as Admin";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "User Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RF_ID_Attendance.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1076, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Controls.Add(this.No3lbl);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.No2lbl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.No1lbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(1076, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 205);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            // 
            // No3lbl
            // 
            this.No3lbl.AutoSize = true;
            this.No3lbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.No3lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No3lbl.Location = new System.Drawing.Point(51, 177);
            this.No3lbl.MaximumSize = new System.Drawing.Size(50, 0);
            this.No3lbl.MinimumSize = new System.Drawing.Size(50, 0);
            this.No3lbl.Name = "No3lbl";
            this.No3lbl.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.No3lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.No3lbl.Size = new System.Drawing.Size(50, 20);
            this.No3lbl.TabIndex = 53;
            this.No3lbl.Text = "00";
            this.No3lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 131);
            this.label6.MaximumSize = new System.Drawing.Size(135, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(126, 39);
            this.label6.TabIndex = 52;
            this.label6.Text = "No. of Unique Students timed in as of Today: ";
            // 
            // No2lbl
            // 
            this.No2lbl.AutoSize = true;
            this.No2lbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.No2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No2lbl.Location = new System.Drawing.Point(51, 106);
            this.No2lbl.MaximumSize = new System.Drawing.Size(50, 0);
            this.No2lbl.MinimumSize = new System.Drawing.Size(50, 0);
            this.No2lbl.Name = "No2lbl";
            this.No2lbl.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.No2lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.No2lbl.Size = new System.Drawing.Size(50, 20);
            this.No2lbl.TabIndex = 51;
            this.No2lbl.Text = "00";
            this.No2lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.MaximumSize = new System.Drawing.Size(135, 0);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(134, 26);
            this.label5.TabIndex = 50;
            this.label5.Text = "No. of Students timed in as of Today: ";
            // 
            // No1lbl
            // 
            this.No1lbl.AutoSize = true;
            this.No1lbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.No1lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.No1lbl.Location = new System.Drawing.Point(51, 41);
            this.No1lbl.MaximumSize = new System.Drawing.Size(50, 0);
            this.No1lbl.MinimumSize = new System.Drawing.Size(50, 0);
            this.No1lbl.Name = "No1lbl";
            this.No1lbl.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.No1lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.No1lbl.Size = new System.Drawing.Size(50, 20);
            this.No1lbl.TabIndex = 49;
            this.No1lbl.Text = "00";
            this.No1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 15);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "No. of Students Inside:";
            // 
            // UserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RF_ID_Attendance.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDashboard_FormClosed);
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDashboard_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Button Studentlistbtn;
        private System.Windows.Forms.Button Attendancebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Button Attendancepicbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label No2lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label No1lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label No3lbl;
        private System.Windows.Forms.Label label6;
    }
}