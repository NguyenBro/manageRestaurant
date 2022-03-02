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
    public partial class ManageComponentForm : Form
    {
        public ManageComponentForm()
        {
            InitializeComponent();
        }

        private void ManageComponentForm_Load(object sender, EventArgs e)
        {
            loadListBoxAllMaterial();
            loadListBoxFoodMaterial();
        }

        public void loadListBoxAllMaterial()
        {
            listBox_AllMaterial.DataSource = MATERIAL.getMaterialByName("");
            listBox_AllMaterial.DisplayMember = "name";
            listBox_AllMaterial.ValueMember = "id";
        }

        public void loadListBoxFoodMaterial()
        {
            listBox_FoodMaterial.DataSource = FOOD.getFoodComponent(InterVar.foodID);
            listBox_FoodMaterial.DisplayMember = "name";
            listBox_FoodMaterial.ValueMember = "id";
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                int fid = InterVar.foodID;
                int mid = (int)listBox_AllMaterial.SelectedValue;
                int amount = (int)numericUpDown_Amount.Value;

                if (FOOD.CheckExistComponent(fid, mid))
                {
                    MessageBox.Show("Material Exist!", "Add Component", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (amount <= 0)
                {
                    MessageBox.Show("Amount must greater than 0!", "Add Component", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (FOOD.AddFoodComponent(fid, mid, amount))
                    {

                        loadListBoxFoodMaterial();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            try
            {
                int fid = InterVar.foodID;
                int mid = (int)listBox_AllMaterial.SelectedValue;

                if (FOOD.RemoveFoodComponent(fid, mid))
                {
                    loadListBoxFoodMaterial();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
