using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient; //to communicate with SQL Server Database
using System.Configuration; // to use the ConfigurationManager
//using SysbyteTest.EntityDb;
using System.Data; // to use DataSet or DataTable
using SysbyteTest.Models;
using Microsoft.Ajax.Utilities;

namespace SysbyteTest.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
           // AppointmentModel apointmentModel = new AppointmentModel();
            DBData obj = new DBData();
            DataTable dtDay = new DataTable();
            dtDay = obj.GetDay();
            ChkDayTimeViewModel objchkdaytime = new ChkDayTimeViewModel();
            List<DayModel> objday = new List<DayModel>();
            for(int i=0;i< dtDay.Rows.Count;i++)
            {
                objday.Add(new DayModel()
                {
                    DayId = Convert.ToInt32(dtDay.Rows[i]["Days_Id"].ToString()),
                    DayName = dtDay.Rows[i]["Days_Name"].ToString(), IsDayChecked=false,
                   // TimeHour=dt.Rows[i]["TimeHour"].ToString(),IsTimeChecked=s
                });
            }
            objchkdaytime.dayInfo = objday;

            DataTable dtTime = new DataTable();
            dtTime = obj.GetTime();
            List<TimeModel> objtime = new List<TimeModel>();
            for (int i = 0; i < dtTime.Rows.Count; i++)
            {
                objtime.Add(new TimeModel()
                {
                    TimeId = Convert.ToInt32(dtTime.Rows[i]["Time_Id"].ToString()),
                    Time = dtTime.Rows[i]["TimeHour"].ToString(),
                    IsTimeChecked = false
                });
            }
            objchkdaytime.timeInfo = objtime;

            return View(objchkdaytime);
        }

        //[HttpPost]
        //public ActionResult Index()
        //{

        //}
    }
}
