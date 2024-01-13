
namespace Prototype2
{
    partial class FormProfitCalc
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
            this.lblBudget = new System.Windows.Forms.Label();
            this.btnCalc = new Guna.UI2.WinForms.Guna2Button();
            this.txtFirstBudget = new System.Windows.Forms.TextBox();
            this.listbxProfit = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumSnack = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFilm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCostSnack = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostFilm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.ForeColor = System.Drawing.Color.Lavender;
            this.lblBudget.Location = new System.Drawing.Point(44, 34);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(193, 20);
            this.lblBudget.TabIndex = 13;
            this.lblBudget.Text = "Enter your starting budget";
            // 
            // btnCalc
            // 
            this.btnCalc.Animated = true;
            this.btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.btnCalc.CheckedState.Parent = this.btnCalc;
            this.btnCalc.CustomImages.Parent = this.btnCalc;
            this.btnCalc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalc.DisabledState.Parent = this.btnCalc;
            this.btnCalc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalc.ForeColor = System.Drawing.Color.White;
            this.btnCalc.HoverState.Parent = this.btnCalc;
            this.btnCalc.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCalc.Location = new System.Drawing.Point(429, 285);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.ShadowDecoration.Parent = this.btnCalc;
            this.btnCalc.Size = new System.Drawing.Size(161, 66);
            this.btnCalc.TabIndex = 12;
            this.btnCalc.Text = "Calculate Profit";
            this.btnCalc.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtFirstBudget
            // 
            this.txtFirstBudget.BackColor = System.Drawing.Color.MediumPurple;
            this.txtFirstBudget.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtFirstBudget.ForeColor = System.Drawing.Color.Lavender;
            this.txtFirstBudget.Location = new System.Drawing.Point(48, 91);
            this.txtFirstBudget.Multiline = true;
            this.txtFirstBudget.Name = "txtFirstBudget";
            this.txtFirstBudget.Size = new System.Drawing.Size(157, 30);
            this.txtFirstBudget.TabIndex = 11;
            // 
            // listbxProfit
            // 
            this.listbxProfit.FormattingEnabled = true;
            this.listbxProfit.ItemHeight = 20;
            this.listbxProfit.Location = new System.Drawing.Point(48, 310);
            this.listbxProfit.Name = "listbxProfit";
            this.listbxProfit.Size = new System.Drawing.Size(144, 104);
            this.listbxProfit.TabIndex = 14;
            this.listbxProfit.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(302, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Number of snacks bought";
            // 
            // txtNumSnack
            // 
            this.txtNumSnack.BackColor = System.Drawing.Color.MediumPurple;
            this.txtNumSnack.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNumSnack.ForeColor = System.Drawing.Color.Lavender;
            this.txtNumSnack.Location = new System.Drawing.Point(306, 91);
            this.txtNumSnack.Multiline = true;
            this.txtNumSnack.Name = "txtNumSnack";
            this.txtNumSnack.Size = new System.Drawing.Size(157, 30);
            this.txtNumSnack.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(302, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Number of films bought";
            // 
            // txtNumFilm
            // 
            this.txtNumFilm.BackColor = System.Drawing.Color.MediumPurple;
            this.txtNumFilm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtNumFilm.ForeColor = System.Drawing.Color.Lavender;
            this.txtNumFilm.Location = new System.Drawing.Point(306, 219);
            this.txtNumFilm.Multiline = true;
            this.txtNumFilm.Name = "txtNumFilm";
            this.txtNumFilm.Size = new System.Drawing.Size(157, 30);
            this.txtNumFilm.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(566, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cost of snacks bought";
            // 
            // txtCostSnack
            // 
            this.txtCostSnack.BackColor = System.Drawing.Color.MediumPurple;
            this.txtCostSnack.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCostSnack.ForeColor = System.Drawing.Color.Lavender;
            this.txtCostSnack.Location = new System.Drawing.Point(570, 91);
            this.txtCostSnack.Multiline = true;
            this.txtCostSnack.Name = "txtCostSnack";
            this.txtCostSnack.Size = new System.Drawing.Size(157, 30);
            this.txtCostSnack.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(566, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cost of films bought";
            // 
            // txtCostFilm
            // 
            this.txtCostFilm.BackColor = System.Drawing.Color.MediumPurple;
            this.txtCostFilm.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtCostFilm.ForeColor = System.Drawing.Color.Lavender;
            this.txtCostFilm.Location = new System.Drawing.Point(570, 219);
            this.txtCostFilm.Multiline = true;
            this.txtCostFilm.Name = "txtCostFilm";
            this.txtCostFilm.Size = new System.Drawing.Size(157, 30);
            this.txtCostFilm.TabIndex = 22;
            // 
            // FormProfitCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1077, 525);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCostFilm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCostSnack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumFilm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumSnack);
            this.Controls.Add(this.listbxProfit);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtFirstBudget);
            this.Name = "FormProfitCalc";
            this.Text = "FormProfitCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBudget;
        private Guna.UI2.WinForms.Guna2Button btnCalc;
        private System.Windows.Forms.TextBox txtFirstBudget;
        private System.Windows.Forms.ListBox listbxProfit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumSnack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCostSnack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCostFilm;
    }
}