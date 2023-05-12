using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RF_ID_Attendance.Modules;
using MySql.Data.MySqlClient;
using System.IO;

namespace RF_ID_Attendance
{
    public partial class UserStudentlist : Form
    {
        private Database db;
        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";
        public UserStudentlist()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard formdash = new UserDashboard();
            formdash.Show();
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

        private void FormStudentlist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Backbtn.PerformClick();
        }

        private void ViewStudents()
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

        private void FormStudentlist_Load(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
            ViewStudents();
            studentlistDGV.Sort(studentlistDGV.Columns["StudentID"], ListSortDirection.Ascending);
            LoadCmb();
        }

        private void Searchboxtxt_TextChanged(object sender, EventArgs e)
        {
            SearchStudent();
            if (Searchboxtxt.Text == "")
            {
                ViewStudents();
                studentlistDGV.Sort(studentlistDGV.Columns["StudentID"], ListSortDirection.Ascending);
            }
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
            ViewStudents();
        }
    }
}
