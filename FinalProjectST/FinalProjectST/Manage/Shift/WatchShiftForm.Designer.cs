
namespace FinalProjectST
{
    partial class WatchShiftForm
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
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFind = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textbox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_Shift = new System.Windows.Forms.DataGridView();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Shift)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.buttonFind);
            this.guna2CustomGradientPanel1.Controls.Add(this.textbox_Search);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Button1);
            this.guna2CustomGradientPanel1.Controls.Add(this.dataGridView_Shift);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(237)))));
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(238)))), ((int)(((byte)(48)))));
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(139)))), ((int)(((byte)(230)))));
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(244)))), ((int)(((byte)(123)))));
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(-1, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.ShadowDecoration.Parent = this.guna2CustomGradientPanel1;
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(811, 615);
            this.guna2CustomGradientPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(239, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 46);
            this.label1.TabIndex = 27;
            this.label1.Text = "MANAGE SHIFT";
            // 
            // buttonFind
            // 
            this.buttonFind.CheckedState.Parent = this.buttonFind;
            this.buttonFind.CustomImages.Parent = this.buttonFind;
            this.buttonFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonFind.ForeColor = System.Drawing.Color.White;
            this.buttonFind.HoverState.Parent = this.buttonFind;
            this.buttonFind.Location = new System.Drawing.Point(725, 107);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.ShadowDecoration.Parent = this.buttonFind;
            this.buttonFind.Size = new System.Drawing.Size(58, 32);
            this.buttonFind.TabIndex = 26;
            this.buttonFind.Text = "FIND";
            this.buttonFind.Click += new System.EventHandler(this.guna2GradientButtonFind_Click);
            // 
            // textbox_Search
            // 
            this.textbox_Search.BorderRadius = 15;
            this.textbox_Search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_Search.DefaultText = "";
            this.textbox_Search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Search.DisabledState.Parent = this.textbox_Search;
            this.textbox_Search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Search.FocusedState.Parent = this.textbox_Search;
            this.textbox_Search.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textbox_Search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Search.HoverState.Parent = this.textbox_Search;
            this.textbox_Search.Location = new System.Drawing.Point(413, 108);
            this.textbox_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_Search.Name = "textbox_Search";
            this.textbox_Search.PasswordChar = '\0';
            this.textbox_Search.PlaceholderText = "Search ....";
            this.textbox_Search.SelectedText = "";
            this.textbox_Search.ShadowDecoration.Parent = this.textbox_Search;
            this.textbox_Search.Size = new System.Drawing.Size(305, 31);
            this.textbox_Search.TabIndex = 25;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(327, 566);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(144, 40);
            this.guna2Button1.TabIndex = 23;
            this.guna2Button1.Text = "REFRESH";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dataGridView_Shift
            // 
            this.dataGridView_Shift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Shift.Location = new System.Drawing.Point(26, 158);
            this.dataGridView_Shift.Name = "dataGridView_Shift";
            this.dataGridView_Shift.Size = new System.Drawing.Size(757, 402);
            this.dataGridView_Shift.TabIndex = 22;
            // 
            // WatchShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 618);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "WatchShiftForm";
            this.Text = "WatchShiftForm";
            this.Load += new System.EventHandler(this.WatchShiftForm_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Shift)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.DataGridView dataGridView_Shift;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Search;
        private Guna.UI2.WinForms.Guna2GradientButton buttonFind;
        private System.Windows.Forms.Label label1;
    }
}