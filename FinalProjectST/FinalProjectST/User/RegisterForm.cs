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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            label_Alert.ForeColor = Color.Red;
            label_Alert.Text = "";

            if (checkEmpty())
            {
                label_Alert.Text = "Emply Field!";
            }
            else
            {
                try
                {
                    string name = textbox_name.Text.Trim();
                    string email = textbox_Email.Text.Trim();
                    string phone = textbox_phone.Text.Trim();
                    string address = textbox_Address.Text.Trim();
                    string pass = textbox_Password.Text.Trim();
                    string repass = textbox_RetypePassword.Text.Trim();

                    if (USER.checkExistEmail(email))
                    {
                        label_Alert.Text = "Exist Email!";
                    }
                    else if (pass != repass)
                    {
                        label_Alert.Text = "Please retype correct password!";
                    }
                    else
                    {
                        if (USER.insertUser(name, phone,address, email, pass))
                        {
                            label_Alert.ForeColor = Color.Green;
                            label_Alert.Text = "Register Successfully!";
                        }
                        else
                        {
                            label_Alert.Text = "Error!!!";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public bool checkEmpty()
        {
            if (textbox_name.Text.Trim() == "" || textbox_Email.Text.Trim() == "" || textbox_phone.Text.Trim() == "" || textbox_Address.Text.Trim()=="" || textbox_Password.Text.Trim() == "" || textbox_RetypePassword.Text.Trim() == "")
            {
                return true;
            }
            return false;
        }

        private void label_Clear_Click(object sender, EventArgs e)
        {
            label_Alert.ForeColor = Color.Red;
            label_Alert.Text = "";

            textbox_name.Text = "";
            textbox_Email.Text = "";
            textbox_phone.Text = "";
            textbox_Address.Text = "";
            textbox_Password.Text = "";
            textbox_RetypePassword.Text = "";
        }
    }
}
