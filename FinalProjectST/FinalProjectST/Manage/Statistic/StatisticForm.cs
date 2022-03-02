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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            LoadChartOrder();
            LoadChartSales();
            LoadChartFood();
            LoadChartMaterial();
            LoadChartPayroll();
            LoadChartProfit();
        }

        private void LoadChartFood()
        {
            try
            {
                DataTable food_table = STATISTIC.StatisticFood();

                for (int i = 0; i < food_table.Rows.Count; i++)
                {
                    String food = food_table.Rows[i]["name"].ToString();
                    String amount = food_table.Rows[i]["amount"].ToString();

                    chart_Food.Series["Amount"].Points.AddXY(food, amount);
                }

                chart_Food.Series[0].IsValueShownAsLabel = true;
                chart_Food.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart_Food.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadChartMaterial()
        {
            try
            {
                DataTable material_table = STATISTIC.StatisticMaterial();

                for (int i = 0; i < material_table.Rows.Count; i++)
                {
                    String material = material_table.Rows[i]["name"].ToString();
                    String amount = material_table.Rows[i]["amount"].ToString();

                    chart_Material.Series["Amount"].Points.AddXY(material, amount);

                }

                chart_Material.Series[0].IsValueShownAsLabel = true;
                chart_Material.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart_Material.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadChartOrder()
        {
            try
            {
                int online_order = STATISTIC.StatisticOrder(1);
                int offline_order = STATISTIC.StatisticOrder(2);

                String[] x = { "Online Order", "Offline Order" };
                int[] y = { online_order, offline_order };

                chart_Order.Series[0].ChartType = SeriesChartType.Pie;
                chart_Order.Series[0].Points.AddXY("Online Order", online_order);
                chart_Order.Series[0].Points.AddXY("Offline Order", offline_order);

                foreach (DataPoint p in chart_Order.Series[0].Points)
                {
                    p.Label = "#PERCENT\n#VALX";
                }

                chart_Order.Series[0].IsVisibleInLegend = false;

                label_OfflineOrder.Text = offline_order.ToString();
                label_OnlineOrder.Text = online_order.ToString();
                label_AllOrder.Text = (online_order + offline_order).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void LoadChartSales()
        {
            LoadChartSalesByOrder();
            LoadChartSalesByFood();
            LoadChartSalesByDate();
        }

        private void LoadChartSalesByOrder()
        {
            try
            {
                int online_order = STATISTIC.StatisticSalesByOrder(1);
                int offline_order = STATISTIC.StatisticSalesByOrder(2);
                chart_Sales_ByOrder.Series[0].ChartType = SeriesChartType.Pie;
                chart_Sales_ByOrder.Series[0].Points.AddXY("Online Order", online_order);
                chart_Sales_ByOrder.Series[0].Points.AddXY("Offline Order", offline_order);

                foreach (DataPoint p in chart_Sales_ByOrder.Series[0].Points)
                {
                    p.Label = "#PERCENT\n#VALX";
                }

                chart_Sales_ByOrder.Series[0].IsVisibleInLegend = false;

                label_Sales_OfflineOrder.Text = offline_order.ToString();
                label_Sales_OnlineOrder.Text = online_order.ToString();
                label_Sales_AllOrder.Text = (online_order + offline_order).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadChartSalesByFood()
        {
            try
            {
                DataTable sales_food_table = STATISTIC.StatisticSalesByFood();

                int total = 0;

                for (int i = 0; i < sales_food_table.Rows.Count; i++)
                {
                    String food = sales_food_table.Rows[i]["name"].ToString();
                    int cost = int.Parse(sales_food_table.Rows[i]["cost"].ToString());

                    chart_Sales_ByFood.Series[0].Points.AddXY(food, cost);
                    total += cost;
                }

                chart_Sales_ByFood.Series[0].IsValueShownAsLabel = true;
                chart_Sales_ByFood.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart_Sales_ByFood.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                label_Sales_TotalFood.Text = total.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadChartSalesByDate()
        {
            try
            {
                DataTable sales_date_table = STATISTIC.StatisticSalesByDate();

                for (int i = 0; i < sales_date_table.Rows.Count; i++)
                {
                    DateTime date = DateTime.Parse(sales_date_table.Rows[i]["date"].ToString());
                    int total = int.Parse(sales_date_table.Rows[i]["total"].ToString());

                    chart_Sales_ByDate.Series[0].Points.AddXY(date, total);
                }

                chart_Sales_ByDate.Series[0].IsValueShownAsLabel = true;
                chart_Sales_ByDate.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart_Sales_ByDate.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadChartPayroll()
        {
            try
            {
                DataTable payroll_table = STATISTIC.StatisticPayroll();

                for (int i = 0; i < payroll_table.Rows.Count; i++)
                {
                    String uname = payroll_table.Rows[i]["username"].ToString();
                    int salary = int.Parse(payroll_table.Rows[i]["total"].ToString());

                    if(salary>0)
                    {
                        chart_Payroll.Series[0].Points.AddXY(uname, salary);
                    }                 
                }

                chart_Payroll.Series[0].IsValueShownAsLabel = true;
                chart_Payroll.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart_Payroll.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string month_number_to_string(int n)
        {
            string[] month = {"January","February","March","April","May","June","July","August","September","October","November","December" };

            return month[n - 1];
        }

        private void LoadChartProfit()
        {
            try
            {
                DataTable profit_table = STATISTIC.StatisticProfit(DateTime.Now.Year);

                for(int i=0;i<profit_table.Rows.Count;i++)
                {
                    string month= profit_table.Rows[i]["Month"].ToString();
                    string total = profit_table.Rows[i]["Total_Sales"].ToString();

                    if(Int32.Parse(total)>0)
                    {
                        month = month_number_to_string(Int32.Parse(month));
                        chart_Profit.Series[0].Points.AddXY(month, total);
                    }
                }

                chart_Profit.Series[0].IsValueShownAsLabel = true;
                chart_Profit.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                chart_Profit.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
