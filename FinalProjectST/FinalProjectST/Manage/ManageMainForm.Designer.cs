
namespace FinalProjectST
{
    partial class ManageMainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableBookedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableFreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderOnlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageFoodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewShiftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_logout = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.flowLayoutPanel_Table = new System.Windows.Forms.FlowLayoutPanel();
            this.label_Name = new System.Windows.Forms.Label();
            this.button_home = new Guna.UI2.WinForms.Guna2Button();
            this.button_EditInfo = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.menuStrip1.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tableToolStripMenuItem,
            this.orderOnlineToolStripMenuItem,
            this.manageFoodToolStripMenuItem,
            this.manageMaterialToolStripMenuItem,
            this.manageEmployeeToolStripMenuItem,
            this.manageShiftToolStripMenuItem,
            this.statisticToolStripMenuItem,
            this.salaryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(105, 65);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1125, 38);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tableToolStripMenuItem
            // 
            this.tableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allTableToolStripMenuItem,
            this.tableBookedToolStripMenuItem,
            this.tableFreeToolStripMenuItem});
            this.tableToolStripMenuItem.Name = "tableToolStripMenuItem";
            this.tableToolStripMenuItem.Size = new System.Drawing.Size(75, 34);
            this.tableToolStripMenuItem.Text = "Table";
            this.tableToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // allTableToolStripMenuItem
            // 
            this.allTableToolStripMenuItem.Name = "allTableToolStripMenuItem";
            this.allTableToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.allTableToolStripMenuItem.Text = "All Table";
            this.allTableToolStripMenuItem.Click += new System.EventHandler(this.allTableToolStripMenuItem_Click);
            // 
            // tableBookedToolStripMenuItem
            // 
            this.tableBookedToolStripMenuItem.Name = "tableBookedToolStripMenuItem";
            this.tableBookedToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.tableBookedToolStripMenuItem.Text = "Table Booked";
            this.tableBookedToolStripMenuItem.Click += new System.EventHandler(this.tableBookedToolStripMenuItem_Click);
            // 
            // tableFreeToolStripMenuItem
            // 
            this.tableFreeToolStripMenuItem.Name = "tableFreeToolStripMenuItem";
            this.tableFreeToolStripMenuItem.Size = new System.Drawing.Size(217, 28);
            this.tableFreeToolStripMenuItem.Text = "Table Free";
            this.tableFreeToolStripMenuItem.Click += new System.EventHandler(this.tableFreeToolStripMenuItem_Click);
            // 
            // orderOnlineToolStripMenuItem
            // 
            this.orderOnlineToolStripMenuItem.Name = "orderOnlineToolStripMenuItem";
            this.orderOnlineToolStripMenuItem.Size = new System.Drawing.Size(149, 34);
            this.orderOnlineToolStripMenuItem.Text = "Order Online";
            this.orderOnlineToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.orderOnlineToolStripMenuItem.Click += new System.EventHandler(this.orderOnlineToolStripMenuItem_Click);
            // 
            // manageFoodToolStripMenuItem
            // 
            this.manageFoodToolStripMenuItem.Name = "manageFoodToolStripMenuItem";
            this.manageFoodToolStripMenuItem.Size = new System.Drawing.Size(159, 34);
            this.manageFoodToolStripMenuItem.Text = "Manage Food";
            this.manageFoodToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageFoodToolStripMenuItem.Click += new System.EventHandler(this.manageFoodToolStripMenuItem_Click);
            // 
            // manageMaterialToolStripMenuItem
            // 
            this.manageMaterialToolStripMenuItem.Name = "manageMaterialToolStripMenuItem";
            this.manageMaterialToolStripMenuItem.Size = new System.Drawing.Size(185, 34);
            this.manageMaterialToolStripMenuItem.Text = "Manage Material";
            this.manageMaterialToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageMaterialToolStripMenuItem.Click += new System.EventHandler(this.manageMaterialToolStripMenuItem_Click);
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.AutoSize = false;
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(206, 28);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            this.manageEmployeeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // manageShiftToolStripMenuItem
            // 
            this.manageShiftToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitShiftToolStripMenuItem,
            this.viewShiftToolStripMenuItem});
            this.manageShiftToolStripMenuItem.Name = "manageShiftToolStripMenuItem";
            this.manageShiftToolStripMenuItem.Size = new System.Drawing.Size(153, 34);
            this.manageShiftToolStripMenuItem.Text = "Manage Shift";
            // 
            // splitShiftToolStripMenuItem
            // 
            this.splitShiftToolStripMenuItem.Name = "splitShiftToolStripMenuItem";
            this.splitShiftToolStripMenuItem.Size = new System.Drawing.Size(196, 28);
            this.splitShiftToolStripMenuItem.Text = "Split Shift";
            this.splitShiftToolStripMenuItem.Click += new System.EventHandler(this.splitShiftToolStripMenuItem_Click);
            // 
            // viewShiftToolStripMenuItem
            // 
            this.viewShiftToolStripMenuItem.Name = "viewShiftToolStripMenuItem";
            this.viewShiftToolStripMenuItem.Size = new System.Drawing.Size(196, 28);
            this.viewShiftToolStripMenuItem.Text = "Watch Shift";
            this.viewShiftToolStripMenuItem.Click += new System.EventHandler(this.viewShiftToolStripMenuItem_Click);
            // 
            // statisticToolStripMenuItem
            // 
            this.statisticToolStripMenuItem.Name = "statisticToolStripMenuItem";
            this.statisticToolStripMenuItem.Size = new System.Drawing.Size(103, 34);
            this.statisticToolStripMenuItem.Text = "Statistic";
            this.statisticToolStripMenuItem.Click += new System.EventHandler(this.statisticToolStripMenuItem_Click);
            // 
            // salaryToolStripMenuItem
            // 
            this.salaryToolStripMenuItem.Name = "salaryToolStripMenuItem";
            this.salaryToolStripMenuItem.Size = new System.Drawing.Size(84, 34);
            this.salaryToolStripMenuItem.Text = "Salary";
            this.salaryToolStripMenuItem.Click += new System.EventHandler(this.salaryToolStripMenuItem_Click);
            // 
            // button_logout
            // 
            this.button_logout.BackColor = System.Drawing.Color.Transparent;
            this.button_logout.BorderRadius = 10;
            this.button_logout.CheckedState.Parent = this.button_logout;
            this.button_logout.CustomImages.Parent = this.button_logout;
            this.button_logout.FillColor = System.Drawing.Color.Red;
            this.button_logout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_logout.ForeColor = System.Drawing.Color.White;
            this.button_logout.HoverState.Parent = this.button_logout;
            this.button_logout.Location = new System.Drawing.Point(1000, 11);
            this.button_logout.Name = "button_logout";
            this.button_logout.ShadowDecoration.Parent = this.button_logout;
            this.button_logout.Size = new System.Drawing.Size(180, 45);
            this.button_logout.TabIndex = 3;
            this.button_logout.Text = "LOGOUT";
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.flowLayoutPanel_Table);
            this.guna2CustomGradientPanel1.Controls.Add(this.label_Name);
            this.guna2CustomGradientPanel1.Controls.Add(this.button_home);
            this.guna2CustomGradientPanel1.Controls.Add(this.button_logout);
            this.guna2CustomGradientPanel1.Controls.Add(this.menuStrip1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(237)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(234)))), ((int)(((byte)(221)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(230)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(244)))), ((int)(((byte)(123)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(2, 1);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1251, 515);
            this.guna2CustomGradientPanel1.TabIndex = 5;
            // 
            // flowLayoutPanel_Table
            // 
            this.flowLayoutPanel_Table.AutoScroll = true;
            this.flowLayoutPanel_Table.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_Table.Location = new System.Drawing.Point(110, 106);
            this.flowLayoutPanel_Table.Name = "flowLayoutPanel_Table";
            this.flowLayoutPanel_Table.Size = new System.Drawing.Size(1120, 421);
            this.flowLayoutPanel_Table.TabIndex = 12;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.BackColor = System.Drawing.Color.Transparent;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.ForeColor = System.Drawing.Color.Black;
            this.label_Name.Location = new System.Drawing.Point(126, 21);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(51, 20);
            this.label_Name.TabIndex = 11;
            this.label_Name.Text = "label1";
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.Transparent;
            this.button_home.BorderRadius = 10;
            this.button_home.CheckedState.Parent = this.button_home;
            this.button_home.CustomImages.Parent = this.button_home;
            this.button_home.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_home.ForeColor = System.Drawing.Color.White;
            this.button_home.HoverState.Parent = this.button_home;
            this.button_home.Location = new System.Drawing.Point(800, 11);
            this.button_home.Name = "button_home";
            this.button_home.ShadowDecoration.Parent = this.button_home;
            this.button_home.Size = new System.Drawing.Size(180, 45);
            this.button_home.TabIndex = 6;
            this.button_home.Text = "HOME";
            this.button_home.Click += new System.EventHandler(this.button_home_Click);
            // 
            // button_EditInfo
            // 
            this.button_EditInfo.CheckedState.Parent = this.button_EditInfo;
            this.button_EditInfo.CustomImages.Parent = this.button_EditInfo;
            this.button_EditInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_EditInfo.ForeColor = System.Drawing.Color.White;
            this.button_EditInfo.HoverState.Parent = this.button_EditInfo;
            this.button_EditInfo.Location = new System.Drawing.Point(3, 112);
            this.button_EditInfo.Name = "button_EditInfo";
            this.button_EditInfo.ShadowDecoration.Parent = this.button_EditInfo;
            this.button_EditInfo.Size = new System.Drawing.Size(101, 31);
            this.button_EditInfo.TabIndex = 13;
            this.button_EditInfo.Text = "Edit Infomation";
            this.button_EditInfo.Click += new System.EventHandler(this.button_EditInfo_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImage = global::FinalProjectST.Properties.Resources.faceEmployee;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(109, 103);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2CustomGradientPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guna2CustomGradientPanel2.BorderRadius = 50;
            this.guna2CustomGradientPanel2.Controls.Add(this.button_EditInfo);
            this.guna2CustomGradientPanel2.Controls.Add(this.guna2PictureBox1);
            this.guna2CustomGradientPanel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(60)))), ((int)(((byte)(242)))));
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(154)))), ((int)(((byte)(239)))));
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(117)))), ((int)(((byte)(231)))));
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(239)))), ((int)(((byte)(86)))));
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(2, 1);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.ShadowDecoration.Parent = this.guna2CustomGradientPanel2;
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(109, 515);
            this.guna2CustomGradientPanel2.TabIndex = 13;
            // 
            // ManageMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1244, 531);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "ManageMainForm";
            this.Text = "ManageMainForm";
            this.Load += new System.EventHandler(this.ManageMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableBookedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableFreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderOnlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageFoodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button button_logout;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.ToolStripMenuItem manageShiftToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button button_home;
        private System.Windows.Forms.ToolStripMenuItem statisticToolStripMenuItem;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.ToolStripMenuItem splitShiftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewShiftToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Table;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private Guna.UI2.WinForms.Guna2Button button_EditInfo;
        private System.Windows.Forms.ToolStripMenuItem salaryToolStripMenuItem;
    }
}