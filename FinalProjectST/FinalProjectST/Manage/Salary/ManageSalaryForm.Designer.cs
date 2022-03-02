
namespace FinalProjectST
{
    partial class ManageSalaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Pay = new Guna.UI2.WinForms.Guna2Button();
            this.button_Refresh = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_Salary = new System.Windows.Forms.DataGridView();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Salary)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 39;
            this.label1.Text = "MANAGE SALARY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Search
            // 
            this.button_Search.CheckedState.Parent = this.button_Search;
            this.button_Search.CustomImages.Parent = this.button_Search;
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.HoverState.Parent = this.button_Search;
            this.button_Search.Location = new System.Drawing.Point(589, 76);
            this.button_Search.Name = "button_Search";
            this.button_Search.ShadowDecoration.Parent = this.button_Search;
            this.button_Search.Size = new System.Drawing.Size(100, 32);
            this.button_Search.TabIndex = 18;
            this.button_Search.Text = "Search";
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textbox_Search
            // 
            this.textbox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_Search.DefaultText = "";
            this.textbox_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Search.DisabledState.Parent = this.textbox_Search;
            this.textbox_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Search.FocusedState.Parent = this.textbox_Search;
            this.textbox_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Search.HoverState.Parent = this.textbox_Search;
            this.textbox_Search.Location = new System.Drawing.Point(269, 76);
            this.textbox_Search.Name = "textbox_Search";
            this.textbox_Search.PasswordChar = '\0';
            this.textbox_Search.PlaceholderText = "Search by Date, Name ...";
            this.textbox_Search.SelectedText = "";
            this.textbox_Search.ShadowDecoration.Parent = this.textbox_Search;
            this.textbox_Search.Size = new System.Drawing.Size(305, 32);
            this.textbox_Search.TabIndex = 17;
            // 
            // button_Pay
            // 
            this.button_Pay.BorderRadius = 20;
            this.button_Pay.CheckedState.Parent = this.button_Pay;
            this.button_Pay.CustomImages.Parent = this.button_Pay;
            this.button_Pay.FillColor = System.Drawing.Color.Red;
            this.button_Pay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Pay.ForeColor = System.Drawing.Color.White;
            this.button_Pay.HoverState.Parent = this.button_Pay;
            this.button_Pay.Location = new System.Drawing.Point(403, 622);
            this.button_Pay.Name = "button_Pay";
            this.button_Pay.ShadowDecoration.Parent = this.button_Pay;
            this.button_Pay.Size = new System.Drawing.Size(180, 45);
            this.button_Pay.TabIndex = 13;
            this.button_Pay.Text = "PAY FOR EMPLOYEES";
            this.button_Pay.Click += new System.EventHandler(this.button_Pay_Click);
            // 
            // button_Refresh
            // 
            this.button_Refresh.BorderRadius = 20;
            this.button_Refresh.CheckedState.Parent = this.button_Refresh;
            this.button_Refresh.CustomImages.Parent = this.button_Refresh;
            this.button_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Refresh.ForeColor = System.Drawing.Color.White;
            this.button_Refresh.HoverState.Parent = this.button_Refresh;
            this.button_Refresh.Location = new System.Drawing.Point(119, 622);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.ShadowDecoration.Parent = this.button_Refresh;
            this.button_Refresh.Size = new System.Drawing.Size(180, 45);
            this.button_Refresh.TabIndex = 12;
            this.button_Refresh.Text = "REFRESH";
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // dataGridView_Salary
            // 
            this.dataGridView_Salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Salary.Location = new System.Drawing.Point(10, 123);
            this.dataGridView_Salary.Name = "dataGridView_Salary";
            this.dataGridView_Salary.Size = new System.Drawing.Size(679, 478);
            this.dataGridView_Salary.TabIndex = 0;
            this.dataGridView_Salary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.button_Search);
            this.guna2GradientPanel1.Controls.Add(this.textbox_Search);
            this.guna2GradientPanel1.Controls.Add(this.button_Pay);
            this.guna2GradientPanel1.Controls.Add(this.button_Refresh);
            this.guna2GradientPanel1.Controls.Add(this.dataGridView_Salary);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(1, 3);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(701, 675);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // ManageSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 680);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "ManageSalaryForm";
            this.Text = "ManageSalaryForm";
            this.Load += new System.EventHandler(this.ManageSalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Salary)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Search;
        private Guna.UI2.WinForms.Guna2Button button_Pay;
        private Guna.UI2.WinForms.Guna2Button button_Refresh;
        private System.Windows.Forms.DataGridView dataGridView_Salary;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}