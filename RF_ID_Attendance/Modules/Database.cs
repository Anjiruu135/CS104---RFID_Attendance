using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace RF_ID_Attendance.Modules
{
    public class Database
    {
        public string connString = "server=localhost;username=root;password=;database=rfid_db;port=3306;";
        public MySqlConnection con;
        public MySqlCommand cmd;
    }
}
