
namespace FinalProjectST
{
    partial class ManageMaterialForm
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
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_Unit = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView_Material = new System.Windows.Forms.DataGridView();
            this.button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.button_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.button_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.button_UploadImage = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_Amount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pictureBox_Material = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Material)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Material)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 36);
            this.label6.TabIndex = 56;
            this.label6.Text = "Unit";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_Unit
            // 
            this.textbox_Unit.BorderRadius = 15;
            this.textbox_Unit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_Unit.DefaultText = "";
            this.textbox_Unit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_Unit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_Unit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Unit.DisabledState.Parent = this.textbox_Unit;
            this.textbox_Unit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Unit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Unit.FocusedState.Parent = this.textbox_Unit;
            this.textbox_Unit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Unit.HoverState.Parent = this.textbox_Unit;
            this.textbox_Unit.Location = new System.Drawing.Point(124, 166);
            this.textbox_Unit.Name = "textbox_Unit";
            this.textbox_Unit.PasswordChar = '\0';
            this.textbox_Unit.PlaceholderText = "";
            this.textbox_Unit.SelectedText = "";
            this.textbox_Unit.ShadowDecoration.Parent = this.textbox_Unit;
            this.textbox_Unit.Size = new System.Drawing.Size(263, 36);
            this.textbox_Unit.TabIndex = 55;
            // 
            // dataGridView_Material
            // 
            this.dataGridView_Material.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Material.Location = new System.Drawing.Point(402, 61);
            this.dataGridView_Material.Name = "dataGridView_Material";
            this.dataGridView_Material.Size = new System.Drawing.Size(512, 444);
            this.dataGridView_Material.TabIndex = 53;
            this.dataGridView_Material.DoubleClick += new System.EventHandler(this.dataGridView_Material_DoubleClick);
            // 
            // button_Search
            // 
            this.button_Search.CheckedState.Parent = this.button_Search;
            this.button_Search.CustomImages.Parent = this.button_Search;
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.HoverState.Parent = this.button_Search;
            this.button_Search.Location = new System.Drawing.Point(803, 18);
            this.button_Search.Name = "button_Search";
            this.button_Search.ShadowDecoration.Parent = this.button_Search;
            this.button_Search.Size = new System.Drawing.Size(111, 37);
            this.button_Search.TabIndex = 52;
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
            this.textbox_Search.Location = new System.Drawing.Point(402, 18);
            this.textbox_Search.Name = "textbox_Search";
            this.textbox_Search.PasswordChar = '\0';
            this.textbox_Search.PlaceholderText = "Search by Name ...";
            this.textbox_Search.SelectedText = "";
            this.textbox_Search.ShadowDecoration.Parent = this.textbox_Search;
            this.textbox_Search.Size = new System.Drawing.Size(395, 37);
            this.textbox_Search.TabIndex = 51;
            // 
            // button_Clear
            // 
            this.button_Clear.BorderRadius = 20;
            this.button_Clear.CheckedState.Parent = this.button_Clear;
            this.button_Clear.CustomImages.Parent = this.button_Clear;
            this.button_Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.HoverState.Parent = this.button_Clear;
            this.button_Clear.Location = new System.Drawing.Point(688, 527);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.ShadowDecoration.Parent = this.button_Clear;
            this.button_Clear.Size = new System.Drawing.Size(180, 45);
            this.button_Clear.TabIndex = 50;
            this.button_Clear.Text = "CLEAR";
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BorderRadius = 20;
            this.button_Delete.CheckedState.Parent = this.button_Delete;
            this.button_Delete.CustomImages.Parent = this.button_Delete;
            this.button_Delete.FillColor = System.Drawing.Color.Red;
            this.button_Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.HoverState.Parent = this.button_Delete;
            this.button_Delete.Location = new System.Drawing.Point(484, 527);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.ShadowDecoration.Parent = this.button_Delete;
            this.button_Delete.Size = new System.Drawing.Size(180, 45);
            this.button_Delete.TabIndex = 49;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.Color.White;
            this.button_Edit.BorderRadius = 20;
            this.button_Edit.CheckedState.Parent = this.button_Edit;
            this.button_Edit.CustomImages.Parent = this.button_Edit;
            this.button_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Edit.ForeColor = System.Drawing.Color.White;
            this.button_Edit.HoverState.Parent = this.button_Edit;
            this.button_Edit.Location = new System.Drawing.Point(277, 527);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.ShadowDecoration.Parent = this.button_Edit;
            this.button_Edit.Size = new System.Drawing.Size(180, 45);
            this.button_Edit.TabIndex = 48;
            this.button_Edit.Text = "EDIT";
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
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
            this.button_Add.Location = new System.Drawing.Point(66, 527);
            this.button_Add.Name = "button_Add";
            this.button_Add.ShadowDecoration.Parent = this.button_Add;
            this.button_Add.Size = new System.Drawing.Size(180, 45);
            this.button_Add.TabIndex = 47;
            this.button_Add.Text = "ADD";
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_UploadImage
            // 
            this.button_UploadImage.CheckedState.Parent = this.button_UploadImage;
            this.button_UploadImage.CustomImages.Parent = this.button_UploadImage;
            this.button_UploadImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_UploadImage.ForeColor = System.Drawing.Color.White;
            this.button_UploadImage.HoverState.Parent = this.button_UploadImage;
            this.button_UploadImage.Location = new System.Drawing.Point(124, 474);
            this.button_UploadImage.Name = "button_UploadImage";
            this.button_UploadImage.ShadowDecoration.Parent = this.button_UploadImage;
            this.button_UploadImage.Size = new System.Drawing.Size(263, 31);
            this.button_UploadImage.TabIndex = 46;
            this.button_UploadImage.Text = "Upload";
            this.button_UploadImage.Click += new System.EventHandler(this.button_UploadImage_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 36);
            this.label5.TabIndex = 43;
            this.label5.Text = "Image";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 36);
            this.label3.TabIndex = 41;
            this.label3.Text = "Amount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_Name
            // 
            this.textbox_Name.BorderRadius = 15;
            this.textbox_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_Name.DefaultText = "";
            this.textbox_Name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_Name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_Name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Name.DisabledState.Parent = this.textbox_Name;
            this.textbox_Name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Name.FocusedState.Parent = this.textbox_Name;
            this.textbox_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Name.HoverState.Parent = this.textbox_Name;
            this.textbox_Name.Location = new System.Drawing.Point(124, 61);
            this.textbox_Name.Name = "textbox_Name";
            this.textbox_Name.PasswordChar = '\0';
            this.textbox_Name.PlaceholderText = "";
            this.textbox_Name.SelectedText = "";
            this.textbox_Name.ShadowDecoration.Parent = this.textbox_Name;
            this.textbox_Name.Size = new System.Drawing.Size(263, 36);
            this.textbox_Name.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 36);
            this.label2.TabIndex = 39;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 38;
            this.label1.Text = "MANAGE MATERIAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDown_Amount
            // 
            this.numericUpDown_Amount.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDown_Amount.BorderRadius = 15;
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
            this.numericUpDown_Amount.Location = new System.Drawing.Point(124, 112);
            this.numericUpDown_Amount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_Amount.Name = "numericUpDown_Amount";
            this.numericUpDown_Amount.ShadowDecoration.Parent = this.numericUpDown_Amount;
            this.numericUpDown_Amount.Size = new System.Drawing.Size(185, 36);
            this.numericUpDown_Amount.TabIndex = 57;
            // 
            // pictureBox_Material
            // 
            this.pictureBox_Material.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Material.Location = new System.Drawing.Point(124, 229);
            this.pictureBox_Material.Name = "pictureBox_Material";
            this.pictureBox_Material.ShadowDecoration.Parent = this.pictureBox_Material;
            this.pictureBox_Material.Size = new System.Drawing.Size(263, 239);
            this.pictureBox_Material.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Material.TabIndex = 45;
            this.pictureBox_Material.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(205)))), ((int)(((byte)(163)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(98)))), ((int)(((byte)(159)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(1, -1);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(922, 582);
            this.guna2GradientPanel1.TabIndex = 58;
            // 
            // ManageMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 582);
            this.Controls.Add(this.numericUpDown_Amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_Unit);
            this.Controls.Add(this.dataGridView_Material);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textbox_Search);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_UploadImage);
            this.Controls.Add(this.pictureBox_Material);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "ManageMaterialForm";
            this.Text = "ManageMaterialForm";
            this.Load += new System.EventHandler(this.ManageMaterialForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Material)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Material)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Unit;
        private System.Windows.Forms.DataGridView dataGridView_Material;
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Search;
        private Guna.UI2.WinForms.Guna2Button button_Clear;
        private Guna.UI2.WinForms.Guna2Button button_Delete;
        private Guna.UI2.WinForms.Guna2Button button_Edit;
        private Guna.UI2.WinForms.Guna2Button button_Add;
        private Guna.UI2.WinForms.Guna2Button button_UploadImage;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_Material;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDown_Amount;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}