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
    public partial class FormWorkers : Form
    {
        private SqlConnection con = null;
        private SqlCommandBuilder bldr = null;
        private SqlDataAdapter sda = null;
        private DataSet ds = null;
        private bool newRowAdding = false;
        public FormWorkers()
        {
            InitializeComponent();
        }

        private void FormWorkers_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                sda = new SqlDataAdapter("SELECT *,'Delete' AS [Command] FROM staff_tbl", con);
                bldr = new SqlCommandBuilder(sda);
                bldr.GetInsertCommand();
                bldr.GetDeleteCommand();
                bldr.GetUpdateCommand();
                ds = new DataSet();
                sda.Fill(ds, "staff_tbl");
                dgvWorkers.DataSource = ds.Tables["staff_tbl"];

                for (int i = 0; i < dgvWorkers.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvWorkers[7, i] = linkCell;
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
                    ds.Tables["staff_tbl"].Clear();
                    sda.Fill(ds, "staff_tbl");
                dgvWorkers.DataSource = ds.Tables["staff_tbl"];

                    for (int i = 0; i < dgvWorkers.Rows.Count; i++)
                    {
                        DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvWorkers[7, i] = linkCell;
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

            private void dgvWorkers_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    if (e.ColumnIndex == 7)
                    {
                        string task = dgvWorkers.Rows[e.RowIndex].Cells[7].Value.ToString();
                        if (task == "Delete")
                        {
                            if (MessageBox.Show("Удалить эту строку", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                == DialogResult.Yes)
                            {
                                int rowIndex = e.RowIndex;
                            dgvWorkers.Rows.RemoveAt(rowIndex);
                                ds.Tables["staff_tbl"].Rows[rowIndex].Delete();
                                sda.Update(ds, "staff_tbl");
                            }
                        }
                        else if (task == "Insert")
                        {
                            int rowIndex = dgvWorkers.Rows.Count - 2;
                            DataRow row = ds.Tables["staff_tbl"].NewRow();
                            row["staffID"] = dgvWorkers.Rows[rowIndex].Cells["staffID"].Value;
                            row["username"] = dgvWorkers.Rows[rowIndex].Cells["username"].Value;
                            row["password"] = dgvWorkers.Rows[rowIndex].Cells["password"].Value;
                            row["first_name"] = dgvWorkers.Rows[rowIndex].Cells["first_name"].Value;
                            row["last_name"] = dgvWorkers.Rows[rowIndex].Cells["last_name"].Value;
                            row["email"] = dgvWorkers.Rows[rowIndex].Cells["email"].Value;
                            row["phone_number"] = dgvWorkers.Rows[rowIndex].Cells["phone_number"].Value;

                            ds.Tables["staff_tbl"].Rows.Add(row);
                            ds.Tables["staff_tbl"].Rows.RemoveAt(ds.Tables["staff_tbl"].Rows.Count - 1);
                        dgvWorkers.Rows[e.RowIndex].Cells[7].Value = "Delete";
                            sda.Update(ds, "staff_tbl");
                            newRowAdding = false;
                        }
                        else if (task == "Update")
                        {
                            int r = e.RowIndex;

                            ds.Tables["staff_tbl"].Rows[r]["staffID"] = dgvWorkers.Rows[r].Cells["staffID"].Value;
                            ds.Tables["staff_tbl"].Rows[r]["username"] = dgvWorkers.Rows[r].Cells["username"].Value;
                            ds.Tables["staff_tbl"].Rows[r]["password"] = dgvWorkers.Rows[r].Cells["password"].Value;
                            ds.Tables["staff_tbl"].Rows[r]["first_name"] = dgvWorkers.Rows[r].Cells["first_name"].Value;
                            ds.Tables["staff_tbl"].Rows[r]["last_name"] = dgvWorkers.Rows[r].Cells["last_name"].Value;
                            ds.Tables["staff_tbl"].Rows[r]["email"] = dgvWorkers.Rows[r].Cells["email"].Value;
                            ds.Tables["staff_tbl"].Rows[r]["phone_number"] = dgvWorkers.Rows[r].Cells["phone_number"].Value;
                            sda.Update(ds, "staff_tbl");
                        dgvWorkers.Rows[e.RowIndex].Cells[7].Value = "Delete";
                        }
                        ReLoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void dgvWorkers_UserAddedRow(object sender, DataGridViewRowEventArgs e)
            {
                try
                {
                    if (newRowAdding == false)
                    {
                        newRowAdding = true;
                        int lastRow = dgvWorkers.Rows.Count - 2;
                        DataGridViewRow row = dgvWorkers.Rows[lastRow];
                        DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvWorkers[7, lastRow] = linkCell;
                        row.Cells["Command"].Value = "Insert";

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void dgvWorkers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
            {
                try
                {
                    if (newRowAdding == false)
                    {
                        int rowIndex = dgvWorkers.SelectedCells[0].RowIndex;
                        DataGridViewRow editingRow = dgvWorkers.Rows[rowIndex];
                        DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvWorkers[7, rowIndex] = linkCell;
                        editingRow.Cells["Command"].Value = "Update";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void dgvWorkers_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
            {
                e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
                if (dgvWorkers.CurrentCell.ColumnIndex == 7)
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

