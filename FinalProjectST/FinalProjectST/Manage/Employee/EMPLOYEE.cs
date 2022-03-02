using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectST
{
    class EMPLOYEE
    {
        public static bool checkExistUsername(string uname)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_ByUsername(@uname)", MY_DB.getConnection);
            command.Parameters.Add("@uname", SqlDbType.NVarChar).Value = uname;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static String getEmployeePass(String uname)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_ByUsername(@uname)", MY_DB.getConnection);
            command.Parameters.Add("@uname", SqlDbType.NVarChar).Value = uname;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return table.Rows[0][3].ToString();
            }
            else
            {
                return "";
            }
        }

        public static bool checkEmployee(string uname, string pass)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee(@uname,@pass)", MY_DB.getConnection);
            command.Parameters.Add("@uname", SqlDbType.NVarChar).Value = uname;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                InterVar.employeeID = (int)table.Rows[0][0];
                return true;

            }
            else
            {
                return false;
            }
        }

        public static int getEmployeePosition(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_Position(@id)", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return (int)table.Rows[0][0];
            }
            else
            {
                return 0;
            }
        }

        public static string getEmployeeName(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_ByID(@id)", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return table.Rows[0][1].ToString();
            }
            else
            {
                return "";
            }
        }

        public static string getEmployeeUsername(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_ByID(@id)", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return table.Rows[0][2].ToString();
            }
            else
            {
                return "";
            }
        }

        public static bool CheckShift(int EmployeeID)
        {
            DateTime now = DateTime.Now;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Check_Shift(@id,@date,@status,@shift)", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = EmployeeID;
            command.Parameters.Add("@date", SqlDbType.Date).Value = now;
            command.Parameters.Add("@status", SqlDbType.NChar).Value = "NO";
            command.Parameters.Add("@shift", SqlDbType.Int).Value = getShiftByTime();

            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool CheckIn(int EmployeeID)
        {
            int shift = getShiftByTime();
            Double hour = 0;
            if (shift == 1)
            {
                DateTime vao = DateTime.Now;
                DateTime macdinh = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 0, 0);
                hour = CalculateHour(vao, macdinh);
            }
            else if (shift == 2)
            {
                DateTime vao = DateTime.Now;
                DateTime macdinh = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0);
                hour = CalculateHour(vao, macdinh);
            }
            else
            {
                DateTime vao = DateTime.Now;
                DateTime macdinh = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);
                hour = CalculateHour(vao, macdinh);
            }
            int shiftL = ShiftLogin();
            if (shiftL != -1)
            {
                DateTime checkin = DateTime.Now;
                DataTable table = MANAGER.getTableAllocation(EmployeeID, checkin);
                if (int.Parse(table.Rows[0]["shift"].ToString().Trim()) == shiftL)
                {
                    int id = Convert.ToInt32(table.Rows[0]["id"].ToString());
                    MANAGER.UpdateStatusAllocation(id, "IN");
                    MANAGER.UpdateHoursAllocation(id, 5 - (float)hour);
                    InterVar.timeCheckIn = checkin;
                    return true;
                }
                else if (int.Parse(table.Rows[1]["shift"].ToString().Trim()) == shiftL)
                {
                    int id = Convert.ToInt32(table.Rows[1]["id"].ToString());
                    MANAGER.UpdateStatusAllocation(id, "IN");
                    MANAGER.UpdateHoursAllocation(id, 5 - (float)hour);
                    InterVar.timeCheckIn = checkin;
                    return true;

                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public static bool CheckOut(int EmployeeID)
        {

            DateTime checkout = DateTime.Now;
            DataTable table = MANAGER.getTableAllocation(EmployeeID, checkout);
            if (table.Rows[0]["status"].ToString().Trim() == "IN")
            {
                int id = Convert.ToInt32(table.Rows[0]["id"].ToString());
                MANAGER.UpdateStatusAllocation(id, "OUT");
                //
                Double hours = 0;
                Double hourDaLam = Convert.ToDouble(table.Rows[0]["hour"].ToString());
                int shift = Convert.ToInt32(table.Rows[0]["shift"].ToString());
                if (shift == 1)
                {
                    DateTime ra = DateTime.Now;
                    DateTime macdinh = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0);
                    hours = CalculateHour(macdinh, ra);
                }
                else if (shift == 2)
                {
                    DateTime ra = DateTime.Now;
                    DateTime macdinh = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);
                    hours = CalculateHour(macdinh, ra);
                }
                else
                {
                    DateTime ra = DateTime.Now;
                    DateTime macdinh = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 0, 0);
                    hours = CalculateHour(macdinh, ra);
                }

                //Insert Hours vao Allocation
                MANAGER.UpdateHoursAllocation(id, (float)(hourDaLam - hours));

                return true;

            }
            else if (table.Rows[1]["status"].ToString().Trim() == "IN")
            {
                int id = Convert.ToInt32(table.Rows[1]["id"].ToString());
                MANAGER.UpdateStatusAllocation(id, "OUT");
                //Chen Thoi Gian
                Double hours = 0;
                Double hourDaLam = Convert.ToDouble(table.Rows[1]["hour"].ToString());
                int shift = Convert.ToInt32(table.Rows[1]["shift"].ToString());
                if (shift == 1)
                {
                    DateTime ra = DateTime.Now;
                    DateTime macdinh = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0);
                    hours = CalculateHour(macdinh, ra);
                }
                else if (shift == 2)
                {
                    DateTime ra = DateTime.Now;
                    DateTime macdinh = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 0, 0);
                    hours = CalculateHour(macdinh, ra);
                }
                else
                {
                    DateTime ra = DateTime.Now;
                    DateTime macdinh = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 0, 0);
                    hours = CalculateHour(macdinh, ra);
                }
                MANAGER.UpdateHoursAllocation(id, (float)(hourDaLam - hours));
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool CheckStatusShift(int eid, DateTime date)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Check_Shift_Status(@id,@date,@st)", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            command.Parameters.Add("@st", SqlDbType.NVarChar).Value = "IN";
            DataTable Shift = MY_DB.getData(command);
            if (Shift.Rows.Count > 0)
            {
                return true;
            }
            else
                return false;
        }

        public static DataTable getEmployees(SqlCommand command)
        {
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable getEmployeeShift(String name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_Shift(@txt) ORDER BY date,name_position,employee_id,shift");
            command.Parameters.Add("@txt", SqlDbType.NVarChar).Value = name;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable getDateAllocation(int eid)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Allocation_Date(@id)");
            command.Parameters.Add("@id", SqlDbType.Int).Value = eid;
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt;

        }
        public static DataTable getDateAllocation(int eid, DateTime date)
        {


            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Allocation_Date_ByDate(@id,@date)");
            command.Parameters.Add("@id", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            DataTable dt = EMPLOYEE.getEmployees(command);
            return dt;

        }

        public static int GetFirstShift(int eid, DateTime date)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Shift_ByDate(@id,@date)");
            command.Parameters.Add("@id", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            DataTable dt = EMPLOYEE.getEmployees(command);
            int firstShift = Convert.ToInt32(dt.Rows[0]["shift"].ToString());
            return firstShift;
        }

        public static int GetSecondShift(int eid, DateTime date)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Shift_ByDate(@id,@date)");
            command.Parameters.Add("@id", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            DataTable dt = EMPLOYEE.getEmployees(command);
            int secondShift = Convert.ToInt32(dt.Rows[1]["shift"].ToString());
            return secondShift;
        }

        public static string getFirstStatus(int eid, DateTime date)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Shift_ByDate(@id,@date)");
            command.Parameters.Add("@id", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            DataTable dt = EMPLOYEE.getEmployees(command);
            string firstStatus = dt.Rows[0]["status"].ToString().Trim();
            return firstStatus;
        }

        public static string getSecondStatus(int eid, DateTime date)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Shift_ByDate(@id,@date)");
            command.Parameters.Add("@id", SqlDbType.Int).Value = eid;
            command.Parameters.Add("@date", SqlDbType.Date).Value = date;
            DataTable dt = EMPLOYEE.getEmployees(command);
            string secondStatus = dt.Rows[1]["status"].ToString().Trim();
            return secondStatus;
        }
        public static MemoryStream getPicture(int eid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_ByID(@id)", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = eid;
            DataTable table = MY_DB.getData(command);
            if (table.Rows[0]["image"].ToString() != "")
            {
                byte[] pic = (byte[])table.Rows[0]["image"];
                MemoryStream picture = new MemoryStream(pic);
                return picture;
            }
            return null;
        }
        public static int ShiftLogin()
        {
            DateTime now = DateTime.Now;
            if (now.Hour >= 7 && now.Hour <= 11)
                return 1;
            else if (now.Hour >= 12 && now.Hour <= 16)
                return 2;
            else if (now.Hour >= 17 && now.Hour <= 22)
                return 3;
            else
                return -1;
        }

        public static DataTable getEmployeeByID(int ID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_ByID(@id)");
            command.Parameters.Add("@id", SqlDbType.Int).Value = ID;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable getEmployeeByName(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_ByName(@name)");
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static String getEmployeePassword(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Employee_ByID(@id)", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return table.Rows[0][3].ToString();
            }
            else
            {
                return "";
            }
        }

        public static DataTable getAllPosition()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.View_Position");
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static bool CreateManageLogin(String name, string username, string password, MemoryStream image)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Create_Manage_Login @name,@username,@pass,@image", MY_DB.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@image", SqlDbType.Image).Value = image.ToArray();

            return MY_DB.exedata(cmd);
        }

        public static bool CreateStaffLogin(String name, string username, string password, int position_id, MemoryStream image)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Create_Staff_Login @name,@username,@pass,@pos_id,@image", MY_DB.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            cmd.Parameters.Add("@pos_id", SqlDbType.Int).Value = position_id;
            cmd.Parameters.Add("@image", SqlDbType.Image).Value = image.ToArray();

            return MY_DB.exedata(cmd);
        }

        public static bool DeleteEmployeeLogin(String name)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Delete_Employee_Login @name", MY_DB.getConnection);
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

            return MY_DB.exedata(cmd);
        }

        public static bool insertEmployee(string name, string username, string password, int position_id, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Insert_Employee @name,@username,@pass,@pos_id,@image", MY_DB.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@pos_id", SqlDbType.Int).Value = position_id;
            command.Parameters.Add("@image", SqlDbType.Image).Value = image.ToArray();

            MY_DB.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        public static bool updateEmployee(int id, string name, string username, string password, int position_id, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Update_Employee @id,@name,@username,@pass,@pos_id,@image", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@username", SqlDbType.NVarChar).Value = username;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;
            command.Parameters.Add("@pos_id", SqlDbType.Int).Value = position_id;
            command.Parameters.Add("@image", SqlDbType.Image).Value = image.ToArray();

            MY_DB.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        public static bool deleteEmployee(int id)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Delete_Employee @id", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;

            MY_DB.openConnection();

            if (command.ExecuteNonQuery() == 1)
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

        public static String getPosition()
        {
            int position = EMPLOYEE.getEmployeePosition(InterVar.employeeID);
            if (position == 1)
            {
                return "Manager";
            }
            else if (position == 2)
            {
                return "Cashier";
            }
            else if (position == 3)
            {
                return "Staff";
            }
            else
            {
                return "Chef";
            }
        }
        public static int getShiftByTime()
        {
            DateTime date = DateTime.Now;
            if (date.Hour >= 7 && date.Hour <= 11)
            {
                return 1;
            }
            else if (date.Hour >= 12 && date.Hour <= 16)
            {
                return 2;
            }
            else if (date.Hour >= 17 && date.Hour <= 22)
            {
                return 3;
            }
            return 0;
        }
        public static Double CalculateHour(DateTime a, DateTime b)
        {
            if (a > b)
            {
                Double kq = 0;
                TimeSpan c = a - b;
                if (c.Minutes > 30)
                    kq = kq + 0.5;
                return kq + c.Hours;
            }
            else
            {
                Double kq = 0;
                TimeSpan c = b - a;
                if (c.Minutes > 30)
                    kq = kq - 0.5;
                return kq - c.Hours;
            }
        }

        public static bool InsertPayroll(DateTime date, int eid)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Insert_Payroll @date,@eid", MY_DB.getConnection);
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@eid", SqlDbType.Int).Value = eid;

            return MY_DB.exedata(cmd);
        }

        public static DataTable getSalaryEmployee(int eid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Salary_Of_Employee(@eid) ORDER BY date");
            command.Parameters.Add("@eid", SqlDbType.Int).Value = eid;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
