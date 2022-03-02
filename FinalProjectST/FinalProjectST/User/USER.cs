using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectST
{
    class USER
    {
        public static bool insertUser(string name, string phone,string address, string email, string pass)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Insert_Users @name,@phone,@address,@email,@pass", MY_DB.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;

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

        public static bool updateUser(int id, string name, string phone,string address ,string email, string pass)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Update_Users @id,@name,@phone,@address,@email,@pass", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;
            command.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;

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

        public static bool checkUser(string email, string pass)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_User(@email,@pass)", MY_DB.getConnection);
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                InterVar.userID = (int)table.Rows[0][0];
                return true;

            }
            else
            {
                return false;
            }
        }

        public static bool checkExistEmail(string email)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_User_ByEmail(@email)", MY_DB.getConnection);
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
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

        public static string getUserName(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_User_ByID(@id)", MY_DB.getConnection);
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

        public static String getUserPass(String email)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_User_ByEmail(@email)", MY_DB.getConnection);
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
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

        public static DataTable getUserByID(int id)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_User_ByID(@id)", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            return table;
        }

        public static int getUserByEmail(String email)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_User_ByEmail(@email)", MY_DB.getConnection);
            command.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
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
    }
}
