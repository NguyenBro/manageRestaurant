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
    public partial class StaffMainForm : Form
    {
        public StaffMainForm()
        {
            InitializeComponent();
        }

        private void StaffMainForm_Load(object sender, EventArgs e)
        {
            label_Name.Text = "Welcome " + EMPLOYEE.getEmployeeName(InterVar.employeeID);
            this.label_position.Text += EMPLOYEE.getPosition();
            if (EMPLOYEE.CheckStatusShift(InterVar.employeeID, DateTime.Now) == false)
            {
                this.button_checkin.Visible = true;
                this.button_checkout.Visible = false;
                this.manageRestaurantToolStripMenuItem.Visible = false;
            }
            else
            {
                this.button_checkin.Visible = false;
                this.button_checkout.Visible = true;
                this.manageRestaurantToolStripMenuItem.Visible = true;
            }
            MemoryStream memoryStream = EMPLOYEE.getPicture(InterVar.employeeID);
            if (memoryStream != null)
            {
                this.guna2CirclePictureBox1.Image = Image.FromStream(memoryStream);
            }
            else
                this.guna2CirclePictureBox1.Image = Image.FromFile("../../Image/faceEmployee.png");

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                InterVar.employeeID = 0;
                LoginForm a = new LoginForm();
                this.Hide();
                a.ShowDialog();
                this.Show();
                Application.Exit();
            }
        }

        private void manageRestaurantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMainForm a = new ManageMainForm();
            this.Hide();
            a.ShowDialog();
            this.Show();
            Application.Exit();
        }



        private void button_checkout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to check out ?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    if (EMPLOYEE.CheckOut(InterVar.employeeID) == true)
                    {
                        if (EMPLOYEE.InsertPayroll(DateTime.Today, InterVar.employeeID))
                        {
                            MessageBox.Show("Time: " + DateTime.Now, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.button_checkin.Visible = true;
                            this.button_checkout.Visible = false;
                            this.manageRestaurantToolStripMenuItem.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Error!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error While Check Out!", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show("Warning: " + ee.Message, "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void button_checkin_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to check in ?", "Check in", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (EMPLOYEE.CheckShift(InterVar.employeeID) == true)
                {
                    if (EMPLOYEE.CheckIn(InterVar.employeeID) == true)
                    {
                        MessageBox.Show("Time: " + InterVar.timeCheckIn, "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.button_checkin.Visible = false;
                        this.button_checkout.Visible = true;
                        this.manageRestaurantToolStripMenuItem.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You haven't session in this shift", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You haven't session in this shift", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void viewShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffWatchShiftForm f = new StaffWatchShiftForm();
            f.Show(this);
        }

        private void editInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffEditInfoForm f = new StaffEditInfoForm();
            f.ShowDialog();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaffViewSalaryForm f = new StaffViewSalaryForm();
            f.Show();
        }
    }
}
