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
    public partial class FormProfitCalc : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");

        public FormProfitCalc()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            float profit = 0;
            float loss = 0;
            int budget = Convert.ToInt32(txtFirstBudget.Text);
            int snackCount = Convert.ToInt32(txtNumSnack.Text);
            int snackPrice = Convert.ToInt32(txtCostSnack.Text);
            int filmCount = Convert.ToInt32(txtNumFilm.Text);
            int filmPrice = Convert.ToInt32(txtCostFilm.Text);
            loss = (snackCount * snackPrice) + (filmCount * filmPrice);
            float final = 0;
            SqlCommand cmd = new SqlCommand("SELECT total_cost FROM snack_tbl", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    listbxProfit.Items.Add(reader["total_cost"].ToString());
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            SqlCommand cmmd = new SqlCommand("SELECT final_cost FROM booking_tbl", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmmd.ExecuteReader();

                while (reader.Read())
                {
                    listbxProfit.Items.Add(reader["final_cost"].ToString());
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            
            final = budget + profit - loss;
            MessageBox.Show(final.ToString(), "Final Calculation!");

        }
        
        
    }
}
