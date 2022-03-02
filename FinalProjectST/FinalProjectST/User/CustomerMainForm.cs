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
    public partial class CustomerMainForm : Form
    {
        public CustomerMainForm()
        {
            InitializeComponent();
        }

        private void CustomerMainForm_Load(object sender, EventArgs e)
        {

            label_Name.Text = "Welcome " + USER.getUserName(InterVar.userID).ToUpper();

            LoadForm();
            LoadOrdered();
            TotalAll();
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

        public void LoadForm()
        {
            //check status Order
            if (ORDER.checkOrderByUser(InterVar.userID))
            {
                button_Book.Enabled = false;
                button_Order.Enabled = true;
                Button_Pay.Enabled = true;
            }
            else
            {
                button_Book.Enabled = true;
                button_Order.Enabled = false;
                Button_Pay.Enabled = false;
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Want To Logout?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                InterVar.userID = 0;
                LoginForm a = new LoginForm();
                this.Hide();
                a.ShowDialog();
                this.Show();
                Application.Exit();
            }

        }



        private void button_Book_Click(object sender, EventArgs e)
        {
            try
            {
                ORDER.CreateOrder(1, InterVar.userID, 1000);
                LoadForm();
                TotalAll();
            }
            catch
            {

            }

        }

        private void Button_Order_Click(object sender, EventArgs e)
        {
            OrderOnlineForm f = new OrderOnlineForm();
            f.ShowDialog();
            LoadOrdered();
            TotalAll();
        }

        private void Button_Pay_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are You Sure To Pay This Order?", "Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ORDER.updateStatusOrder(InterVar.orderID, "OUT");
                    ORDER.updateOrderCost(InterVar.orderID, Int32.Parse(label_Total.Text));
                    InterVar.orderID = 0;

                    ThanksForm f = new ThanksForm();
                    f.ShowDialog();

                    LoadForm();
                    LoadOrdered();
                    TotalAll();
                }
            }
            catch
            {

            }
        }

        private void button_EditInfo_Click(object sender, EventArgs e)
        {
            UserEditInfoForm f = new UserEditInfoForm();
            f.ShowDialog();
        }

    }
}
