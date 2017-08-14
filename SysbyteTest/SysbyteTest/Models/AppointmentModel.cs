using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SysbyteTest.Models
{
    public class AppointmentModel
    {
        public string firstName { get; set; }
        public int mobile { get; set; }
        public string email { get; set; }
        public int daysId { get; set; }
        public int timeId { get; set; }
       // public List<AppointmentModel> appointmentInfo { get; set; }
    }
}