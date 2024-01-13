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
    public partial class FormFilms : Form
    {
        private SqlConnection con = null;
        private SqlCommandBuilder bldr = null;
        private SqlDataAdapter sda = null;
        private DataSet ds = null;
        private bool newRowAdding = false;
        public FormFilms()
        {
            InitializeComponent();
        }
        
        private void FormFilms_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Documents\Login1.mdf;Integrated Security=True;Connect Timeout=30;");
            con.Open();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                sda = new SqlDataAdapter("SELECT *,'Delete' AS [Command] FROM film_tbl", con);
                bldr = new SqlCommandBuilder(sda);
                bldr.GetInsertCommand();
                bldr.GetDeleteCommand();
                bldr.GetUpdateCommand();
                ds = new DataSet();
                sda.Fill(ds, "film_tbl");
                dgvFilms.DataSource = ds.Tables["film_tbl"];

                for (int i =0; i < dgvFilms.Rows.Count; i++) {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvFilms[10, i] = linkCell;
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
                ds.Tables["film_tbl"].Clear();
                sda.Fill(ds, "film_tbl");
                dgvFilms.DataSource = ds.Tables["film_tbl"];

                for (int i = 0; i < dgvFilms.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvFilms[10, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dgvFilms_ColumnNameChanged(object sender, DataGridViewColumnEventArgs e)
        {
            dgvFilms.ColumnCount = 10;
            //Set the columns name
            dgvFilms.Columns[0].HeaderText = "Film ID";
            dgvFilms.Columns[1].HeaderText = "Language";
            dgvFilms.Columns[2].HeaderText = "Cinema hall";
            dgvFilms.Columns[3].HeaderText = "Title";
            dgvFilms.Columns[4].HeaderText = "Genre";
            dgvFilms.Columns[5].HeaderText = "Description";
            dgvFilms.Columns[6].HeaderText = "Release year";
            dgvFilms.Columns[7].HeaderText = "Duration";
            dgvFilms.Columns[8].HeaderText = "Rating";
            dgvFilms.Columns[9].HeaderText = "Ticket price";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ReLoadData();
        }

        private void dgvFilms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try 
            {
                if (e.ColumnIndex == 10) 
                {
                    string task = dgvFilms.Rows[e.RowIndex].Cells[10].Value.ToString();
                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку", "Удаление",MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            dgvFilms.Rows.RemoveAt(rowIndex);
                            ds.Tables["film_tbl"].Rows[rowIndex].Delete();
                            sda.Update(ds, "film_tbl");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dgvFilms.Rows.Count - 2;
                        DataRow row = ds.Tables["film_tbl"].NewRow();
                        row["languageID"] = dgvFilms.Rows[rowIndex].Cells["languageID"].Value;
                        row["cinema_hallID"] = dgvFilms.Rows[rowIndex].Cells["cinema_hallID"].Value;
                        row["title"] = dgvFilms.Rows[rowIndex].Cells["title"].Value;
                        row["genre"] = dgvFilms.Rows[rowIndex].Cells["genre"].Value;
                        row["description"] = dgvFilms.Rows[rowIndex].Cells["description"].Value;
                        row["release_year"] = dgvFilms.Rows[rowIndex].Cells["release_year"].Value;
                        row["film_duration"] = dgvFilms.Rows[rowIndex].Cells["film_duration"].Value;
                        row["rating"] = dgvFilms.Rows[rowIndex].Cells["rating"].Value;
                        row["ticket_price"] = dgvFilms.Rows[rowIndex].Cells["ticket_price"].Value;

                        ds.Tables["film_tbl"].Rows.Add(row);
                        ds.Tables["film_tbl"].Rows.RemoveAt(ds.Tables["film_tbl"].Rows.Count - 1);
                        dgvFilms.Rows[e.RowIndex].Cells[10].Value = "Delete";
                        sda.Update(ds, "film_tbl");
                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;
                        
                        ds.Tables["film_tbl"].Rows[r]["languageID"] = dgvFilms.Rows[r].Cells["languageID"].Value;
                        ds.Tables["film_tbl"].Rows[r]["cinema_hallID"] = dgvFilms.Rows[r].Cells["cinema_hallID"].Value;
                        ds.Tables["film_tbl"].Rows[r]["title"] = dgvFilms.Rows[r].Cells["title"].Value;
                        ds.Tables["film_tbl"].Rows[r]["genre"] = dgvFilms.Rows[r].Cells["genre"].Value;
                        ds.Tables["film_tbl"].Rows[r]["description"] = dgvFilms.Rows[r].Cells["description"].Value;
                        ds.Tables["film_tbl"].Rows[r]["release_year"] = dgvFilms.Rows[r].Cells["release_year"].Value;
                        ds.Tables["film_tbl"].Rows[r]["film_duration"] = dgvFilms.Rows[r].Cells["film_duration"].Value;
                        ds.Tables["film_tbl"].Rows[r]["rating"] = dgvFilms.Rows[r].Cells["rating"].Value;
                        ds.Tables["film_tbl"].Rows[r]["ticket_price"] = dgvFilms.Rows[r].Cells["ticket_price"].Value;
                        sda.Update(ds, "film_tbl");
                        dgvFilms.Rows[e.RowIndex].Cells[10].Value = "Delete";
                    }
                    ReLoadData();
                }
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFilms_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if(newRowAdding==false)
                {
                    newRowAdding = true;
                    int lastRow = dgvFilms.Rows.Count - 2;
                    DataGridViewRow row = dgvFilms.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvFilms[10, lastRow] = linkCell;
                    row.Cells["Command"].Value = "Insert";

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFilms_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dgvFilms.SelectedCells[0].RowIndex;
                    DataGridViewRow editingRow = dgvFilms.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    dgvFilms[10, rowIndex] = linkCell;
                    editingRow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvFilms_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);
            if(dgvFilms.CurrentCell.ColumnIndex==7)
            {
                TextBox txtBox = e.Control as TextBox;
                if(txtBox!=null)
                {
                    txtBox.KeyPress+=new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }
        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
