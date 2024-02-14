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

namespace POS
{
    public partial class FrmBrandList : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader reader = null;
        DBConnection dbConnection = new DBConnection();

        public FrmBrandList()
        {
            InitializeComponent();
            conn = new SqlConnection(dbConnection.MyConnection());
            LoadRecords();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmBrand frmBrand = new FrmBrand(this);
            frmBrand.ShowSave();
            frmBrand.ShowDialog();
        }

        public void LoadRecords()
        {
            int i = 1;
            dataGridView1.Rows.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT id, brand FROM tblBrand ORDER BY brand", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(i, reader["id"].ToString(), reader["brand"].ToString());
                i++;
            }
            reader.Close();
            conn.Close();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                FrmBrand frmBrand = new FrmBrand(this);
                frmBrand.ShowUpdate();
                frmBrand.lblID.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                frmBrand.txtBrandName.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                frmBrand.ShowDialog();
            }
        }
    }
}
