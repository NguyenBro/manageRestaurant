using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinalProjectST
{
    public partial class EmployeeHoursStaticForm : Form
    {
        public EmployeeHoursStaticForm()
        {
            InitializeComponent();

        }

        public void loadChart()
        {
            DataTable table = EMPLOYEE.getSalaryEmployee(InterVar.employeeID);
            if (table.Rows.Count < 7)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    DateTime date = (DateTime)table.Rows[i]["date"];
                    int x = date.Day;
                    string day = ("Day" + x);

                    float hours = float.Parse(table.Rows[i]["SumHours"].ToString());

                    chart1.Series["Hours"].Points.AddXY(date, hours);
                    chart1.Series[0].ChartType = SeriesChartType.Line;

                }
            }
            else
            {
                for (int i = table.Rows.Count - 7; i < table.Rows.Count; i++)
                {
                    DateTime date = (DateTime)table.Rows[i]["date"];
                    int x = date.Day;
                    string day = ("Day" + x);

                    float hours = float.Parse(table.Rows[i]["SumHours"].ToString());

                    chart1.Series["Hours"].Points.AddXY(date, hours);
                    chart1.Series[0].ChartType = SeriesChartType.Line;
                }
            }
        }

        private void EmployeeHoursStaticForm_Load(object sender, EventArgs e)
        {
            loadChart();
        }
    }
}
