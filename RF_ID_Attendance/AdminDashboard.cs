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
using RFID_Scanner_Attendance;

namespace RF_ID_Attendance
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";

        private void Studentlistbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminStudentlist formstud = new AdminStudentlist();
            formstud.Show();
        }

        private void Attendancebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminAttendancelist formattend = new AdminAttendancelist();
            formattend.Show();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        { 
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
            RecentInOut();
            LoadCmb();
            aylistcmb.SelectedIndex = 0;
            CountStudents();
            Fillchart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Logoutbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                UserDashboard formdash = new UserDashboard();
                formdash.Show();
            }      
        }

        private void Dashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Logoutbtn.PerformClick();
        }

        private void Attendancepicbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormScanner formattendpic = new FormScanner();
            formattendpic.Show();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formPopup = new AdminPinLogin();
            formPopup.ShowDialog();
        }

        private void CountStudents()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string count_in_query = "SELECT COUNT(*) as countdata from attendance Where InStatus='Timed In' AND OutStatus='' AND Date = '" + DateTime.Now.ToLongDateString() + "'";
            MySqlCommand commandDatabase = new MySqlCommand(count_in_query, databaseConnection);
            string count_today_query = "SELECT COUNT(*) as countdatatoday from attendance Where InStatus='Timed In' AND Date = '" + DateTime.Now.ToLongDateString() + "'";
            MySqlCommand commandDatabase1 = new MySqlCommand(count_today_query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            commandDatabase1.CommandTimeout = 60;
            MySqlDataReader reader1;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.Read())
                {
                    string Count_in = reader.GetInt32("countdata").ToString();
                    No1lbl.Text = Count_in;
                }
                databaseConnection.Close();

                databaseConnection.Open();
                reader1 = commandDatabase1.ExecuteReader();
                if (reader1.Read())
                {
                    string Count_today = reader1.GetInt32("countdatatoday").ToString();
                    No2lbl.Text = Count_today;
                }
                databaseConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string count_unique_query = "SELECT COUNT(*) as countunique FROM attendance WHERE Date = '" + DateTime.Now.ToLongDateString() + "' GROUP BY Fullname;";
            MySqlCommand commandDatabase2 = new MySqlCommand(count_unique_query, databaseConnection);
            commandDatabase2.CommandTimeout = 60;
            MySqlDataReader reader2;
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(count_unique_query, databaseConnection);
            da.Fill(dt);
            try
            {
                databaseConnection.Open();
                reader2 = commandDatabase2.ExecuteReader();
                if (reader2.Read())
                {
                    string Count_unique = dt.Rows.Count.ToString();
                    No3lbl.Text = Count_unique;
                }
                databaseConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Fillchart()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string count_students_query = "SELECT Courselevel, COUNT(*) as Course FROM student WHERE Acadyear ='" + aylistcmb.Text + "' GROUP BY Courselevel";
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(count_students_query, databaseConnection);
            da.Fill(dt);
            studentschart.DataSource = dt;
            studentschart.Series["Course"].XValueMember = "Courselevel";
            studentschart.Series["Course"].YValueMembers = "Course";

            string count_attendance_query = "SELECT Date, COUNT(*) as StudAtt FROM attendance WHERE Acadyear ='" + aylistcmb.Text + "' GROUP BY Date ORDER BY Id ASC";
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(count_attendance_query, databaseConnection);
            da1.Fill(dt1);
            attendancechart.DataSource = dt1;
            attendancechart.Series["StudAtt"].XValueMember = "Date";
            attendancechart.Series["StudAtt"].YValueMembers = "StudAtt";
        }

        private void RecentInOut()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string in_query = "SELECT Fullname, Timein from attendance ORDER by Id DESC LIMIT 5";
            MySqlCommand commandDatabase = new MySqlCommand(in_query, databaseConnection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(in_query, databaseConnection);
            da.Fill(dt);
            recenttimein.DataSource = dt;

            string out_query = "SELECT Fullname, Timeout from attendance WHERE Timeout !='' ORDER by Id DESC LIMIT 5";
            MySqlCommand commandDatabase1 = new MySqlCommand(out_query, databaseConnection);
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(out_query, databaseConnection);
            da1.Fill(dt1);
            recenttimeout.DataSource = dt1;
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
        }

        private void aylistcmb_SelectedValueChanged(object sender, EventArgs e)
        {
            Fillchart();
        }

        private void aylistcmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentschart.Series.Clear();
            studentschart.Series.Add("Course");
            studentschart.Series["Course"].XValueMember = "Courselevel";
            studentschart.Series["Course"].YValueMembers = "Course";

            attendancechart.Series.Clear();
            attendancechart.Series.Add("StudAtt");
            var series = attendancechart.Series["StudAtt"];
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Range;
            attendancechart.Series["StudAtt"].XValueMember = "Date";
            attendancechart.Series["StudAtt"].YValueMembers = "StudAtt";
            Fillchart();
        }
    }
}
