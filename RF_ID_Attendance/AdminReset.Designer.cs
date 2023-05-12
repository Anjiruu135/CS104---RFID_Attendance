namespace RF_ID_Attendance
{
    partial class AdminReset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminReset));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datelbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Newpwordtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Confirmnewpwordtxt = new System.Windows.Forms.TextBox();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Oldpwordtxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 200);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "New Password:";
            // 
            // Newpwordtxt
            // 
            this.Newpwordtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Newpwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newpwordtxt.Location = new System.Drawing.Point(305, 197);
            this.Newpwordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Newpwordtxt.Name = "Newpwordtxt";
            this.Newpwordtxt.Size = new System.Drawing.Size(200, 26);
            this.Newpwordtxt.TabIndex = 2;
            this.Newpwordtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Newpwordtxt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(473, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 31);
            this.label2.TabIndex = 40;
            this.label2.Text = "Admin Reset Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 31);
            this.label1.TabIndex = 39;
            this.label1.Text = "WMSU ID Attendance";
            // 
            // Cancelbtn
            // 
            this.Cancelbtn.BackColor = System.Drawing.Color.IndianRed;
            this.Cancelbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancelbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelbtn.ForeColor = System.Drawing.Color.White;
            this.Cancelbtn.Location = new System.Drawing.Point(347, 294);
            this.Cancelbtn.Name = "Cancelbtn";
            this.Cancelbtn.Size = new System.Drawing.Size(250, 40);
            this.Cancelbtn.TabIndex = 5;
            this.Cancelbtn.Text = "Cancel";
            this.Cancelbtn.UseVisualStyleBackColor = false;
            this.Cancelbtn.Click += new System.EventHandler(this.Cancelbtn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 20);
            this.label5.TabIndex = 47;
            this.label5.Text = "Confirm New Password:";
            // 
            // Confirmnewpwordtxt
            // 
            this.Confirmnewpwordtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Confirmnewpwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirmnewpwordtxt.Location = new System.Drawing.Point(305, 235);
            this.Confirmnewpwordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Confirmnewpwordtxt.Name = "Confirmnewpwordtxt";
            this.Confirmnewpwordtxt.Size = new System.Drawing.Size(200, 26);
            this.Confirmnewpwordtxt.TabIndex = 3;
            this.Confirmnewpwordtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Confirmnewpwordtxt_KeyDown);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Location = new System.Drawing.Point(67, 294);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(250, 40);
            this.Updatebtn.TabIndex = 4;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Cancelbtn);
            this.groupBox1.Controls.Add(this.Updatebtn);
            this.groupBox1.Controls.Add(this.Oldpwordtxt);
            this.groupBox1.Controls.Add(this.datelbl);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.timelbl);
            this.groupBox1.Controls.Add(this.Newpwordtxt);
            this.groupBox1.Controls.Add(this.Confirmnewpwordtxt);
            this.groupBox1.Location = new System.Drawing.Point(305, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 375);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(147, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "Current Password:";
            // 
            // Oldpwordtxt
            // 
            this.Oldpwordtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Oldpwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Oldpwordtxt.Location = new System.Drawing.Point(305, 163);
            this.Oldpwordtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Oldpwordtxt.Name = "Oldpwordtxt";
            this.Oldpwordtxt.Size = new System.Drawing.Size(200, 26);
            this.Oldpwordtxt.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RF_ID_Attendance.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1070, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 75);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // AdminReset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::RF_ID_Attendance.Properties.Resources._2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminReset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Reset Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormReset_FormClosed);
            this.Load += new System.EventHandler(this.FormReset_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormReset_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Newpwordtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Confirmnewpwordtxt;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Oldpwordtxt;
    }
}