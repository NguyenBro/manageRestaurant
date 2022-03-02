using Guna.UI2.WinForms;
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
    public partial class ManageOnlineOrderForm : Form
    {
        public ManageOnlineOrderForm()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageOnlineOrderForm_Load(object sender, EventArgs e)
        {
            LoadOrderNoConfirm();
            LoadOrderConfirmed();
            LoadOrderDenied();
        }

        public void LoadOrderNoConfirm()
        {
            DataTable table = ORDER.getOrderOnlineByStatus("OUT");
            flowLayoutPanel_NoConfirm.Controls.Clear();
            LoadOrder(table);
        }

        public void LoadOrderConfirmed()
        {
            DataTable table = ORDER.getOrderOnlineByStatus("DONE");
            flowLayoutPanel_Confirmed.Controls.Clear();
            LoadOrder(table);
        }

        public void LoadOrderDenied()
        {
            DataTable table = ORDER.getOrderOnlineByStatus("DENIED");
            flowLayoutPanel_Denied.Controls.Clear();
            LoadOrder(table);
        }

        public void LoadOrder(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int orderID = int.Parse(table.Rows[i]["id"].ToString());
                String email = table.Rows[i]["email"].ToString();
                int cost = int.Parse(table.Rows[i]["cost"].ToString());
                String status = table.Rows[i]["status"].ToString().Trim();

                MakePanelOrder(orderID, email, cost, status);
            }

        }

        public void MakePanelOrder(int orderID, String email, int cost, String status)
        {
            Panel order_panel = new Panel();
            order_panel.Size = new Size(920, 100);
            order_panel.BorderStyle = BorderStyle.FixedSingle;

            //label ID
            Label label_ID = new Label
            {
                Text = "ID: " + orderID,
                Location = new Point(20, 40),
                Font = new Font("Tahoma", 12, FontStyle.Bold)
            };

            int userID = USER.getUserByEmail(email);
            DataTable info = USER.getUserByID(userID);
            string name = info.Rows[0]["name"].ToString();
            string phone= info.Rows[0]["phone"].ToString();
            string address = info.Rows[0]["address"].ToString();

            //label username
            Label label_Username = new Label
            {
                Text = name.ToUpper(),
                Size = new Size(200, 20),
                Location = new Point(150, 10),
                Font = new Font("Tahoma", 12,FontStyle.Bold)
            };

            //label phone
            Label label_Phone = new Label
            {
                Text = "Phone: " + phone,
                Size = new Size(200, 20),
                Location = new Point(150, 30),
                Font = new Font("Tahoma", 11)
            };

            //label email
            Label label_Email = new Label
            {
                Text = "Email: " + email,
                Size = new Size(200, 20),
                Location = new Point(150, 50),
                Font = new Font("Tahoma", 11)
            };

            //label address
            Label label_Address = new Label
            {
                Text = "Address: " + address,
                Size = new Size(400, 20),
                Location = new Point(150, 70),
                Font = new Font("Tahoma", 11)
            };

            //label cost
            Label label_Cost = new Label
            {
                Text = "Cost: ",
                Location = new Point(400, 15),
                Font = new Font("Tahoma", 11),
                Size = new Size(42, 20)
            };


            //button Detail
            Guna2Button button_Detail = new Guna2Button
            {
                Text = "Detail",
                Location = new Point(810, 5),
                Size = new Size(100, 50),
                BorderRadius = 15
            };
            button_Detail.Click += (sender, EventArgs) => button_Detail_Click(sender, EventArgs, orderID);


            order_panel.Controls.Add(label_ID);
            order_panel.Controls.Add(label_Username);
            order_panel.Controls.Add(label_Phone);
            order_panel.Controls.Add(label_Address);
            order_panel.Controls.Add(label_Email);
            order_panel.Controls.Add(label_Cost);
            order_panel.Controls.Add(button_Detail);

            if (status.Equals("OUT"))
            {
                //label total
                Label label_Total = new Label
                {
                    Text = cost.ToString(),
                    Location = new Point(440, 13),
                    Font = new Font("Tahoma", 11, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleRight,
                    ForeColor = Color.Red
                };

                //button Confirm
                Guna2Button button_Confirm = new Guna2Button
                {
                    Text = "Confirm",
                    Location = new Point(590, 5),
                    Size = new Size(100, 50),
                    BorderRadius = 15,
                    FillColor = Color.Green
                };
                button_Confirm.Click += (sender, EventArgs) => button_Confirm_Click(sender, EventArgs, orderID);

                //button Deny
                Guna2Button button_Deny = new Guna2Button
                {
                    Text = "Deny",
                    Location = new Point(700, 5),
                    Size = new Size(100, 50),
                    BorderRadius = 15,
                    FillColor = Color.Red
                };
                button_Deny.Click += (sender, EventArgs) => button_Deny_Click(sender, EventArgs, orderID);

                //add controls
                order_panel.Controls.Add(label_Total);
                order_panel.Controls.Add(button_Confirm);
                order_panel.Controls.Add(button_Deny);

                flowLayoutPanel_NoConfirm.Controls.Add(order_panel);
            }
            else if (status.Equals("DONE"))
            {
                //label total
                Label label_Total = new Label
                {
                    Text = cost.ToString(),
                    Location = new Point(440, 13),
                    Font = new Font("Tahoma", 11, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleRight,
                    ForeColor = Color.Green
                };
                order_panel.Controls.Add(label_Total);

                flowLayoutPanel_Confirmed.Controls.Add(order_panel);
            }
            else
            {
                //label total
                Label label_Total = new Label
                {
                    Text = cost.ToString(),
                    Location = new Point(440, 13),
                    Font = new Font("Tahoma", 11, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleRight,
                    ForeColor = Color.Red
                };
                order_panel.Controls.Add(label_Total);

                flowLayoutPanel_Denied.Controls.Add(order_panel);
            }

        }

        private void button_Confirm_Click(object sender, EventArgs e, int orderID)
        {
            try
            {
                if (MessageBox.Show("Are You Sure To Confirm This Order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    DataTable table = ORDER.getOrdered(orderID);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        int fid = int.Parse(table.Rows[i]["fid"].ToString());
                        int amount = int.Parse(table.Rows[i]["amount"].ToString());

                        ORDER.subtractMaterial(fid, amount);
                    }
                    ORDER.updateStatusOrder(orderID, "DONE");
                    SALES.InsertSales(DateTime.Today, orderID);
                    LoadOrderNoConfirm();
                    LoadOrderConfirmed();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_Deny_Click(object sender, EventArgs e, int orderID)
        {
            try
            {
                if (MessageBox.Show("Are You Sure To Deny This Order?", "Deny Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ORDER.updateStatusOrder(orderID, "DENIED");
                    LoadOrderNoConfirm();
                    LoadOrderDenied();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_Detail_Click(object sender, EventArgs e, int orderID)
        {
            InterVar.orderID = orderID;
            OrderDetailForm f = new OrderDetailForm();
            f.ShowDialog();
            InterVar.orderID = 0;
        }
    }
}
