namespace RF_ID_Attendance
{
    partial class UserAttendancelist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAttendancelist));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Studentnamelbl = new System.Windows.Forms.Label();
            this.StudentIdlbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datelbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttendancelistDGV = new System.Windows.Forms.DataGridView();
            this.InStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Searchboxtxt = new System.Windows.Forms.TextBox();
            this.aylistcmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendancelistDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RF_ID_Attendance.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1119, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // Studentnamelbl
            // 
            this.Studentnamelbl.AutoSize = true;
            this.Studentnamelbl.Location = new System.Drawing.Point(12, 675);
            this.Studentnamelbl.Name = "Studentnamelbl";
            this.Studentnamelbl.Size = new System.Drawing.Size(38, 16);
            this.Studentnamelbl.TabIndex = 53;
            this.Studentnamelbl.Text = "          ";
            // 
            // StudentIdlbl
            // 
            this.StudentIdlbl.AutoSize = true;
            this.StudentIdlbl.Location = new System.Drawing.Point(12, 651);
            this.StudentIdlbl.Name = "StudentIdlbl";
            this.StudentIdlbl.Size = new System.Drawing.Size(38, 16);
            this.StudentIdlbl.TabIndex = 52;
            this.StudentIdlbl.Text = "          ";
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
            this.datelbl.Location = new System.Drawing.Point(11, 10);
            this.datelbl.Name = "datelbl";
            this.datelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datelbl.Size = new System.Drawing.Size(48, 20);
            this.datelbl.TabIndex = 51;
            this.datelbl.Text = "Date ";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(11, 35);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(43, 20);
            this.timelbl.TabIndex = 50;
            this.timelbl.Text = "Time";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 300;
            // 
            // OutStatus
            // 
            this.OutStatus.DataPropertyName = "OutStatus";
            this.OutStatus.HeaderText = "OutStatus";
            this.OutStatus.Name = "OutStatus";
            this.OutStatus.ReadOnly = true;
            // 
            // TimeOut
            // 
            this.TimeOut.DataPropertyName = "Timeout";
            this.TimeOut.HeaderText = "Time Out";
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.ReadOnly = true;
            this.TimeOut.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TimeOut.Width = 125;
            // 
            // TimeIn
            // 
            this.TimeIn.DataPropertyName = "Timein";
            this.TimeIn.HeaderText = "Time In";
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.ReadOnly = true;
            this.TimeIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TimeIn.Width = 125;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Fullname";
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 300;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "Studentidatt";
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 125;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // AttendancelistDGV
            // 
            this.AttendancelistDGV.AllowUserToAddRows = false;
            this.AttendancelistDGV.AllowUserToDeleteRows = false;
            this.AttendancelistDGV.AllowUserToResizeColumns = false;
            this.AttendancelistDGV.AllowUserToResizeRows = false;
            this.AttendancelistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendancelistDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StudentID,
            this.StudentName,
            this.TimeIn,
            this.InStatus,
            this.TimeOut,
            this.OutStatus,
            this.Date});
            this.AttendancelistDGV.Location = new System.Drawing.Point(64, 119);
            this.AttendancelistDGV.Name = "AttendancelistDGV";
            this.AttendancelistDGV.ReadOnly = true;
            this.AttendancelistDGV.RowHeadersVisible = false;
            this.AttendancelistDGV.RowTemplate.Height = 24;
            this.AttendancelistDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendancelistDGV.Size = new System.Drawing.Size(1131, 483);
            this.AttendancelistDGV.TabIndex = 49;
            // 
            // InStatus
            // 
            this.InStatus.DataPropertyName = "InStatus";
            this.InStatus.HeaderText = "InStatus";
            this.InStatus.Name = "InStatus";
            this.InStatus.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 31);
            this.label6.TabIndex = 48;
            this.label6.Text = "Attendance List";
            // 
            // Backbtn
            // 
            this.Backbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Backbtn.BackColor = System.Drawing.Color.Maroon;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.ForeColor = System.Drawing.Color.White;
            this.Backbtn.Location = new System.Drawing.Point(11, 660);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(200, 32);
            this.Backbtn.TabIndex = 46;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(928, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Search";
            // 
            // Searchboxtxt
            // 
            this.Searchboxtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Searchboxtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchboxtxt.Location = new System.Drawing.Point(995, 86);
            this.Searchboxtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Searchboxtxt.Name = "Searchboxtxt";
            this.Searchboxtxt.Size = new System.Drawing.Size(200, 26);
            this.Searchboxtxt.TabIndex = 55;
            this.Searchboxtxt.TextChanged += new System.EventHandler(this.Searchboxtxt_TextChanged);
            // 
            // aylistcmb
            // 
            this.aylistcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aylistcmb.FormattingEnabled = true;
            this.aylistcmb.Location = new System.Drawing.Point(183, 87);
            this.aylistcmb.Name = "aylistcmb";
            this.aylistcmb.Size = new System.Drawing.Size(125, 24);
            this.aylistcmb.TabIndex = 64;
            this.aylistcmb.SelectedValueChanged += new System.EventHandler(this.aylistcmb_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Academic Year";
            // 
            // UserAttendancelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.aylistcmb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Searchboxtxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Studentnamelbl);
            this.Controls.Add(this.StudentIdlbl);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.AttendancelistDGV);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAttendancelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Attendance List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserAttendancelist_FormClosed);
            this.Load += new System.EventHandler(this.UserAttendancelist_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserAttendancelist_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttendancelistDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Studentnamelbl;
        private System.Windows.Forms.Label StudentIdlbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridView AttendancelistDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Searchboxtxt;
        private System.Windows.Forms.ComboBox aylistcmb;
        private System.Windows.Forms.Label label11;
    }
}