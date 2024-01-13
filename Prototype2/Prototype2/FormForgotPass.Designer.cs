
namespace Prototype2
{
    partial class FormForgotPass
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
            this.btnPassRecovery = new Guna.UI2.WinForms.Guna2Button();
            this.lblpass = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPassRecovery
            // 
            this.btnPassRecovery.Animated = true;
            this.btnPassRecovery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.btnPassRecovery.CheckedState.Parent = this.btnPassRecovery;
            this.btnPassRecovery.CustomImages.Parent = this.btnPassRecovery;
            this.btnPassRecovery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPassRecovery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPassRecovery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPassRecovery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPassRecovery.DisabledState.Parent = this.btnPassRecovery;
            this.btnPassRecovery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnPassRecovery.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPassRecovery.ForeColor = System.Drawing.Color.White;
            this.btnPassRecovery.HoverState.Parent = this.btnPassRecovery;
            this.btnPassRecovery.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnPassRecovery.Location = new System.Drawing.Point(188, 182);
            this.btnPassRecovery.Name = "btnPassRecovery";
            this.btnPassRecovery.ShadowDecoration.Parent = this.btnPassRecovery;
            this.btnPassRecovery.Size = new System.Drawing.Size(262, 60);
            this.btnPassRecovery.TabIndex = 3;
            this.btnPassRecovery.Text = "Войти";
            this.btnPassRecovery.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnPassRecovery.Click += new System.EventHandler(this.btnPassRecovery_Click);
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.ForeColor = System.Drawing.Color.Lavender;
            this.lblpass.Location = new System.Drawing.Point(54, 40);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(500, 20);
            this.lblpass.TabIndex = 12;
            this.lblpass.Text = "Напишите ваш никнейм и почту для нахождения вашего пароля";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.MediumPurple;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtEmail.ForeColor = System.Drawing.Color.Lavender;
            this.txtEmail.Location = new System.Drawing.Point(380, 107);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(223, 30);
            this.txtEmail.TabIndex = 11;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.MediumPurple;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.Lavender;
            this.txtUsername.Location = new System.Drawing.Point(42, 107);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(223, 30);
            this.txtUsername.TabIndex = 13;
            // 
            // FormForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(112)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(660, 336);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnPassRecovery);
            this.Name = "FormForgotPass";
            this.Text = "FormForgotPass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPassRecovery;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
    }
}