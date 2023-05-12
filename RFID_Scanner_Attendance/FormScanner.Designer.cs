namespace RFID_Scanner_Attendance
{
    partial class FormScanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormScanner));
            this.Studentnamelbl = new System.Windows.Forms.Label();
            this.Enterbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datelbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.StudentIdlbl = new System.Windows.Forms.Label();
            this.Studentidtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PicViewer = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseYearLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.Timeinoutlbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Timesubmitlbl = new System.Windows.Forms.Label();
            this.Studentname2lbl = new System.Windows.Forms.Label();
            this.aylistcmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicViewer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Studentnamelbl
            // 
            this.Studentnamelbl.AutoSize = true;
            this.Studentnamelbl.Location = new System.Drawing.Point(1, 416);
            this.Studentnamelbl.Name = "Studentnamelbl";
            this.Studentnamelbl.Size = new System.Drawing.Size(48, 17);
            this.Studentnamelbl.TabIndex = 37;
            this.Studentnamelbl.Text = "          ";
            this.Studentnamelbl.Visible = false;
            // 
            // Enterbtn
            // 
            this.Enterbtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Enterbtn.BackColor = System.Drawing.Color.LimeGreen;
            this.Enterbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enterbtn.ForeColor = System.Drawing.Color.White;
            this.Enterbtn.Location = new System.Drawing.Point(71, 219);
            this.Enterbtn.Margin = new System.Windows.Forms.Padding(2);
            this.Enterbtn.Name = "Enterbtn";
            this.Enterbtn.Size = new System.Drawing.Size(300, 32);
            this.Enterbtn.TabIndex = 1;
            this.Enterbtn.Text = "Enter";
            this.Enterbtn.UseVisualStyleBackColor = false;
            this.Enterbtn.Click += new System.EventHandler(this.Enterbtn_Click_1);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // datelbl
            // 
            this.datelbl.AutoSize = true;
            this.datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datelbl.Location = new System.Drawing.Point(6, 23);
            this.datelbl.Name = "datelbl";
            this.datelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datelbl.Size = new System.Drawing.Size(48, 20);
            this.datelbl.TabIndex = 35;
            this.datelbl.Text = "Date ";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(6, 48);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(43, 20);
            this.timelbl.TabIndex = 34;
            this.timelbl.Text = "Time";
            // 
            // StudentIdlbl
            // 
            this.StudentIdlbl.AutoSize = true;
            this.StudentIdlbl.Location = new System.Drawing.Point(1, 392);
            this.StudentIdlbl.Name = "StudentIdlbl";
            this.StudentIdlbl.Size = new System.Drawing.Size(48, 17);
            this.StudentIdlbl.TabIndex = 36;
            this.StudentIdlbl.Text = "          ";
            this.StudentIdlbl.Visible = false;
            // 
            // Studentidtxt
            // 
            this.Studentidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentidtxt.Location = new System.Drawing.Point(71, 169);
            this.Studentidtxt.Name = "Studentidtxt";
            this.Studentidtxt.Size = new System.Drawing.Size(300, 37);
            this.Studentidtxt.TabIndex = 0;
            this.Studentidtxt.TextChanged += new System.EventHandler(this.Studentidtxt_TextChanged);
            this.Studentidtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Studentidtxt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 31;
            this.label2.Text = "Scan ID";
            // 
            // PicViewer
            // 
            this.PicViewer.AllowUserToAddRows = false;
            this.PicViewer.AllowUserToDeleteRows = false;
            this.PicViewer.AllowUserToOrderColumns = true;
            this.PicViewer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PicViewer.BackgroundColor = System.Drawing.Color.White;
            this.PicViewer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PicViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PicViewer.ColumnHeadersVisible = false;
            this.PicViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StudentID,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.CourseYearLevel,
            this.Rfid,
            this.Image,
            this.Picture});
            this.PicViewer.GridColor = System.Drawing.Color.White;
            this.PicViewer.Location = new System.Drawing.Point(458, 42);
            this.PicViewer.Margin = new System.Windows.Forms.Padding(2);
            this.PicViewer.Name = "PicViewer";
            this.PicViewer.ReadOnly = true;
            this.PicViewer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PicViewer.RowHeadersVisible = false;
            this.PicViewer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PicViewer.RowTemplate.Height = 250;
            this.PicViewer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PicViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PicViewer.Size = new System.Drawing.Size(300, 250);
            this.PicViewer.TabIndex = 38;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 600;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "Studentid";
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentID.Visible = false;
            this.StudentID.Width = 125;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "Firstname";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FirstName.Visible = false;
            this.FirstName.Width = 150;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "Middlename";
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            this.MiddleName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MiddleName.Visible = false;
            this.MiddleName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "Lastname";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LastName.Visible = false;
            this.LastName.Width = 150;
            // 
            // CourseYearLevel
            // 
            this.CourseYearLevel.DataPropertyName = "Courselevel";
            this.CourseYearLevel.HeaderText = "Course - Year Level";
            this.CourseYearLevel.Name = "CourseYearLevel";
            this.CourseYearLevel.ReadOnly = true;
            this.CourseYearLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseYearLevel.Visible = false;
            // 
            // Rfid
            // 
            this.Rfid.DataPropertyName = "Rfid";
            this.Rfid.HeaderText = "RF Card ID";
            this.Rfid.Name = "Rfid";
            this.Rfid.ReadOnly = true;
            this.Rfid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Rfid.Visible = false;
            this.Rfid.Width = 125;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.Visible = false;
            this.Image.Width = 200;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Picture";
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Picture.Width = 300;
            // 
            // Timeinoutlbl
            // 
            this.Timeinoutlbl.AutoSize = true;
            this.Timeinoutlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timeinoutlbl.ForeColor = System.Drawing.Color.White;
            this.Timeinoutlbl.Location = new System.Drawing.Point(458, 294);
            this.Timeinoutlbl.MaximumSize = new System.Drawing.Size(300, 0);
            this.Timeinoutlbl.MinimumSize = new System.Drawing.Size(300, 0);
            this.Timeinoutlbl.Name = "Timeinoutlbl";
            this.Timeinoutlbl.Padding = new System.Windows.Forms.Padding(75, 0, 75, 0);
            this.Timeinoutlbl.Size = new System.Drawing.Size(300, 26);
            this.Timeinoutlbl.TabIndex = 39;
            this.Timeinoutlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aylistcmb);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Timesubmitlbl);
            this.groupBox1.Controls.Add(this.Timeinoutlbl);
            this.groupBox1.Controls.Add(this.Studentname2lbl);
            this.groupBox1.Controls.Add(this.Enterbtn);
            this.groupBox1.Controls.Add(this.PicViewer);
            this.groupBox1.Controls.Add(this.Studentidtxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.datelbl);
            this.groupBox1.Controls.Add(this.Studentnamelbl);
            this.groupBox1.Controls.Add(this.timelbl);
            this.groupBox1.Controls.Add(this.StudentIdlbl);
            this.groupBox1.Location = new System.Drawing.Point(12, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 436);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RFID_Scanner_Attendance.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(725, 380);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Timesubmitlbl
            // 
            this.Timesubmitlbl.AutoSize = true;
            this.Timesubmitlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timesubmitlbl.Location = new System.Drawing.Point(458, 351);
            this.Timesubmitlbl.MaximumSize = new System.Drawing.Size(300, 0);
            this.Timesubmitlbl.MinimumSize = new System.Drawing.Size(300, 0);
            this.Timesubmitlbl.Name = "Timesubmitlbl";
            this.Timesubmitlbl.Size = new System.Drawing.Size(300, 20);
            this.Timesubmitlbl.TabIndex = 39;
            this.Timesubmitlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Studentname2lbl
            // 
            this.Studentname2lbl.AutoSize = true;
            this.Studentname2lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Studentname2lbl.Location = new System.Drawing.Point(458, 326);
            this.Studentname2lbl.MaximumSize = new System.Drawing.Size(300, 0);
            this.Studentname2lbl.MinimumSize = new System.Drawing.Size(300, 0);
            this.Studentname2lbl.Name = "Studentname2lbl";
            this.Studentname2lbl.Size = new System.Drawing.Size(300, 24);
            this.Studentname2lbl.TabIndex = 38;
            this.Studentname2lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // aylistcmb
            // 
            this.aylistcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aylistcmb.FormattingEnabled = true;
            this.aylistcmb.Location = new System.Drawing.Point(222, 270);
            this.aylistcmb.Name = "aylistcmb";
            this.aylistcmb.Size = new System.Drawing.Size(125, 25);
            this.aylistcmb.TabIndex = 64;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(99, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 63;
            this.label11.Text = "Academic Year";
            // 
            // FormScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 437);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Scanner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAttendancepic_FormClosed);
            this.Load += new System.EventHandler(this.FormAttendancepic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicViewer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Studentnamelbl;
        private System.Windows.Forms.Button Enterbtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Label StudentIdlbl;
        private System.Windows.Forms.TextBox Studentidtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView PicViewer;
        private System.Windows.Forms.Label Timeinoutlbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseYearLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Timesubmitlbl;
        private System.Windows.Forms.Label Studentname2lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox aylistcmb;
        private System.Windows.Forms.Label label11;
    }
}