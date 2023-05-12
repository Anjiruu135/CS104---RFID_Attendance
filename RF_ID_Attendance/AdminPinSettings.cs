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
    public partial class AdminPinSettings : Form
    {
        public AdminPinSettings()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";

        private void AdminPinSettings_Load(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
        }

        private void AdminPinSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSettings formsett = new AdminSettings();
            formsett.Show();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            ResetPinCommand();
        }

        private void ResetPinCommand()
        {
            string query = "SELECT * FROM Pin Where Pinpass='" + Encrypt.HashString(Currentpintxt.Text) + "'";
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
                    string update_query = "UPDATE Pin SET Pinpass='" + Encrypt.HashString(Newpintxt.Text) + "' WHERE ID = 1 ";
                    MySqlCommand commandDatabase1 = new MySqlCommand(update_query, databaseConnection);
                    try
                    {
                        if (Newpintxt.Text == Confirmnewpintxt.Text)
                        {
                            databaseConnection.Close();
                            databaseConnection.Open();
                            commandDatabase1.ExecuteNonQuery();
                            databaseConnection.Close();
                            MessageBox.Show("Successfully changed Pin", "Pin Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            AdminDashboard formadminddash = new AdminDashboard();
                            formadminddash.Show();
                        }
                        else
                        {
                            MessageBox.Show("New Pin does not match Confirm Pin", "Pin Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Old Pin Incorrect", "Pin Reset Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
