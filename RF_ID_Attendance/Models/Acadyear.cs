using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RF_ID_Attendance.Models
{
    public class Acadyear
    {
        [Required]
        public string Year1 { get; set; }

        [Required]
        public string Year2 { get; set; }
    }
}
