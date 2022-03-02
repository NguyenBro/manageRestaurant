using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectST
{
    class TABLE
    {
        public static DataTable getAllTable()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Get_Table()", MY_DB.getConnection);
            return MY_DB.getData(cmd);
        }
        public static DataTable getTableFree()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Get_Table_ByStaTus(@st)", MY_DB.getConnection);
            cmd.Parameters.Add("@st", SqlDbType.Int).Value = 0;
            return MY_DB.getData(cmd);
        }
        public static DataTable getTableBusy()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Get_Table_ByStaTus(@st)", MY_DB.getConnection);
            cmd.Parameters.Add("@st", SqlDbType.Int).Value = 1;
            return MY_DB.getData(cmd);
        }
        public static DataTable getTableByID(int ID)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Get_Table_ByID(@id)", MY_DB.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            return MY_DB.getData(cmd);
        }

        public static DataTable getTableByUser(int uid)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.Get_Table_ByUser(@uid)", MY_DB.getConnection);
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = uid;
            return MY_DB.getData(cmd);
        }

        public static bool changeStatus(int tableID, int status)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Update_Table_Status @id,@st", MY_DB.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = tableID;
            cmd.Parameters.Add("@st", SqlDbType.Int).Value = status;
            return MY_DB.exedata(cmd);
        }
    }
}
