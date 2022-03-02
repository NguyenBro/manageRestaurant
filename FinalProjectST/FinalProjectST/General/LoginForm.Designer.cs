
namespace FinalProjectST
{
    partial class LoginForm
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
            this.tabControl_Customer = new System.Windows.Forms.TabControl();
            this.tabPage_Customer = new System.Windows.Forms.TabPage();
            this.label_Alert_Customer = new System.Windows.Forms.Label();
            this.label_register = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Login = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabPage_Staff = new System.Windows.Forms.TabPage();
            this.label_Alert_Staff = new System.Windows.Forms.Label();
            this.button_Login_Staff = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox_password_staff = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox_username_staff = new Guna.UI2.WinForms.Guna2TextBox();
            this.tabControl_Customer.SuspendLayout();
            this.tabPage_Customer.SuspendLayout();
            this.tabPage_Staff.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Customer
            // 
            this.tabControl_Customer.Controls.Add(this.tabPage_Customer);
            this.tabControl_Customer.Controls.Add(this.tabPage_Staff);
            this.tabControl_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_Customer.Location = new System.Drawing.Point(2, 3);
            this.tabControl_Customer.Name = "tabControl_Customer";
            this.tabControl_Customer.RightToLeftLayout = true;
            this.tabControl_Customer.SelectedIndex = 0;
            this.tabControl_Customer.Size = new System.Drawing.Size(510, 394);
            this.tabControl_Customer.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl_Customer.TabIndex = 0;
            this.tabControl_Customer.Tag = "";
            // 
            // tabPage_Customer
            // 
            this.tabPage_Customer.Controls.Add(this.label_Alert_Customer);
            this.tabPage_Customer.Controls.Add(this.label_register);
            this.tabPage_Customer.Controls.Add(this.label7);
            this.tabPage_Customer.Controls.Add(this.button_Login);
            this.tabPage_Customer.Controls.Add(this.label3);
            this.tabPage_Customer.Controls.Add(this.textbox_Password);
            this.tabPage_Customer.Controls.Add(this.label2);
            this.tabPage_Customer.Controls.Add(this.label1);
            this.tabPage_Customer.Controls.Add(this.textbox_email);
            this.tabPage_Customer.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Customer.Name = "tabPage_Customer";
            this.tabPage_Customer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Customer.Size = new System.Drawing.Size(502, 365);
            this.tabPage_Customer.TabIndex = 0;
            this.tabPage_Customer.Text = "CUSTOMER";
            this.tabPage_Customer.UseVisualStyleBackColor = true;
            // 
            // label_Alert_Customer
            // 
            this.label_Alert_Customer.ForeColor = System.Drawing.Color.Red;
            this.label_Alert_Customer.Location = new System.Drawing.Point(113, 213);
            this.label_Alert_Customer.Name = "label_Alert_Customer";
            this.label_Alert_Customer.Size = new System.Drawing.Size(276, 35);
            this.label_Alert_Customer.TabIndex = 16;
            this.label_Alert_Customer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_register
            // 
            this.label_register.AutoSize = true;
            this.label_register.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_register.Location = new System.Drawing.Point(245, 322);
            this.label_register.Name = "label_register";
            this.label_register.Size = new System.Drawing.Size(102, 16);
            this.label_register.TabIndex = 7;
            this.label_register.Text = "Register Now";
            this.label_register.Click += new System.EventHandler(this.label_register_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(145, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Not a Member?";
            // 
            // button_Login
            // 
            this.button_Login.BorderRadius = 20;
            this.button_Login.CheckedState.Parent = this.button_Login;
            this.button_Login.CustomImages.Parent = this.button_Login;
            this.button_Login.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.HoverState.Parent = this.button_Login;
            this.button_Login.Location = new System.Drawing.Point(106, 251);
            this.button_Login.Name = "button_Login";
            this.button_Login.ShadowDecoration.Parent = this.button_Login;
            this.button_Login.Size = new System.Drawing.Size(292, 45);
            this.button_Login.TabIndex = 5;
            this.button_Login.Text = "LOGIN";
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.textbox_Password.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textbox_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_Password.HoverState.Parent = this.textbox_Password;
            this.textbox_Password.Location = new System.Drawing.Point(178, 165);
            this.textbox_Password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_Password.Name = "textbox_Password";
            this.textbox_Password.PasswordChar = '*';
            this.textbox_Password.PlaceholderText = "Enter your password...";
            this.textbox_Password.SelectedText = "";
            this.textbox_Password.ShadowDecoration.Parent = this.textbox_Password;
            this.textbox_Password.Size = new System.Drawing.Size(266, 43);
            this.textbox_Password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 51);
            this.label2.TabIndex = 2;
            this.label2.Text = "RESTAURANT LOGIN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_email
            // 
            this.textbox_email.BorderRadius = 15;
            this.textbox_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_email.DefaultText = "";
            this.textbox_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_email.DisabledState.Parent = this.textbox_email;
            this.textbox_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_email.FocusedState.Parent = this.textbox_email;
            this.textbox_email.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textbox_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_email.HoverState.Parent = this.textbox_email;
            this.textbox_email.Location = new System.Drawing.Point(178, 99);
            this.textbox_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.PasswordChar = '\0';
            this.textbox_email.PlaceholderText = "Enter your email...";
            this.textbox_email.SelectedText = "";
            this.textbox_email.ShadowDecoration.Parent = this.textbox_email;
            this.textbox_email.Size = new System.Drawing.Size(266, 43);
            this.textbox_email.TabIndex = 0;
            // 
            // tabPage_Staff
            // 
            this.tabPage_Staff.Controls.Add(this.label_Alert_Staff);
            this.tabPage_Staff.Controls.Add(this.button_Login_Staff);
            this.tabPage_Staff.Controls.Add(this.label6);
            this.tabPage_Staff.Controls.Add(this.label5);
            this.tabPage_Staff.Controls.Add(this.textbox_password_staff);
            this.tabPage_Staff.Controls.Add(this.label4);
            this.tabPage_Staff.Controls.Add(this.textbox_username_staff);
            this.tabPage_Staff.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Staff.Name = "tabPage_Staff";
            this.tabPage_Staff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Staff.Size = new System.Drawing.Size(502, 365);
            this.tabPage_Staff.TabIndex = 1;
            this.tabPage_Staff.Text = "STAFF";
            this.tabPage_Staff.UseVisualStyleBackColor = true;
            // 
            // label_Alert_Staff
            // 
            this.label_Alert_Staff.ForeColor = System.Drawing.Color.Red;
            this.label_Alert_Staff.Location = new System.Drawing.Point(114, 226);
            this.label_Alert_Staff.Name = "label_Alert_Staff";
            this.label_Alert_Staff.Size = new System.Drawing.Size(276, 35);
            this.label_Alert_Staff.TabIndex = 16;
            this.label_Alert_Staff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_Login_Staff
            // 
            this.button_Login_Staff.BorderRadius = 20;
            this.button_Login_Staff.CheckedState.Parent = this.button_Login_Staff;
            this.button_Login_Staff.CustomImages.Parent = this.button_Login_Staff;
            this.button_Login_Staff.FillColor = System.Drawing.Color.Red;
            this.button_Login_Staff.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.button_Login_Staff.ForeColor = System.Drawing.Color.White;
            this.button_Login_Staff.HoverState.Parent = this.button_Login_Staff;
            this.button_Login_Staff.Location = new System.Drawing.Point(107, 275);
            this.button_Login_Staff.Name = "button_Login_Staff";
            this.button_Login_Staff.ShadowDecoration.Parent = this.button_Login_Staff;
            this.button_Login_Staff.Size = new System.Drawing.Size(292, 45);
            this.button_Login_Staff.TabIndex = 7;
            this.button_Login_Staff.Text = "LOGIN";
            this.button_Login_Staff.Click += new System.EventHandler(this.button_Login_Staff_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(335, 51);
            this.label6.TabIndex = 6;
            this.label6.Text = "STAFF LOGIN";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(57, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 43);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_password_staff
            // 
            this.textbox_password_staff.BorderRadius = 15;
            this.textbox_password_staff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_password_staff.DefaultText = "";
            this.textbox_password_staff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_password_staff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_password_staff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_password_staff.DisabledState.Parent = this.textbox_password_staff;
            this.textbox_password_staff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_password_staff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_password_staff.FocusedState.Parent = this.textbox_password_staff;
            this.textbox_password_staff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textbox_password_staff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_password_staff.HoverState.Parent = this.textbox_password_staff;
            this.textbox_password_staff.Location = new System.Drawing.Point(173, 178);
            this.textbox_password_staff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_password_staff.Name = "textbox_password_staff";
            this.textbox_password_staff.PasswordChar = '*';
            this.textbox_password_staff.PlaceholderText = "Enter your password...";
            this.textbox_password_staff.SelectedText = "";
            this.textbox_password_staff.ShadowDecoration.Parent = this.textbox_password_staff;
            this.textbox_password_staff.Size = new System.Drawing.Size(270, 43);
            this.textbox_password_staff.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textbox_username_staff
            // 
            this.textbox_username_staff.BorderRadius = 15;
            this.textbox_username_staff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textbox_username_staff.DefaultText = "";
            this.textbox_username_staff.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textbox_username_staff.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textbox_username_staff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_username_staff.DisabledState.Parent = this.textbox_username_staff;
            this.textbox_username_staff.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textbox_username_staff.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_username_staff.FocusedState.Parent = this.textbox_username_staff;
            this.textbox_username_staff.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textbox_username_staff.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textbox_username_staff.HoverState.Parent = this.textbox_username_staff;
            this.textbox_username_staff.Location = new System.Drawing.Point(173, 105);
            this.textbox_username_staff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox_username_staff.Name = "textbox_username_staff";
            this.textbox_username_staff.PasswordChar = '\0';
            this.textbox_username_staff.PlaceholderText = "Enter your username...";
            this.textbox_username_staff.SelectedText = "";
            this.textbox_username_staff.ShadowDecoration.Parent = this.textbox_username_staff;
            this.textbox_username_staff.Size = new System.Drawing.Size(270, 43);
            this.textbox_username_staff.TabIndex = 2;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 400);
            this.Controls.Add(this.tabControl_Customer);
            this.Name = "LoginForm";
            this.Text = "Restaurant Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.tabControl_Customer.ResumeLayout(false);
            this.tabPage_Customer.ResumeLayout(false);
            this.tabPage_Customer.PerformLayout();
            this.tabPage_Staff.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Customer;
        private System.Windows.Forms.TabPage tabPage_Customer;
        private System.Windows.Forms.TabPage tabPage_Staff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox textbox_email;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox textbox_Password;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox textbox_password_staff;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox textbox_username_staff;
        private System.Windows.Forms.Label label_register;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button button_Login;
        private Guna.UI2.WinForms.Guna2Button button_Login_Staff;
        private System.Windows.Forms.Label label_Alert_Customer;
        private System.Windows.Forms.Label label_Alert_Staff;
    }
}