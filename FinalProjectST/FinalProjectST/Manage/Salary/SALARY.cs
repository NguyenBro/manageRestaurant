using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectST
{
    class SALARY
    {
        public static DataTable getPayroll()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_PayRoll() ORDER BY date,name_position,employee_id");
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt;
        }

        public static DataTable getSalaryByNameDate(String text)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Salary_ByNameDate(@text) ORDER BY date,name_position,employee_id");
            command.Parameters.Add("@text", SqlDbType.NVarChar).Value = text;
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt;
        }

        public static DataTable getEmployeeUnPaid()
        {
            DateTime date = DateTime.Now;
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_UnPaid(@date)");
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt;

        }

        public static bool InsertPayRoll(DateTime date, int eid)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Insert_Salary_Employee @date,@eid", MY_DB.getConnection);
            command.Parameters.Add("@eid", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
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

        public static bool UpdateStatusPayroll(DateTime date, int eid)
        {

            int st = 1;
            SqlCommand command = new SqlCommand("EXECUTE dbo.Update_Payroll_Status @date,@eid,@status", MY_DB.getConnection);
            command.Parameters.Add("@eid", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@status", SqlDbType.Int).Value = st;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
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
    }
}
