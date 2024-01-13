using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Prototype2
{
    public partial class FormReview : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");
        public FormReview()
        {
            InitializeComponent();
        }


        private void btnSaveReview_Click(object sender, EventArgs e)
        {
            
            
            if (txtReviewBody.Text!="" && txtReviewTopic.Text!="")
            {
                con.Open();
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO review_tbl(username, review_topic, review_text) VALUES('" + txtUsername.Text + "', '" + txtReviewTopic.Text + "', '" + txtReviewBody.Text + "')", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
                finally
                {
                    con.Close();
                }
                MessageBox.Show("Congratulations! Your review have successfully saved.");
                this.Close();
                

            }
            else
            {
                MessageBox.Show("Error! Rewrite the passwords and check if there are the same and fill all fields! ");
            }
        }

    }
}
