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
    public partial class StaffWatchShiftForm : Form
    {
        public StaffWatchShiftForm()
        {
            InitializeComponent();
        }

        public void fillData()
        {
            DataTable table = EMPLOYEE.getDateAllocation(InterVar.employeeID);
            table.Columns.Add("Shift 1");
            table.Columns.Add("Shift 2");
            table.Columns.Add("Shift 3");
            table.Columns.Add("Status Check Out");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DateTime date = (DateTime)table.Rows[i]["date"];
                int firstShift = EMPLOYEE.GetFirstShift(InterVar.employeeID, date);
                int secondShift = EMPLOYEE.GetSecondShift(InterVar.employeeID, date);
                //MessageBox.Show("Date:" +date +"s1: " + firstShift + ",s2: " + secondShift);
                table.Rows[i][firstShift] = "X";
                table.Rows[i][secondShift] = "X";

                string firstStatus = EMPLOYEE.getFirstStatus(InterVar.employeeID, date);
                string secondStatus = EMPLOYEE.getSecondStatus(InterVar.employeeID, date);
                //MessageBox.Show("Date:" +date +"s1: " + firstStatus + ",s2: " + secondStatus);
                if (firstStatus.Trim() == "OUT" && secondStatus.Trim() == "OUT")
                {
                    table.Rows[i][4] = "YES-YES";
                }
                else if (firstStatus.Trim() == "OUT")
                {
                    table.Rows[i][4] = "YES-NO";
                }
                else if (secondStatus.Trim() == "OUT")
                {
                    table.Rows[i][4] = "NO-YES";
                }
                else
                {
                    table.Rows[i][4] = "NO-NO";
                }

            }


            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;

            //==
            ChangeColor();
        }



        private void StaffWatchShiftForm_Load(object sender, EventArgs e)
        {
            fillData();
            guna2DateTimePicker1.Value = DateTime.Today;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            DateTime datetime = guna2DateTimePicker1.Value;
            DataTable table = EMPLOYEE.getDateAllocation(InterVar.employeeID, datetime);
            table.Columns.Add("Shift 1");
            table.Columns.Add("Shift 2");
            table.Columns.Add("Shift 3");
            table.Columns.Add("Status Check Out");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DateTime date = (DateTime)table.Rows[i]["date"];
                int firstShift = EMPLOYEE.GetFirstShift(InterVar.employeeID, date);
                int secondShift = EMPLOYEE.GetSecondShift(InterVar.employeeID, date);
                //MessageBox.Show("Date:" +date +"s1: " + firstShift + ",s2: " + secondShift);
                table.Rows[i][firstShift] = "X";
                table.Rows[i][secondShift] = "X";

                string firstStatus = EMPLOYEE.getFirstStatus(InterVar.employeeID, date);
                string secondStatus = EMPLOYEE.getSecondStatus(InterVar.employeeID, date);
                //MessageBox.Show("Date:" +date +"s1: " + firstStatus + ",s2: " + secondStatus);
                if (firstStatus.Trim() == "OUT" && secondStatus.Trim() == "OUT")
                {
                    table.Rows[i][4] = "YES-YES";
                }
                else if (firstStatus.Trim() == "OUT")
                {
                    table.Rows[i][4] = "YES-NO";
                }
                else if (secondStatus.Trim() == "OUT")
                {
                    table.Rows[i][4] = "NO-YES";
                }
                else
                {
                    table.Rows[i][4] = "NO-NO";
                }

            }


            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = table;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;

            //==
            ChangeColor();

        }

        public void ChangeColor()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Trim() == "X")
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = ColorTranslator.FromHtml("#1118f7");
                        dataGridView1.Rows[i].Cells[j].Style.ForeColor = ColorTranslator.FromHtml("#1118f7");
                    }
                }
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[4].Value.ToString().Trim() == "YES-YES")
                {
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#1cf711");
                }
                else if (dataGridView1.Rows[i].Cells[4].Value.ToString().Trim() == "NO-NO")
                {
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#f70707");

                }
                else
                {
                    dataGridView1.Rows[i].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#f7f707");
                }
            }
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            fillData();
        }
    }
}
