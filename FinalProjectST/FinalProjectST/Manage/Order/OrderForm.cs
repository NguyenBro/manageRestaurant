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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        //flag=1: DataGridView Food
        //flag=2: DataGridView Ordered
        public int flag = 0;

        public int currentFoodID = 0;

        public int oldAmount = 0;

        private void OrderForm_Load(object sender, EventArgs e)
        {
            LoadDataGridAllFood("");
            LoadOrdered();
            TotalAll();
            label_Total.Text = "0";

            dataGridView_Ordered.DoubleClick += dataGridViewOrdered_DoubleClick;

            //add event double click
            dataGridView_Appetizer.DoubleClick += dataGridViewAppetizer_DoubleClick;
            dataGridView_MainDishes.DoubleClick += dataGridViewMainDishes_DoubleClick;
            dataGridView_Dessert.DoubleClick += dataGridViewDessert_DoubleClick;
            dataGridView_Drink.DoubleClick += dataGridViewDrink_DoubleClick;
        }

        public void ClearAllLabel()
        {
            label_FoodName.Text = "";
            label_Type.Text = "";
            label_Cost.Text = "";
            numericUpDown_Amount.Value = 1;
        }

        public void LoadOrdered()
        {
            dataGridView_Ordered.RowTemplate.Height = 40;
            dataGridView_Ordered.DataSource = ORDER.getOrdered(InterVar.orderID);
            dataGridView_Ordered.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Ordered.AllowUserToAddRows = false;
            dataGridView_Ordered.Columns["fid"].Visible = false;
            dataGridView_Ordered.Columns["tid"].Visible = false;
            dataGridView_Ordered.Columns["name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_Ordered.Columns["name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView_Ordered.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Ordered.Columns["cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_Ordered.Columns["amount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_Ordered.Columns["total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView_Ordered.Columns["name"].HeaderText = "NAME";
            dataGridView_Ordered.Columns["type"].HeaderText = "TYPE";
            dataGridView_Ordered.Columns["cost"].HeaderText = "COST";
            dataGridView_Ordered.Columns["amount"].HeaderText = "AMOUNT";
            dataGridView_Ordered.Columns["total"].HeaderText = "TOTAL";

        }

        private void dataGridViewOrdered_DoubleClick(object sender, EventArgs e)
        {
            flag = 2;

            try
            {
                currentFoodID = (int)dataGridView_Ordered.CurrentRow.Cells["fid"].Value;
                label_FoodName.Text = dataGridView_Ordered.CurrentRow.Cells["name"].Value.ToString();
                label_Type.Text = dataGridView_Ordered.CurrentRow.Cells["type"].Value.ToString();
                label_Cost.Text = dataGridView_Ordered.CurrentRow.Cells["cost"].Value.ToString();
                oldAmount = (int)dataGridView_Ordered.CurrentRow.Cells["amount"].Value;
                numericUpDown_Amount.Value = oldAmount;
                label_Total.Text = dataGridView_Ordered.CurrentRow.Cells["total"].Value.ToString();
            }
            catch
            {

            }
        }

        public void LoadDataGridAllFood(string name)
        {
            LoadDataGridFood(dataGridView_Appetizer, 1, name);
            LoadDataGridFood(dataGridView_MainDishes, 2, name);
            LoadDataGridFood(dataGridView_Dessert, 3, name);
            LoadDataGridFood(dataGridView_Drink, 4, name);
        }

        public void LoadDataGridFood(DataGridView dgv, int type, string name)
        {
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dgv.RowTemplate.Height = 70;
            dgv.DataSource = FOOD.getFoodByType(type, name);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            picCol = (DataGridViewImageColumn)dgv.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgv.AllowUserToAddRows = false;
            dgv.Columns["id"].Visible = false;
            dgv.Columns["type"].Visible = false;
            dgv.Columns["name"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.Columns["name"].Width = 120;
            dgv.Columns["cost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["name"].HeaderText = "NAME";
            dgv.Columns["cost"].HeaderText = "COST";
            dgv.Columns["image"].HeaderText = "IMAGE";

        }

        private void dataGridViewAppetizer_DoubleClick(object sender, EventArgs e)
        {
            flag = 1;

            try
            {
                currentFoodID = (int)dataGridView_Appetizer.CurrentRow.Cells["id"].Value;
                label_FoodName.Text = dataGridView_Appetizer.CurrentRow.Cells["name"].Value.ToString();
                label_Type.Text = "Appetizer";
                label_Cost.Text = dataGridView_Appetizer.CurrentRow.Cells["cost"].Value.ToString();
                numericUpDown_Amount.Value = 1;
                setLabelTotal();
            }
            catch
            {

            }
        }

        private void dataGridViewMainDishes_DoubleClick(object sender, EventArgs e)
        {
            flag = 1;

            try
            {
                currentFoodID = (int)dataGridView_MainDishes.CurrentRow.Cells["id"].Value;
                label_FoodName.Text = dataGridView_MainDishes.CurrentRow.Cells["name"].Value.ToString();
                label_Type.Text = "Main Dishes";
                label_Cost.Text = dataGridView_MainDishes.CurrentRow.Cells["cost"].Value.ToString();
                numericUpDown_Amount.Value = 1;
                setLabelTotal();
            }
            catch
            {

            }
        }

        private void dataGridViewDessert_DoubleClick(object sender, EventArgs e)
        {
            flag = 1;

            try
            {
                currentFoodID = (int)dataGridView_Dessert.CurrentRow.Cells["id"].Value;
                label_FoodName.Text = dataGridView_Dessert.CurrentRow.Cells["name"].Value.ToString();
                label_Type.Text = "Dessert";
                label_Cost.Text = dataGridView_Dessert.CurrentRow.Cells["cost"].Value.ToString();
                numericUpDown_Amount.Value = 1;
                setLabelTotal();
            }
            catch
            {

            }
        }

        private void dataGridViewDrink_DoubleClick(object sender, EventArgs e)
        {
            flag = 1;

            try
            {
                currentFoodID = (int)dataGridView_Drink.CurrentRow.Cells["id"].Value;
                label_FoodName.Text = dataGridView_Drink.CurrentRow.Cells["name"].Value.ToString();
                label_Type.Text = "Drink";
                label_Cost.Text = dataGridView_Drink.CurrentRow.Cells["cost"].Value.ToString();
                numericUpDown_Amount.Value = 1;
                setLabelTotal();
            }
            catch
            {

            }
        }

        private bool checkEmptyLabel()
        {
            if (label_FoodName.Text.Trim() == "" || label_Type.Text.Trim() == "" || label_Cost.Text.Trim() == "")
            {
                return true;
            }
            return false;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                try
                {
                    if (checkEmptyLabel())
                    {
                        MessageBox.Show("Empty Field!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int oid = InterVar.orderID;
                        int fid = currentFoodID;
                        int amount = (int)numericUpDown_Amount.Value;

                        if (ORDER.checkExistFoodOrder(oid, fid))
                        {
                            MessageBox.Show("Order Exist!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!ORDER.checkMaterialEnough(fid, amount))
                        {
                            MessageBox.Show("Not Enough Material!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ORDER.addFoodOrder(oid, fid, amount))
                        {
                            LoadOrdered();
                            ClearAllLabel();
                            TotalAll();
                        }
                        else
                        {
                            MessageBox.Show("Error!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (flag == 2)
            {
                try
                {
                    if (checkEmptyLabel())
                    {
                        MessageBox.Show("Empty Field!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int oid = InterVar.orderID;
                        int fid = currentFoodID;
                        int newAmount = (int)numericUpDown_Amount.Value;
                        int amount = newAmount - oldAmount;

                        if (!ORDER.checkExistFoodOrder(oid, fid))
                        {
                            MessageBox.Show("Order Not Exist!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (!ORDER.checkMaterialEnough(fid, amount))
                        {
                            MessageBox.Show("Not Enough Material!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ORDER.updateFoodOrder(oid, fid, newAmount, amount))
                        {
                            oldAmount = newAmount;
                            LoadOrdered();
                            TotalAll();
                        }
                        else
                        {
                            MessageBox.Show("Error!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (flag == 2)
            {
                try
                {
                    if (checkEmptyLabel())
                    {
                        MessageBox.Show("Empty Field!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        int oid = InterVar.orderID;
                        int fid = currentFoodID;

                        if (!ORDER.checkExistFoodOrder(oid, fid))
                        {
                            MessageBox.Show("Order Not Exist!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ORDER.removeFoodOrder(oid, fid, oldAmount))
                        {
                            oldAmount = 0;
                            LoadOrdered();
                            ClearAllLabel();
                            TotalAll();
                        }
                        else
                        {
                            MessageBox.Show("Error!", "Order", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            flag = 0;
            ClearAllLabel();

            try
            {
                LoadDataGridAllFood(textBox_Search.Text.Trim());
            }
            catch
            {

            }

        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TotalAll()
        {

            try
            {
                label_TotalAll.Text = ORDER.getPaymentOfOrder(InterVar.orderID).ToString();
            }
            catch
            {

            }

        }

        private void setLabelTotal()
        {
            if (label_Cost.Text.Trim() == "")
            {
                label_Total.Text = "0";
            }
            else
            {
                try
                {
                    //calculator total
                    int cost = Int32.Parse(label_Cost.Text.Trim());
                    int amount = (int)numericUpDown_Amount.Value;
                    int total = cost * amount;

                    label_Total.Text = total.ToString();

                }
                catch
                {
                    label_Total.Text = "0";
                }
            }
        }

        private void numericUpDown_Amount_ValueChanged(object sender, EventArgs e)
        {
            setLabelTotal();
        }
    }
}
