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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";

        private void LoginCommand()
        {
            string query = "SELECT * FROM Login Where Username='" + Usernametxt.Text + "' AND Password='" + Encrypt.HashString(Passwordtxt.Text) + "'";
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
                        MessageBox.Show("Successful Login", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        AdminDashboard dash = new AdminDashboard();
                        dash.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username/Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            LoginCommand();
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel login?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                UserDashboard formdash = new UserDashboard();
                formdash.Show();
            }    
        }

        private void Usernametxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Loginbtn.PerformClick();
        }

        private void Passwordtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Loginbtn.PerformClick();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Cancelbtn.PerformClick();
        }

        private void Loginbtn_Click_1(object sender, EventArgs e)
        {
            LoginCommand();
        }
    }
}
