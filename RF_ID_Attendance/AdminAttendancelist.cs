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
using System.IO;

namespace RF_ID_Attendance
{
    public partial class AdminAttendancelist : Form
    {
        public AdminAttendancelist()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard dash = new AdminDashboard();
            dash.Show();
        }

        private void FormAttendancelist_Load(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
            GetAttendance();
            LoadCmb();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void FormAttendancelist_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormAttendancelist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Backbtn.PerformClick();
        }

        private void Enterbtn_Click(object sender, EventArgs e)
        {
            SubmitCommand();
            GetAttendance();
            Studentidtxt.Clear();
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
                        if (dt.Rows.Count > 0)
                        {
                            databaseConnection.Open();
                            commandDatabase3.ExecuteReader();
                            databaseConnection.Close();
                        }

                        else
                        {
                            databaseConnection.Open();
                            commandDatabase1.ExecuteReader();
                            databaseConnection.Close();
                        }
                    }
                    else
                    {
                        if (dt.Rows.Count > 0)
                        {
                            databaseConnection.Open();
                            commandDatabase3.ExecuteReader();
                            databaseConnection.Close();
                        }

                        else
                        {
                            databaseConnection.Open();
                            commandDatabase1.ExecuteReader();
                            databaseConnection.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        
        private void Studentidtxt_TextChanged(object sender, EventArgs e)
        {
            IDcheckCommand();
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

        private void Studentidtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Enterbtn.PerformClick();
                Studentidtxt.Clear();
            }
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to reset attendance? \n\nNote: This will only reset the current selected Academic Year", "Reset Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ResetAttendance();
            }
        }

        private void ResetAttendance()
        {
            string query = "DELETE from attendance WHERE InStatus='"+ "Timed In" + "' AND Acadyear='" + aylistcmb.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.ExecuteNonQuery();
            databaseConnection.Close();
            GetAttendance();
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

        private void Searchboxtxt_TextChanged(object sender, EventArgs e)
        {
            SearchAttendance();
            if (Searchboxtxt.Text == "")
            {
                GetAttendance();
            }
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            RemoveCommand();
            GetAttendance();
        }

        private void RemoveCommand()
        {
            if (MessageBox.Show("Do you want to remove attendance?", "Delete Attendance", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string selected_studentid = AttendancelistDGV.CurrentRow.Cells["StudentID"].Value.ToString();
                string selected_fullname = AttendancelistDGV.CurrentRow.Cells["StudentName"].Value.ToString();
                string selected_timein = AttendancelistDGV.CurrentRow.Cells["TimeIn"].Value.ToString();
                string selected_instatus = AttendancelistDGV.CurrentRow.Cells["InStatus"].Value.ToString();
                string selected_timeout = AttendancelistDGV.CurrentRow.Cells["TimeOut"].Value.ToString();
                string selected_outstatus = AttendancelistDGV.CurrentRow.Cells["OutStatus"].Value.ToString();
                string selected_date = AttendancelistDGV.CurrentRow.Cells["Date"].Value.ToString();

                string delete_row = "DELETE from attendance WHERE Studentidatt= '" + selected_studentid + "' AND Fullname= '" + selected_fullname + "' AND Timein= '" + selected_timein + "' AND InStatus= '" + selected_instatus + "' AND Timeout= '" + selected_timeout + "' AND OutStatus= '" + selected_outstatus + "' AND date= '" + selected_date + "' AND Acadyear='" + aylistcmb.Text + "'";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(delete_row, databaseConnection);

                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }
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
                    DataTable dt = Excel.DataGridView_To_Datatable(AttendancelistDGV);
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
            GetAttendance();
        }
    }
}
