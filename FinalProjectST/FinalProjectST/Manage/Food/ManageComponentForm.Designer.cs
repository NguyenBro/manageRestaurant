
namespace FinalProjectST
{
    partial class ManageComponentForm
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
            this.listBox_AllMaterial = new System.Windows.Forms.ListBox();
            this.listBox_FoodMaterial = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.button_Remove = new Guna.UI2.WinForms.Guna2Button();
            this.button_Confirm = new Guna.UI2.WinForms.Guna2Button();
            this.numericUpDown_Amount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_AllMaterial
            // 
            this.listBox_AllMaterial.FormattingEnabled = true;
            this.listBox_AllMaterial.Location = new System.Drawing.Point(12, 82);
            this.listBox_AllMaterial.Name = "listBox_AllMaterial";
            this.listBox_AllMaterial.Size = new System.Drawing.Size(316, 329);
            this.listBox_AllMaterial.TabIndex = 0;
            // 
            // listBox_FoodMaterial
            // 
            this.listBox_FoodMaterial.FormattingEnabled = true;
            this.listBox_FoodMaterial.Location = new System.Drawing.Point(472, 82);
            this.listBox_FoodMaterial.Name = "listBox_FoodMaterial";
            this.listBox_FoodMaterial.Size = new System.Drawing.Size(316, 329);
            this.listBox_FoodMaterial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(172)))), ((int)(((byte)(168)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANAGE COMPONENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Material";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Food Material";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_Add
            // 
            this.button_Add.BorderRadius = 20;
            this.button_Add.CheckedState.Parent = this.button_Add;
            this.button_Add.CustomImages.Parent = this.button_Add;
            this.button_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Add.ForeColor = System.Drawing.Color.White;
            this.button_Add.HoverState.Parent = this.button_Add;
            this.button_Add.Location = new System.Drawing.Point(345, 226);
            this.button_Add.Name = "button_Add";
            this.button_Add.ShadowDecoration.Parent = this.button_Add;
            this.button_Add.Size = new System.Drawing.Size(109, 42);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "ADD";
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.BorderRadius = 20;
            this.button_Remove.CheckedState.Parent = this.button_Remove;
            this.button_Remove.CustomImages.Parent = this.button_Remove;
            this.button_Remove.FillColor = System.Drawing.Color.Red;
            this.button_Remove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Remove.ForeColor = System.Drawing.Color.White;
            this.button_Remove.HoverState.Parent = this.button_Remove;
            this.button_Remove.Location = new System.Drawing.Point(345, 285);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.ShadowDecoration.Parent = this.button_Remove;
            this.button_Remove.Size = new System.Drawing.Size(109, 42);
            this.button_Remove.TabIndex = 6;
            this.button_Remove.Text = "REMOVE";
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // button_Confirm
            // 
            this.button_Confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(172)))), ((int)(((byte)(168)))));
            this.button_Confirm.BorderRadius = 20;
            this.button_Confirm.CheckedState.Parent = this.button_Confirm;
            this.button_Confirm.CustomImages.Parent = this.button_Confirm;
            this.button_Confirm.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button_Confirm.ForeColor = System.Drawing.Color.White;
            this.button_Confirm.HoverState.Parent = this.button_Confirm;
            this.button_Confirm.Location = new System.Drawing.Point(580, 417);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.ShadowDecoration.Parent = this.button_Confirm;
            this.button_Confirm.Size = new System.Drawing.Size(159, 42);
            this.button_Confirm.TabIndex = 7;
            this.button_Confirm.Text = "CONFIRM";
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // numericUpDown_Amount
            // 
            this.numericUpDown_Amount.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDown_Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDown_Amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numericUpDown_Amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numericUpDown_Amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numericUpDown_Amount.DisabledState.Parent = this.numericUpDown_Amount;
            this.numericUpDown_Amount.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numericUpDown_Amount.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numericUpDown_Amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numericUpDown_Amount.FocusedState.Parent = this.numericUpDown_Amount;
            this.numericUpDown_Amount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numericUpDown_Amount.Location = new System.Drawing.Point(345, 170);
            this.numericUpDown_Amount.Name = "numericUpDown_Amount";
            this.numericUpDown_Amount.ShadowDecoration.Parent = this.numericUpDown_Amount;
            this.numericUpDown_Amount.Size = new System.Drawing.Size(109, 36);
            this.numericUpDown_Amount.TabIndex = 8;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(214)))), ((int)(((byte)(243)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(172)))), ((int)(((byte)(168)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(1, 1);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(797, 466);
            this.guna2GradientPanel1.TabIndex = 9;
            // 
            // ManageComponentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.numericUpDown_Amount);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_FoodMaterial);
            this.Controls.Add(this.listBox_AllMaterial);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "ManageComponentForm";
            this.Text = "ManageComponentForm";
            this.Load += new System.EventHandler(this.ManageComponentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_AllMaterial;
        private System.Windows.Forms.ListBox listBox_FoodMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button button_Add;
        private Guna.UI2.WinForms.Guna2Button button_Remove;
        private Guna.UI2.WinForms.Guna2Button button_Confirm;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDown_Amount;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}