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
    class MATERIAL
    {
        public static bool insertMaterial(string name, int amount, string unit, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Insert_Material @name,@amount,@unit,@image", MY_DB.getConnection);
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            command.Parameters.Add("@unit", SqlDbType.NVarChar).Value = unit;
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

        public static bool updateMaterial(int id, string name, int amount, string unit, MemoryStream image)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Update_Material @id,@name,@amount,@unit,@image", MY_DB.getConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            command.Parameters.Add("@unit", SqlDbType.NVarChar).Value = unit;
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

        public static bool deleteMaterial(int id)
        {
            SqlCommand command = new SqlCommand("EXECUTE dbo.Delete_Material @id", MY_DB.getConnection);
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

        public static DataTable getMaterialByName(string name)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Material_ByName(@name)");
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;

            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
