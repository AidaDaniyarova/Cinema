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
    public partial class FormBuying : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");
        public FormBuying()
        {
            InitializeComponent();
        }

        private void FormBuying_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select title from film_tbl", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbFilmName.Items.Add(reader["title"].ToString());
                    
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

        private void btnTotalPrice_Click(object sender, EventArgs e)
        {
            float total_price = 0;
            float tic_price1 = 0;
            float tic_price2 = 0;
            float tic_price3 = 0;
            int people_number1 = 0;
            int people_number2 = 0;
            int people_number3 = 0;
            if (cmbAgeGroup1.SelectedItem.ToString() == "Adult")
            {
                SqlCommand cmd = new SqlCommand("select adult_price from tickets_tbl where ticketID=3", con);
                try
                {
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tic_price1 = Convert.ToInt32(reader["adult_price"].ToString());
                        people_number1 = Convert.ToInt32(cmbPeopleNum1.SelectedItem.ToString());
                        total_price = tic_price1 * people_number1 + tic_price2 * people_number2 + tic_price3 * people_number3;
                        MessageBox.Show(total_price.ToString(), "Total Price");
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
                if (cmbAgeGroup1.SelectedItem.ToString() == "Child")
                {
                    SqlCommand cmd = new SqlCommand("select child_price from tickets_tbl where ticketID=3", con);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            tic_price1 = Convert.ToInt32(reader["child_price"].ToString());
                            people_number1 = Convert.ToInt32(cmbPeopleNum1.SelectedItem.ToString());
                            total_price = tic_price1 * people_number1 + tic_price2 * people_number2 + tic_price3 * people_number3;
                            MessageBox.Show(total_price.ToString(), "Total Price");
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
                    if (cmbAgeGroup1.SelectedItem.ToString() == "Student")
                    {
                        SqlCommand cmd = new SqlCommand("select student_price from tickets_tbl where ticketID=3", con);
                        try
                        {
                            con.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {
                                tic_price1 = Convert.ToInt32(reader["student_price"].ToString());
                                people_number1 = Convert.ToInt32(cmbPeopleNum1.SelectedItem.ToString());
                                total_price = tic_price1 * people_number1 + tic_price2 * people_number2 + tic_price3 * people_number3;
                                MessageBox.Show(total_price.ToString(), "Total Price");
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
                        if (cmbAgeGroup1.SelectedItem.ToString() == "Retiree")
                        {
                            SqlCommand cmd = new SqlCommand("select retiree_price from tickets_tbl where ticketID=3", con);
                            try
                            {
                                con.Open();
                                SqlDataReader reader = cmd.ExecuteReader();
                                while (reader.Read())
                                {
                                    tic_price1 = Convert.ToInt32(reader["retiree_price"].ToString());
                                    people_number1 = Convert.ToInt32(cmbPeopleNum1.SelectedItem.ToString());
                                    total_price = tic_price1 * people_number1 + tic_price2 * people_number2 + tic_price3 * people_number3;
                                    MessageBox.Show(total_price.ToString(), "Total Price");
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
                    }
                    
                }

            }
        }
    }
}
