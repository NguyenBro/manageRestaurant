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
    public partial class WatchShiftForm : Form
    {
        public WatchShiftForm()
        {
            InitializeComponent();
        }

        private void WatchShiftForm_Load(object sender, EventArgs e)
        {
            fillData();
        }

        private void fillData()
        {
            dataGridView_Shift.ReadOnly = true;
            dataGridView_Shift.RowTemplate.Height = 60;
            dataGridView_Shift.DataSource = MANAGER.getTableSplitShift();
            dataGridView_Shift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Shift.AllowUserToAddRows = false;
            ChangeColor();
        }

        private void ChangeColor()
        {
            for (int i = 0; i < dataGridView_Shift.Rows.Count; i++)
            {
                if (dataGridView_Shift.Rows[i].Cells[5].Value.ToString().Trim() == "NO")
                {
                    dataGridView_Shift.Rows[i].Cells[5].Style.BackColor = ColorTranslator.FromHtml("#f41616");
                }
                else if (dataGridView_Shift.Rows[i].Cells[5].Value.ToString().Trim() == "OUT")
                {
                    dataGridView_Shift.Rows[i].Cells[5].Style.BackColor = ColorTranslator.FromHtml("#09f219");
                }
                else
                {
                    dataGridView_Shift.Rows[i].Cells[5].Style.BackColor = ColorTranslator.FromHtml("#f7f707");
                }

                //============
                if (dataGridView_Shift.Rows[i].Cells[4].Value.ToString().Trim() == "1")
                {
                    dataGridView_Shift.Rows[i].Cells[1].Style.BackColor = ColorTranslator.FromHtml("#7a6af7");
                    dataGridView_Shift.Rows[i].Cells[2].Style.BackColor = ColorTranslator.FromHtml("#7a6af7");
                    dataGridView_Shift.Rows[i].Cells[3].Style.BackColor = ColorTranslator.FromHtml("#7a6af7");
                    dataGridView_Shift.Rows[i].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#7a6af7");
                }
                else if (dataGridView_Shift.Rows[i].Cells[4].Value.ToString().Trim() == "2")
                {
                    dataGridView_Shift.Rows[i].Cells[1].Style.BackColor = ColorTranslator.FromHtml("#513bf7");
                    dataGridView_Shift.Rows[i].Cells[2].Style.BackColor = ColorTranslator.FromHtml("#513bf7");
                    dataGridView_Shift.Rows[i].Cells[3].Style.BackColor = ColorTranslator.FromHtml("#513bf7");
                    dataGridView_Shift.Rows[i].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#513bf7");
                }
                else
                {
                    dataGridView_Shift.Rows[i].Cells[1].Style.BackColor = ColorTranslator.FromHtml("#2509f7");
                    dataGridView_Shift.Rows[i].Cells[2].Style.BackColor = ColorTranslator.FromHtml("#2509f7");
                    dataGridView_Shift.Rows[i].Cells[3].Style.BackColor = ColorTranslator.FromHtml("#2509f7");
                    dataGridView_Shift.Rows[i].Cells[4].Style.BackColor = ColorTranslator.FromHtml("#2509f7");
                }

                //==========f2b36f
                dataGridView_Shift.Columns[0].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f2b36f");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            fillData();
        }

        private void guna2GradientButtonFind_Click(object sender, EventArgs e)
        {

            dataGridView_Shift.ReadOnly = true;
            dataGridView_Shift.RowTemplate.Height = 60;
            dataGridView_Shift.DataSource = EMPLOYEE.getEmployeeShift(textbox_Search.Text.Trim());
            dataGridView_Shift.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Shift.AllowUserToAddRows = false;
            ChangeColor();
        }
    }
}
