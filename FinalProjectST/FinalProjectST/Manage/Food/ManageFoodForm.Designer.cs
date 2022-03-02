
namespace FinalProjectST
{
    partial class ManageFoodForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_Cost = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.comboBox_Type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.button_UploadImage = new Guna.UI2.WinForms.Guna2Button();
            this.button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.button_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.button_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.button_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView_Food = new System.Windows.Forms.DataGridView();
            this.listBox_Material = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_EditMaterial = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox_Food = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Food)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE FOOD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.textbox_Name.Location = new System.Drawing.Point(126, 64);
            this.textbox_Name.Name = "textbox_Name";
            this.textbox_Name.PasswordChar = '\0';
            this.textbox_Name.PlaceholderText = "";
            this.textbox_Name.SelectedText = "";
            this.textbox_Name.ShadowDecoration.Parent = this.textbox_Name;
            this.textbox_Name.Size = new System.Drawing.Size(263, 36);
            this.textbox_Name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Type";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "Image";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_Cost
            // 
            this.numericUpDown_Cost.BackColor = System.Drawing.Color.Transparent;
            this.numericUpDown_Cost.BorderRadius = 15;
            this.numericUpDown_Cost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numericUpDown_Cost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.numericUpDown_Cost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.numericUpDown_Cost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.numericUpDown_Cost.DisabledState.Parent = this.numericUpDown_Cost;
            this.numericUpDown_Cost.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.numericUpDown_Cost.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.numericUpDown_Cost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.numericUpDown_Cost.FocusedState.Parent = this.numericUpDown_Cost;
            this.numericUpDown_Cost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Cost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.numericUpDown_Cost.Location = new System.Drawing.Point(126, 106);
            this.numericUpDown_Cost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_Cost.Name = "numericUpDown_Cost";
            this.numericUpDown_Cost.ShadowDecoration.Parent = this.numericUpDown_Cost;
            this.numericUpDown_Cost.Size = new System.Drawing.Size(185, 36);
            this.numericUpDown_Cost.TabIndex = 7;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_Type.BorderRadius = 15;
            this.comboBox_Type.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FocusedColor = System.Drawing.Color.Empty;
            this.comboBox_Type.FocusedState.Parent = this.comboBox_Type;
            this.comboBox_Type.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.HoverState.Parent = this.comboBox_Type;
            this.comboBox_Type.ItemHeight = 30;
            this.comboBox_Type.ItemsAppearance.Parent = this.comboBox_Type;
            this.comboBox_Type.Location = new System.Drawing.Point(126, 148);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.ShadowDecoration.Parent = this.comboBox_Type;
            this.comboBox_Type.Size = new System.Drawing.Size(263, 36);
            this.comboBox_Type.TabIndex = 8;
            // 
            // button_UploadImage
            // 
            this.button_UploadImage.CheckedState.Parent = this.button_UploadImage;
            this.button_UploadImage.CustomImages.Parent = this.button_UploadImage;
            this.button_UploadImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_UploadImage.ForeColor = System.Drawing.Color.White;
            this.button_UploadImage.HoverState.Parent = this.button_UploadImage;
            this.button_UploadImage.Location = new System.Drawing.Point(126, 505);
            this.button_UploadImage.Name = "button_UploadImage";
            this.button_UploadImage.ShadowDecoration.Parent = this.button_UploadImage;
            this.button_UploadImage.Size = new System.Drawing.Size(176, 31);
            this.button_UploadImage.TabIndex = 10;
            this.button_UploadImage.Text = "Upload";
            this.button_UploadImage.Click += new System.EventHandler(this.button_UploadImage_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_Add.BorderRadius = 20;
            this.button_Add.CheckedState.Parent = this.button_Add;
            this.button_Add.CustomBorderColor = System.Drawing.Color.White;
            this.button_Add.CustomImages.Parent = this.button_Add;
            this.button_Add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_Add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Add.HoverState.Parent = this.button_Add;
            this.button_Add.Location = new System.Drawing.Point(69, 554);
            this.button_Add.Name = "button_Add";
            this.button_Add.ShadowDecoration.Parent = this.button_Add;
            this.button_Add.Size = new System.Drawing.Size(180, 45);
            this.button_Add.TabIndex = 11;
            this.button_Add.Text = "ADD";
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Edit.BorderRadius = 20;
            this.button_Edit.CheckedState.Parent = this.button_Edit;
            this.button_Edit.CustomImages.Parent = this.button_Edit;
            this.button_Edit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Edit.ForeColor = System.Drawing.Color.White;
            this.button_Edit.HoverState.Parent = this.button_Edit;
            this.button_Edit.Location = new System.Drawing.Point(280, 554);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.ShadowDecoration.Parent = this.button_Edit;
            this.button_Edit.Size = new System.Drawing.Size(180, 45);
            this.button_Edit.TabIndex = 12;
            this.button_Edit.Text = "EDIT";
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Delete.BorderRadius = 20;
            this.button_Delete.CheckedState.Parent = this.button_Delete;
            this.button_Delete.CustomImages.Parent = this.button_Delete;
            this.button_Delete.FillColor = System.Drawing.Color.Red;
            this.button_Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Delete.ForeColor = System.Drawing.Color.White;
            this.button_Delete.HoverState.Parent = this.button_Delete;
            this.button_Delete.Location = new System.Drawing.Point(487, 554);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.ShadowDecoration.Parent = this.button_Delete;
            this.button_Delete.Size = new System.Drawing.Size(180, 45);
            this.button_Delete.TabIndex = 13;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Clear.BorderRadius = 20;
            this.button_Clear.CheckedState.Parent = this.button_Clear;
            this.button_Clear.CustomImages.Parent = this.button_Clear;
            this.button_Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.HoverState.Parent = this.button_Clear;
            this.button_Clear.Location = new System.Drawing.Point(691, 554);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.ShadowDecoration.Parent = this.button_Clear;
            this.button_Clear.Size = new System.Drawing.Size(180, 45);
            this.button_Clear.TabIndex = 14;
            this.button_Clear.Text = "CLEAR";
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
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
            this.textbox_Search.Location = new System.Drawing.Point(404, 21);
            this.textbox_Search.Name = "textbox_Search";
            this.textbox_Search.PasswordChar = '\0';
            this.textbox_Search.PlaceholderText = "Search by Food name ...";
            this.textbox_Search.SelectedText = "";
            this.textbox_Search.ShadowDecoration.Parent = this.textbox_Search;
            this.textbox_Search.Size = new System.Drawing.Size(395, 37);
            this.textbox_Search.TabIndex = 15;
            // 
            // button_Search
            // 
            this.button_Search.CheckedState.Parent = this.button_Search;
            this.button_Search.CustomImages.Parent = this.button_Search;
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.HoverState.Parent = this.button_Search;
            this.button_Search.Location = new System.Drawing.Point(805, 21);
            this.button_Search.Name = "button_Search";
            this.button_Search.ShadowDecoration.Parent = this.button_Search;
            this.button_Search.Size = new System.Drawing.Size(111, 37);
            this.button_Search.TabIndex = 16;
            this.button_Search.Text = "Search";
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // dataGridView_Food
            // 
            this.dataGridView_Food.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Food.Location = new System.Drawing.Point(404, 64);
            this.dataGridView_Food.Name = "dataGridView_Food";
            this.dataGridView_Food.Size = new System.Drawing.Size(512, 472);
            this.dataGridView_Food.TabIndex = 17;
            this.dataGridView_Food.DoubleClick += new System.EventHandler(this.dataGridView_Food_DoubleClick);
            // 
            // listBox_Material
            // 
            this.listBox_Material.FormattingEnabled = true;
            this.listBox_Material.Location = new System.Drawing.Point(126, 190);
            this.listBox_Material.Name = "listBox_Material";
            this.listBox_Material.Size = new System.Drawing.Size(263, 108);
            this.listBox_Material.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 36);
            this.label6.TabIndex = 19;
            this.label6.Text = "Material";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_EditMaterial
            // 
            this.button_EditMaterial.CheckedState.Parent = this.button_EditMaterial;
            this.button_EditMaterial.CustomImages.Parent = this.button_EditMaterial;
            this.button_EditMaterial.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_EditMaterial.ForeColor = System.Drawing.Color.White;
            this.button_EditMaterial.HoverState.Parent = this.button_EditMaterial;
            this.button_EditMaterial.Location = new System.Drawing.Point(126, 304);
            this.button_EditMaterial.Name = "button_EditMaterial";
            this.button_EditMaterial.ShadowDecoration.Parent = this.button_EditMaterial;
            this.button_EditMaterial.Size = new System.Drawing.Size(123, 22);
            this.button_EditMaterial.TabIndex = 20;
            this.button_EditMaterial.Text = "Edit Material";
            this.button_EditMaterial.Click += new System.EventHandler(this.button_EditMaterial_Click);
            // 
            // pictureBox_Food
            // 
            this.pictureBox_Food.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Food.Location = new System.Drawing.Point(126, 334);
            this.pictureBox_Food.Name = "pictureBox_Food";
            this.pictureBox_Food.ShadowDecoration.Parent = this.pictureBox_Food;
            this.pictureBox_Food.Size = new System.Drawing.Size(176, 165);
            this.pictureBox_Food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Food.TabIndex = 9;
            this.pictureBox_Food.TabStop = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(205)))), ((int)(((byte)(163)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(98)))), ((int)(((byte)(159)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(2, 1);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(926, 598);
            this.guna2GradientPanel1.TabIndex = 21;
            // 
            // ManageFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 602);
            this.Controls.Add(this.button_EditMaterial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox_Material);
            this.Controls.Add(this.dataGridView_Food);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textbox_Search);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_UploadImage);
            this.Controls.Add(this.pictureBox_Food);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.numericUpDown_Cost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "ManageFoodForm";
            this.Text = "ManageFoodForm";
            this.Load += new System.EventHandler(this.ManageFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Cost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Food)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2NumericUpDown numericUpDown_Cost;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_Type;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_Food;
        private Guna.UI2.WinForms.Guna2Button button_UploadImage;
        private Guna.UI2.WinForms.Guna2Button button_Add;
        private Guna.UI2.WinForms.Guna2Button button_Edit;
        private Guna.UI2.WinForms.Guna2Button button_Delete;
        private Guna.UI2.WinForms.Guna2Button button_Clear;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Search;
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private System.Windows.Forms.DataGridView dataGridView_Food;
        private System.Windows.Forms.ListBox listBox_Material;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button button_EditMaterial;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
    }
}