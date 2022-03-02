
namespace FinalProjectST
{
    partial class StaffEditInfoForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_General = new System.Windows.Forms.TabPage();
            this.button_UploadImage = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox_Employee = new Guna.UI2.WinForms.Guna2PictureBox();
            this.button_Close = new Guna.UI2.WinForms.Guna2Button();
            this.button_UpdateInfo = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_Name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_Password = new System.Windows.Forms.TabPage();
            this.button_UpdatePassword = new Guna.UI2.WinForms.Guna2Button();
            this.textbox_ReNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textbox_NewPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_OldPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Employee)).BeginInit();
            this.tabPage_Password.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "EDIT STAFF INFOMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_General);
            this.tabControl1.Controls.Add(this.tabPage_Password);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(532, 444);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage_General
            // 
            this.tabPage_General.Controls.Add(this.button_UploadImage);
            this.tabPage_General.Controls.Add(this.textbox_Username);
            this.tabPage_General.Controls.Add(this.label3);
            this.tabPage_General.Controls.Add(this.pictureBox_Employee);
            this.tabPage_General.Controls.Add(this.button_Close);
            this.tabPage_General.Controls.Add(this.button_UpdateInfo);
            this.tabPage_General.Controls.Add(this.label4);
            this.tabPage_General.Controls.Add(this.textbox_Name);
            this.tabPage_General.Controls.Add(this.label2);
            this.tabPage_General.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_General.Location = new System.Drawing.Point(4, 25);
            this.tabPage_General.Name = "tabPage_General";
            this.tabPage_General.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_General.Size = new System.Drawing.Size(524, 415);
            this.tabPage_General.TabIndex = 0;
            this.tabPage_General.Text = "General";
            this.tabPage_General.UseVisualStyleBackColor = true;
            // 
            // button_UploadImage
            // 
            this.button_UploadImage.CheckedState.Parent = this.button_UploadImage;
            this.button_UploadImage.CustomImages.Parent = this.button_UploadImage;
            this.button_UploadImage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_UploadImage.ForeColor = System.Drawing.Color.White;
            this.button_UploadImage.HoverState.Parent = this.button_UploadImage;
            this.button_UploadImage.Location = new System.Drawing.Point(398, 131);
            this.button_UploadImage.Name = "button_UploadImage";
            this.button_UploadImage.ShadowDecoration.Parent = this.button_UploadImage;
            this.button_UploadImage.Size = new System.Drawing.Size(95, 42);
            this.button_UploadImage.TabIndex = 11;
            this.button_UploadImage.Text = "Upload Image";
            this.button_UploadImage.Click += new System.EventHandler(this.button_UploadImage_Click);
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
            this.textbox_Username.Enabled = false;
            this.textbox_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Username.FocusedState.Parent = this.textbox_Username;
            this.textbox_Username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textbox_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Username.HoverState.Parent = this.textbox_Username;
            this.textbox_Username.Location = new System.Drawing.Point(178, 73);
            this.textbox_Username.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_Username.Name = "textbox_Username";
            this.textbox_Username.PasswordChar = '\0';
            this.textbox_Username.PlaceholderText = "";
            this.textbox_Username.SelectedText = "";
            this.textbox_Username.ShadowDecoration.Parent = this.textbox_Username;
            this.textbox_Username.Size = new System.Drawing.Size(299, 36);
            this.textbox_Username.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_Employee
            // 
            this.pictureBox_Employee.Location = new System.Drawing.Point(178, 131);
            this.pictureBox_Employee.Name = "pictureBox_Employee";
            this.pictureBox_Employee.ShadowDecoration.Parent = this.pictureBox_Employee;
            this.pictureBox_Employee.Size = new System.Drawing.Size(214, 200);
            this.pictureBox_Employee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Employee.TabIndex = 8;
            this.pictureBox_Employee.TabStop = false;
            // 
            // button_Close
            // 
            this.button_Close.BorderRadius = 20;
            this.button_Close.CheckedState.Parent = this.button_Close;
            this.button_Close.CustomImages.Parent = this.button_Close;
            this.button_Close.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_Close.ForeColor = System.Drawing.Color.White;
            this.button_Close.HoverState.Parent = this.button_Close;
            this.button_Close.Location = new System.Drawing.Point(287, 364);
            this.button_Close.Name = "button_Close";
            this.button_Close.ShadowDecoration.Parent = this.button_Close;
            this.button_Close.Size = new System.Drawing.Size(180, 45);
            this.button_Close.TabIndex = 7;
            this.button_Close.Text = "Close";
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_UpdateInfo
            // 
            this.button_UpdateInfo.BorderRadius = 20;
            this.button_UpdateInfo.CheckedState.Parent = this.button_UpdateInfo;
            this.button_UpdateInfo.CustomImages.Parent = this.button_UpdateInfo;
            this.button_UpdateInfo.FillColor = System.Drawing.Color.Red;
            this.button_UpdateInfo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_UpdateInfo.ForeColor = System.Drawing.Color.White;
            this.button_UpdateInfo.HoverState.Parent = this.button_UpdateInfo;
            this.button_UpdateInfo.Location = new System.Drawing.Point(54, 364);
            this.button_UpdateInfo.Name = "button_UpdateInfo";
            this.button_UpdateInfo.ShadowDecoration.Parent = this.button_UpdateInfo;
            this.button_UpdateInfo.Size = new System.Drawing.Size(180, 45);
            this.button_UpdateInfo.TabIndex = 6;
            this.button_UpdateInfo.Text = "Update Information";
            this.button_UpdateInfo.Click += new System.EventHandler(this.button_UpdateInfo_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Image";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.textbox_Name.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textbox_Name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Name.HoverState.Parent = this.textbox_Name;
            this.textbox_Name.Location = new System.Drawing.Point(178, 18);
            this.textbox_Name.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_Name.Name = "textbox_Name";
            this.textbox_Name.PasswordChar = '\0';
            this.textbox_Name.PlaceholderText = "";
            this.textbox_Name.SelectedText = "";
            this.textbox_Name.ShadowDecoration.Parent = this.textbox_Name;
            this.textbox_Name.Size = new System.Drawing.Size(299, 36);
            this.textbox_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage_Password
            // 
            this.tabPage_Password.Controls.Add(this.button_UpdatePassword);
            this.tabPage_Password.Controls.Add(this.textbox_ReNewPass);
            this.tabPage_Password.Controls.Add(this.label7);
            this.tabPage_Password.Controls.Add(this.textbox_NewPass);
            this.tabPage_Password.Controls.Add(this.label6);
            this.tabPage_Password.Controls.Add(this.textbox_OldPass);
            this.tabPage_Password.Controls.Add(this.label5);
            this.tabPage_Password.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Password.Name = "tabPage_Password";
            this.tabPage_Password.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Password.Size = new System.Drawing.Size(524, 415);
            this.tabPage_Password.TabIndex = 1;
            this.tabPage_Password.Text = "Password";
            this.tabPage_Password.UseVisualStyleBackColor = true;
            // 
            // button_UpdatePassword
            // 
            this.button_UpdatePassword.BorderRadius = 20;
            this.button_UpdatePassword.CheckedState.Parent = this.button_UpdatePassword;
            this.button_UpdatePassword.CustomImages.Parent = this.button_UpdatePassword;
            this.button_UpdatePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button_UpdatePassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button_UpdatePassword.ForeColor = System.Drawing.Color.White;
            this.button_UpdatePassword.HoverState.Parent = this.button_UpdatePassword;
            this.button_UpdatePassword.Location = new System.Drawing.Point(173, 249);
            this.button_UpdatePassword.Name = "button_UpdatePassword";
            this.button_UpdatePassword.ShadowDecoration.Parent = this.button_UpdatePassword;
            this.button_UpdatePassword.Size = new System.Drawing.Size(180, 45);
            this.button_UpdatePassword.TabIndex = 8;
            this.button_UpdatePassword.Text = "Update Password";
            this.button_UpdatePassword.Click += new System.EventHandler(this.button_UpdatePassword_Click);
            // 
            // textbox_ReNewPass
            // 
            this.textbox_ReNewPass.BorderRadius = 15;
            this.textbox_ReNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_ReNewPass.DefaultText = "";
            this.textbox_ReNewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_ReNewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_ReNewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_ReNewPass.DisabledState.Parent = this.textbox_ReNewPass;
            this.textbox_ReNewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_ReNewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_ReNewPass.FocusedState.Parent = this.textbox_ReNewPass;
            this.textbox_ReNewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textbox_ReNewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_ReNewPass.HoverState.Parent = this.textbox_ReNewPass;
            this.textbox_ReNewPass.Location = new System.Drawing.Point(173, 165);
            this.textbox_ReNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_ReNewPass.Name = "textbox_ReNewPass";
            this.textbox_ReNewPass.PasswordChar = '*';
            this.textbox_ReNewPass.PlaceholderText = "Re-Enter Your New Password ...";
            this.textbox_ReNewPass.SelectedText = "";
            this.textbox_ReNewPass.ShadowDecoration.Parent = this.textbox_ReNewPass;
            this.textbox_ReNewPass.Size = new System.Drawing.Size(299, 36);
            this.textbox_ReNewPass.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(46, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "Re-Type ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_NewPass
            // 
            this.textbox_NewPass.BorderRadius = 15;
            this.textbox_NewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_NewPass.DefaultText = "";
            this.textbox_NewPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_NewPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_NewPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_NewPass.DisabledState.Parent = this.textbox_NewPass;
            this.textbox_NewPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_NewPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_NewPass.FocusedState.Parent = this.textbox_NewPass;
            this.textbox_NewPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textbox_NewPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_NewPass.HoverState.Parent = this.textbox_NewPass;
            this.textbox_NewPass.Location = new System.Drawing.Point(173, 102);
            this.textbox_NewPass.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_NewPass.Name = "textbox_NewPass";
            this.textbox_NewPass.PasswordChar = '*';
            this.textbox_NewPass.PlaceholderText = "Enter Your New Password ...";
            this.textbox_NewPass.SelectedText = "";
            this.textbox_NewPass.ShadowDecoration.Parent = this.textbox_NewPass;
            this.textbox_NewPass.Size = new System.Drawing.Size(299, 36);
            this.textbox_NewPass.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(46, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 36);
            this.label6.TabIndex = 4;
            this.label6.Text = "New Password";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_OldPass
            // 
            this.textbox_OldPass.BorderRadius = 15;
            this.textbox_OldPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_OldPass.DefaultText = "";
            this.textbox_OldPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_OldPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_OldPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_OldPass.DisabledState.Parent = this.textbox_OldPass;
            this.textbox_OldPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_OldPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_OldPass.FocusedState.Parent = this.textbox_OldPass;
            this.textbox_OldPass.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textbox_OldPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_OldPass.HoverState.Parent = this.textbox_OldPass;
            this.textbox_OldPass.Location = new System.Drawing.Point(173, 39);
            this.textbox_OldPass.Margin = new System.Windows.Forms.Padding(4);
            this.textbox_OldPass.Name = "textbox_OldPass";
            this.textbox_OldPass.PasswordChar = '*';
            this.textbox_OldPass.PlaceholderText = "Enter Your Old Password...";
            this.textbox_OldPass.SelectedText = "";
            this.textbox_OldPass.ShadowDecoration.Parent = this.textbox_OldPass;
            this.textbox_OldPass.Size = new System.Drawing.Size(299, 36);
            this.textbox_OldPass.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Old Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StaffEditInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 498);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "StaffEditInfoForm";
            this.Text = "StaffEditInfoForm";
            this.Load += new System.EventHandler(this.StaffEditInfoForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_General.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Employee)).EndInit();
            this.tabPage_Password.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_General;
        private Guna.UI2.WinForms.Guna2Button button_Close;
        private Guna.UI2.WinForms.Guna2Button button_UpdateInfo;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage_Password;
        private Guna.UI2.WinForms.Guna2Button button_UpdatePassword;
        private Guna.UI2.WinForms.Guna2TextBox textbox_ReNewPass;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox textbox_NewPass;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox textbox_OldPass;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button button_UploadImage;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Username;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox_Employee;
    }
}