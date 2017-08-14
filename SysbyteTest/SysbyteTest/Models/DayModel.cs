using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SysbyteTest.Models
{
    public class DayModel
    {
        public int DayId { get; set; }
        public string DayName { get; set; }
        public bool IsDayChecked { get; set; }
       
    }

    //public class ChkDayModel
    //{
    //    public List<DayModel> dayInfo { get; set; }
    //}
}