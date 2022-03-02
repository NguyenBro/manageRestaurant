using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectST
{
    class ORDER
    {
        public static int getPaymentOfOrder(int orderID)
        {
            SqlCommand cmd = new SqlCommand("Select dbo.PaymentOfOrder(@id) payment", MY_DB.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = orderID;
            DataTable table = MY_DB.getData(cmd);
            if (table.Rows.Count > 0)
            {
                int kq = 0;
                int.TryParse(table.Rows[0]["payment"].ToString(), out kq);
                return kq;
            }
            else
                return 0;
        }
        public static int CreateOrder(int orderType, int userID, int tableID)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Create_Order @type,@uid,@table,@st,@tst", MY_DB.getConnection);
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = orderType;
            cmd.Parameters.Add("@uid", SqlDbType.Int).Value = userID;
            cmd.Parameters.Add("@table", SqlDbType.Int).Value = tableID;
            cmd.Parameters.Add("@st", SqlDbType.NVarChar).Value = "IN";
            cmd.Parameters.Add("@tst", SqlDbType.Int).Value = 1;
            bool flag = MY_DB.exedata(cmd);
            if (flag == true)
            {
                return GetOrderIDOfTable(tableID);
            }
            return -1;
        }
        public static int GetOrderIDOfTable(int tableID)
        {
            SqlCommand cmd = new SqlCommand("Select dbo.Get_OrderIdOfTable(@table) id", MY_DB.getConnection);
            cmd.Parameters.Add("@table", SqlDbType.Int).Value = tableID;
            DataTable data = MY_DB.getData(cmd);
            if (data.Rows.Count > 0)
                return int.Parse(data.Rows[0]["id"].ToString());
            else
                return -1;
        }
        public static bool deleteOrder(int OrderID)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Delete_Order @id", MY_DB.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = OrderID;
            return MY_DB.exedata(cmd);
        }
        public static bool updateStatusOrder(int OrderID, String Status)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Update_Order_Status @id,@st", MY_DB.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = OrderID;
            cmd.Parameters.Add("@st", SqlDbType.NVarChar).Value = Status;
            return MY_DB.exedata(cmd);
        }
        public static bool PayOrder(int OrderID)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Pay_Order @id,@st,@co", MY_DB.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = OrderID;
            cmd.Parameters.Add("@st", SqlDbType.NVarChar).Value = "OUT";
            cmd.Parameters.Add("@co", SqlDbType.Int).Value = getPaymentOfOrder(OrderID);
            return MY_DB.exedata(cmd);
        }

        public static bool checkOrderByUser(int userID)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_OrderOnlineNotPay(@uid)", MY_DB.getConnection);
            command.Parameters.Add("@uid", SqlDbType.Int).Value = userID;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                InterVar.orderID = (int)table.Rows[0]["id"];
                return true;

            }
            else
            {
                return false;
            }
        }

        public static bool checkOrderStatus(int orderID, string status)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_OrderStatus(@oid,@stt)", MY_DB.getConnection);
            command.Parameters.Add("@oid", SqlDbType.Int).Value = orderID;
            command.Parameters.Add("@stt", SqlDbType.NChar).Value = status;
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

        public static DataTable getOrdered(int oid)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Food_Ordered(@oid) ORDER BY tid");
            command.Parameters.Add("@oid", SqlDbType.Int).Value = oid;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable getOrderOnlineByStatus(String status)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_OrderOnline_ByStatus(@stt)");
            command.Parameters.Add("@stt", SqlDbType.NChar).Value = status;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static DataTable getOrderByID(int orderID)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Order_By_ID(@oid)");
            command.Parameters.Add("@oid", SqlDbType.Int).Value = orderID;
            command.Connection = MY_DB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public static bool checkExistFoodOrder(int orderID, int foodID)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Get_Food_Order(@oid,@fid)", MY_DB.getConnection);
            command.Parameters.Add("@oid", SqlDbType.Int).Value = orderID;
            command.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
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

        //Offline Order
        public static bool addFoodOrder(int orderID, int foodID, int amount)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Insert_Food_Order @oid,@fid,@amount", MY_DB.getConnection);
            cmd.Parameters.Add("@oid", SqlDbType.Int).Value = orderID;
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            return MY_DB.exedata(cmd);
        }

        public static bool updateFoodOrder(int orderID, int foodID, int newAmount, int amount)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Update_Food_Order @oid,@fid,@namount,@amount", MY_DB.getConnection);
            cmd.Parameters.Add("@oid", SqlDbType.Int).Value = orderID;
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            cmd.Parameters.Add("@namount", SqlDbType.Int).Value = newAmount;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            return MY_DB.exedata(cmd);
        }

        public static bool removeFoodOrder(int orderID, int foodID, int amount)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Delete_Food_Order @oid,@fid,@amount", MY_DB.getConnection);
            cmd.Parameters.Add("@oid", SqlDbType.Int).Value = orderID;
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            return MY_DB.exedata(cmd);
        }

        //Online Order
        public static bool addOnlineOrder(int orderID, int foodID, int amount)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Insert_Orders @oid,@fid,@amount", MY_DB.getConnection);
            cmd.Parameters.Add("@oid", SqlDbType.Int).Value = orderID;
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            return MY_DB.exedata(cmd);
        }

        public static bool updateOnlineOrder(int orderID, int foodID, int newAmount)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Update_Order @oid,@fid,@namount", MY_DB.getConnection);
            cmd.Parameters.Add("@oid", SqlDbType.Int).Value = orderID;
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            cmd.Parameters.Add("@namount", SqlDbType.Int).Value = newAmount;
            return MY_DB.exedata(cmd);
        }

        public static bool removeOnlineOrder(int orderID, int foodID)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Delete_Online_Order @oid,@fid", MY_DB.getConnection);
            cmd.Parameters.Add("@oid", SqlDbType.Int).Value = orderID;
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            return MY_DB.exedata(cmd);
        }

        //check Material
        public static bool checkMaterialEnough(int foodID, int amount)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("SELECT * FROM dbo.Check_Material_Enough(@fid,@amount)", MY_DB.getConnection);
            command.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            command.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            adapter.SelectCommand = command;

            adapter.Fill(table);

            if ((table.Rows.Count > 0))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool subtractMaterial(int foodID, int amount)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Subtract_Material @fid,@amount", MY_DB.getConnection);
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = foodID;
            cmd.Parameters.Add("@amount", SqlDbType.Int).Value = amount;
            return MY_DB.exedata(cmd);
        }

        public static bool updateOrderCost(int orderID, int cost)
        {
            SqlCommand cmd = new SqlCommand("EXECUTE dbo.Update_Order_Cost @oid,@cost", MY_DB.getConnection);
            cmd.Parameters.Add("@oid", SqlDbType.Int).Value = orderID;
            cmd.Parameters.Add("@cost", SqlDbType.Int).Value = cost;
            return MY_DB.exedata(cmd);
        }
    }
}
