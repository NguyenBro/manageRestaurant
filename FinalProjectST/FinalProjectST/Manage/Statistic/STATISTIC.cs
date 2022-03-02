using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectST
{
    class STATISTIC
    {
        public static DataTable StatisticFood()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.View_Statistic_Food");
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable StatisticMaterial()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.View_Statistic_Material");
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static int StatisticOrder(int type)
        {
            SqlCommand cmd = new SqlCommand("Select dbo.Statistic_Order(@type) order_num", MY_DB.getConnection);
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
            DataTable table = MY_DB.getData(cmd);
            if (table.Rows.Count > 0)
            {
                return int.Parse(table.Rows[0]["order_num"].ToString());
            }
            else
                return 0;
        }

        public static int StatisticSalesByOrder(int type)
        {
            SqlCommand cmd = new SqlCommand("Select dbo.Statistic_Sales_ByOrder(@type) sum", MY_DB.getConnection);
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
            DataTable table = MY_DB.getData(cmd);
            if (table.Rows.Count > 0)
            {
                int kq = 0;
                int.TryParse(table.Rows[0]["sum"].ToString(), out kq);
                return kq;
            }
            else
                return 0;
        }

        public static DataTable StatisticSalesByFood()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.View_Statistic_Sales_ByFood");
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable StatisticSalesByDate()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.View_Statistic_Sales_ByDate");
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable StatisticPayroll()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.View_Statistic_Payroll");
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable StatisticProfit(int year)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Table_Total_Profit(@year)");
            command.Parameters.Add("@year", SqlDbType.Int).Value = year;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
