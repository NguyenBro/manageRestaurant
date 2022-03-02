using Guna.UI2.WinForms;
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
    public partial class ManageMainForm : Form
    {
        public ManageMainForm()
        {
            InitializeComponent();
        }

        private void ManageMainForm_Load(object sender, EventArgs e)
        {
            if (EMPLOYEE.getEmployeePosition(InterVar.employeeID) != 1)
            {
                this.manageEmployeeToolStripMenuItem.Visible = false;
                this.manageFoodToolStripMenuItem.Visible = false;
                this.manageShiftToolStripMenuItem.Visible = false;
                this.manageMaterialToolStripMenuItem.Visible = false;
            }
            else
            {
                this.button_home.Visible = false;
            }
            label_Name.Text = "Welcome " + EMPLOYEE.getEmployeeName(InterVar.employeeID).ToUpper() + " (" + EMPLOYEE.getPosition() + ")";
            MemoryStream memoryStream = EMPLOYEE.getPicture(InterVar.employeeID);
            if (memoryStream != null)  
            {
                this.guna2PictureBox1.Image = Image.FromStream(memoryStream);
            }
            else
                this.guna2PictureBox1.Image = Image.FromFile("../../Image/faceEmployee.png");
            LoadAllTable();
        }

        public void ClearAllTable()
        {
            flowLayoutPanel_Table.Controls.Clear();
        }

        public void LoadFreeTable()
        {
            DataTable table = TABLE.getTableFree();
            LoadTable(table);
        }

        public void LoadBusyTable()
        {
            DataTable table = TABLE.getTableBusy();
            LoadTable(table);
        }

        public void LoadAllTable()
        {
            DataTable table = TABLE.getAllTable();
            LoadTable(table);
        }

        public void LoadTable(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int TableID = int.Parse(table.Rows[i]["id"].ToString());
                int Status = int.Parse(table.Rows[i]["status"].ToString());
                int Chair = int.Parse(table.Rows[i]["chairs"].ToString());
                MakeIconTable(TableID, Status, Chair);
            }
        }

        public void MakeIconTable(int TableID, int Status, int Chair)
        {
            Panel table = new Panel();

            table.Size = new Size(160, 200);
            table.BorderStyle = BorderStyle.FixedSingle;

            //picture box
            Guna2CirclePictureBox picture = new Guna2CirclePictureBox();
            picture.Size = new Size(100, 100);
            picture.Location = new Point(30, 30);
            picture.Image = Image.FromFile("../../Image/table.jpg");
            picture.SizeMode = PictureBoxSizeMode.Zoom;
            table.Controls.Add(picture);
            picture.DoubleClick += Picture_DoubleClick;
            picture.Tag = TableID;

            //label status
            Label label_Status = new Label();
            label_Status.Text = "Busy";
            label_Status.Location = new Point(58, 0);
            label_Status.Font = new Font("Tahoma", 12, FontStyle.Bold);
            label_Status.ForeColor = Color.Black;

            if (Status == 0)
            {
                label_Status.Text = "Free";
                label_Status.ForeColor = Color.Black;
                table.BackColor = ColorTranslator.FromHtml("#75e68f");
            }
            else if (Status == 1)
            {
                label_Status.Text = "Busy";
                label_Status.ForeColor = Color.Black;
                table.BackColor = ColorTranslator.FromHtml("#d97171");
            }


            //label name
            Label label_Name = new Label();
            label_Name.Text = ("Table: " + TableID.ToString());
            label_Name.Location = new Point(0, 135);
            label_Name.Width = 160;
            label_Name.TextAlign = ContentAlignment.MiddleCenter;
            label_Name.Font = new Font("Tahoma", 14, FontStyle.Bold);
            label_Name.ForeColor = Color.Black;

            //label chair
            Label label_Chair = new Label();
            label_Chair.Text = ("Chair: " + Chair.ToString());
            label_Chair.Location = new Point(0, 170);
            label_Chair.Width = 160;
            label_Chair.TextAlign = ContentAlignment.MiddleCenter;
            label_Chair.Font = new Font("Tahoma", 10, FontStyle.Bold);
            label_Chair.ForeColor = Color.Black;

            table.Controls.Add(label_Status);
            table.Controls.Add(label_Name);
            table.Controls.Add(label_Chair);
            flowLayoutPanel_Table.Controls.Add(table);
        }

        private void Picture_DoubleClick(object sender, EventArgs e)
        {
            PictureBox a = sender as PictureBox;
            using (TableForm table = new TableForm((int)a.Tag))
            {
                table.ShowDialog();
            }
            ClearAllTable();
            LoadAllTable();
        }
        private void button_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to logout out ?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                InterVar.employeeID = 0;
                LoginForm a = new LoginForm();
                this.Hide();
                a.ShowDialog();
                Application.Exit();
            }
        }

        private void button_home_Click(object sender, EventArgs e)
        {
            StaffMainForm a = new StaffMainForm();
            this.Hide();
            a.ShowDialog();
            Application.Exit();

        }

        private void splitShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SplitShiftForm f = new SplitShiftForm();
            f.ShowDialog();

        }

        private void viewShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WatchShiftForm f = new WatchShiftForm();
            f.ShowDialog();
        }

        private void manageFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageFoodForm f = new ManageFoodForm();
            f.ShowDialog();
        }

        private void manageMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMaterialForm f = new ManageMaterialForm();
            f.ShowDialog();
        }

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageEmployeeForm f = new ManageEmployeeForm();
            f.ShowDialog();
        }

        private void allTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllTable();
            LoadAllTable();
        }

        private void tableBookedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllTable();
            LoadBusyTable();
        }

        private void tableFreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAllTable();
            LoadFreeTable();
        }

        private void orderOnlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageOnlineOrderForm f = new ManageOnlineOrderForm();
            f.ShowDialog();
        }

        private void button_EditInfo_Click(object sender, EventArgs e)
        {
            Console.WriteLine(InterVar.employeeID);
            StaffEditInfoForm f = new StaffEditInfoForm();
            f.ShowDialog();
        }

        private void statisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticForm f = new StatisticForm();
            f.ShowDialog();
        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageSalaryForm f = new ManageSalaryForm();
            f.Show();
        }
    }
}
