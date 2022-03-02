
namespace FinalProjectST
{
    partial class ManageEmployeeForm
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
            this.dataGridView_Employee = new System.Windows.Forms.DataGridView();
            this.button_Search = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_Search = new Guna.UI2.WinForms.Guna2TextBox();
            this.button_Clear = new Guna.UI2.WinForms.Guna2Button();
            this.button_Delete = new Guna.UI2.WinForms.Guna2Button();
            this.button_Edit = new Guna.UI2.WinForms.Guna2Button();
            this.button_Add = new Guna.UI2.WinForms.Guna2Button();
            this.button_UploadImage = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox_Type = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.textbox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox_Employee = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Employee)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Employee
            // 
            this.dataGridView_Employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Employee.Location = new System.Drawing.Point(405, 59);
            this.dataGridView_Employee.Name = "dataGridView_Employee";
            this.dataGridView_Employee.Size = new System.Drawing.Size(512, 444);
            this.dataGridView_Employee.TabIndex = 34;
            this.dataGridView_Employee.DoubleClick += new System.EventHandler(this.dataGridView_Employee_DoubleClick);
            // 
            // button_Search
            // 
            this.button_Search.CheckedState.Parent = this.button_Search;
            this.button_Search.CustomImages.Parent = this.button_Search;
            this.button_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Search.ForeColor = System.Drawing.Color.White;
            this.button_Search.HoverState.Parent = this.button_Search;
            this.button_Search.Location = new System.Drawing.Point(806, 16);
            this.button_Search.Name = "button_Search";
            this.button_Search.ShadowDecoration.Parent = this.button_Search;
            this.button_Search.Size = new System.Drawing.Size(111, 37);
            this.button_Search.TabIndex = 33;
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
            this.textbox_Search.Location = new System.Drawing.Point(405, 16);
            this.textbox_Search.Name = "textbox_Search";
            this.textbox_Search.PasswordChar = '\0';
            this.textbox_Search.PlaceholderText = "Search by Name or Username ...";
            this.textbox_Search.SelectedText = "";
            this.textbox_Search.ShadowDecoration.Parent = this.textbox_Search;
            this.textbox_Search.Size = new System.Drawing.Size(395, 37);
            this.textbox_Search.TabIndex = 32;
            // 
            // button_Clear
            // 
            this.button_Clear.BorderRadius = 20;
            this.button_Clear.CheckedState.Parent = this.button_Clear;
            this.button_Clear.CustomImages.Parent = this.button_Clear;
            this.button_Clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Clear.ForeColor = System.Drawing.Color.White;
            this.button_Clear.HoverState.Parent = this.button_Clear;
            this.button_Clear.Location = new System.Drawing.Point(691, 525);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.ShadowDecoration.Parent = this.button_Clear;
            this.button_Clear.Size = new System.Drawing.Size(180, 45);
            this.button_Clear.TabIndex = 31;
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
            this.button_Delete.Location = new System.Drawing.Point(487, 525);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.ShadowDecoration.Parent = this.button_Delete;
            this.button_Delete.Size = new System.Drawing.Size(180, 45);
            this.button_Delete.TabIndex = 30;
            this.button_Delete.Text = "DELETE";
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.BorderRadius = 20;
            this.button_Edit.CheckedState.Parent = this.button_Edit;
            this.button_Edit.CustomImages.Parent = this.button_Edit;
            this.button_Edit.FillColor = System.Drawing.Color.Magenta;
            this.button_Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_Edit.ForeColor = System.Drawing.Color.White;
            this.button_Edit.HoverState.Parent = this.button_Edit;
            this.button_Edit.Location = new System.Drawing.Point(280, 525);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.ShadowDecoration.Parent = this.button_Edit;
            this.button_Edit.Size = new System.Drawing.Size(180, 45);
            this.button_Edit.TabIndex = 29;
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
            this.button_Add.Location = new System.Drawing.Point(69, 525);
            this.button_Add.Name = "button_Add";
            this.button_Add.ShadowDecoration.Parent = this.button_Add;
            this.button_Add.Size = new System.Drawing.Size(180, 45);
            this.button_Add.TabIndex = 28;
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
            this.button_UploadImage.Location = new System.Drawing.Point(127, 472);
            this.button_UploadImage.Name = "button_UploadImage";
            this.button_UploadImage.ShadowDecoration.Parent = this.button_UploadImage;
            this.button_UploadImage.Size = new System.Drawing.Size(263, 31);
            this.button_UploadImage.TabIndex = 27;
            this.button_UploadImage.Text = "Upload";
            this.button_UploadImage.Click += new System.EventHandler(this.button_UploadImage_Click);
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
            this.comboBox_Type.Location = new System.Drawing.Point(127, 185);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.ShadowDecoration.Parent = this.comboBox_Type;
            this.comboBox_Type.Size = new System.Drawing.Size(263, 36);
            this.comboBox_Type.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 36);
            this.label5.TabIndex = 23;
            this.label5.Text = "Image";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 36);
            this.label4.TabIndex = 22;
            this.label4.Text = "Position";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 36);
            this.label3.TabIndex = 21;
            this.label3.Text = "Username";
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
            this.textbox_Name.Location = new System.Drawing.Point(127, 59);
            this.textbox_Name.Name = "textbox_Name";
            this.textbox_Name.PasswordChar = '\0';
            this.textbox_Name.PlaceholderText = "";
            this.textbox_Name.SelectedText = "";
            this.textbox_Name.ShadowDecoration.Parent = this.textbox_Name;
            this.textbox_Name.Size = new System.Drawing.Size(263, 36);
            this.textbox_Name.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 18;
            this.label1.Text = "MANAGE EMPLOYEE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textbox_Username
            // 
            this.textbox_Username.BorderRadius = 15;
            this.textbox_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_Username.DefaultText = "";
            this.textbox_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Username.DisabledState.Parent = this.textbox_Username;
            this.textbox_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Username.FocusedState.Parent = this.textbox_Username;
            this.textbox_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Username.HoverState.Parent = this.textbox_Username;
            this.textbox_Username.Location = new System.Drawing.Point(127, 101);
            this.textbox_Username.Name = "textbox_Username";
            this.textbox_Username.PasswordChar = '\0';
            this.textbox_Username.PlaceholderText = "";
            this.textbox_Username.SelectedText = "";
            this.textbox_Username.ShadowDecoration.Parent = this.textbox_Username;
            this.textbox_Username.Size = new System.Drawing.Size(263, 36);
            this.textbox_Username.TabIndex = 35;
            // 
            // textbox_Password
            // 
            this.textbox_Password.BorderRadius = 15;
            this.textbox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_Password.DefaultText = "";
            this.textbox_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Password.DisabledState.Parent = this.textbox_Password;
            this.textbox_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Password.FocusedState.Parent = this.textbox_Password;
            this.textbox_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Password.HoverState.Parent = this.textbox_Password;
            this.textbox_Password.Location = new System.Drawing.Point(127, 143);
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.PasswordChar = '*';
            this.textbox_Password.PlaceholderText = "";
            this.textbox_Password.SelectedText = "";
            this.textbox_Password.ShadowDecoration.Parent = this.textbox_Password;
            this.textbox_Password.Size = new System.Drawing.Size(263, 36);
            this.textbox_Password.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 36);
            this.label6.TabIndex = 37;
            this.label6.Text = "Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_Employee
            // 
            this.pictureBox_Employee.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Employee.Location = new System.Drawing.Point(127, 227);
            this.pictureBox_Employee.Name = "pictureBox_Employee";
            this.pictureBox_Employee.ShadowDecoration.Parent = this.pictureBox_Employee;
            this.pictureBox_Employee.Size = new System.Drawing.Size(263, 239);
            this.pictureBox_Employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Employee.TabIndex = 26;
            this.pictureBox_Employee.TabStop = false;
            // 
            // ManageEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 579);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textbox_Password);
            this.Controls.Add(this.textbox_Username);
            this.Controls.Add(this.dataGridView_Employee);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.textbox_Search);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_UploadImage);
            this.Controls.Add(this.pictureBox_Employee);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textbox_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManageEmployeeForm";
            this.Text = "ManageEmployeeForm";
            this.Load += new System.EventHandler(this.ManageEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Employee;
        private Guna.UI2.WinForms.Guna2Button button_Search;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Search;
        private Guna.UI2.WinForms.Guna2Button button_Clear;
        private Guna.UI2.WinForms.Guna2Button button_Delete;
        private Guna.UI2.WinForms.Guna2Button button_Edit;
        private Guna.UI2.WinForms.Guna2Button button_Add;
        private Guna.UI2.WinForms.Guna2Button button_UploadImage;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_Employee;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Username;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Password;
        private System.Windows.Forms.Label label6;
    }
}