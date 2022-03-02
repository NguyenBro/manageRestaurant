
namespace FinalProjectST
{
    partial class StaffViewSalaryForm
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
            this.button_Static = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Static
            // 
            this.button_Static.BorderRadius = 20;
            this.button_Static.CheckedState.Parent = this.button_Static;
            this.button_Static.CustomImages.Parent = this.button_Static;
            this.button_Static.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Static.ForeColor = System.Drawing.Color.White;
            this.button_Static.HoverState.Parent = this.button_Static;
            this.button_Static.Location = new System.Drawing.Point(176, 444);
            this.button_Static.Name = "button_Static";
            this.button_Static.ShadowDecoration.Parent = this.button_Static;
            this.button_Static.Size = new System.Drawing.Size(180, 45);
            this.button_Static.TabIndex = 42;
            this.button_Static.Text = "STATIC";
            this.button_Static.Click += new System.EventHandler(this.button_Static_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(501, 347);
            this.dataGridView1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 38);
            this.label1.TabIndex = 40;
            this.label1.Text = "SALARY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.button_Static);
            this.guna2GradientPanel1.Controls.Add(this.dataGridView1);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-1, -1);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(523, 502);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // StaffViewSalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 500);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "StaffViewSalaryForm";
            this.Text = "StaffViewForm";
            this.Load += new System.EventHandler(this.StaffViewSalaryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button button_Static;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}