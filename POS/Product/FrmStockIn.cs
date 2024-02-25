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

namespace POS.Product
{
    public partial class FrmStockIn : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbConnection = new DBConnection();
        SqlDataReader reader = null;

        public FrmStockIn()
        {
            InitializeComponent();
            conn = new SqlConnection(dbConnection.MyConnection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void LoadProduct()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT pcode, pdesc, qty FROM tblProduct WHERE pdesc LIKE '%" + txtSearch.Text + "%' ORDER BY pdesc", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
            }
            reader.Close();
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colSelect")
            {
                if (MessageBox.Show("Add this item?", "Add", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO tblStockIn (refno, pcode, sdate, stockinby) VALUES(@refno, @pcode, @sdate, @stockinby)", conn); // * FROM tblProduct WHERE pcode LIKE '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", conn);
                    cmd.Parameters.AddWithValue("@refno", txtReferenceNo.Text);
                    cmd.Parameters.AddWithValue("@pcode", dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    cmd.Parameters.AddWithValue("@sdate", dtStockInDate.Value);
                    cmd.Parameters.AddWithValue("@stockinby", txtStockInBy.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Success added!", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStockIn();
                }
            }
        }

        public void LoadStockIn()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT * FROM vwStockIn", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                i++;
                dataGridView2.Rows.Add(i, reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString());
            }
            reader.Close();
            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
