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
    class FOOD
    {
        public static bool insertFood(string name, int cost, int type, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Insert_Food @name,@cost,@type,@image", MY_DB.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cost", SqlDbType.Int).Value = cost;
            command.Parameters.Add("@type", SqlDbType.Int).Value = type;
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

        public static bool updateFood(int id, string name, int cost, int type, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Update_Food @id,@name,@cost,@type,@image", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@cost", SqlDbType.Int).Value = cost;
            command.Parameters.Add("@type", SqlDbType.Int).Value = type;
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

        public static bool deleteFood(int id)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Delete_Food @id", MY_DB.getConnection);
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

        public static DataTable getAllFood()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Food()");
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable getFoodByID(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Food_ByID(@id)");
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable getFoodByName(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Food_ByName(@name)");
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable getFoodByType(int type, string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Food_ByType(@type,@name)");
            command.Parameters.Add("@type", SqlDbType.Int).Value = type;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable getFoodType()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Type_Food()");
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable getFoodComponent(int foodID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Get_Food_Component(@fid)");
            command.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static bool AddFoodComponent(int foodID, int materialID, int amount)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Insert_FoodComponent @fid,@mid,@amount", MY_DB.getConnection);
            command.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            command.Parameters.Add("@mid", SqlDbType.Int).Value = materialID;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;

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

        public static bool UpdateFoodComponent(int foodID, int materialID, int amount)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Update_FoodComponent @fid,@mid,@amount", MY_DB.getConnection);
            command.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            command.Parameters.Add("@mid", SqlDbType.Int).Value = materialID;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;

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

        public static bool RemoveFoodComponent(int foodID, int materialID)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Delete_FoodComponent @fid,@mid", MY_DB.getConnection);
            command.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            command.Parameters.Add("@mid", SqlDbType.Int).Value = materialID;

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

        public static bool CheckExistComponent(int foodID, int materialID)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Component(@fid,@mid)", MY_DB.getConnection);
            command.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            command.Parameters.Add("@mid", SqlDbType.Int).Value = materialID;

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
    }
}
