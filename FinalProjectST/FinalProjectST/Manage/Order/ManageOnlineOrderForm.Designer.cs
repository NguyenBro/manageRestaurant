
namespace FinalProjectST
{
    partial class ManageOnlineOrderForm
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
            this.button_Close = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel_NoConfirm = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_Confirmed = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_NoConfirm = new System.Windows.Forms.TabPage();
            this.tabPage_Confirmed = new System.Windows.Forms.TabPage();
            this.tabPage_Denied = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel_Denied = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage_NoConfirm.SuspendLayout();
            this.tabPage_Confirmed.SuspendLayout();
            this.tabPage_Denied.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE ONLINE ORDER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Close
            // 
            this.button_Close.BorderRadius = 15;
            this.button_Close.CheckedState.Parent = this.button_Close;
            this.button_Close.CustomImages.Parent = this.button_Close;
            this.button_Close.FillColor = System.Drawing.Color.DimGray;
            this.button_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.HoverState.Parent = this.button_Close;
            this.button_Close.Location = new System.Drawing.Point(416, 429);
            this.button_Close.Name = "button_Close";
            this.button_Close.ShadowDecoration.Parent = this.button_Close;
            this.button_Close.Size = new System.Drawing.Size(148, 34);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "CLOSE";
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // flowLayoutPanel_NoConfirm
            // 
            this.flowLayoutPanel_NoConfirm.AutoScroll = true;
            this.flowLayoutPanel_NoConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_NoConfirm.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel_NoConfirm.Name = "flowLayoutPanel_NoConfirm";
            this.flowLayoutPanel_NoConfirm.Size = new System.Drawing.Size(950, 329);
            this.flowLayoutPanel_NoConfirm.TabIndex = 3;
            // 
            // flowLayoutPanel_Confirmed
            // 
            this.flowLayoutPanel_Confirmed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Confirmed.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel_Confirmed.Name = "flowLayoutPanel_Confirmed";
            this.flowLayoutPanel_Confirmed.Size = new System.Drawing.Size(950, 329);
            this.flowLayoutPanel_Confirmed.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_NoConfirm);
            this.tabControl1.Controls.Add(this.tabPage_Confirmed);
            this.tabControl1.Controls.Add(this.tabPage_Denied);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 53);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(970, 370);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage_NoConfirm
            // 
            this.tabPage_NoConfirm.Controls.Add(this.flowLayoutPanel_NoConfirm);
            this.tabPage_NoConfirm.Location = new System.Drawing.Point(4, 25);
            this.tabPage_NoConfirm.Name = "tabPage_NoConfirm";
            this.tabPage_NoConfirm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_NoConfirm.Size = new System.Drawing.Size(962, 341);
            this.tabPage_NoConfirm.TabIndex = 0;
            this.tabPage_NoConfirm.Text = "No Confirm";
            this.tabPage_NoConfirm.UseVisualStyleBackColor = true;
            // 
            // tabPage_Confirmed
            // 
            this.tabPage_Confirmed.Controls.Add(this.flowLayoutPanel_Confirmed);
            this.tabPage_Confirmed.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Confirmed.Name = "tabPage_Confirmed";
            this.tabPage_Confirmed.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Confirmed.Size = new System.Drawing.Size(962, 341);
            this.tabPage_Confirmed.TabIndex = 1;
            this.tabPage_Confirmed.Text = "Confirmed";
            this.tabPage_Confirmed.UseVisualStyleBackColor = true;
            // 
            // tabPage_Denied
            // 
            this.tabPage_Denied.Controls.Add(this.flowLayoutPanel_Denied);
            this.tabPage_Denied.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Denied.Name = "tabPage_Denied";
            this.tabPage_Denied.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Denied.Size = new System.Drawing.Size(962, 341);
            this.tabPage_Denied.TabIndex = 2;
            this.tabPage_Denied.Text = "Denied";
            this.tabPage_Denied.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel_Denied
            // 
            this.flowLayoutPanel_Denied.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel_Denied.Location = new System.Drawing.Point(3, 6);
            this.flowLayoutPanel_Denied.Name = "flowLayoutPanel_Denied";
            this.flowLayoutPanel_Denied.Size = new System.Drawing.Size(956, 329);
            this.flowLayoutPanel_Denied.TabIndex = 0;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(109)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(113)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(994, 473);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // ManageOnlineOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 477);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "ManageOnlineOrderForm";
            this.Text = "ManageOnlineOrderForm";
            this.Load += new System.EventHandler(this.ManageOnlineOrderForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_NoConfirm.ResumeLayout(false);
            this.tabPage_Confirmed.ResumeLayout(false);
            this.tabPage_Denied.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button button_Close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_NoConfirm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Confirmed;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_NoConfirm;
        private System.Windows.Forms.TabPage tabPage_Confirmed;
        private System.Windows.Forms.TabPage tabPage_Denied;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Denied;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}