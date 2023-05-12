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
    public partial class AdminPinLogin : Form
    {
        public AdminPinLogin()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";

        private void Enterpinbtn_Click(object sender, EventArgs e)
        {
            EnterPinCommand();
        }

        private void EnterPinCommand()
        {
            string query = "SELECT * FROM Pin WHERE Pinpass='" + Encrypt.HashString(Pinpasstxt.Text) + "'";
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
                    while (reader.Read())
                    {
                        this.Hide();
                        AdminSettings settingsform = new AdminSettings();
                        settingsform.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Pin", "Enter Pin Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AdminPinLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            AdminDashboard formaddash = new AdminDashboard();
            formaddash.Show();
        }
    }
}
