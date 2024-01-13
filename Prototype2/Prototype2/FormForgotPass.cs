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
using System.Text.RegularExpressions;

namespace Prototype2
{
    public partial class FormForgotPass : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");
        public FormForgotPass()
        {
            InitializeComponent();
        }

        private void btnPassRecovery_Click(object sender, EventArgs e)
        {

            var EmailId = txtEmail.Text;


            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

            if (Regex.IsMatch(EmailId, pattern))
            {//if email is valid
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from user_tbl where username='" + txtUsername.Text + "' and email= '" + txtEmail.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    SqlCommand cmd = new SqlCommand("select password from user_tbl", con);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string password = (reader["password"].ToString());
                            MessageBox.Show("Your password is: "+password);
                            
                        }
                    }
                    catch (Exception b)
                    {
                        MessageBox.Show(b.ToString());
                    }
                    finally
                    {
                        con.Close();
                    }

                }
                else
                {
                   
                    MessageBox.Show("Please, check your username and password!");
                }

            }
            else
            {
                MessageBox.Show("Error! Email is not valid, please rewrite it!");
            }
        }
    }
}
