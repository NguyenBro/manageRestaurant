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
    public partial class StaffEditInfoForm : Form
    {
        public StaffEditInfoForm()
        {
            InitializeComponent();
        }

        private int eid = InterVar.employeeID;
        private String name = "";
        private String username = "";
        private String password = "";
        private int position_id;

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_UpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbox_Name.Text.Trim() == "" || pictureBox_Employee.Image == null)
                {
                    MessageBox.Show("Empty Field!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MemoryStream image = new MemoryStream();
                    pictureBox_Employee.Image.Save(image, pictureBox_Employee.Image.RawFormat);
                    name = textbox_Name.Text;

                    if (EMPLOYEE.updateEmployee(eid, name, username, password, position_id, image))
                    {
                        MessageBox.Show("Update Infomation Successfully!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_UpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbox_OldPass.Text.Trim() == "" || textbox_NewPass.Text.Trim() == "" || textbox_ReNewPass.Text.Trim() == "")
                {
                    MessageBox.Show("Empty Field!", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!textbox_OldPass.Text.Trim().Equals(password))
                {
                    MessageBox.Show("Incorrect Old Password!", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!textbox_NewPass.Text.Trim().Equals(textbox_ReNewPass.Text.Trim()))
                {
                    MessageBox.Show("Please Retype Correct Password!", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    password = textbox_NewPass.Text.Trim();
                    MemoryStream image = new MemoryStream();
                    pictureBox_Employee.Image.Save(image, pictureBox_Employee.Image.RawFormat);

                    if (EMPLOYEE.updateEmployee(eid, name, username, password, position_id, image))
                    {
                        MessageBox.Show("Update Password Successfully!", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textbox_OldPass.Text = "";
                        textbox_NewPass.Text = "";
                        textbox_ReNewPass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error!", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StaffEditInfoForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {

            try
            {
                DataTable table = EMPLOYEE.getEmployeeByID(eid);

                name = table.Rows[0]["name"].ToString();
                username = table.Rows[0]["name"].ToString();
                password = table.Rows[0]["password"].ToString();
                position_id = int.Parse(table.Rows[0]["position_id"].ToString());

                pictureBox_Employee.Image = Image.FromStream(new MemoryStream((byte[])table.Rows[0]["image"]));
                textbox_Name.Text = name;
                textbox_Username.Text = username;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
