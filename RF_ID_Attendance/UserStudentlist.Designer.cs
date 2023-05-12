namespace RF_ID_Attendance
{
    partial class UserStudentlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserStudentlist));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.datelbl = new System.Windows.Forms.Label();
            this.timelbl = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.studentlistDGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseYearLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.Searchboxtxt = new System.Windows.Forms.TextBox();
            this.aylistcmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentlistDGV)).BeginInit();
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
            this.datelbl.Location = new System.Drawing.Point(12, 10);
            this.datelbl.Name = "datelbl";
            this.datelbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.datelbl.Size = new System.Drawing.Size(48, 20);
            this.datelbl.TabIndex = 64;
            this.datelbl.Text = "Date ";
            // 
            // timelbl
            // 
            this.timelbl.AutoSize = true;
            this.timelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timelbl.Location = new System.Drawing.Point(12, 35);
            this.timelbl.Name = "timelbl";
            this.timelbl.Size = new System.Drawing.Size(43, 20);
            this.timelbl.TabIndex = 63;
            this.timelbl.Text = "Time";
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
            this.Backbtn.TabIndex = 58;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(532, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 31);
            this.label6.TabIndex = 59;
            this.label6.Text = "Student List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::RF_ID_Attendance.Properties.Resources.Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1120, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // studentlistDGV
            // 
            this.studentlistDGV.AllowUserToAddRows = false;
            this.studentlistDGV.AllowUserToDeleteRows = false;
            this.studentlistDGV.AllowUserToResizeColumns = false;
            this.studentlistDGV.AllowUserToResizeRows = false;
            this.studentlistDGV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.studentlistDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentlistDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StudentID,
            this.FirstName,
            this.MiddleName,
            this.LastName,
            this.CourseYearLevel,
            this.Rfid,
            this.Image,
            this.Picture});
            this.studentlistDGV.Location = new System.Drawing.Point(31, 116);
            this.studentlistDGV.Margin = new System.Windows.Forms.Padding(2);
            this.studentlistDGV.Name = "studentlistDGV";
            this.studentlistDGV.ReadOnly = true;
            this.studentlistDGV.RowHeadersVisible = false;
            this.studentlistDGV.RowTemplate.Height = 75;
            this.studentlistDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.studentlistDGV.Size = new System.Drawing.Size(1168, 519);
            this.studentlistDGV.TabIndex = 62;
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
            this.StudentID.DataPropertyName = "Studentid";
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentID.Width = 175;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "Firstname";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FirstName.Width = 200;
            // 
            // MiddleName
            // 
            this.MiddleName.DataPropertyName = "Middlename";
            this.MiddleName.HeaderText = "Middle Name";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            this.MiddleName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MiddleName.Width = 200;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "Lastname";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LastName.Width = 200;
            // 
            // CourseYearLevel
            // 
            this.CourseYearLevel.DataPropertyName = "Courselevel";
            this.CourseYearLevel.HeaderText = "Course - Year Level";
            this.CourseYearLevel.Name = "CourseYearLevel";
            this.CourseYearLevel.ReadOnly = true;
            this.CourseYearLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CourseYearLevel.Width = 150;
            // 
            // Rfid
            // 
            this.Rfid.DataPropertyName = "Rfid";
            this.Rfid.HeaderText = "RF Card ID";
            this.Rfid.Name = "Rfid";
            this.Rfid.ReadOnly = true;
            this.Rfid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Rfid.Width = 150;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.Name = "Image";
            this.Image.ReadOnly = true;
            this.Image.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Image.Visible = false;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Picture";
            this.Picture.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(932, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 70;
            this.label10.Text = "Search";
            // 
            // Searchboxtxt
            // 
            this.Searchboxtxt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Searchboxtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchboxtxt.Location = new System.Drawing.Point(999, 84);
            this.Searchboxtxt.Margin = new System.Windows.Forms.Padding(4);
            this.Searchboxtxt.Name = "Searchboxtxt";
            this.Searchboxtxt.Size = new System.Drawing.Size(200, 26);
            this.Searchboxtxt.TabIndex = 69;
            this.Searchboxtxt.TextChanged += new System.EventHandler(this.Searchboxtxt_TextChanged);
            // 
            // aylistcmb
            // 
            this.aylistcmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aylistcmb.FormattingEnabled = true;
            this.aylistcmb.Location = new System.Drawing.Point(150, 85);
            this.aylistcmb.Name = "aylistcmb";
            this.aylistcmb.Size = new System.Drawing.Size(125, 24);
            this.aylistcmb.TabIndex = 72;
            this.aylistcmb.SelectedValueChanged += new System.EventHandler(this.aylistcmb_SelectedValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(27, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 71;
            this.label11.Text = "Academic Year";
            // 
            // UserStudentlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1232, 703);
            this.Controls.Add(this.aylistcmb);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Searchboxtxt);
            this.Controls.Add(this.datelbl);
            this.Controls.Add(this.timelbl);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.studentlistDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserStudentlist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Student List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStudentlist_FormClosed);
            this.Load += new System.EventHandler(this.FormStudentlist_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormStudentlist_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentlistDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label datelbl;
        private System.Windows.Forms.Label timelbl;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView studentlistDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseYearLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Searchboxtxt;
        private System.Windows.Forms.ComboBox aylistcmb;
        private System.Windows.Forms.Label label11;
    }
}