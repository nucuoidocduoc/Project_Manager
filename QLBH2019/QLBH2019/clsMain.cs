using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLBH2019
{
    class clsMain
    {
        public static void DoSQL(string sql)
        {
            string strcn = " Data Source=113.190.234.205,1433;Initial Catalog=ktqd2019;Persist Security Info=True;User ID=ktqd;Password=Ktqd-2019";
            SqlConnection conn = new SqlConnection(strcn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();           
            conn.Close();
        }
    }
}
