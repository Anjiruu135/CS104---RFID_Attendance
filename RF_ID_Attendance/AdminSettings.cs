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
using RF_ID_Attendance.Models;
using System.ComponentModel.DataAnnotations;

namespace RF_ID_Attendance
{
    public partial class AdminSettings : Form
    {
        public AdminSettings()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";

        private void AddAYbtn_Click(object sender, EventArgs e)
        {
            ValidateAY();
            LoadCmb();
        }

        private void LoadCmb()
        {
            aylistcmb.Items.Clear();
            string loadcmb_query = "Select * FROM academic_year";
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

        private void AddAY()
        {
            string acad_year = Sy1lbl.Text + " - " + Sy2lbl.Text;
            string checkyear = "SELECT * from academic_year WHERE Acadyear='" + acad_year + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(checkyear, databaseConnection);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Academic Year already exist!", "Submit Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string adday_query = "INSERT into academic_year (AcadYear) VALUES ('" + acad_year + "')";
                MySqlCommand commandDatabase = new MySqlCommand(adday_query, databaseConnection);
                databaseConnection.Open();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Close();
            }
        }

        private void AdminSettings_Load(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
            LoadCmb();
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Hide();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard formaddash = new AdminDashboard();
            formaddash.Show();
        }

        private void ResetPassbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminReset formreset = new AdminReset();
            formreset.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timelbl.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void RemoveAYbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove this Academic Year? \n\nNote: This will remove every data stored within the Academic Year", "Remove Academic Year", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RemoveAY();
                LoadCmb();
            }
        }

        private void RemoveAY()
        {
            string removeay_query = "DELETE FROM academic_year WHERE Acadyear='" + aylistcmb.Text + "'; DELETE FROM student WHERE Acadyear='" + aylistcmb.Text + "'; DELETE FROM attendance WHERE Acadyear='" + aylistcmb.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(removeay_query, databaseConnection);
            databaseConnection.Open();
            commandDatabase.ExecuteNonQuery();
            databaseConnection.Close();
        }

        private void ValidateAY()
        {

            var AcadyearModel = new Acadyear()
            {
                Year1 = Sy1lbl.Text,
                Year2 = Sy2lbl.Text
            };

            ValidationContext context = new ValidationContext(AcadyearModel);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(AcadyearModel, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage} \n");
                MessageBox.Show(errorMsg.ToString(), "Validation Error");
                return;
            }
            else
            {
                AddAY();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminPinSettings formpinset = new AdminPinSettings();
            formpinset.Show();
        }

        private void AdminSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
