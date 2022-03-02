
namespace FinalProjectST
{
    partial class ThanksForm
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
            this.button_OK = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "We will deliver your foods as soon as possible";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_OK
            // 
            this.button_OK.BorderRadius = 12;
            this.button_OK.CheckedState.Parent = this.button_OK;
            this.button_OK.CustomImages.Parent = this.button_OK;
            this.button_OK.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_OK.ForeColor = System.Drawing.Color.White;
            this.button_OK.HoverState.Parent = this.button_OK;
            this.button_OK.Location = new System.Drawing.Point(211, 351);
            this.button_OK.Name = "button_OK";
            this.button_OK.ShadowDecoration.Parent = this.button_OK;
            this.button_OK.Size = new System.Drawing.Size(135, 36);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // ThanksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProjectST.Properties.Resources.thanks;
            this.ClientSize = new System.Drawing.Size(558, 399);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label1);
            this.Name = "ThanksForm";
            this.Text = "Thank You!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button button_OK;
    }
}