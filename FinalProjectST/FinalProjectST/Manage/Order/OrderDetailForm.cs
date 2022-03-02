using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectST
{
    public partial class OrderDetailForm : Form
    {
        public OrderDetailForm()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderDetailForm_Load(object sender, EventArgs e)
        {
            label_OrderID.Text = "ID: " + InterVar.orderID.ToString();

            try
            {
                DataTable order_info = ORDER.getOrderByID(InterVar.orderID);
                label_Email.Text = "Email: " + order_info.Rows[0]["email"].ToString();
                label_Cost.Text = "Cost: " + order_info.Rows[0]["cost"].ToString();

                int userID = USER.getUserByEmail(order_info.Rows[0]["email"].ToString());
                DataTable info = USER.getUserByID(userID);
                label_Name.Text = "Name: "+info.Rows[0]["name"].ToString();
                label_Phone.Text = "Phone number: "+info.Rows[0]["phone"].ToString();
                label_Address.Text = "Address: "+info.Rows[0]["address"].ToString();

                LoadOrdered();
            }
            catch
            {

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
    }
}
