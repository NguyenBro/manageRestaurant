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
    public partial class StaffViewSalaryForm : Form
    {
        public StaffViewSalaryForm()
        {
            InitializeComponent();
        }

        public void fillData()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = EMPLOYEE.getSalaryEmployee(InterVar.employeeID);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            ChangeColor();
        }

        public void ChangeColor()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["status"].Value.ToString().Trim() == "0")
                {
                    dataGridView1.Rows[i].Cells["status"].Style.ForeColor = ColorTranslator.FromHtml("#f70707");
                    dataGridView1.Rows[i].Cells["status"].Style.BackColor = ColorTranslator.FromHtml("#f70707");
                }
                else
                {
                    dataGridView1.Rows[i].Cells["status"].Style.ForeColor = ColorTranslator.FromHtml("#1cf711");
                    dataGridView1.Rows[i].Cells["status"].Style.BackColor = ColorTranslator.FromHtml("#1cf711");
                }

                if (float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) == 8)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7a6af7");
                }
                else if (float.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) < 7)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2509f7");
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#513bf7");
                }
            }
        }

        private void button_Static_Click(object sender, EventArgs e)
        {
            EmployeeHoursStaticForm f = new EmployeeHoursStaticForm();
            f.Show(this);
        }
        private void StaffViewSalaryForm_Load(object sender, EventArgs e)
        {
            fillData();
        }
    }
}
