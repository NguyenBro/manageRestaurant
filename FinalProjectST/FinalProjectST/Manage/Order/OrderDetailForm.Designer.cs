
namespace FinalProjectST
{
    partial class OrderDetailForm
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
            this.label_OrderID = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Cost = new System.Windows.Forms.Label();
            this.dataGridView_Ordered = new System.Windows.Forms.DataGridView();
            this.button_Close = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Phone = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ordered)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ORDER DETAIL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_OrderID
            // 
            this.label_OrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_OrderID.Location = new System.Drawing.Point(43, 63);
            this.label_OrderID.Name = "label_OrderID";
            this.label_OrderID.Size = new System.Drawing.Size(90, 20);
            this.label_OrderID.TabIndex = 1;
            this.label_OrderID.Text = "label2";
            // 
            // label_Email
            // 
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(43, 126);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(316, 15);
            this.label_Email.TabIndex = 2;
            this.label_Email.Text = "label3";
            // 
            // label_Cost
            // 
            this.label_Cost.AutoSize = true;
            this.label_Cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Cost.Location = new System.Drawing.Point(426, 65);
            this.label_Cost.Name = "label_Cost";
            this.label_Cost.Size = new System.Drawing.Size(41, 15);
            this.label_Cost.TabIndex = 3;
            this.label_Cost.Text = "label4";
            // 
            // dataGridView_Ordered
            // 
            this.dataGridView_Ordered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ordered.Location = new System.Drawing.Point(12, 181);
            this.dataGridView_Ordered.Name = "dataGridView_Ordered";
            this.dataGridView_Ordered.Size = new System.Drawing.Size(776, 233);
            this.dataGridView_Ordered.TabIndex = 4;
            // 
            // button_Close
            // 
            this.button_Close.BorderRadius = 15;
            this.button_Close.CheckedState.Parent = this.button_Close;
            this.button_Close.CustomImages.Parent = this.button_Close;
            this.button_Close.FillColor = System.Drawing.Color.Teal;
            this.button_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.HoverState.Parent = this.button_Close;
            this.button_Close.Location = new System.Drawing.Point(307, 420);
            this.button_Close.Name = "button_Close";
            this.button_Close.ShadowDecoration.Parent = this.button_Close;
            this.button_Close.Size = new System.Drawing.Size(180, 37);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "CLOSE";
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.Controls.Add(this.label_Email);
            this.guna2GradientPanel1.Controls.Add(this.label_Address);
            this.guna2GradientPanel1.Controls.Add(this.button_Close);
            this.guna2GradientPanel1.Controls.Add(this.label_Phone);
            this.guna2GradientPanel1.Controls.Add(this.dataGridView_Ordered);
            this.guna2GradientPanel1.Controls.Add(this.label_Name);
            this.guna2GradientPanel1.Controls.Add(this.label_Cost);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(188)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 3);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(798, 460);
            this.guna2GradientPanel1.TabIndex = 6;
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(43, 89);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(199, 28);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "label3";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Phone
            // 
            this.label_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Phone.Location = new System.Drawing.Point(426, 126);
            this.label_Phone.Name = "label_Phone";
            this.label_Phone.Size = new System.Drawing.Size(252, 15);
            this.label_Phone.TabIndex = 8;
            this.label_Phone.Text = "label3";
            // 
            // label_Address
            // 
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.Location = new System.Drawing.Point(43, 150);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(568, 15);
            this.label_Address.TabIndex = 9;
            this.label_Address.Text = "label4";
            // 
            // OrderDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.label_OrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "OrderDetailForm";
            this.Text = "OrderDetailForm";
            this.Load += new System.EventHandler(this.OrderDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ordered)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_OrderID;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Cost;
        private System.Windows.Forms.DataGridView dataGridView_Ordered;
        private Guna.UI2.WinForms.Guna2Button button_Close;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label_Phone;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Address;
    }
}