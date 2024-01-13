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
    public partial class FormBuyingTicket : Form
    {
        static int seatbookbo = -1;
        public static Color free = Color.FromArgb(32, 199, 140);
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();


        public FormBuyingTicket()
        {
            InitializeComponent();
        }

        

        private void FormBuyingTicket_Load(object sender, EventArgs e)
        {
            
             seatstatus();
            SqlCommand cmd = new SqlCommand("select title from film_tbl", con);
            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbFilmName.Items.Add(reader["title"].ToString());
                    if (cmbFilmName.SelectedIndex == 0)
                    {
                        cmbTime.Items.Add("10:40");
                        cmbTime.Items.Add("12:40");
                        cmbTime.Items.Add("16:40");
                    }
                    else if (cmbFilmName.SelectedIndex == 1)
                    {
                        cmbTime.Items.Add("10:00");
                        cmbTime.Items.Add("11:20");
                        cmbTime.Items.Add("13:40");
                        cmbTime.Items.Add("15:30");
                        cmbTime.Items.Add("17:50");
                    }
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
            try
            {
                if (cmbFilmName.SelectedIndex == 0)
                {
                    cmbTime.Items.Add("10:40");
                    cmbTime.Items.Add("12:40");
                    cmbTime.Items.Add("16:40");
                }
                else if (cmbFilmName.SelectedIndex == 1)
                {
                    cmbTime.Items.Add("10:00");
                    cmbTime.Items.Add("11:20");
                    cmbTime.Items.Add("13:40");
                    cmbTime.Items.Add("15:30");
                    cmbTime.Items.Add("17:50");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void seatstatus()
        {
            string myquery = "Select * from seat_tbl";
            cmd.CommandText = myquery;
            cmd.Connection = con;
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            int rows = ds.Tables[0].Rows.Count;
            int i = 0;
            while (i < rows)
            {
                string status;
                status = ds.Tables[0].Rows[i]["seatStatus"].ToString();
                if (status == "F")
                {
                    if (i == 0 && seatbookbo - 1 != i)
                    {
                        btnSeatno1.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 1 && seatbookbo - 1 != i)
                    {
                        btnSeatno2.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 2 && seatbookbo - 1 != i)
                    {
                        btnSeatno3.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 3 && seatbookbo - 1 != i)
                    {
                        btnSeatno4.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 4 && seatbookbo - 1 != i)
                    {
                        btnSeatno5.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 5 && seatbookbo - 1 != i)
                    {
                        btnSeatno6.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 6 && seatbookbo - 1 != i)
                    {
                        btnSeatno7.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 7 && seatbookbo - 1 != i)
                    {
                        btnSeatno8.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 8 && seatbookbo - 1 != i)
                    {
                        btnSeatno9.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 9 && seatbookbo - 1 != i)
                    {
                        btnSeatno10.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 10 && seatbookbo - 1 != i)
                    {
                        btnSeatno11.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 11 && seatbookbo - 1 != i)
                    {
                        btnSeatno12.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 12 && seatbookbo - 1 != i)
                    {
                        btnSeatno13.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 13 && seatbookbo - 1 != i)
                    {
                        btnSeatno14.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 14 && seatbookbo - 1 != i)
                    {
                        btnSeatno15.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 15 && seatbookbo - 1 != i)
                    {
                        btnSeatno16.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 16 && seatbookbo - 1 != i)
                    {
                        btnSeatno17.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 17 && seatbookbo - 1 != i)
                    {
                        btnSeatno18.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 18 && seatbookbo - 1 != i)
                    {
                        btnSeatno19.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 19 && seatbookbo - 1 != i)
                    {
                        btnSeatno20.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 20 && seatbookbo - 1 != i)
                    {
                        btnSeatno21.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 21 && seatbookbo - 1 != i)
                    {
                        btnSeatno22.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 22 && seatbookbo - 1 != i)
                    {
                        btnSeatno23.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 23 && seatbookbo - 1 != i)
                    {
                        btnSeatno24.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 24 && seatbookbo - 1 != i)
                    {
                        btnSeatno25.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 25 && seatbookbo - 1 != i)
                    {
                        btnSeatno26.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 26 && seatbookbo - 1 != i)
                    {
                        btnSeatno27.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 27 && seatbookbo - 1 != i)
                    {
                        btnSeatno28.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 28 && seatbookbo - 1 != i)
                    {
                        btnSeatno29.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 29 && seatbookbo - 1 != i)
                    {
                        btnSeatno30.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 30 && seatbookbo - 1 != i)
                    {
                        btnSeatno31.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 31 && seatbookbo - 1 != i)
                    {
                        btnSeatno32.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 32 && seatbookbo - 1 != i)
                    {
                        btnSeatno33.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 33 && seatbookbo - 1 != i)
                    {
                        btnSeatno34.BackColor = Color.FromArgb(32, 199, 140);
                    }
                    if (i == 34 && seatbookbo - 1 != i)
                    {
                        btnSeatno35.BackColor = Color.FromArgb(32, 199, 140);
                    }
                }

                if (status == "N")
                {
                    if (i == 0)
                    {
                        btnSeatno1.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno1.Enabled = false;
                    }
                    if (i == 1)
                    {
                        btnSeatno2.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno2.Enabled = false;
                    }
                    if (i == 2)
                    {
                        btnSeatno3.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno3.Enabled = false;
                    }
                    if (i == 3)
                    {
                        btnSeatno4.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno4.Enabled = false;
                    }
                    if (i == 4)
                    {
                        btnSeatno5.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno5.Enabled = false;
                    }
                    if (i == 5)
                    {
                        btnSeatno6.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno6.Enabled = false;
                    }
                    if (i == 6)
                    {
                        btnSeatno7.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno7.Enabled = false;
                    }
                    if (i == 7)
                    {
                        btnSeatno8.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno8.Enabled = false;
                    }
                    if (i == 8)
                    {
                        btnSeatno9.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno9.Enabled = false;
                    }
                    if (i == 9)
                    {
                        btnSeatno10.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno10.Enabled = false;
                    }
                    if (i == 10)
                    {
                        btnSeatno11.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno11.Enabled = false;
                    }
                    if (i == 11)
                    {
                        btnSeatno12.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno12.Enabled = false;
                    }
                    if (i == 12)
                    {
                        btnSeatno13.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno13.Enabled = false;
                    }
                    if (i == 13)
                    {
                        btnSeatno14.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno14.Enabled = false;
                    }
                    if (i == 14)
                    {
                        btnSeatno15.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno15.Enabled = false;
                    }
                    if (i == 15)
                    {
                        btnSeatno16.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno16.Enabled = false;
                    }
                    if (i == 16)
                    {
                        btnSeatno17.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno17.Enabled = false;
                    }
                    if (i == 17)
                    {
                        btnSeatno18.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno18.Enabled = false;
                    }
                    if (i == 18)
                    {
                        btnSeatno19.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno19.Enabled = false;
                    }
                    if (i == 19)
                    {
                        btnSeatno20.BackColor = System.Drawing.Color.DeepPink;
                        btnSeatno20.Enabled = false;
                    }
                        if (i == 20)
                        {
                            btnSeatno21.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno21.Enabled = false;
                        }
                        if (i == 21)
                        {
                            btnSeatno22.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno22.Enabled = false;
                        }
                        if (i == 22)
                        {
                            btnSeatno23.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno23.Enabled = false;
                        }
                        if (i == 23)
                        {
                            btnSeatno24.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno24.Enabled = false;
                        }
                        if (i == 24)
                        {
                            btnSeatno25.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno25.Enabled = false;
                        }
                        if (i == 25)
                        {
                            btnSeatno26.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno26.Enabled = false;
                        }
                        if (i == 26)
                        {
                            btnSeatno27.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno27.Enabled = false;
                        }
                        if (i == 27)
                        {
                            btnSeatno28.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno28.Enabled = false;
                        }
                        if (i == 28)
                        {
                            btnSeatno29.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno29.Enabled = false;
                        }
                        if (i == 29)
                        {
                            btnSeatno30.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno30.Enabled = false;
                        }
                        if (i == 30)
                        {
                            btnSeatno31.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno31.Enabled = false;
                        }
                        if (i == 31)
                        {
                            btnSeatno32.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno32.Enabled = false;
                        }
                        if (i == 32)
                        {
                            btnSeatno33.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno33.Enabled = false;
                        }
                        if (i == 33)
                        {
                            btnSeatno34.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno34.Enabled = false;
                        }
                        if (i == 34)
                        {
                            btnSeatno35.BackColor = System.Drawing.Color.DeepPink;
                            btnSeatno35.Enabled = false;
                        }
                    }
                    i = i + 1;
                }
            }
        
        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            string updatedata = "Update seat_tbl set seatStatus='N' where seatID=" + seatbookbo;

            try
            {
                con.Open();
                cmd.CommandText = updatedata;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                if (rdbAdult.Checked)
                {
                    SqlCommand cmd = new SqlCommand("select adult_price from tickets_tbl where ticketID=2", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int row = seatbookbo / 7+1;
                    int col = seatbookbo % 7;
                    while (reader.Read())
                    {
                         float price = Convert.ToInt32(reader["adult_price"].ToString());
                        MessageBox.Show("Вы успешно забронировали на: ряд " + row + " место: " + col + " по фильму " + cmbFilmName.SelectedItem + " на " + cmbTime.SelectedItem + " на взрослый билет по цене: " + price, "Сообщение");
                    }
                    
                }
                else if (rdbChild.Checked)
                {

                    SqlCommand cmd = new SqlCommand("select child_price from tickets_tbl where ticketID=2", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int row =seatbookbo/7+1;
                    int col = seatbookbo % 7;
                    while (reader.Read())
                    {
                        float price = Convert.ToInt32(reader["child_price"].ToString());
                        MessageBox.Show("Вы успешно забронировали на: ряд " + row + " место: " + col + " по фильму " + cmbFilmName.SelectedItem + " на " + cmbTime.SelectedItem + " на детский билет по цене: " + price, "Сообщение");
                     }
                    
                }
                else if (rdbStud.Checked)
                {
                    SqlCommand cmd = new SqlCommand("select student_price from tickets_tbl where ticketID=2", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int row = seatbookbo / 7+1;
                    int col = seatbookbo % 7;
                    while (reader.Read())
                    {
                        float price = Convert.ToInt32(reader["student_price"].ToString());
                        MessageBox.Show("Вы успешно забронировали на: ряд " + row + " место: " + col + " по фильму " + cmbFilmName.SelectedItem + " на " + cmbTime.SelectedItem + " на студенческий билет по цене: " + price, "Сообщение");
                     }
                    
                }
                else if (rdbRetiree.Checked)
                {
                    SqlCommand cmd = new SqlCommand("select retiree_price from tickets_tbl where ticketID=2", con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    int row = seatbookbo / 7+1;
                    int col = seatbookbo % 7;
                        while (reader.Read())
                        {
                            float price = Convert.ToInt32(reader["retiree_price"].ToString());
                            MessageBox.Show("Вы успешно забронировали на: ряд " + row + " место: " + col + " по фильму " + cmbFilmName.SelectedItem + " на " + cmbTime.SelectedItem + " на пенсионерный билет по цене: " + price, "Сообщение");
                         
                    }
                }
                else {
                    MessageBox.Show("Выберите возрастную группу вашего билета", "Ошибка");
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
            
        }

        private void btnSeatno1_Click(object sender, EventArgs e)
        {
            seatbookbo = 1;
            btnSeatno1.BackColor= System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno2_Click(object sender, EventArgs e)
        {
            seatbookbo = 2;
            btnSeatno2.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno3_Click(object sender, EventArgs e)
        {
            seatbookbo = 3;
            btnSeatno3.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno4_Click(object sender, EventArgs e)
        {
            seatbookbo = 4;
            btnSeatno4.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno5_Click(object sender, EventArgs e)
        {
            seatbookbo = 5;
            btnSeatno5.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno6_Click(object sender, EventArgs e)
        {
            seatbookbo = 6;
            btnSeatno6.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno7_Click(object sender, EventArgs e)
        {
            seatbookbo = 7;
            btnSeatno7.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno8_Click(object sender, EventArgs e)
        {
            seatbookbo = 8;
            btnSeatno8.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno9_Click(object sender, EventArgs e)
        {
            seatbookbo = 9;
            btnSeatno9.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno10_Click(object sender, EventArgs e)
        {
            seatbookbo = 10;
            btnSeatno10.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno11_Click(object sender, EventArgs e)
        {
            seatbookbo = 11;
            btnSeatno11.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno12_Click(object sender, EventArgs e)
        {
            seatbookbo = 12;
            btnSeatno12.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno13_Click(object sender, EventArgs e)
        {
            seatbookbo = 13;
            btnSeatno13.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno14_Click(object sender, EventArgs e)
        {
            seatbookbo = 14;
            btnSeatno14.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno15_Click(object sender, EventArgs e)
        {
            seatbookbo = 15;
            btnSeatno15.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno16_Click(object sender, EventArgs e)
        {
            seatbookbo = 16;
            btnSeatno16.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno17_Click(object sender, EventArgs e)
        {
            seatbookbo = 17;
            btnSeatno17.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno18_Click(object sender, EventArgs e)
        {
            seatbookbo = 18;
            btnSeatno18.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno19_Click(object sender, EventArgs e)
        {
            seatbookbo = 19;
            btnSeatno19.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno20_Click(object sender, EventArgs e)
        {
            seatbookbo = 20;
            btnSeatno20.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno21_Click(object sender, EventArgs e)
        {
            seatbookbo = 21;
            btnSeatno21.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno22_Click(object sender, EventArgs e)
        {
            seatbookbo = 22;
            btnSeatno22.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno23_Click(object sender, EventArgs e)
        {
            seatbookbo = 23;
            btnSeatno23.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno24_Click(object sender, EventArgs e)
        {
            seatbookbo = 24;
            btnSeatno24.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno25_Click(object sender, EventArgs e)
        {
            seatbookbo = 25;
            btnSeatno25.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno26_Click(object sender, EventArgs e)
        {
            seatbookbo = 26;
            btnSeatno26.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno27_Click(object sender, EventArgs e)
        {
            seatbookbo = 27;
            btnSeatno27.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno28_Click(object sender, EventArgs e)
        {
            seatbookbo = 28;
            btnSeatno28.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno29_Click(object sender, EventArgs e)
        {
            seatbookbo = 29;
            btnSeatno29.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno30_Click(object sender, EventArgs e)
        {
            seatbookbo = 30;
            btnSeatno30.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno31_Click(object sender, EventArgs e)
        {
            seatbookbo = 31;
            btnSeatno31.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno32_Click(object sender, EventArgs e)
        {
            seatbookbo = 32;
            btnSeatno32.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno33_Click(object sender, EventArgs e)
        {
            seatbookbo = 33;
            btnSeatno33.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno34_Click(object sender, EventArgs e)
        {
            seatbookbo = 34;
            btnSeatno34.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }
        private void btnSeatno35_Click(object sender, EventArgs e)
        {
            seatbookbo = 35;
            btnSeatno35.BackColor = System.Drawing.Color.Gray;
            seatstatus();
        }




    }
}
