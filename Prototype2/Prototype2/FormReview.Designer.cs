
namespace Prototype2
{
    partial class FormReview
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
            this.btnSaveReview = new Guna.UI2.WinForms.Guna2Button();
            this.txtReviewTopic = new System.Windows.Forms.TextBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.lblBody = new System.Windows.Forms.Label();
            this.txtReviewBody = new System.Windows.Forms.TextBox();
            this.dateWrittenReview = new System.Windows.Forms.DateTimePicker();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveReview
            // 
            this.btnSaveReview.Animated = true;
            this.btnSaveReview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.btnSaveReview.CheckedState.Parent = this.btnSaveReview;
            this.btnSaveReview.CustomImages.Parent = this.btnSaveReview;
            this.btnSaveReview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveReview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveReview.DisabledState.Parent = this.btnSaveReview;
            this.btnSaveReview.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(199)))), ((int)(((byte)(140)))));
            this.btnSaveReview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveReview.ForeColor = System.Drawing.Color.White;
            this.btnSaveReview.HoverState.Parent = this.btnSaveReview;
            this.btnSaveReview.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSaveReview.Location = new System.Drawing.Point(470, 349);
            this.btnSaveReview.Name = "btnSaveReview";
            this.btnSaveReview.ShadowDecoration.Parent = this.btnSaveReview;
            this.btnSaveReview.Size = new System.Drawing.Size(157, 47);
            this.btnSaveReview.TabIndex = 12;
            this.btnSaveReview.Text = "Save a review";
            this.btnSaveReview.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.btnSaveReview.Click += new System.EventHandler(this.btnSaveReview_Click);
            // 
            // txtReviewTopic
            // 
            this.txtReviewTopic.BackColor = System.Drawing.Color.MediumPurple;
            this.txtReviewTopic.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtReviewTopic.ForeColor = System.Drawing.Color.Lavender;
            this.txtReviewTopic.Location = new System.Drawing.Point(272, 79);
            this.txtReviewTopic.Multiline = true;
            this.txtReviewTopic.Name = "txtReviewTopic";
            this.txtReviewTopic.Size = new System.Drawing.Size(409, 36);
            this.txtReviewTopic.TabIndex = 13;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.ForeColor = System.Drawing.Color.Lavender;
            this.lblTopic.Location = new System.Drawing.Point(26, 91);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(144, 20);
            this.lblTopic.TabIndex = 14;
            this.lblTopic.Text = "Topic of the review:";
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.ForeColor = System.Drawing.Color.Lavender;
            this.lblBody.Location = new System.Drawing.Point(26, 146);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(138, 20);
            this.lblBody.TabIndex = 15;
            this.lblBody.Text = "Body of the review";
            // 
            // txtReviewBody
            // 
            this.txtReviewBody.BackColor = System.Drawing.Color.MediumPurple;
            this.txtReviewBody.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtReviewBody.ForeColor = System.Drawing.Color.Lavender;
            this.txtReviewBody.Location = new System.Drawing.Point(272, 146);
            this.txtReviewBody.Multiline = true;
            this.txtReviewBody.Name = "txtReviewBody";
            this.txtReviewBody.Size = new System.Drawing.Size(409, 181);
            this.txtReviewBody.TabIndex = 16;
            // 
            // dateWrittenReview
            // 
            this.dateWrittenReview.CalendarTitleForeColor = System.Drawing.Color.MediumPurple;
            this.dateWrittenReview.Location = new System.Drawing.Point(30, 194);
            this.dateWrittenReview.Name = "dateWrittenReview";
            this.dateWrittenReview.Size = new System.Drawing.Size(200, 26);
            this.dateWrittenReview.TabIndex = 17;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.MediumPurple;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txtUsername.ForeColor = System.Drawing.Color.Lavender;
            this.txtUsername.Location = new System.Drawing.Point(272, 37);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 36);
            this.txtUsername.TabIndex = 18;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.Lavender;
            this.lblUsername.Location = new System.Drawing.Point(26, 53);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(142, 20);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "From (Your name):";
            // 
            // FormReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.dateWrittenReview);
            this.Controls.Add(this.txtReviewBody);
            this.Controls.Add(this.lblBody);
            this.Controls.Add(this.lblTopic);
            this.Controls.Add(this.txtReviewTopic);
            this.Controls.Add(this.btnSaveReview);
            this.Name = "FormReview";
            this.Text = "g";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSaveReview;
        private System.Windows.Forms.TextBox txtReviewTopic;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.TextBox txtReviewBody;
        private System.Windows.Forms.DateTimePicker dateWrittenReview;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
    }
}