
namespace Prototype2
{
    partial class FormBuyingSnacks
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
            this.components = new System.ComponentModel.Container();
            this.login1DataSet1 = new Prototype2.Login1DataSet1();
            this.snacktblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.snack_tblTableAdapter = new Prototype2.Login1DataSet1TableAdapters.snack_tblTableAdapter();
            this.lblSnackname = new System.Windows.Forms.Label();
            this.lblSnacknumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTotalPrice = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSnackNum1 = new System.Windows.Forms.NumericUpDown();
            this.cmbSnackNum2 = new System.Windows.Forms.NumericUpDown();
            this.cmbSnackNum3 = new System.Windows.Forms.NumericUpDown();
            this.cmbSnackName3 = new Prototype2.Combobox();
            this.cmbSnackName2 = new Prototype2.Combobox();
            this.cmbSnackName1 = new Prototype2.Combobox();
            ((System.ComponentModel.ISupportInitialize)(this.login1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snacktblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSnackNum1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSnackNum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSnackNum3)).BeginInit();
            this.SuspendLayout();
            // 
            // login1DataSet1
            // 
            this.login1DataSet1.DataSetName = "Login1DataSet1";
            this.login1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // snacktblBindingSource
            // 
            this.snacktblBindingSource.DataMember = "snack_tbl";
            this.snacktblBindingSource.DataSource = this.login1DataSet1;
            // 
            // snack_tblTableAdapter
            // 
            this.snack_tblTableAdapter.ClearBeforeFill = true;
            // 
            // lblSnackname
            // 
            this.lblSnackname.AutoSize = true;
            this.lblSnackname.ForeColor = System.Drawing.Color.Lavender;
            this.lblSnackname.Location = new System.Drawing.Point(32, 52);
            this.lblSnackname.Name = "lblSnackname";
            this.lblSnackname.Size = new System.Drawing.Size(114, 20);
            this.lblSnackname.TabIndex = 11;
            this.lblSnackname.Text = "Choose snack:";
            // 
            // lblSnacknumber
            // 
            this.lblSnacknumber.AutoSize = true;
            this.lblSnacknumber.ForeColor = System.Drawing.Color.Lavender;
            this.lblSnacknumber.Location = new System.Drawing.Point(341, 52);
            this.lblSnacknumber.Name = "lblSnacknumber";
            this.lblSnacknumber.Size = new System.Drawing.Size(116, 20);
            this.lblSnacknumber.TabIndex = 13;
            this.lblSnacknumber.Text = "Snack number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(341, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Snack number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lavender;
            this.label2.Location = new System.Drawing.Point(32, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Choose snack:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(341, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Snack number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lavender;
            this.label4.Location = new System.Drawing.Point(32, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Choose snack:";
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.Animated = true;
            this.btnTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.btnTotalPrice.CheckedState.Parent = this.btnTotalPrice;
            this.btnTotalPrice.CustomImages.Parent = this.btnTotalPrice;
            this.btnTotalPrice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalPrice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTotalPrice.DisabledState.Parent = this.btnTotalPrice;
            this.btnTotalPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTotalPrice.ForeColor = System.Drawing.Color.White;
            this.btnTotalPrice.HoverState.Parent = this.btnTotalPrice;
            this.btnTotalPrice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTotalPrice.Location = new System.Drawing.Point(345, 436);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.ShadowDecoration.Parent = this.btnTotalPrice;
            this.btnTotalPrice.Size = new System.Drawing.Size(204, 66);
            this.btnTotalPrice.TabIndex = 22;
            this.btnTotalPrice.Text = "Calculate total price";
            this.btnTotalPrice.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnProfit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "0";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(647, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "0";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(647, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "0";
            this.label7.Visible = false;
            // 
            // cmbSnackNum1
            // 
            this.cmbSnackNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSnackNum1.Location = new System.Drawing.Point(345, 97);
            this.cmbSnackNum1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.cmbSnackNum1.Name = "cmbSnackNum1";
            this.cmbSnackNum1.Size = new System.Drawing.Size(158, 30);
            this.cmbSnackNum1.TabIndex = 26;
            this.cmbSnackNum1.ValueChanged += new System.EventHandler(this.cmbSnackNum1_Click);
            // 
            // cmbSnackNum2
            // 
            this.cmbSnackNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSnackNum2.Location = new System.Drawing.Point(345, 229);
            this.cmbSnackNum2.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.cmbSnackNum2.Name = "cmbSnackNum2";
            this.cmbSnackNum2.Size = new System.Drawing.Size(158, 30);
            this.cmbSnackNum2.TabIndex = 27;
            this.cmbSnackNum2.ValueChanged += new System.EventHandler(this.cmbSnackNum2_Click);
            // 
            // cmbSnackNum3
            // 
            this.cmbSnackNum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSnackNum3.Location = new System.Drawing.Point(345, 357);
            this.cmbSnackNum3.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.cmbSnackNum3.Name = "cmbSnackNum3";
            this.cmbSnackNum3.Size = new System.Drawing.Size(158, 30);
            this.cmbSnackNum3.TabIndex = 28;
            this.cmbSnackNum3.ValueChanged += new System.EventHandler(this.cmbSnackNum3_Click);
            // 
            // cmbSnackName3
            // 
            this.cmbSnackName3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSnackName3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSnackName3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSnackName3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.cmbSnackName3.BorderSize = 3;
            this.cmbSnackName3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbSnackName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSnackName3.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSnackName3.IconColor = System.Drawing.Color.Crimson;
            this.cmbSnackName3.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbSnackName3.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbSnackName3.Location = new System.Drawing.Point(36, 357);
            this.cmbSnackName3.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbSnackName3.Name = "cmbSnackName3";
            this.cmbSnackName3.Padding = new System.Windows.Forms.Padding(3);
            this.cmbSnackName3.Size = new System.Drawing.Size(200, 41);
            this.cmbSnackName3.TabIndex = 18;
            this.cmbSnackName3.Texts = "";
            // 
            // cmbSnackName2
            // 
            this.cmbSnackName2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSnackName2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSnackName2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSnackName2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.cmbSnackName2.BorderSize = 3;
            this.cmbSnackName2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbSnackName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSnackName2.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSnackName2.IconColor = System.Drawing.Color.Crimson;
            this.cmbSnackName2.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbSnackName2.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbSnackName2.Location = new System.Drawing.Point(36, 229);
            this.cmbSnackName2.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbSnackName2.Name = "cmbSnackName2";
            this.cmbSnackName2.Padding = new System.Windows.Forms.Padding(3);
            this.cmbSnackName2.Size = new System.Drawing.Size(200, 41);
            this.cmbSnackName2.TabIndex = 14;
            this.cmbSnackName2.Texts = "";
            // 
            // cmbSnackName1
            // 
            this.cmbSnackName1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSnackName1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSnackName1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSnackName1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.cmbSnackName1.BorderSize = 3;
            this.cmbSnackName1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbSnackName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSnackName1.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSnackName1.IconColor = System.Drawing.Color.Crimson;
            this.cmbSnackName1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbSnackName1.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbSnackName1.Location = new System.Drawing.Point(36, 97);
            this.cmbSnackName1.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbSnackName1.Name = "cmbSnackName1";
            this.cmbSnackName1.Padding = new System.Windows.Forms.Padding(3);
            this.cmbSnackName1.Size = new System.Drawing.Size(200, 41);
            this.cmbSnackName1.TabIndex = 1;
            this.cmbSnackName1.Texts = "";
            // 
            // FormBuyingSnacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(849, 572);
            this.Controls.Add(this.cmbSnackNum3);
            this.Controls.Add(this.cmbSnackNum2);
            this.Controls.Add(this.cmbSnackNum1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSnackName3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSnackName2);
            this.Controls.Add(this.lblSnacknumber);
            this.Controls.Add(this.lblSnackname);
            this.Controls.Add(this.cmbSnackName1);
            this.Name = "FormBuyingSnacks";
            this.Text = "Закуски";
            this.Load += new System.EventHandler(this.FormBuying_Snacks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snacktblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSnackNum1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSnackNum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSnackNum3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Login1DataSet1 login1DataSet1;
        private System.Windows.Forms.BindingSource snacktblBindingSource;
        private Login1DataSet1TableAdapters.snack_tblTableAdapter snack_tblTableAdapter;
        private Combobox cmbSnackName1;
        private System.Windows.Forms.Label lblSnackname;
        private System.Windows.Forms.Label lblSnacknumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Combobox cmbSnackName2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Combobox cmbSnackName3;
        private Guna.UI2.WinForms.Guna2Button btnTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown cmbSnackNum1;
        private System.Windows.Forms.NumericUpDown cmbSnackNum2;
        private System.Windows.Forms.NumericUpDown cmbSnackNum3;
    }
}