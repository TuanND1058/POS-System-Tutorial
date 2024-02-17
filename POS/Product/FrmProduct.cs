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
    public partial class FrmProduct : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbConnection = new DBConnection();
        SqlDataReader reader = null;

        public FrmProduct()
        {
            conn = new SqlConnection(dbConnection.MyConnection());
            InitializeComponent();
        }

        public void ShowSave()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            //txtCategoryName.Clear();
            //txtCategoryName.Focus();
        }

        public void ShowUpdate()
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            //txtCategoryName.Focus();
        }

        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            //txtCategoryName.Clear();
            //txtCategoryName.Focus();
        }

        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT category FROM tblCategory", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboCategory.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        public void LoadBrand()
        {
            cboBrand.Items.Clear();
            conn.Open();
            cmd = new SqlCommand("SELECT brand FROM tblBrand", conn);
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboBrand.Items.Add(reader[0].ToString());
            }
            reader.Close();
            conn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
