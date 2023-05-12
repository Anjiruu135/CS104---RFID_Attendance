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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin formlogin = new AdminLogin();
            formlogin.Show();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
            CountStudents();
        }

        private void FormDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormDashboard_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Exitbtn.PerformClick();
        }

        private void Studentlistbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserStudentlist formstud = new UserStudentlist();
            formstud.Show();
        }

        private void Attendancebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserAttendancelist formattend = new UserAttendancelist();
            formattend.Show();
        }

        private void Attendancepicbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormScanner formattendpic = new FormScanner();
            formattendpic.Show();
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

            string count_unique_query = "SELECT COUNT(*) as countunique FROM attendance WHERE Date = '"+ DateTime.Now.ToLongDateString() + "' GROUP BY Fullname;";
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
    }
}
