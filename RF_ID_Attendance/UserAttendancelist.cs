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

namespace RF_ID_Attendance
{
    public partial class UserAttendancelist : Form
    {
        public UserAttendancelist()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void UserAttendancelist_Load(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
            GetAttendance();
            LoadCmb();
        }

        private void UserAttendancelist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UserAttendancelist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Backbtn.PerformClick();
        }

        private void GetAttendance()
        {
            string query = "SELECT * from attendance WHERE Acadyear='" + aylistcmb.Text + "' ORDER by Id DESC";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase1 = new MySqlCommand(query, databaseConnection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(query, databaseConnection);
            da.Fill(dt);
            AttendancelistDGV.DataSource = dt;
        }

        private void SearchAttendance()
        {
            string search_query = "SELECT * FROM attendance WHERE (Studentidatt LIKE '%" + Searchboxtxt.Text + "%' or Fullname LIKE '%" + Searchboxtxt.Text + "%' or Date LIKE '%" + Searchboxtxt.Text + "%' or Timein LIKE '%" + Searchboxtxt.Text + "%' or Timeout LIKE '%" + Searchboxtxt.Text + "%') AND Acadyear='" + aylistcmb.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(search_query, databaseConnection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(search_query, databaseConnection);
            da.Fill(dt);
            AttendancelistDGV.DataSource = dt;
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDashboard dash = new UserDashboard();
            dash.Show();
        }

        private void Searchboxtxt_TextChanged(object sender, EventArgs e)
        {
            SearchAttendance();
            if (Searchboxtxt.Text == "")
            {
                GetAttendance();
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
            GetAttendance();
        }
    }
}
