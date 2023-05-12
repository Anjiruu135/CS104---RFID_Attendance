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
    public partial class AdminReset : Form
    {
        public AdminReset()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";

        private void ResetPasswordCommand()
        {
            string query = "SELECT * FROM Login Where Password='" + Encrypt.HashString(Oldpwordtxt.Text) + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {                     
                    string update_query = "UPDATE Login SET Password='" + Encrypt.HashString(Newpwordtxt.Text) + "' WHERE ID = 1 ";
                    MySqlCommand commandDatabase1 = new MySqlCommand(update_query, databaseConnection);
                    try
                    {
                        if (Newpwordtxt.Text == Confirmnewpwordtxt.Text)
                        {
                            databaseConnection.Close();
                            databaseConnection.Open();
                            commandDatabase1.ExecuteNonQuery();
                            databaseConnection.Close();
                            MessageBox.Show("Successfully changed Password", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            AdminLogin formlog = new AdminLogin();
                            formlog.Show();
                        }
                        else
                        {
                            MessageBox.Show("New Password does not match Confirm Password", "Password Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Old Password Incorrect", "Password Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormReset_Load(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void FormReset_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            ResetPasswordCommand();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings formsett = new AdminSettings();
            formsett.Show();
        }

        private void Newpwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Updatebtn.PerformClick();
        }

        private void Confirmnewpwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Updatebtn.PerformClick();
        }

        private void FormReset_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Cancelbtn.PerformClick();
        }
    }
}
