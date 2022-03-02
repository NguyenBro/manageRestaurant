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
    public partial class SplitShiftForm : Form
    {
        public SplitShiftForm()
        {
            InitializeComponent();
        }

        private void button_Split_Click(object sender, EventArgs e)
        {
            //Xoa Cai Chia Ca Lan Truoc
            DateTime day = guna2DateTimePickerDate.Value;
            MANAGER.deleteDateNow(day);

            // Split_Shift(1);
            DataTable table = MANAGER.getTablePosition();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                int id_pos = Convert.ToInt32(table.Rows[i]["id"].ToString());
                //Khong Chia Manager
                if (id_pos != 1)
                {

                    Split_Shift(id_pos, day);
                }

            }
            fillData();
            MessageBox.Show("Divided shifts for employees", "successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void Split_Shift(int id_pos, DateTime day)
        {

            //Truoc Khi Chia Ca ,Thuc Hien Xuong Ca Cu


            int totalE = MANAGER.totalEmployees(id_pos);

            //MessageBox.Show("tong=" + s);
            if (totalE <= 2)
            {
                string name = MANAGER.getNamePosition(id_pos);
                MessageBox.Show(name + ": Not Enough Person,Minimum 3 employees", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                //Mang 2 chieu chia Ca cho CV
                int m = 3;
                int n = totalE;
                int skip = n * 2;
                int[,] Arr = new int[m, n];
                for (int a = 0; a < m; a++)
                {
                    for (int b = 0; b < n; b++)
                        Arr[a, b] = 0;
                }

                int i = 0;
                int j = 0;
                while (skip != 0)
                {
                    Arr[i, j] = 1;
                    if (i < m - 1 && j < n - 1)
                    {
                        i++;
                        j++;
                    }

                    else if (i == m - 1 && j < n - 1)
                    {
                        i = 0;
                        j++;
                    }
                    else if (i < m - 1 && j == n - 1)
                    {
                        i++;
                        j = 0;
                    }

                    else
                    {
                        i = 1;
                        j = 0;
                    }
                    skip--;
                }


                int point = Convert.ToInt32(guna2DateTimePickerDate.Value.Day) % totalE;


                DataTable table = MANAGER.getTableEmployee(id_pos);


                for (i = 0; i < totalE; i++)
                {

                    int id = Convert.ToInt32(table.Rows[point]["id"].ToString());

                    if (Arr[0, i] == 1 && Arr[1, i] == 1)
                    {

                        MANAGER.Insert_Allocation(id, day, 2, "NO", 0);
                        MANAGER.Insert_Allocation(id, day, 3, "NO", 0);

                    }

                    else if (Arr[1, i] == 1 && Arr[2, i] == 1)
                    {

                        MANAGER.Insert_Allocation(id, day, 1, "NO", 0);
                        MANAGER.Insert_Allocation(id, day, 2, "NO", 0);

                    }

                    else if (Arr[0, i] == 1 && Arr[2, i] == 1)
                    {
                        MANAGER.Insert_Allocation(id, day, 1, "NO", 0);
                        MANAGER.Insert_Allocation(id, day, 3, "NO", 0);

                    }

                    else
                        MessageBox.Show("BUG");

                    point++;
                    if (point == totalE)
                        point = 0;
                }

                //==============Reload DataGridview

            }

        }

        public void fillData()
        {


            //======================
            DateTime date = guna2DateTimePickerDate.Value;
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 60;
            dataGridView1.DataSource = MANAGER.getTableSplitShift(date);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToAddRows = false;
            ChangeColor();

        }

        private void button_Watch_Click(object sender, EventArgs e)
        {
            WatchShiftForm f = new WatchShiftForm();
            f.Show(this);
        }

        private void ChangeColor()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {


                //============
                if (dataGridView1.Rows[i].Cells[3].Value.ToString().Trim() == "1")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#7a6af7");

                }
                else if (dataGridView1.Rows[i].Cells[3].Value.ToString().Trim() == "2")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#513bf7");

                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2509f7");

                }

                //==========f2b36f

            }
        }

        private void SplitShiftForm_Load(object sender, EventArgs e)
        {
            guna2DateTimePickerDate.Value = DateTime.Today;
        }
    }
}
