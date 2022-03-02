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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //Login Customer
        private void button_Login_Click(object sender, EventArgs e)
        {
            //label_Alert_Customer.ForeColor = Color.Red;
            label_Alert_Customer.Text = "";

            if (textbox_email.Text.Trim() == "" || textbox_Password.Text.Trim() == "")
            {
                label_Alert_Customer.Text = "Empty Field!";
            }
            else
            {
                try
                {
                    string email = textbox_email.Text;
                    string pass = textbox_Password.Text;

                    if (!USER.checkExistEmail(email))
                    {
                        label_Alert_Customer.Text = "Email is not exist!";
                    }
                    else if (USER.checkUser(email, pass))
                    {
                        Console.WriteLine(InterVar.userID);
                        CustomerMainForm a = new CustomerMainForm();
                        this.Hide();
                        a.ShowDialog();
                        //this.Show();
                        Application.Exit();
                    }
                    else
                    {
                        label_Alert_Customer.Text = "Incorrect Password!";
                        textbox_Password.Text = "";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Register
        private void label_register_Click(object sender, EventArgs e)
        {
            RegisterForm F = new RegisterForm();
            F.Show();
        }

        //Login Staff
        private void button_Login_Staff_Click(object sender, EventArgs e)
        {
            label_Alert_Staff.Text = "";

            if (textbox_username_staff.Text.Trim() == "" || textbox_password_staff.Text.Trim() == "")
            {
                label_Alert_Staff.Text = "Empty Field!";
            }
            else
            {
                try
                {
                    string uname = textbox_username_staff.Text;
                    string pass = textbox_password_staff.Text;

                    if (!EMPLOYEE.checkExistUsername(uname))
                    {
                        label_Alert_Staff.Text = "Username is not exist!";
                    }
                    else if (EMPLOYEE.checkEmployee(uname, pass))
                    {
                        if (EMPLOYEE.getEmployeePosition(InterVar.employeeID) == 1)
                        {
                            ManageMainForm a = new ManageMainForm();
                            this.Hide();
                            a.ShowDialog();
                            //this.Show();
                            Application.Exit();
                        }
                        else
                        {
                            StaffMainForm a = new StaffMainForm();
                            this.Hide();
                            a.ShowDialog();
                            //this.Show();
                            Application.Exit();
                        }
                    }
                    else
                    {
                        label_Alert_Staff.Text = "Incorrect Password";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            //test
            textbox_email.Text = "user1@gmail.com";
            textbox_Password.Text = "123456";
            textbox_username_staff.Text = "manage1";
            textbox_password_staff.Text = "123456";
        }
    }
}
