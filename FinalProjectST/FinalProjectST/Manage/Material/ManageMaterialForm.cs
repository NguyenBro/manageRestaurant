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
    public partial class ManageMaterialForm : Form
    {
        public ManageMaterialForm()
        {
            InitializeComponent();
        }

        public int currentMaterialID = 0;

        private void ManageMaterialForm_Load(object sender, EventArgs e)
        {
            fillGrid();
            loadForm();
        }

        public void fillGrid()
        {
            dataGridView_Material.ReadOnly = true;

            DataTable table = MATERIAL.getMaterialByName("");

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_Material.RowTemplate.Height = 60;
            dataGridView_Material.DataSource = table;
            dataGridView_Material.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            picCol = (DataGridViewImageColumn)dataGridView_Material.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Material.AllowUserToAddRows = false;

            dataGridView_Material.Columns[0].HeaderText = "ID";
            dataGridView_Material.Columns[1].HeaderText = "NAME";
            dataGridView_Material.Columns[2].HeaderText = "AMOUNT";
            dataGridView_Material.Columns[3].HeaderText = "UNIT";
            dataGridView_Material.Columns[4].HeaderText = "IMAGE";
        }

        public void loadForm()
        {

            currentMaterialID = 0;
            textbox_Name.Text = "";
            numericUpDown_Amount.Value = 0;
            textbox_Unit.Text = "";
            pictureBox_Material.Image = null;
            textbox_Search.Text = "";
        }

        private void button_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Material.Image = Image.FromFile(opf.FileName);
            }
        }

        public bool checkEmptyField()
        {
            if (textbox_Name.Text.Trim() == "" || textbox_Unit.Text.Trim() == "" || pictureBox_Material.Image == null)
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
                    MessageBox.Show("Empty Field!", "Add Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string name = textbox_Name.Text.Trim();
                    int amount = (int)numericUpDown_Amount.Value;
                    string unit = textbox_Unit.Text.Trim();
                    MemoryStream image = new MemoryStream();
                    pictureBox_Material.Image.Save(image, pictureBox_Material.Image.RawFormat);

                    if (amount <= 0)
                    {
                        MessageBox.Show("Amount must greater than 0!", "Add Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (MATERIAL.insertMaterial(name, amount, unit, image))
                    {
                        MessageBox.Show("Insert Material Successfully!", "Add Material", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid();
                        loadForm();
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Add Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkEmptyField())
                {
                    MessageBox.Show("Empty Field!", "Edit Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string name = textbox_Name.Text.Trim();
                    int amount = (int)numericUpDown_Amount.Value;
                    string unit = textbox_Unit.Text.Trim();
                    MemoryStream image = new MemoryStream();
                    pictureBox_Material.Image.Save(image, pictureBox_Material.Image.RawFormat);

                    if (amount <= 0)
                    {
                        MessageBox.Show("Amount must greater than 0!", "Edit Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (MATERIAL.updateMaterial(currentMaterialID, name, amount, unit, image))
                    {
                        MessageBox.Show("Update Material Successfully!", "Edit Material", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid();

                    }
                    else
                    {
                        MessageBox.Show("Error!", "Edit Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkEmptyField())
                {
                    MessageBox.Show("Empty Field!", "Delete Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("Do You Want To Delete This Material?", "Delete Material", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (MATERIAL.deleteMaterial(currentMaterialID))
                        {
                            MessageBox.Show("Material Removed!", "Delete Material", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid();
                            loadForm();
                        }
                        else
                        {
                            MessageBox.Show("Error!", "Delete Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            fillGrid();
            loadForm();
        }

        private void dataGridView_Material_DoubleClick(object sender, EventArgs e)
        {
            currentMaterialID = (int)dataGridView_Material.CurrentRow.Cells[0].Value;
            textbox_Name.Text = dataGridView_Material.CurrentRow.Cells[1].Value.ToString();
            numericUpDown_Amount.Value = (int)dataGridView_Material.CurrentRow.Cells[2].Value;
            textbox_Unit.Text = dataGridView_Material.CurrentRow.Cells[3].Value.ToString();

            //if image is not null
            try
            {
                byte[] pic;
                pic = (byte[])dataGridView_Material.CurrentRow.Cells[4].Value;
                MemoryStream picture = new MemoryStream(pic);
                pictureBox_Material.Image = Image.FromStream(picture);
            }
            catch
            {

            }

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Material.ReadOnly = true;

            DataTable table = MATERIAL.getMaterialByName(textbox_Search.Text.Trim());

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_Material.RowTemplate.Height = 60;
            dataGridView_Material.DataSource = table;
            dataGridView_Material.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            picCol = (DataGridViewImageColumn)dataGridView_Material.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Material.AllowUserToAddRows = false;

            dataGridView_Material.Columns[0].HeaderText = "ID";
            dataGridView_Material.Columns[1].HeaderText = "NAME";
            dataGridView_Material.Columns[2].HeaderText = "AMOUNT";
            dataGridView_Material.Columns[3].HeaderText = "UNIT";
            dataGridView_Material.Columns[4].HeaderText = "IMAGE";

            currentMaterialID = 0;
            textbox_Name.Text = "";
            numericUpDown_Amount.Value = 0;
            textbox_Unit.Text = "";
            pictureBox_Material.Image = null;
        }
    }
}
