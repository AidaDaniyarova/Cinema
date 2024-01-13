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
    public partial class FormHalls : Form
    {
        private SqlConnection con = null;
        private SqlCommandBuilder bldr = null;
        private SqlDataAdapter sda = null;
        private DataSet ds = null;
        private bool newRowAdding = false;
        public FormHalls()
        {
            InitializeComponent();
        }

        private void FormHalls_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                sda = new SqlDataAdapter("SELECT *,'Delete' AS [Command] FROM cinema_hall_tbl", con);
                bldr = new SqlCommandBuilder(sda);
                bldr.GetInsertCommand();
                bldr.GetDeleteCommand();
                bldr.GetUpdateCommand();
                ds = new DataSet();
                sda.Fill(ds, "cinema_hall_tbl");
                dgvHall.DataSource = ds.Tables["cinema_hall_tbl"];

                for (int i = 0; i < dgvHall.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvHall[4, i] = linkCell;
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
                ds.Tables["cinema_hall_tbl"].Clear();
                sda.Fill(ds, "cinema_hall_tbl");
                dgvHall.DataSource = ds.Tables["cinema_hall_tbl"];

                for (int i = 0; i < dgvHall.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvHall[4, i] = linkCell;
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

        private void dgvHall_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                {
                    string task = dgvHall.Rows[e.RowIndex].Cells[4].Value.ToString();
                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dgvHall.Rows.RemoveAt(rowIndex);
                            ds.Tables["cinema_hall_tbl"].Rows[rowIndex].Delete();
                            sda.Update(ds, "cinema_hall_tbl");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dgvHall.Rows.Count - 2;
                        DataRow row = ds.Tables["cinema_hall_tbl"].NewRow();
                        row["cinema_hallID"] = dgvHall.Rows[rowIndex].Cells["cinema_hallID"].Value;
                        row["hall_type"] = dgvHall.Rows[rowIndex].Cells["hall_type"].Value;
                        row["hall_size"] = dgvHall.Rows[rowIndex].Cells["hall_size"].Value;
                        row["seat_number"] = dgvHall.Rows[rowIndex].Cells["seat_number"].Value;
                       

                        ds.Tables["cinema_hall_tbl"].Rows.Add(row);
                        ds.Tables["cinema_hall_tbl"].Rows.RemoveAt(ds.Tables["cinema_hall_tbl"].Rows.Count - 1);
                        dgvHall.Rows[e.RowIndex].Cells[4].Value = "Delete";
                        sda.Update(ds, "cinema_hall_tbl");
                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        ds.Tables["cinema_hall_tbl"].Rows[r]["cinema_hallID"] = dgvHall.Rows[r].Cells["cinema_hallID"].Value;
                        ds.Tables["cinema_hall_tbl"].Rows[r]["hall_type"] = dgvHall.Rows[r].Cells["hall_type"].Value;
                        ds.Tables["cinema_hall_tbl"].Rows[r]["hall_size"] = dgvHall.Rows[r].Cells["hall_size"].Value;
                        ds.Tables["cinema_hall_tbl"].Rows[r]["seat_number"] = dgvHall.Rows[r].Cells["seat_number"].Value;
                        
                        sda.Update(ds, "cinema_hall_tbl");
                        dgvHall.Rows[e.RowIndex].Cells[4].Value = "Delete";
                    }
                    ReLoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHall_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;
                    int lastRow = dgvHall.Rows.Count - 2;
                    DataGridViewRow row = dgvHall.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvHall[4, lastRow] = linkCell;
                    row.Cells["Command"].Value = "Insert";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHall_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dgvHall.SelectedCells[0].RowIndex;
                    DataGridViewRow editingRow = dgvHall.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvHall[4, rowIndex] = linkCell;
                    editingRow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvHall_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (dgvHall.CurrentCell.ColumnIndex == 7)
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
