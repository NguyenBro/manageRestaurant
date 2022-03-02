
namespace FinalProjectST
{
    partial class CustomerMainForm
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
            this.label_Name = new System.Windows.Forms.Label();
            this.button_logout = new Guna.UI2.WinForms.Guna2Button();
            this.button_Order = new Guna.UI2.WinForms.Guna2Button();
            this.button_Book = new Guna.UI2.WinForms.Guna2Button();
            this.Button_Pay = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_Ordered = new System.Windows.Forms.DataGridView();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label_Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_EditInfo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ordered)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(12, 21);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(341, 45);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "label1";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Transparent;
            this.button_logout.BorderRadius = 20;
            this.button_logout.CheckedState.Parent = this.button_logout;
            this.button_logout.CustomBorderColor = System.Drawing.Color.Transparent;
            this.button_logout.CustomImages.Parent = this.button_logout;
            this.button_logout.FillColor = System.Drawing.Color.Red;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.HoverState.Parent = this.button_logout;
            this.button_logout.Location = new System.Drawing.Point(686, 18);
            this.button_logout.Name = "button_logout";
            this.button_logout.ShadowDecoration.Parent = this.button_logout;
            this.button_logout.Size = new System.Drawing.Size(180, 45);
            this.button_logout.TabIndex = 1;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_Order
            // 
            this.button_Order.BackColor = System.Drawing.Color.Transparent;
            this.button_Order.BorderRadius = 15;
            this.button_Order.CheckedState.Parent = this.button_Order;
            this.button_Order.CustomImages.Parent = this.button_Order;
            this.button_Order.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Order.ForeColor = System.Drawing.Color.White;
            this.button_Order.HoverState.Parent = this.button_Order;
            this.button_Order.Location = new System.Drawing.Point(369, 421);
            this.button_Order.Name = "button_Order";
            this.button_Order.ShadowDecoration.Parent = this.button_Order;
            this.button_Order.Size = new System.Drawing.Size(180, 45);
            this.button_Order.TabIndex = 11;
            this.button_Order.Text = "Order";
            this.button_Order.Click += new System.EventHandler(this.Button_Order_Click);
            // 
            // button_Book
            // 
            this.button_Book.BackColor = System.Drawing.Color.Transparent;
            this.button_Book.BorderRadius = 15;
            this.button_Book.CheckedState.Parent = this.button_Book;
            this.button_Book.CustomImages.Parent = this.button_Book;
            this.button_Book.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Book.ForeColor = System.Drawing.Color.White;
            this.button_Book.HoverState.Parent = this.button_Book;
            this.button_Book.Location = new System.Drawing.Point(116, 421);
            this.button_Book.Name = "button_Book";
            this.button_Book.ShadowDecoration.Parent = this.button_Book;
            this.button_Book.Size = new System.Drawing.Size(180, 45);
            this.button_Book.TabIndex = 10;
            this.button_Book.Text = "Book";
            this.button_Book.Click += new System.EventHandler(this.button_Book_Click);
            // 
            // Button_Pay
            // 
            this.Button_Pay.BackColor = System.Drawing.Color.Transparent;
            this.Button_Pay.BorderRadius = 15;
            this.Button_Pay.CheckedState.Parent = this.Button_Pay;
            this.Button_Pay.CustomImages.Parent = this.Button_Pay;
            this.Button_Pay.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Pay.ForeColor = System.Drawing.Color.White;
            this.Button_Pay.HoverState.Parent = this.Button_Pay;
            this.Button_Pay.Location = new System.Drawing.Point(616, 421);
            this.Button_Pay.Name = "Button_Pay";
            this.Button_Pay.ShadowDecoration.Parent = this.Button_Pay;
            this.Button_Pay.Size = new System.Drawing.Size(180, 45);
            this.Button_Pay.TabIndex = 9;
            this.Button_Pay.Text = "Pay";
            this.Button_Pay.Click += new System.EventHandler(this.Button_Pay_Click);
            // 
            // dataGridView_Ordered
            // 
            this.dataGridView_Ordered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ordered.Location = new System.Drawing.Point(12, 105);
            this.dataGridView_Ordered.Name = "dataGridView_Ordered";
            this.dataGridView_Ordered.Size = new System.Drawing.Size(853, 266);
            this.dataGridView_Ordered.TabIndex = 13;
   
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.BorderRadius = 18;
            this.guna2CustomGradientPanel2.Controls.Add(this.label_Total);
            this.guna2CustomGradientPanel2.Controls.Add(this.label2);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(449, 370);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(416, 45);
            this.guna2CustomGradientPanel2.TabIndex = 14;
            // 
            // label_Total
            // 
            this.label_Total.BackColor = System.Drawing.Color.Transparent;
            this.label_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Total.ForeColor = System.Drawing.Color.White;
            this.label_Total.Location = new System.Drawing.Point(209, 7);
            this.label_Total.Name = "label_Total";
            this.label_Total.Size = new System.Drawing.Size(160, 29);
            this.label_Total.TabIndex = 3;
            this.label_Total.Text = "0";
            this.label_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Payment:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Your Order";
            // 
            // button_EditInfo
            // 
            this.button_EditInfo.BackColor = System.Drawing.Color.Transparent;
            this.button_EditInfo.BorderRadius = 20;
            this.button_EditInfo.CheckedState.Parent = this.button_EditInfo;
            this.button_EditInfo.CustomImages.Parent = this.button_EditInfo;
            this.button_EditInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_EditInfo.ForeColor = System.Drawing.Color.White;
            this.button_EditInfo.HoverState.Parent = this.button_EditInfo;
            this.button_EditInfo.Location = new System.Drawing.Point(490, 18);
            this.button_EditInfo.Name = "button_EditInfo";
            this.button_EditInfo.ShadowDecoration.Parent = this.button_EditInfo;
            this.button_EditInfo.Size = new System.Drawing.Size(180, 45);
            this.button_EditInfo.TabIndex = 16;
            this.button_EditInfo.Text = "Edit Your Infomation";
            this.button_EditInfo.Click += new System.EventHandler(this.button_EditInfo_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.button_EditInfo);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2CustomGradientPanel2);
            this.guna2CustomGradientPanel1.Controls.Add(this.button_logout);
            this.guna2CustomGradientPanel1.Controls.Add(this.Button_Pay);
            this.guna2CustomGradientPanel1.Controls.Add(this.button_Book);
            this.guna2CustomGradientPanel1.Controls.Add(this.button_Order);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(113)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(188)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 3);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(883, 479);
            this.guna2CustomGradientPanel1.TabIndex = 17;
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 481);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Ordered);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "CustomerMainForm";
            this.Text = "CustomerMainForm";
            this.Load += new System.EventHandler(this.CustomerMainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ordered)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private Guna.UI2.WinForms.Guna2Button button_logout;
        private Guna.UI2.WinForms.Guna2Button button_Order;
        private Guna.UI2.WinForms.Guna2Button button_Book;
        private Guna.UI2.WinForms.Guna2Button Button_Pay;
        private System.Windows.Forms.DataGridView dataGridView_Ordered;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label_Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button button_EditInfo;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
    }
}