using POS.Category;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Category
{
    public partial class FrmCategoryList : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader = null;
        DBConnection dbConnection = new DBConnection();

        public FrmCategoryList()
        {
            InitializeComponent();
            conn = new SqlConnection(dbConnection.MyConnection());
            LoadRecords();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmCategory frmCategory = new FrmCategory(this);
            frmCategory.ShowSave();
            frmCategory.ShowDialog();
        }

        public void LoadRecords()
        {
            int i = 1;
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT id, category FROM tblCategory ORDER BY category", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(i, reader["id"].ToString(), reader["category"].ToString());
                i++;
            }
            reader.Close();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FrmCategory frmCategory = new FrmCategory(this);
                frmCategory.ShowUpdate();
                frmCategory.lblID.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                frmCategory.txtCategoryName.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                frmCategory.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this category?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("DELETE FROM tblCategory WHERE id like '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Category has been successfuly deleted.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRecords();
                }
            }
        }
    }
}
