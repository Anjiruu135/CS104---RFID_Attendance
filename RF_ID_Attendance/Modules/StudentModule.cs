using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using RF_ID_Attendance.Models;

namespace RF_ID_Attendance.Modules
{
    public class StudentModule:Database
    {
        public bool Insert(string _studentid, string _firstname, string _middlename, string _lastname, string _courselevel, string _rfid, byte[] _picture, string _acadyear)
        {
            try
            {
                using (base.con = new MySqlConnection(base.connString))
                {
                    using (base.cmd = new MySqlCommand("Insert into student (Studentid, Firstname, Middlename, Lastname, Courselevel, Rfid, Picture, Acadyear) values (@Studentid, @Firstname, @Middlename, @Lastname, @Courselevel, @Rfid, @Picture, @Acadyear)", con))
                    {
                        con.Open();
                        base.cmd.Parameters.AddWithValue("@Studentid", _studentid);
                        base.cmd.Parameters.AddWithValue("@Firstname", _firstname);
                        base.cmd.Parameters.AddWithValue("@Middlename", _middlename);
                        base.cmd.Parameters.AddWithValue("@Lastname", _lastname);
                        base.cmd.Parameters.AddWithValue("@Courselevel", _courselevel);
                        base.cmd.Parameters.AddWithValue("@Rfid", _rfid);
                        base.cmd.Parameters.AddWithValue("@Picture", _picture);
                        base.cmd.Parameters.AddWithValue("@Acadyear", _acadyear);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
