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
    public partial class FormPersInfo : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");
        public FormPersInfo()
        {
            InitializeComponent();
        }

        private void btnPersoSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" && txtPhoneNumber.Text != "")
            {
                con.Open();
                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter("INSERT INTO user_tbl(address, first_name, last_name, phone_number) VALUES('" + txtAddress.Text + "', '" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtPhoneNumber.Text + "') WHERE(username = '" + txtUsername.Text + "')", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Fill all fields to login.");
            }
        }
    }
}
