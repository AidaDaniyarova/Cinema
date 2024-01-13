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
    public partial class FormCustomers : Form
    {
        private SqlConnection con = null;
        private SqlCommandBuilder bldr = null;
        private SqlDataAdapter sda = null;
        private DataSet ds = null;
        private bool newRowAdding = false;
        public FormCustomers()
        {
            InitializeComponent();
            
        }
       

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                sda = new SqlDataAdapter("SELECT *, 'Delete' AS [Delete] FROM user_tbl", con);
                bldr = new SqlCommandBuilder(sda);
                bldr.GetInsertCommand();
                bldr.GetDeleteCommand();
                bldr.GetUpdateCommand();
                ds = new DataSet();
                sda.Fill(ds, "user_tbl");
                dgvUser.DataSource = ds.Tables["user_tbl"];
                for(int i=0; i<dgvUser.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkcell = new DataGridViewLinkCell();
                    dgvUser[10, i] = linkcell;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            try
            {
                ds.Tables["user_tbl"].Clear();
                sda.Fill(ds, "user_tbl");
                dgvUser.DataSource = ds.Tables["user_tbl"];
                for (int i = 0; i < dgvUser.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkcell = new DataGridViewLinkCell();
                    dgvUser[10, i] = linkcell;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void dgvUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            { 
                if(e.ColumnIndex==10)
                {
                    string task = dgvUser.Rows[e.RowIndex].Cells[10].Value.ToString();
                    if(task=="Delete")
                    {
                        if(MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dgvUser.Rows.RemoveAt(rowIndex);
                            ds.Tables["user_tbl"].Rows[rowIndex].Delete();
                            sda.Update(ds, "user_tbl");
                        }
                    }
                    else if(task=="Insert")
                    {
                        int rowIndex = dgvUser.Rows.Count - 2;
                        DataRow row= ds.Tables["user_tbl"].NewRow();

                        row["userID"] = dgvUser.Rows[rowIndex].Cells["userID"].Value;
                        row["first_name"] = dgvUser.Rows[rowIndex].Cells["first_name"].Value;
                        row["last_name"] = dgvUser.Rows[rowIndex].Cells["last_name"].Value;
                        row["address"] = dgvUser.Rows[rowIndex].Cells["address"].Value;
                        row["username"] = dgvUser.Rows[rowIndex].Cells["username"].Value;
                        row["password"] = dgvUser.Rows[rowIndex].Cells["password"].Value;
                        row["email"] = dgvUser.Rows[rowIndex].Cells["email"].Value;
                        row["phone_number"] = dgvUser.Rows[rowIndex].Cells["phone_number"].Value;
                        row["create_date"] = dgvUser.Rows[rowIndex].Cells["create_date"].Value;
                        row["birth_date"] = dgvUser.Rows[rowIndex].Cells["birth_date"].Value;

                        ds.Tables["user_tbl"].Rows.Add(row);
                        ds.Tables["user_tbl"].Rows.RemoveAt(ds.Tables["user_tbl"].Rows.Count - 1);
                        dgvUser.Rows.RemoveAt(dgvUser.Rows.Count - 2);
                        dgvUser.Rows[e.RowIndex].Cells[10].Value = "Delete";
                        sda.Update(ds, "user_tbl");
                        newRowAdding = false;
                    }
                    else if(task =="Update")
                    {
                        int r = e.RowIndex;

                        ds.Tables["user_tbl"].Rows[r]["userID"] = dgvUser.Rows[r].Cells["userID"].Value;
                        ds.Tables["user_tbl"].Rows[r]["first_name"] = dgvUser.Rows[r].Cells["first_name"].Value;
                        ds.Tables["user_tbl"].Rows[r]["last_name"] = dgvUser.Rows[r].Cells["last_name"].Value;
                        ds.Tables["user_tbl"].Rows[r]["address"] = dgvUser.Rows[r].Cells["address"].Value;
                        ds.Tables["user_tbl"].Rows[r]["username"] = dgvUser.Rows[r].Cells["username"].Value;
                        ds.Tables["user_tbl"].Rows[r]["password"] = dgvUser.Rows[r].Cells["password"].Value;
                        ds.Tables["user_tbl"].Rows[r]["email"] = dgvUser.Rows[r].Cells["email"].Value;
                        ds.Tables["user_tbl"].Rows[r]["phone_number"] = dgvUser.Rows[r].Cells["phone_number"].Value;
                        ds.Tables["user_tbl"].Rows[r]["create_date"] = dgvUser.Rows[r].Cells["create_date"].Value;
                        ds.Tables["user_tbl"].Rows[r]["birth_date"] = dgvUser.Rows[r].Cells["birth_date"].Value;
                        sda.Update(ds, "film_tbl");
                        dgvUser.Rows[e.RowIndex].Cells[10].Value = "Delete";
                    }
                    ReloadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUser_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if(newRowAdding==false)
                {
                    newRowAdding = true;
                    int lastRow = dgvUser.Rows.Count - 2;
                    DataGridViewRow row = dgvUser.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvUser[10, lastRow] = linkCell;
                    row.Cells["Command"].Value = "Insert";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dgvUser_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dgvUser.SelectedCells[0].RowIndex;
                    DataGridViewRow editingRow = dgvUser.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvUser[10, rowIndex] = linkCell;
                    editingRow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUser_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if (dgvUser.CurrentCell.ColumnIndex == 7)
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
