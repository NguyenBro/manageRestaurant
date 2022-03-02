using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectST
{
    public partial class TableForm : Form
    {
        private int tableID;
        public TableForm(int TableID)
        {
            this.tableID = TableID;
            InitializeComponent();
        }

        private void Table_Form_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            this.guna2CirclePictureBox1.Image = Image.FromFile("../../Image/table.jpg");
            DataTable table = TABLE.getTableByID(this.tableID);
            if (table.Rows.Count > 0)
            {
                this.label_ID.Text = "Table ID: " + table.Rows[0]["id"].ToString();
                this.label_Chair.Text = "Chair: " + table.Rows[0]["chairs"].ToString();
            }
            if (int.Parse(table.Rows[0]["status"].ToString()) == 0)
            {
                this.label_status.Text = "Status: Free";
                this.button_book.Enabled = true;
                this.Button_Pay.Enabled = false;
                this.Button_order.Enabled = false;
            }
            else
            {
                this.label_status.Text = "Status: Busy";
                this.button_book.Enabled = false;
                this.Button_Pay.Enabled = true;
                this.Button_order.Enabled = true;
                SqlCommand cmd = new SqlCommand("Select dbo.Get_OrderIdOfTable(@table) id", MY_DB.getConnection);
                cmd.Parameters.Add("@table", SqlDbType.Int).Value = this.tableID;
                DataTable data = MY_DB.getData(cmd);
                if (data.Rows.Count > 0)
                {
                    InterVar.orderID = int.Parse(data.Rows[0]["id"].ToString());
                }
                else
                {
                    InterVar.orderID = -1;
                }
                LoadOrdered();
                TotalAll();

            }

        }


        private void button_book_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want To Book This Table ?", "Book Table", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                InterVar.orderID = ORDER.CreateOrder(2, USER.getUserByEmail("admin"), tableID);
                if (InterVar.orderID != -1)
                {
                    if (TABLE.changeStatus(this.tableID, 1) != true)
                    {
                        ORDER.deleteOrder(InterVar.orderID);
                    }
                    else
                    {
                        this.LoadData();
                    }
                }
                else
                {
                    MessageBox.Show("Can't create the order !!!", "Book Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Button_Pay_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you Want To Pay This Table ?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (ORDER.PayOrder(InterVar.orderID) == true)
                {
                    TABLE.changeStatus(tableID, 0);
                    SALES.InsertSales(DateTime.Today, InterVar.orderID);
                    InterVar.orderID = 0;
                    
                    LoadData();
                    dataGridView_Ordered.DataSource = null;
                    dataGridView_Ordered.Rows.Clear();
                    label_Total.Text = "0";
                }
                else
                {
                    MessageBox.Show("Error While Paying !!!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }    

        public void LoadOrdered()
        {
            dataGridView_Ordered.DataSource = ORDER.getOrdered(InterVar.orderID);
            dataGridView_Ordered.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Ordered.AllowUserToAddRows = false;
            dataGridView_Ordered.Columns["fid"].Visible = false;
            dataGridView_Ordered.Columns["tid"].Visible = false;
            dataGridView_Ordered.Columns["name"].Width = 300;
            dataGridView_Ordered.Columns["cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_Ordered.Columns["amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_Ordered.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_Ordered.Columns["name"].HeaderText = "NAME";
            dataGridView_Ordered.Columns["type"].HeaderText = "TYPE";
            dataGridView_Ordered.Columns["cost"].HeaderText = "COST";
            dataGridView_Ordered.Columns["amount"].HeaderText = "AMOUNT";
            dataGridView_Ordered.Columns["total"].HeaderText = "TOTAL";
        }


        private void Button_order_Click(object sender, EventArgs e)
        {
            OrderForm f = new OrderForm();
            f.ShowDialog();
            LoadOrdered();
            TotalAll();
        }

        private void Button_Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TotalAll()
        {

            try
            {
                label_Total.Text = ORDER.getPaymentOfOrder(InterVar.orderID).ToString();
            }
            catch
            {

            }

        }
    }
}
