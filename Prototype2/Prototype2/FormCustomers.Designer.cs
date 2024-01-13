
namespace Prototype2
{
    partial class FormCustomers
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
            this.login1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login1DataSet = new Prototype2.Login1DataSet();
            this.pnlclient = new System.Windows.Forms.Panel();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.lblId = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpload = new Guna.UI2.WinForms.Guna2Button();
            this.btnFilms = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.cmbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.login1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login1DataSet)).BeginInit();
            this.pnlclient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();
            // 
            // login1DataSetBindingSource
            // 
            this.login1DataSetBindingSource.DataSource = this.login1DataSet;
            this.login1DataSetBindingSource.Position = 0;
            // 
            // login1DataSet
            // 
            this.login1DataSet.DataSetName = "Login1DataSet";
            this.login1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlclient
            // 
            this.pnlclient.Controls.Add(this.btnReload);
            this.pnlclient.Controls.Add(this.dgvUser);
            this.pnlclient.Controls.Add(this.lblId);
            this.pnlclient.Controls.Add(this.txtUserName);
            this.pnlclient.Controls.Add(this.guna2Button1);
            this.pnlclient.Controls.Add(this.btnUpload);
            this.pnlclient.Controls.Add(this.btnFilms);
            this.pnlclient.Controls.Add(this.btnEdit);
            this.pnlclient.Controls.Add(this.cmbSort);
            this.pnlclient.Controls.Add(this.lblSort);
            this.pnlclient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlclient.Location = new System.Drawing.Point(0, 0);
            this.pnlclient.Name = "pnlclient";
            this.pnlclient.Size = new System.Drawing.Size(1553, 669);
            this.pnlclient.TabIndex = 11;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnReload.CheckedState.Parent = this.btnReload;
            this.btnReload.CustomImages.Parent = this.btnReload;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.DisabledState.Parent = this.btnReload;
            this.btnReload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.Lavender;
            this.btnReload.HoverState.Parent = this.btnReload;
            this.btnReload.Location = new System.Drawing.Point(699, 21);
            this.btnReload.Name = "btnReload";
            this.btnReload.ShadowDecoration.Parent = this.btnReload;
            this.btnReload.Size = new System.Drawing.Size(115, 45);
            this.btnReload.TabIndex = 21;
            this.btnReload.Text = "Обновить";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(12, 126);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersWidth = 62;
            this.dgvUser.RowTemplate.Height = 28;
            this.dgvUser.Size = new System.Drawing.Size(1510, 452);
            this.dgvUser.TabIndex = 20;
            this.dgvUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellContentClick);
            this.dgvUser.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellValueChanged);
            this.dgvUser.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvUser_EditingControlShowing);
            this.dgvUser.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvUser_UserAddedRow);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblId.Location = new System.Drawing.Point(32, 599);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(221, 25);
            this.lblId.TabIndex = 19;
            this.lblId.Text = "Введите ID пользователя ";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.MediumPurple;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUserName.ForeColor = System.Drawing.Color.Lavender;
            this.txtUserName.Location = new System.Drawing.Point(285, 599);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 45);
            this.txtUserName.TabIndex = 18;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.DisabledState.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Lavender;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(497, 599);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(96, 45);
            this.guna2Button1.TabIndex = 16;
            this.guna2Button1.Text = "Удалить";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnUpload.CheckedState.Parent = this.btnUpload;
            this.btnUpload.CustomImages.Parent = this.btnUpload;
            this.btnUpload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpload.DisabledState.Parent = this.btnUpload;
            this.btnUpload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpload.ForeColor = System.Drawing.Color.Lavender;
            this.btnUpload.HoverState.Parent = this.btnUpload;
            this.btnUpload.Location = new System.Drawing.Point(615, 599);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.ShadowDecoration.Parent = this.btnUpload;
            this.btnUpload.Size = new System.Drawing.Size(156, 45);
            this.btnUpload.TabIndex = 15;
            this.btnUpload.Text = "Редактировать";
            // 
            // btnFilms
            // 
            this.btnFilms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnFilms.FlatAppearance.BorderSize = 0;
            this.btnFilms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilms.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFilms.ForeColor = System.Drawing.Color.Lavender;
            this.btnFilms.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFilms.IconColor = System.Drawing.Color.Lavender;
            this.btnFilms.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFilms.IconSize = 32;
            this.btnFilms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilms.Location = new System.Drawing.Point(842, 21);
            this.btnFilms.Name = "btnFilms";
            this.btnFilms.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFilms.Size = new System.Drawing.Size(188, 45);
            this.btnFilms.TabIndex = 14;
            this.btnFilms.Text = "Фильтровать";
            this.btnFilms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFilms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFilms.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.DisabledState.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.Lavender;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(1046, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(180, 45);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Изменить данные";
            // 
            // cmbSort
            // 
            this.cmbSort.BackColor = System.Drawing.Color.Transparent;
            this.cmbSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSort.FocusedState.Parent = this.cmbSort;
            this.cmbSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSort.HoverState.Parent = this.cmbSort;
            this.cmbSort.ItemHeight = 30;
            this.cmbSort.Items.AddRange(new object[] {
            "ID",
            "Fisrts name",
            "Last name"});
            this.cmbSort.ItemsAppearance.Parent = this.cmbSort;
            this.cmbSort.Location = new System.Drawing.Point(211, 41);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.ShadowDecoration.Parent = this.cmbSort;
            this.cmbSort.Size = new System.Drawing.Size(188, 36);
            this.cmbSort.TabIndex = 12;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSort.ForeColor = System.Drawing.Color.Lavender;
            this.lblSort.Location = new System.Drawing.Point(56, 41);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(149, 25);
            this.lblSort.TabIndex = 11;
            this.lblSort.Text = "Сортировать по:";
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(1553, 669);
            this.Controls.Add(this.pnlclient);
            this.Name = "FormCustomers";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.FormCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login1DataSet)).EndInit();
            this.pnlclient.ResumeLayout(false);
            this.pnlclient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource login1DataSetBindingSource;
        private Login1DataSet login1DataSet;
        private System.Windows.Forms.Panel pnlclient;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnUpload;
        private FontAwesome.Sharp.IconButton btnFilms;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.DataGridView dgvUser;
        private Guna.UI2.WinForms.Guna2Button btnReload;
    }
}