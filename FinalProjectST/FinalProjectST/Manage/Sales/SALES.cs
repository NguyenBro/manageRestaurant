using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectST
{
    class SALES
    {
        public static bool InsertSales(DateTime date, int oid)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Insert_Sales @date,@oid", MY_DB.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@oid", SqlDbType.Int).Value = oid;

            return MY_DB.exedata(cmd);
        }
    }
}
