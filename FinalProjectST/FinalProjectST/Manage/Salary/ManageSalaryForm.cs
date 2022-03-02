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
    public partial class ManageSalaryForm : Form
    {
        public ManageSalaryForm()
        {
            InitializeComponent();
        }

        private string text = "";

        public void fillData()
        {
            dataGridView_Salary.ReadOnly = true;
            dataGridView_Salary.RowTemplate.Height = 60;
            dataGridView_Salary.DataSource = SALARY.getPayroll();
            dataGridView_Salary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Salary.AllowUserToAddRows = false;
            ChangeColor();
        }

        public void InsertPayRoll()
        {
            DataTable table = SALARY.getEmployeeUnPaid();
            //MessageBox.Show("so: " + table.Rows.Count);
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DateTime date = (DateTime)table.Rows[i]["date"];
                int eid = Convert.ToInt32(table.Rows[i]["employee_id"].ToString());
                SALARY.InsertPayRoll(date, eid);
            }
        }

        public void ChangeColor()
        {
            for (int i = 0; i < dataGridView_Salary.Rows.Count; i++)
            {
                if (dataGridView_Salary.Rows[i].Cells["status"].Value.ToString().Trim() == "0")
                {
                    dataGridView_Salary.Rows[i].Cells["status"].Style.ForeColor = ColorTranslator.FromHtml("#f70707");
                    dataGridView_Salary.Rows[i].Cells["status"].Style.BackColor = ColorTranslator.FromHtml("#f70707");
                }
                else
                {
                    dataGridView_Salary.Rows[i].Cells["status"].Style.ForeColor = ColorTranslator.FromHtml("#1cf711");
                    dataGridView_Salary.Rows[i].Cells["status"].Style.BackColor = ColorTranslator.FromHtml("#1cf711");
                }

                if (float.Parse(dataGridView_Salary.Rows[i].Cells["SumHours"].Value.ToString()) == 8)
                {
                    dataGridView_Salary.Rows[i].Cells[1].Style.BackColor = ColorTranslator.FromHtml("#7a6af7");
                    dataGridView_Salary.Rows[i].Cells[2].Style.BackColor = ColorTranslator.FromHtml("#7a6af7");
                    dataGridView_Salary.Rows[i].Cells[3].Style.BackColor = ColorTranslator.FromHtml("#7a6af7");
                    dataGridView_Salary.Rows[i].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#7a6af7");
                    dataGridView_Salary.Rows[i].Cells[5].Style.BackColor = ColorTranslator.FromHtml("#7a6af7");

                }
                else if (float.Parse(dataGridView_Salary.Rows[i].Cells["SumHours"].Value.ToString()) < 8 && float.Parse(dataGridView_Salary.Rows[i].Cells["SumHours"].Value.ToString()) >= 7)
                {
                    dataGridView_Salary.Rows[i].Cells[1].Style.BackColor = ColorTranslator.FromHtml("#513bf7");
                    dataGridView_Salary.Rows[i].Cells[2].Style.BackColor = ColorTranslator.FromHtml("#513bf7");
                    dataGridView_Salary.Rows[i].Cells[3].Style.BackColor = ColorTranslator.FromHtml("#513bf7");
                    dataGridView_Salary.Rows[i].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#513bf7");
                    dataGridView_Salary.Rows[i].Cells[5].Style.BackColor = ColorTranslator.FromHtml("#513bf7");

                }
                else
                {
                    dataGridView_Salary.Rows[i].Cells[1].Style.BackColor = ColorTranslator.FromHtml("#2509f7");
                    dataGridView_Salary.Rows[i].Cells[2].Style.BackColor = ColorTranslator.FromHtml("#2509f7");
                    dataGridView_Salary.Rows[i].Cells[3].Style.BackColor = ColorTranslator.FromHtml("#2509f7");
                    dataGridView_Salary.Rows[i].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#2509f7");
                    dataGridView_Salary.Rows[i].Cells[5].Style.BackColor = ColorTranslator.FromHtml("#2509f7");

                }

                dataGridView_Salary.Columns["date"].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ed812f");
            }
        }

        private void ManageSalaryForm_Load(object sender, EventArgs e)
        {
            InsertPayRoll();
            fillData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DateTime date = (DateTime)dataGridView_Salary.CurrentRow.Cells["date"].Value;
            int eid = Convert.ToInt32(dataGridView_Salary.CurrentRow.Cells["employee_id"].Value.ToString());
            //MessageBox.Show("date" +date +"id"+eid);

            dataGridView_Salary.ReadOnly = true;
            dataGridView_Salary.RowTemplate.Height = 60;
            dataGridView_Salary.DataSource = SALARY.getSalaryByNameDate(text);
            dataGridView_Salary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Salary.AllowUserToAddRows = false;
            ChangeColor();
        }

        private void button_Pay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView_Salary.Rows.Count; i++)
            {
                if (dataGridView_Salary.Rows[i].Cells["status"].Value.ToString().Trim() == "0")
                {
                    DateTime date = (DateTime)dataGridView_Salary.Rows[i].Cells["date"].Value;
                    int eid = Convert.ToInt32(dataGridView_Salary.Rows[i].Cells["employee_id"].Value.ToString());
                    //MessageBox.Show("date" + date + ", id" + eid);
                    SALARY.UpdateStatusPayroll(date, eid);
                }

            }

            MessageBox.Show("Complete employee salary payment!", "Pay For Employees", MessageBoxButtons.OK, MessageBoxIcon.Information);

            dataGridView_Salary.ReadOnly = true;
            dataGridView_Salary.RowTemplate.Height = 60;
            dataGridView_Salary.DataSource = SALARY.getSalaryByNameDate(text);
            dataGridView_Salary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Salary.AllowUserToAddRows = false;
            ChangeColor();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {

            dataGridView_Salary.ReadOnly = true;
            dataGridView_Salary.RowTemplate.Height = 60;
            dataGridView_Salary.DataSource = SALARY.getSalaryByNameDate(textbox_Search.Text.Trim());
            dataGridView_Salary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Salary.AllowUserToAddRows = false;
            ChangeColor();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            textbox_Search.Text = "";
            text = "";
            fillData();
        }
    }
}
