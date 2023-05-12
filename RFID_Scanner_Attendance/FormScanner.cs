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
using System.IO;

namespace RFID_Scanner_Attendance
{
    public partial class FormScanner : Form
    {
        public FormScanner()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";

        private void FormAttendancepic_Load(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
            LoadCmb();
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

        private void FormAttendancepic_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void IDcheckCommand()
        {
            string submit_query = "SELECT * FROM student Where Rfid='" + Studentidtxt.Text + "' AND Acadyear='" + aylistcmb.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(submit_query, databaseConnection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(submit_query, databaseConnection);
            da.Fill(dt);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            if (dt.Rows.Count > 0)
            {
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    if (reader.Read())
                    {
                        string name1 = reader["Lastname"].ToString();
                        string name2 = reader["Firstname"].ToString();
                        string name3 = reader["Middlename"].ToString();
                        string fullname = name1 + ", " + name2 + " " + name3;
                        StudentIdlbl.Text = reader["Studentid"].ToString();
                        Studentnamelbl.Text = fullname;
                    }
                    else
                    {

                    }
                    databaseConnection.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                StudentIdlbl.Text = "";
                Studentnamelbl.Text = "";
            }

        }

        private void SubmitCommand()
        {
            string submit_query = "SELECT * FROM student Where Rfid='" + Studentidtxt.Text + "' AND Acadyear='" + aylistcmb.Text + "'";
            string timein_query = "INSERT into attendance(Studentidatt,Fullname,Timein,InStatus,Date,Acadyear) values ('" + StudentIdlbl.Text + "','" + Studentnamelbl.Text + "','" + timelbl.Text + "','" + "Timed In" + "','" + datelbl.Text + "','" + aylistcmb.Text + "')";
            string read_query = "SELECT * from attendance WHERE Studentidatt='" + StudentIdlbl.Text + "' AND InStatus=  '" + "Timed In" + "' AND OutStatus= '" + "" + "'AND Acadyear='" + aylistcmb.Text + "'";
            string timeout_query = "UPDATE attendance SET Timeout='" + timelbl.Text + "', OutStatus='" + "Timed Out" + "' WHERE Studentidatt='" + StudentIdlbl.Text + "' AND InStatus='" + "Timed In" + "' AND OutStatus= '" + "" + "'AND Acadyear='" + aylistcmb.Text + "'";
            string new_query = "SELECT * from attendance WHERE Studentidatt='" + StudentIdlbl.Text + "' AND InStatus='" + "Timed In" + "' AND OutStatus= '" + "Timed Out" + "'AND Acadyear='" + aylistcmb.Text + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase1 = new MySqlCommand(timein_query, databaseConnection);
            MySqlCommand commandDatabase3 = new MySqlCommand(timeout_query, databaseConnection);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(read_query, databaseConnection);
            MySqlDataAdapter da1 = new MySqlDataAdapter(new_query, databaseConnection);
            da.Fill(dt);
            da1.Fill(dt1);

            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(submit_query, databaseConnection);
            da2.Fill(dt2);
            if (dt2.Rows.Count > 0)
            {
                try
                {
                    if (dt1.Rows.Count > 0)
                    {
                        IDcheckCommand2();
                        if (dt.Rows.Count > 0)
                        {
                            databaseConnection.Open();
                            commandDatabase3.ExecuteReader();
                            databaseConnection.Close();
                            Timeinoutlbl.Text = "Time Out";
                            Timeinoutlbl.BackColor = Color.Red;
                        }

                        else
                        {
                            databaseConnection.Open();
                            commandDatabase1.ExecuteReader();
                            databaseConnection.Close();
                            Timeinoutlbl.Text = "Time In";
                            Timeinoutlbl.BackColor = Color.Green;
                        }
                    }
                    else
                    {
                        IDcheckCommand2();
                        if (dt.Rows.Count > 0)
                        {
                            databaseConnection.Open();
                            commandDatabase3.ExecuteReader();
                            databaseConnection.Close();
                            Timeinoutlbl.Text = "Time Out";
                            Timeinoutlbl.BackColor = Color.Red;
                        }

                        else
                        {
                            databaseConnection.Open();
                            commandDatabase1.ExecuteReader();
                            databaseConnection.Close();
                            Timeinoutlbl.Text = "Time In";
                            Timeinoutlbl.BackColor = Color.Green;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Studentname2lbl.Text = "";
                Timesubmitlbl.Text = "";
                Timeinoutlbl.Text = "Invalid ID";
                Timeinoutlbl.BackColor = Color.Black;
                ViewPicture();
            }
        }

        private void Studentidtxt_TextChanged(object sender, EventArgs e)
        {
            IDcheckCommand();
        }

        private void Studentidtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enterbtn.PerformClick();
                Studentidtxt.Clear();
            }
        }

        private void Enterbtn_Click_1(object sender, EventArgs e)
        {
            SubmitCommand();
            ViewPicture();
            Studentidtxt.Clear();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void ViewPicture()
        {
            string view_query = "SELECT * FROM student WHERE Rfid='" + Studentidtxt.Text + "' AND Acadyear='" + aylistcmb.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(view_query, databaseConnection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(view_query, databaseConnection);
            da.Fill(dt);
            PicViewer.DataSource = dt;
        }

        private void IDcheckCommand2()
        {
            string submit_query = "SELECT * FROM student Where Rfid='" + Studentidtxt.Text + "' AND Acadyear='" + aylistcmb.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(submit_query, databaseConnection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(submit_query, databaseConnection);
            da.Fill(dt);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            if (dt.Rows.Count > 0)
            {
                try
                {
                    databaseConnection.Open();
                    reader = commandDatabase.ExecuteReader();

                    if (reader.Read())
                    {
                        string name1 = reader["Lastname"].ToString();
                        string name2 = reader["Firstname"].ToString();
                        string name3 = reader["Middlename"].ToString();
                        string fullname = name1 + ", " + name2 + " " + name3;
                        StudentIdlbl.Text = reader["Studentid"].ToString();
                        Studentname2lbl.Text = fullname;
                        Timesubmitlbl.Text = timelbl.Text;
                    }
                    else
                    {

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
}
