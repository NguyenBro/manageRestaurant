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
    public partial class ManageEmployeeForm : Form
    {
        public ManageEmployeeForm()
        {
            InitializeComponent();
        }

        public int currentEmployeeID = 0;

        private void ManageEmployeeForm_Load(object sender, EventArgs e)
        {
            fillGrid();
            loadForm();
        }

        public void fillGrid()
        {
            dataGridView_Employee.ReadOnly = true;

            DataTable table = EMPLOYEE.getEmployeeByName("");

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_Employee.RowTemplate.Height = 60;
            dataGridView_Employee.DataSource = table;
            dataGridView_Employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            picCol = (DataGridViewImageColumn)dataGridView_Employee.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Employee.AllowUserToAddRows = false;

            dataGridView_Employee.Columns[0].HeaderText = "ID";
            dataGridView_Employee.Columns[1].HeaderText = "NAME";
            dataGridView_Employee.Columns[2].HeaderText = "USERNAME";
            dataGridView_Employee.Columns[3].HeaderText = "POSITION";
            dataGridView_Employee.Columns[4].HeaderText = "IMAGE";

        }

        public void loadForm()
        {
            comboBox_Type.DataSource = EMPLOYEE.getAllPosition();
            comboBox_Type.DisplayMember = "name_position";
            comboBox_Type.ValueMember = "id";
            comboBox_Type.SelectedItem = 0;

            currentEmployeeID = 0;
            textbox_Name.Text = "";
            textbox_Username.Text = "";
            textbox_Password.Text = "";
            pictureBox_Employee.Image = null;
            textbox_Search.Text = "";
        }

        private void button_UploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_Employee.Image = Image.FromFile(opf.FileName);
            }
        }

        private void dataGridView_Employee_DoubleClick(object sender, EventArgs e)
        {
            //get Employee from current row
            currentEmployeeID = (int)dataGridView_Employee.CurrentRow.Cells[0].Value;

            DataTable table = EMPLOYEE.getEmployeeByID(currentEmployeeID);

            try
            {
                textbox_Name.Text = table.Rows[0][1].ToString();
                textbox_Username.Text = table.Rows[0][2].ToString();
                textbox_Password.Text = table.Rows[0][3].ToString();
                comboBox_Type.SelectedIndex = (int)table.Rows[0][4] - 1;
            }
            catch
            {

            }


            //if image is not null
            try
            {
                byte[] pic;
                pic = (byte[])table.Rows[0][5];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox_Employee.Image = Image.FromStream(picture);
            }
            catch
            {

            }

        }

        public bool checkEmptyField()
        {
            if (textbox_Name.Text.Trim() == "" || textbox_Username.Text.Trim() == "" || textbox_Password.Text.Trim() == "" || pictureBox_Employee.Image == null)
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
                    MessageBox.Show("Empty Field!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string name = textbox_Name.Text.Trim();
                    string username = textbox_Username.Text.Trim();
                    string password = textbox_Password.Text.Trim();
                    int pid = comboBox_Type.SelectedIndex + 1;
                    MemoryStream image = new MemoryStream();
                    pictureBox_Employee.Image.Save(image, pictureBox_Employee.Image.RawFormat);

                    if (EMPLOYEE.insertEmployee(name, username, password, pid, image))
                    {
                        MessageBox.Show("Insert Employee Successfully!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid();
                        loadForm();
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkEmptyField())
                {
                    MessageBox.Show("Empty Field!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string name = textbox_Name.Text.Trim();
                    string username = textbox_Username.Text.Trim();
                    string password = textbox_Password.Text.Trim();
                    int pid = comboBox_Type.SelectedIndex + 1;
                    MemoryStream image = new MemoryStream();
                    pictureBox_Employee.Image.Save(image, pictureBox_Employee.Image.RawFormat);

                    if (EMPLOYEE.updateEmployee(currentEmployeeID, name, username, password, pid, image))
                    {
                        MessageBox.Show("Update Employee Successfully!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkEmptyField())
                {
                    MessageBox.Show("Empty Field!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    if (MessageBox.Show("Do You Want To Delete This Employee?", "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (EMPLOYEE.deleteEmployee(currentEmployeeID))
                        {
                            MessageBox.Show("Employee Removed!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillGrid();
                            loadForm();
                        }
                        else
                        {
                            MessageBox.Show("Error!", "Delete Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            loadForm();
            fillGrid();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            dataGridView_Employee.ReadOnly = true;

            DataTable table = EMPLOYEE.getEmployeeByName(textbox_Search.Text.Trim());

            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView_Employee.RowTemplate.Height = 60;
            dataGridView_Employee.DataSource = table;
            dataGridView_Employee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            picCol = (DataGridViewImageColumn)dataGridView_Employee.Columns[4];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView_Employee.AllowUserToAddRows = false;

            dataGridView_Employee.Columns[0].HeaderText = "ID";
            dataGridView_Employee.Columns[1].HeaderText = "NAME";
            dataGridView_Employee.Columns[2].HeaderText = "USERNAME";
            dataGridView_Employee.Columns[3].HeaderText = "POSITION";
            dataGridView_Employee.Columns[4].HeaderText = "IMAGE";

            currentEmployeeID = 0;
            textbox_Name.Text = "";
            textbox_Username.Text = "";
            textbox_Password.Text = "";
            pictureBox_Employee.Image = null;

        }
    }
}
