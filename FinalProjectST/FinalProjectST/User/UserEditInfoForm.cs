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
    public partial class UserEditInfoForm : Form
    {
        public UserEditInfoForm()
        {
            InitializeComponent();
        }

        private int uid = InterVar.userID;
        private String name = "";
        private String email = "";
        private String phone = "";
        private String address = "";
        private String password = "";

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserEditInfoForm_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        public void LoadInfo()
        {

            try
            {
                DataTable table = USER.getUserByID(uid);

                name = table.Rows[0]["name"].ToString();
                email = table.Rows[0]["email"].ToString();
                phone = table.Rows[0]["phone"].ToString();
                address= table.Rows[0]["address"].ToString();

                password = table.Rows[0]["password"].ToString().Trim();

                textbox_Name.Text = name;
                textbox_Phone.Text = phone;
                textbox_Email.Text = email;
                textbox_Address.Text = address;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_UpdateInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (textbox_Name.Text.Trim() == "" || textbox_Phone.Text.Trim() == "")
                {
                    MessageBox.Show("Empty Field!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    name = textbox_Name.Text.Trim();
                    phone = textbox_Phone.Text.Trim();
                    address = textbox_Address.Text.Trim();

                    if (USER.updateUser(uid, name, phone,address, email, password))
                    {
                        MessageBox.Show("Update Information Successfully!", "Update Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    if (USER.updateUser(uid, name, phone,address, email, password))
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
    }
}
