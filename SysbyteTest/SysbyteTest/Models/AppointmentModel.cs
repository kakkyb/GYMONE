using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SysbyteTest.Models
{
    public class AppointmentModel
    {
        [Required]
        public string firstName { get; set; }
        [Required]
        public int mobile { get; set; }
        [Required]
        public string email { get; set; }
        public int daysId { get; set; }
        public int timeId { get; set; }
       // public List<AppointmentModel> appointmentInfo { get; set; }
    }
}