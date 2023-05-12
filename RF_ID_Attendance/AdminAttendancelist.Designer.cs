namespace RF_ID_Attendance
{
    partial class AdminAttendancelist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminAttendancelist));
            this.Backbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Studentidtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AttendancelistDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timelbl = new System.Windows.Forms.Label();
            this.datelbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Enterbtn = new System.Windows.Forms.Button();
            this.StudentIdlbl = new System.Windows.Forms.Label();
            this.Studentnamelbl = new System.Windows.Forms.Label();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Searchboxtxt = new System.Windows.Forms.TextBox();
            this.Removebtn = new System.Windows.Forms.Button();
            this.Exportbtn = new System.Windows.Forms.Button();
            this.aylistcmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AttendancelistDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.Backbtn.TabIndex = 3;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Scan ID";
            // 
            // Studentidtxt
            // 
            this.Studentidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentidtxt.Location = new System.Drawing.Point(72, 202);
            this.Studentidtxt.Name = "Studentidtxt";
            this.Studentidtxt.Size = new System.Drawing.Size(300, 37);
            this.Studentidtxt.TabIndex = 0;
            this.Studentidtxt.TextChanged += new System.EventHandler(this.Studentidtxt_TextChanged);
            this.Studentidtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Studentidtxt_KeyDown);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(696, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 31);
            this.label6.TabIndex = 21;
            this.label6.Text = "Attendance List";
            // 
            // AttendancelistDGV
            // 
            this.AttendancelistDGV.AllowUserToAddRows = false;
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
            this.AttendancelistDGV.Location = new System.Drawing.Point(430, 118);
            this.AttendancelistDGV.MultiSelect = false;
            this.AttendancelistDGV.Name = "AttendancelistDGV";
            this.AttendancelistDGV.ReadOnly = true;
            this.AttendancelistDGV.RowHeadersVisible = false;
            this.AttendancelistDGV.RowTemplate.Height = 24;
            this.AttendancelistDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttendancelistDGV.Size = new System.Drawing.Size(766, 483);
            this.AttendancelistDGV.TabIndex = 22;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "Studentidatt";
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 125;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "Fullname";
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Width = 300;
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
            // InStatus
            // 
            this.InStatus.DataPropertyName = "InStatus";
            this.InStatus.HeaderText = "InStatus";
            this.InStatus.Name = "InStatus";
            this.InStatus.ReadOnly = true;
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
            // OutStatus
            // 
            this.OutStatus.DataPropertyName = "OutStatus";
            this.OutStatus.HeaderText = "OutStatus";
            this.OutStatus.Name = "OutStatus";
            this.OutStatus.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 300;
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(12, 34);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(43, 20);
            this.timelbl.TabIndex = 23;
            this.timelbl.Text = "Time";
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.Location = new System.Drawing.Point(12, 9);
            this.datelbl.Name = "datelbl";
            this.datelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datelbl.Size = new System.Drawing.Size(48, 20);
            this.datelbl.TabIndex = 24;
            this.datelbl.Text = "Date ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Enterbtn
            // 
            this.Enterbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Enterbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Enterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterbtn.ForeColor = System.Drawing.Color.White;
            this.Enterbtn.Location = new System.Drawing.Point(72, 252);
            this.Enterbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Enterbtn.Name = "Enterbtn";
            this.Enterbtn.Size = new System.Drawing.Size(147, 32);
            this.Enterbtn.TabIndex = 1;
            this.Enterbtn.Text = "Enter";
            this.Enterbtn.UseVisualStyleBackColor = false;
            this.Enterbtn.Click += new System.EventHandler(this.Enterbtn_Click);
            // 
            // StudentIdlbl
            // 
            this.StudentIdlbl.AutoSize = true;
            this.StudentIdlbl.Location = new System.Drawing.Point(13, 650);
            this.StudentIdlbl.Name = "StudentIdlbl";
            this.StudentIdlbl.Size = new System.Drawing.Size(48, 17);
            this.StudentIdlbl.TabIndex = 26;
            this.StudentIdlbl.Text = "          ";
            // 
            // Studentnamelbl
            // 
            this.Studentnamelbl.AutoSize = true;
            this.Studentnamelbl.Location = new System.Drawing.Point(13, 674);
            this.Studentnamelbl.Name = "Studentnamelbl";
            this.Studentnamelbl.Size = new System.Drawing.Size(48, 17);
            this.Studentnamelbl.TabIndex = 27;
            this.Studentnamelbl.Text = "          ";
            // 
            // Resetbtn
            // 
            this.Resetbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Resetbtn.BackColor = System.Drawing.Color.Maroon;
            this.Resetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.ForeColor = System.Drawing.Color.White;
            this.Resetbtn.Location = new System.Drawing.Point(72, 288);
            this.Resetbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(300, 32);
            this.Resetbtn.TabIndex = 2;
            this.Resetbtn.Text = "Reset Attendance";
            this.Resetbtn.UseVisualStyleBackColor = false;
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RF_ID_Attendance.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1120, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(929, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 58;
            this.label10.Text = "Search";
            // 
            // Searchboxtxt
            // 
            this.Searchboxtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Searchboxtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchboxtxt.Location = new System.Drawing.Point(996, 85);
            this.Searchboxtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Searchboxtxt.Name = "Searchboxtxt";
            this.Searchboxtxt.Size = new System.Drawing.Size(200, 26);
            this.Searchboxtxt.TabIndex = 57;
            this.Searchboxtxt.TextChanged += new System.EventHandler(this.Searchboxtxt_TextChanged);
            // 
            // Removebtn
            // 
            this.Removebtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Removebtn.BackColor = System.Drawing.Color.IndianRed;
            this.Removebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Removebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removebtn.ForeColor = System.Drawing.Color.White;
            this.Removebtn.Location = new System.Drawing.Point(225, 252);
            this.Removebtn.Margin = new System.Windows.Forms.Padding(2);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(147, 32);
            this.Removebtn.TabIndex = 59;
            this.Removebtn.Text = "Remove";
            this.Removebtn.UseVisualStyleBackColor = false;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // Exportbtn
            // 
            this.Exportbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Exportbtn.BackColor = System.Drawing.Color.Maroon;
            this.Exportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exportbtn.ForeColor = System.Drawing.Color.White;
            this.Exportbtn.Location = new System.Drawing.Point(996, 606);
            this.Exportbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Exportbtn.Name = "Exportbtn";
            this.Exportbtn.Size = new System.Drawing.Size(200, 32);
            this.Exportbtn.TabIndex = 60;
            this.Exportbtn.Text = "Export to Excel";
            this.Exportbtn.UseVisualStyleBackColor = false;
            this.Exportbtn.Click += new System.EventHandler(this.Exportbtn_Click);
            // 
            // aylistcmb
            // 
            this.aylistcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aylistcmb.FormattingEnabled = true;
            this.aylistcmb.Location = new System.Drawing.Point(549, 86);
            this.aylistcmb.Name = "aylistcmb";
            this.aylistcmb.Size = new System.Drawing.Size(125, 25);
            this.aylistcmb.TabIndex = 62;
            this.aylistcmb.SelectedValueChanged += new System.EventHandler(this.aylistcmb_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(426, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 61;
            this.label11.Text = "Academic Year";
            // 
            // AdminAttendancelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.aylistcmb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Exportbtn);
            this.Controls.Add(this.Removebtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Searchboxtxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.Studentnamelbl);
            this.Controls.Add(this.StudentIdlbl);
            this.Controls.Add(this.Enterbtn);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.AttendancelistDGV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Studentidtxt);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminAttendancelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Attendance List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAttendancelist_FormClosed);
            this.Load += new System.EventHandler(this.FormAttendancelist_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormAttendancelist_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.AttendancelistDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Studentidtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView AttendancelistDGV;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Enterbtn;
        private System.Windows.Forms.Label StudentIdlbl;
        private System.Windows.Forms.Label Studentnamelbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Searchboxtxt;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Button Exportbtn;
        private System.Windows.Forms.ComboBox aylistcmb;
        private System.Windows.Forms.Label label11;
    }
}