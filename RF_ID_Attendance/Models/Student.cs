using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RF_ID_Attendance.Models
{
    public class Student
    {
        [Required]
        public string Studentid { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Middlename { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string Courselevel { get; set; }

        [Required]
        public string Rfid { get; set; }

        [Required]
        public string Academicyear { get; set; }
    }
}
