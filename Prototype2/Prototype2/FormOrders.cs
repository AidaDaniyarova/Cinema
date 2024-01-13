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
    public partial class FormOrders : Form
    {
        private SqlConnection con = null;
        private SqlCommandBuilder bldr = null;
        private SqlDataAdapter sda = null;
        private DataSet ds = null;
        private bool newRowAdding = false;
        public FormOrders()
        {
            InitializeComponent();
        }
         private void FormOrders_Load(object sender, EventArgs e)
         {
             con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");
             con.Open();
             LoadData();
          }
        private void LoadData()
        {
            try
            {
                sda = new SqlDataAdapter("SELECT *,'Delete' AS [Command] FROM booking_tbl", con);
                bldr = new SqlCommandBuilder(sda);
                bldr.GetInsertCommand();
                bldr.GetDeleteCommand();
                bldr.GetUpdateCommand();
                ds = new DataSet();
                sda.Fill(ds, "booking_tbl");
                dgvOrders.DataSource = ds.Tables["booking_tbl"];

                for (int i = 0; i < dgvOrders.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvOrders[8, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void ReLoadData()
        {
            try
            {
                ds.Tables["booking_tbl"].Clear();
                sda.Fill(ds, "booking_tbl");
                dgvOrders.DataSource = ds.Tables["booking_tbl"];

                for (int i = 0; i < dgvOrders.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvOrders[8, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ReLoadData();
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8)
                {
                    string task = dgvOrders.Rows[e.RowIndex].Cells[8].Value.ToString();
                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dgvOrders.Rows.RemoveAt(rowIndex);
                            ds.Tables["booking_tbl"].Rows[rowIndex].Delete();
                            sda.Update(ds, "booking_tbl");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dgvOrders.Rows.Count - 2;
                        DataRow row = ds.Tables["booking_tbl"].NewRow();
                        row["bookingID"] = dgvOrders.Rows[rowIndex].Cells["bookingID"].Value;
                        row["staffID"] = dgvOrders.Rows[rowIndex].Cells["staffID"].Value;
                        row["booking_date"] = dgvOrders.Rows[rowIndex].Cells["booking_date"].Value;
                        row["adult_number"] = dgvOrders.Rows[rowIndex].Cells["adult_number"].Value;
                        row["child_number"] = dgvOrders.Rows[rowIndex].Cells["child_number"].Value;
                        row["student_number"] = dgvOrders.Rows[rowIndex].Cells["student_number"].Value;
                        row["retiree_number"] = dgvOrders.Rows[rowIndex].Cells["retiree_number"].Value;
                        row["final_cost"] = dgvOrders.Rows[rowIndex].Cells["final_cost"].Value;
                      

                        ds.Tables["booking_tbl"].Rows.Add(row);
                        ds.Tables["booking_tbl"].Rows.RemoveAt(ds.Tables["booking_tbl"].Rows.Count - 1);
                        dgvOrders.Rows[e.RowIndex].Cells[8].Value = "Delete";
                        sda.Update(ds, "booking_tbl");
                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        ds.Tables["booking_tbl"].Rows[r]["bookingID"] = dgvOrders.Rows[r].Cells["bookingID"].Value;
                        ds.Tables["booking_tbl"].Rows[r]["staffID"] = dgvOrders.Rows[r].Cells["staffID"].Value;
                        ds.Tables["booking_tbl"].Rows[r]["booking_date"] = dgvOrders.Rows[r].Cells["booking_date"].Value;
                        ds.Tables["booking_tbl"].Rows[r]["adult_number"] = dgvOrders.Rows[r].Cells["adult_number"].Value;
                        ds.Tables["booking_tbl"].Rows[r]["child_number"] = dgvOrders.Rows[r].Cells["child_number"].Value;
                        ds.Tables["booking_tbl"].Rows[r]["student_number"] = dgvOrders.Rows[r].Cells["student_number"].Value;
                        ds.Tables["booking_tbl"].Rows[r]["retiree_number"] = dgvOrders.Rows[r].Cells["retiree_number"].Value;
                        ds.Tables["booking_tbl"].Rows[r]["final_cost"] = dgvOrders.Rows[r].Cells["final_cost"].Value;
                         sda.Update(ds, "booking_tbl");
                        dgvOrders.Rows[e.RowIndex].Cells[8].Value = "Delete";
                    }
                    ReLoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrders_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;
                    int lastRow = dgvOrders.Rows.Count - 2;
                    DataGridViewRow row = dgvOrders.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvOrders[8, lastRow] = linkCell;
                    row.Cells["Command"].Value = "Insert";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvOrders_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (dgvOrders.CurrentCell.ColumnIndex == 7)
            {
                TextBox txtBox = e.Control as TextBox;
                if (txtBox != null)
                {
                    txtBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }
        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
