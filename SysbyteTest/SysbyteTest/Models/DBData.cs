using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace SysbyteTest.Models
{
    public class DBData
    {
        SqlConnection con = new SqlConnection( ConfigurationManager.ConnectionStrings["TestDb"].ToString());
        DataTable dt = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;
        public DataTable GetDay()
        {
            try
            {
                using (cmd = new SqlCommand("select Days_Id,Days_Name from tblDay", con))
                {
                   //cmd.CommandType = CommandType.StoredProcedure;
                    if (con.State.Equals(ConnectionState.Closed))
                        con.Open();
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
           // return dt;
        }

        public DataTable GetTime()
        {
            try
            {
                using (cmd = new SqlCommand("select Time_Id,TimeHour from tblTime", con))
                {
                    //cmd.CommandType = CommandType.StoredProcedure;
                    if (con.State.Equals(ConnectionState.Closed))
                        con.Open();
                    da = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    da.Fill(dt);
                    con.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            // return dt;
        }

        //}
    }
}