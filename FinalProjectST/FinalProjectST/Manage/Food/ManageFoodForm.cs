using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectST
{
    public partial class ManageFoodForm : Form
    {
        public ManageFoodForm()
        {
            InitializeComponent();
        }

        private void ManageFoodForm_Load(object sender, EventArgs e)
        {
            loadForm();
            fillGrid();
        }

        public void fillGrid()
        {
            dataGridView_Food.ReadOnly = true;

            DataTable table = FOOD.getAllFood();

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_Food.RowTemplate.Height = 60;
            dataGridView_Food.DataSource = table;
            dataGridView_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            picCol = (DataGridViewImageColumn)dataGridView_Food.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Food.AllowUserToAddRows = false;

            dataGridView_Food.Columns[0].HeaderText = "ID";
            dataGridView_Food.Columns[1].HeaderText = "NAME";
            dataGridView_Food.Columns[2].HeaderText = "COST";
            dataGridView_Food.Columns[3].HeaderText = "TYPE";
            dataGridView_Food.Columns[4].HeaderText = "IMAGE";
        }

        public void loadForm()
        {

            comboBox_Type.DataSource = FOOD.getFoodType();
            comboBox_Type.DisplayMember = "name";
            comboBox_Type.ValueMember = "id";
            comboBox_Type.SelectedItem = 0;

            loadListbox();

            InterVar.foodID = 0;
            textbox_Name.Text = "";
            numericUpDown_Cost.Value = 0;
            pictureBox_Food.Image = null;
            textbox_Search.Text = "";
        }

        public void loadListbox()
        {
            listBox_Material.DataSource = FOOD.getFoodComponent(InterVar.foodID);
            listBox_Material.DisplayMember = "name";
            listBox_Material.ValueMember = "id";
        }

        private void button_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Food.Image = Image.FromFile(opf.FileName);
            }
        }

        public bool checkEmptyField()
        {
            if (textbox_Name.Text.Trim() == "" || pictureBox_Food.Image == null)
            {
                return true;
            }
            return false;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {

            try
            {
                if (checkEmptyField())
                {
                    MessageBox.Show("Empty Field!", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String name = textbox_Name.Text;
                    int cost = (int)numericUpDown_Cost.Value;
                    int type = comboBox_Type.SelectedIndex + 1;
                    MemoryStream image = new MemoryStream();
                    pictureBox_Food.Image.Save(image, pictureBox_Food.Image.RawFormat);

                    if (cost <= 0)
                    {
                        MessageBox.Show("Cost must greater than 0!", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (FOOD.insertFood(name, cost, type, image))
                    {
                        MessageBox.Show("Insert Food Successfully!", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid();
                        loadForm();
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkEmptyField())
                {
                    MessageBox.Show("Empty Field!", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = InterVar.foodID;
                    String name = textbox_Name.Text;
                    int cost = (int)numericUpDown_Cost.Value;
                    int type = comboBox_Type.SelectedIndex + 1;
                    MemoryStream image = new MemoryStream();
                    pictureBox_Food.Image.Save(image, pictureBox_Food.Image.RawFormat);

                    if (cost <= 0)
                    {
                        MessageBox.Show("Cost must greater than 0!", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (FOOD.updateFood(id, name, cost, type, image))
                    {
                        MessageBox.Show("Update Food Successfully!", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid();

                    }
                    else
                    {
                        MessageBox.Show("Error!", "Edit Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkEmptyField())
                {
                    MessageBox.Show("Empty Field!", "Delete Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Do You Want To Delete This Food?", "Delete Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (FOOD.deleteFood(InterVar.foodID))
                        {
                            MessageBox.Show("Food Removed!", "Delete Food", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid();
                            loadForm();
                            loadListbox();
                        }
                        else
                        {
                            MessageBox.Show("Error!", "Delete Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Delete Food", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            loadForm();
            fillGrid();
            loadListbox();
        }

        private void dataGridView_Food_DoubleClick(object sender, EventArgs e)
        {
            InterVar.foodID = (int)dataGridView_Food.CurrentRow.Cells[0].Value;
            //Console.WriteLine(InterVar.foodID);
            textbox_Name.Text = dataGridView_Food.CurrentRow.Cells[1].Value.ToString();
            numericUpDown_Cost.Value = (int)dataGridView_Food.CurrentRow.Cells[2].Value;
            int type = Convert.ToInt32(dataGridView_Food.CurrentRow.Cells[3].Value);

            if (type == 1)
            {
                comboBox_Type.SelectedIndex = 0;
            }
            else if (type == 2)
            {
                comboBox_Type.SelectedIndex = 1;
            }
            else if (type == 3)
            {
                comboBox_Type.SelectedIndex = 2;
            }
            else
            {
                comboBox_Type.SelectedIndex = 3;
            }

            try
            {
                byte[] pic;
                pic = (byte[])dataGridView_Food.CurrentRow.Cells[4].Value;
                MemoryStream picture = new MemoryStream(pic);
                pictureBox_Food.Image = Image.FromStream(picture);
            }
            catch
            {

            }

            loadListbox();

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Food.ReadOnly = true;

            DataTable table = FOOD.getFoodByName(textbox_Search.Text.Trim());
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_Food.RowTemplate.Height = 60;
            dataGridView_Food.DataSource = table;
            dataGridView_Food.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            picCol = (DataGridViewImageColumn)dataGridView_Food.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Food.AllowUserToAddRows = false;
            dataGridView_Food.Columns[0].HeaderText = "ID";
            dataGridView_Food.Columns[1].HeaderText = "NAME";
            dataGridView_Food.Columns[2].HeaderText = "COST";
            dataGridView_Food.Columns[3].HeaderText = "TYPE";
            dataGridView_Food.Columns[4].HeaderText = "IMAGE";

            InterVar.foodID = 0;
            textbox_Name.Text = "";
            numericUpDown_Cost.Value = 0;
            pictureBox_Food.Image = null;
            loadListbox();
        }

        private void button_EditMaterial_Click(object sender, EventArgs e)
        {
            if (InterVar.foodID != 0)
            {
                ManageComponentForm f = new ManageComponentForm();
                f.ShowDialog();
                loadListbox();
            }
        }
    }
}
