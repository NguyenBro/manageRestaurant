using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectST
{
    class MANAGER
    {
        public static bool deleteDateNow(DateTime date)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Delete_Allocation_ByDate @dt", MY_DB.getConnection);
            command.Parameters.Add("@dt", SqlDbType.Date).Value = date.Date;
            MY_DB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                MY_DB.closeConnection();
                return true;

            }

            else
            {
                MY_DB.closeConnection();
                return false;
            }
        }

        public static int totalEmployees(int position)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_ByPosition(@id)", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = position;
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt.Rows.Count;
        }

        public static bool Insert_Allocation(int eid, DateTime date, int shift, string status, float hours)
        {


            SqlCommand command = new SqlCommand("execute dbo.Insert_Allocation @eid,@date,@shift,@status,@hours", MY_DB.getConnection);
            command.Parameters.Add("@eid", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            command.Parameters.Add("@shift", SqlDbType.Int).Value = shift;
            command.Parameters.Add("@status", SqlDbType.NChar).Value = status;
            command.Parameters.Add("@hours", SqlDbType.Float).Value = hours;
            MY_DB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                MY_DB.closeConnection();
                return true;

            }

            else
            {
                MY_DB.closeConnection();
                return false;
            }
        }

        public static DataTable getTableEmployee(int position)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_ByPosition(@id)");
            command.Parameters.Add("@id", SqlDbType.Int).Value = position;
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt;
        }

        public static DataTable getTablePosition()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Position()");
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt;
        }

        public static string getNamePosition(int position)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Postiton_ByID(@id)");
            command.Parameters.Add("@id", SqlDbType.Int).Value = position;
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt.Rows[0]["name_position"].ToString();

        }

        public static bool UpdateStatusAllocation(int eid, DateTime date, string status)
        {


            SqlCommand command = new SqlCommand("EXECUTE dbo.Update_Allocation_Status_ByDate @id,@date,@status", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            command.Parameters.Add("@status", SqlDbType.NChar).Value = status;
            MY_DB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                MY_DB.closeConnection();
                return true;

            }

            else
            {
                MY_DB.closeConnection();
                return false;
            }
        }

        public static bool UpdateStatusAllocation(int id, string status)
        {


            SqlCommand command = new SqlCommand("EXECUTE dbo.Update_Allocation_Status @id,@status", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@status", SqlDbType.NChar).Value = status;
            MY_DB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                MY_DB.closeConnection();
                return true;

            }

            else
            {
                MY_DB.closeConnection();
                return false;
            }
        }

        public static bool UpdateHoursAllocation(int id, float hours)
        {


            SqlCommand command = new SqlCommand("EXECUTE dbo.Update_Allocation_Hour @id,@hour", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@hour", SqlDbType.Float).Value = hours;
            MY_DB.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                MY_DB.closeConnection();
                return true;

            }

            else
            {
                MY_DB.closeConnection();
                return false;
            }
        }

        public static DataTable getTableAllocation(int eid, DateTime date)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Allocation_ByDate(@id,@date)");
            command.Parameters.Add("@id", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt;

        }

        public static DataTable getTableSplitShift(DateTime date)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Table_SplitShift_ByDate(@date)");
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt;

        }

        public static DataTable getTableSplitShift()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Table_SplitShift()");
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt;

        }
    }
}
