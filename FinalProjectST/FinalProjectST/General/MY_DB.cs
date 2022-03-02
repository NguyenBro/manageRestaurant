using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectST
{
    class MY_DB
    {
        private static SqlConnection con = new SqlConnection(@"Data Source=ADMIN\KOKORO;Initial Catalog=Restaurant_ST;Integrated Security=True");

        //get the connection
        public static SqlConnection getConnection
        {
            get { return con; }
        }

        //open the connection
        public static void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //close the connection
        public static void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public static DataTable getData(SqlCommand cmd)
        {
            openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            try
            {
                adapter.SelectCommand = cmd;
                adapter.Fill(table);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                table = null;
            }
            closeConnection();
            return table;
        }
        public static Boolean exedata(SqlCommand cmd)
        {
            openConnection();
            Boolean check = false;
            try
            {
                cmd.ExecuteNonQuery();
                check = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                check = false;
            }
            closeConnection();
            return check;
        }
    }
}
