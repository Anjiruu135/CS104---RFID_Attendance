using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using RF_ID_Attendance.Modules;
using RF_ID_Attendance.Models;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace RF_ID_Attendance
{
    public partial class AdminStudentlist : Form
    {
        private Database db;
        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";
        private StudentModule student = new StudentModule();
        public AdminStudentlist()
        {
            InitializeComponent();
        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            ValidateStudent();
            ViewPicture();
            studentlistDGV.Sort(studentlistDGV.Columns["StudentID"], ListSortDirection.Ascending);
        }

        private void FormStudentList_Load(object sender, EventArgs e)
        { 
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
            ViewPicture();
            studentlistDGV.Sort(studentlistDGV.Columns["StudentID"], ListSortDirection.Ascending);
            LoadCmb();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard dash = new AdminDashboard();
            dash.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void FormStudentlist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Uploadbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfd = new OpenFileDialog();
            openfd.Filter = "Image Files(*.jpg;*.jpeg;*.gif;) | *.jpg;*.jpeg;*.gif;";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                ImageText.Text = openfd.FileName;
                Studentpicbox.Image = new Bitmap(openfd.FileName);
                Studentpicbox.ImageLocation = openfd.FileName;
                Studentpicbox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            DeleteCommand();
            ViewPicture();
            studentlistDGV.Sort(studentlistDGV.Columns["StudentID"], ListSortDirection.Ascending);
            Submitbtn.Visible = true;
            Updatebtn.Visible = false;
        }

        private void DeleteCommand()
        {
            if (MessageBox.Show("Do you want to delete student?", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string selected_studentid = studentlistDGV.CurrentRow.Cells["StudentID"].Value.ToString();
                string selected_firstname = studentlistDGV.CurrentRow.Cells["FirstName"].Value.ToString();
                string selected_middlename = studentlistDGV.CurrentRow.Cells["MiddleName"].Value.ToString();
                string selected_lastname = studentlistDGV.CurrentRow.Cells["Lastname"].Value.ToString();
                string selected_courselevel = studentlistDGV.CurrentRow.Cells["CourseYearLevel"].Value.ToString();
                string selected_rfid = studentlistDGV.CurrentRow.Cells["Rfid"].Value.ToString();
                string selected_picture = studentlistDGV.CurrentRow.Cells["Picture"].Value.ToString();
                string selected_acadyear = studentlistDGV.CurrentRow.Cells["Acadyear"].Value.ToString();

                string delete_row = "DELETE from student where Studentid= '" + selected_studentid + "' AND Firstname= '" + selected_firstname + "' AND Middlename= '" + selected_middlename + "' AND Lastname= '" + selected_lastname + "' AND Courselevel= '" + selected_courselevel + "' AND Rfid= '" + selected_rfid + "'  AND Acadyear= '" + selected_acadyear + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(delete_row, databaseConnection);

                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();

                //GetStudent();
            }
        }

        private void FormStudentlist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Backbtn.PerformClick();
        }

        private void ValidateStudent()
        {

            var StudentModel = new Student()
            {
                Studentid = studentidtxt.Text,
                Firstname = firstnametxt.Text,
                Middlename = middlenametxt.Text,
                Lastname = lastnametxt.Text,
                Courselevel = courseleveltxt.Text,
                Rfid = rfidtxt.Text,
                Academicyear = aylistcmb.Text
            };

            ValidationContext context = new ValidationContext(StudentModel);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(StudentModel, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage} \n");
                MessageBox.Show(errorMsg.ToString(), "Validation Error" );
                return;
            }
            else
            {
                string checkrfid = "SELECT * from student WHERE Rfid='" + rfidtxt.Text + "' AND Acadyear='" + aylistcmb.Text + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                DataTable dt11 = new DataTable();
                MySqlDataAdapter da11 = new MySqlDataAdapter(checkrfid, databaseConnection);
                da11.Fill(dt11);
                if (dt11.Rows.Count > 0)
                {
                    MessageBox.Show("RFID already taken", "Submit Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        string studid = studentidtxt.Text;
                        string fname = firstnametxt.Text;
                        string mname = middlenametxt.Text;
                        string lname = lastnametxt.Text;
                        string courselvl = courseleveltxt.Text;
                        string rfid = rfidtxt.Text;

                        MemoryStream ms = new MemoryStream();
                        Studentpicbox.Image.Save(ms, Studentpicbox.Image.RawFormat);
                        byte[] pic = ms.ToArray();
                        byte[] picture = pic;

                        string ayyear = aylistcmb.Text;

                        if (student.Insert(studid, fname, mname, lname, courselvl, rfid, picture, ayyear))
                        {
                            MessageBox.Show("New student added successfully", "Submit Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }
        }

        private void ViewPicture()
        {
            string view_query = "SELECT * FROM student WHERE Acadyear='" + aylistcmb.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(view_query, databaseConnection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(view_query, databaseConnection);
            da.Fill(dt);
            studentlistDGV.DataSource = dt;
        }

        private void SearchStudent()
        {
            string search_query = "SELECT * FROM student WHERE (Studentid LIKE '%" + Searchboxtxt.Text + "%' or Firstname LIKE '%" + Searchboxtxt.Text + "%' or Middlename LIKE '%" + Searchboxtxt.Text + "%' or Lastname LIKE '%" + Searchboxtxt.Text + "%' or Courselevel LIKE '%" + Searchboxtxt.Text + "%'  or Rfid LIKE '%" + Searchboxtxt.Text + "%') AND Acadyear='" + aylistcmb.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(search_query, databaseConnection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(search_query, databaseConnection);
            da.Fill(dt);
            studentlistDGV.DataSource = dt;
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            studentidtxt.Text = "";
            firstnametxt.Text = "";
            middlenametxt.Text = "";
            lastnametxt.Text = "";
            courseleveltxt.Text = "";
            rfidtxt.Text = "";
            Studentpicbox.Image = null;
            Submitbtn.Visible = true;
            Updatebtn.Visible = false;
        }

        private void Searchboxtxt_TextChanged(object sender, EventArgs e)
        {
            SearchStudent();
            if (Searchboxtxt.Text == "")
            {
                ViewPicture();
                studentlistDGV.Sort(studentlistDGV.Columns["StudentID"], ListSortDirection.Ascending);
            }
        }

        private void UpdateStudent()
        {
            var StudentModel = new Student()
            {
                Studentid = studentidtxt.Text,
                Firstname = firstnametxt.Text,
                Middlename = middlenametxt.Text,
                Lastname = lastnametxt.Text,
                Courselevel = courseleveltxt.Text,
                Rfid = rfidtxt.Text,
                Academicyear = aylistcmb.Text
            };

            ValidationContext context = new ValidationContext(StudentModel);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(StudentModel, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage} \n");
                MessageBox.Show(errorMsg.ToString(), "Validation Error");
                return;
            }
            else
            {
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                try
                {
                    if (MessageBox.Show("Do you want to update student information?", "Update Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string selected_studentid = studentlistDGV.CurrentRow.Cells["StudentID"].Value.ToString();
                        string selected_firstname = studentlistDGV.CurrentRow.Cells["FirstName"].Value.ToString();
                        string selected_middlename = studentlistDGV.CurrentRow.Cells["MiddleName"].Value.ToString();
                        string selected_lastname = studentlistDGV.CurrentRow.Cells["Lastname"].Value.ToString();
                        string selected_courselevel = studentlistDGV.CurrentRow.Cells["CourseYearLevel"].Value.ToString();
                        string selected_rfid = studentlistDGV.CurrentRow.Cells["Rfid"].Value.ToString();

                        MemoryStream ms = new MemoryStream();
                        Studentpicbox.Image.Save(ms, Studentpicbox.Image.RawFormat);
                        byte[] pic = ms.ToArray();
                        byte[] picture = pic;

                        string update_query = "UPDATE student SET Studentid='" + studentidtxt.Text + "', Firstname='" + firstnametxt.Text + "', Middlename='" + middlenametxt.Text + "', Lastname='" + lastnametxt.Text + "', Courselevel='" + courseleveltxt.Text + "', Rfid='" + rfidtxt.Text +"', Picture=@picture WHERE Studentid= '" + selected_studentid + "' AND Firstname= '" + selected_firstname + "' AND Middlename= '" + selected_middlename + "' AND Lastname= '" + selected_lastname + "' AND Courselevel= '" + selected_courselevel + "' AND Rfid= '" + selected_rfid + "' AND Acadyear='" + aylistcmb.Text + "'";
                        MySqlCommand commandDatabase = new MySqlCommand(update_query, databaseConnection);


                        databaseConnection.Open();
                        commandDatabase.Parameters.AddWithValue("@Picture", picture);
                        commandDatabase.ExecuteNonQuery();
                        databaseConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            UpdateStudent();
            ViewPicture();
            studentlistDGV.Sort(studentlistDGV.Columns["StudentID"], ListSortDirection.Ascending);
        }

        private void studentlistDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowInfo();
            Submitbtn.Visible = false;
            Updatebtn.Visible = true;
        }

        private void ShowInfo()
        {
            string selected_studentid = studentlistDGV.CurrentRow.Cells["StudentID"].Value.ToString();
            string selected_firstname = studentlistDGV.CurrentRow.Cells["FirstName"].Value.ToString();
            string selected_middlename = studentlistDGV.CurrentRow.Cells["MiddleName"].Value.ToString();
            string selected_lastname = studentlistDGV.CurrentRow.Cells["Lastname"].Value.ToString();
            string selected_courselevel = studentlistDGV.CurrentRow.Cells["CourseYearLevel"].Value.ToString();
            string selected_rfid = studentlistDGV.CurrentRow.Cells["Rfid"].Value.ToString();

            string view_pic = "SELECT Picture from student WHERE Studentid= '" + selected_studentid + "' AND Firstname= '" + selected_firstname + "' AND Middlename= '" + selected_middlename + "' AND Lastname= '" + selected_lastname + "' AND Courselevel= '" + selected_courselevel + "' AND Rfid= '" + selected_rfid + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(view_pic, databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase);
            DataTable dt = new DataTable();
            da.Fill(dt);

            byte[] pic = (byte[])dt.Rows[0][0];
            MemoryStream ms = new MemoryStream(pic);
            Studentpicbox.Image = Image.FromStream(ms);

            studentidtxt.Text = selected_studentid;
            firstnametxt.Text = selected_firstname;
            middlenametxt.Text = selected_middlename;
            lastnametxt.Text = selected_lastname;
            courseleveltxt.Text = selected_courselevel;
            rfidtxt.Text = selected_rfid;
        }

        private void Exportbtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog openFileDialog = new SaveFileDialog();
                openFileDialog.InitialDirectory = "C:\\Users\\TEDD\\Documents";
                openFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|Excel 2007 (*.xls)|*.xls";
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = Excel.DataGridView_To_Datatable(studentlistDGV);
                    dt.exportToExcel(openFileDialog.FileName);
                    MessageBox.Show("Table exported successfully", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void LoadCmb()
        {
            aylistcmb.Items.Clear();
            string loadcmb_query = "Select * FROM academic_year ORDER BY id DESC";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(loadcmb_query, databaseConnection);
            databaseConnection.Open();
            MySqlDataReader reader = commandDatabase.ExecuteReader();
            while (reader.Read())
            {
                aylistcmb.Items.Add(reader.GetString("Acadyear"));
            }
            databaseConnection.Close();
            aylistcmb.SelectedIndex = 0;
        }

        private void aylistcmb_SelectedValueChanged(object sender, EventArgs e)
        {
            ViewPicture();
        }
    }
}
