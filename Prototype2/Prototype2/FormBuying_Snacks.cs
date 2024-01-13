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
    public partial class FormBuying_Snacks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");

        public FormBuying_Snacks()
        {
            InitializeComponent();
        }

        private void FormBuying_Snacks_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select snack_name from snack_tbl", con);
            
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbSnackName1.Items.Add(reader["snack_name"].ToString());
                    cmbSnackNum1.Items.Add(reader["snack_name"].ToString());
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

        private void btnProfit_Click(object sender, EventArgs e)
        {

            float total_price=0;
            float snack_price1 = 0;
            
            int snack_number1 = 0;
            

            SqlCommand cmd = new SqlCommand("select snack_price from snack_tbl where snack_name='" +cmbSnackName1.SelectedItem.ToString() + "'", con);
            
        
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
                {
                     snack_price1 = Convert.ToInt32(reader["snack_price"].ToString());
                     snack_number1 = Convert.ToInt32(cmbSnackNum1.SelectedItem.ToString());
                  
                    total_price = snack_price1 * snack_number1 ;
                    label5.Text = total_price.ToString();
                   // MessageBox.Show(total_price.ToString(), "Total Price");
                }
            }

        private void cmbSnackNum1_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
