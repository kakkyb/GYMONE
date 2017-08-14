using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SysbyteTest.Models;

namespace SysbyteTest.Models
{
    //public class DayTimeViewModel
    //{
    //    public int DayId { get; set; }
    //    public string DayName { get; set; }
    //    public bool IsDayChecked { get; set; }

    //    public int TimeId { get; set; }
    //    public string TimeHour { get; set; }
    //    public bool IsTimeChecked { get; set; }
    //    public List<DayModel> dayInfo { get; set; }
    //}
    public class ChkDayTimeViewModel
    {
        public List<DayModel> dayInfo { get; set; }
        public List<TimeModel> timeInfo { get; set; }
     //   public List<AppointmentModel> appointModel { get; set; }

        public AppointmentModel appointmodel = new AppointmentModel();

        // public List<DayTimeViewModel> timeInfo { get; set; }
    }
}