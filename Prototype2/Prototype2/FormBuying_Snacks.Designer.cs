
namespace Prototype2
{
    partial class FormBuying_Snacks
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
            this.btnTotalPrice = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSnackNum1 = new Prototype2.Combobox();
            this.cmbSnackName1 = new Prototype2.Combobox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.login1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snacktblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.lblSnackname.Location = new System.Drawing.Point(27, 61);
            this.lblSnackname.Name = "lblSnackname";
            this.lblSnackname.Size = new System.Drawing.Size(130, 20);
            this.lblSnackname.TabIndex = 11;
            this.lblSnackname.Text = "выберите стэки";
            // 
            // lblSnacknumber
            // 
            this.lblSnacknumber.AutoSize = true;
            this.lblSnacknumber.ForeColor = System.Drawing.Color.Lavender;
            this.lblSnacknumber.Location = new System.Drawing.Point(448, 61);
            this.lblSnacknumber.Name = "lblSnacknumber";
            this.lblSnacknumber.Size = new System.Drawing.Size(59, 20);
            this.lblSnacknumber.TabIndex = 13;
            this.lblSnacknumber.Text = "кол-во";
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
            this.label5.Location = new System.Drawing.Point(147, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 462);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "label6";
            // 
            // cmbSnackNum1
            // 
            this.cmbSnackNum1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSnackNum1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSnackNum1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbSnackNum1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.cmbSnackNum1.BorderSize = 3;
            this.cmbSnackNum1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbSnackNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbSnackNum1.ForeColor = System.Drawing.Color.DimGray;
            this.cmbSnackNum1.IconColor = System.Drawing.Color.Crimson;
            this.cmbSnackNum1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbSnackNum1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbSnackNum1.ListTextColor = System.Drawing.Color.DimGray;
            this.cmbSnackNum1.Location = new System.Drawing.Point(237, 97);
            this.cmbSnackNum1.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbSnackNum1.Name = "cmbSnackNum1";
            this.cmbSnackNum1.Padding = new System.Windows.Forms.Padding(3);
            this.cmbSnackNum1.Size = new System.Drawing.Size(200, 41);
            this.cmbSnackNum1.TabIndex = 12;
            this.cmbSnackNum1.Texts = "";
            this.cmbSnackNum1.OnSelectedIndexChanged += new System.EventHandler(this.cmbSnackNum1_OnSelectedIndexChanged);
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
            this.cmbSnackName1.Location = new System.Drawing.Point(31, 97);
            this.cmbSnackName1.MinimumSize = new System.Drawing.Size(200, 30);
            this.cmbSnackName1.Name = "cmbSnackName1";
            this.cmbSnackName1.Padding = new System.Windows.Forms.Padding(3);
            this.cmbSnackName1.Size = new System.Drawing.Size(200, 41);
            this.cmbSnackName1.TabIndex = 1;
            this.cmbSnackName1.Texts = "";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(452, 104);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(249, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "цена";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(31, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(735, 173);
            this.dataGridView1.TabIndex = 26;
            // 
            // FormBuying_Snacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(849, 572);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.lblSnacknumber);
            this.Controls.Add(this.cmbSnackNum1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSnackname);
            this.Controls.Add(this.cmbSnackName1);
            this.Name = "FormBuying_Snacks";
            this.Text = "цена";
            this.Load += new System.EventHandler(this.FormBuying_Snacks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snacktblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private Combobox cmbSnackNum1;
        private Guna.UI2.WinForms.Guna2Button btnTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}