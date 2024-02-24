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
        FrmProductList frmProductList = null;

        public FrmProduct(FrmProductList frmProductList)
        {
            conn = new SqlConnection(dbConnection.MyConnection());
            InitializeComponent();
            this.frmProductList = frmProductList;
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

            txtPrice.Clear();
            txtDescription.Clear();
            txtProductCode.Clear();
            cboBrand.Text = string.Empty;
            cboCategory.Text = string.Empty;
            txtProductCode.Focus();
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
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string bid = string.Empty;
                    string cid = string.Empty;

                    conn.Open();
                    cmd = new SqlCommand("SELECT id FROM tblBrand WHERE brand LIKE '" + cboBrand.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        bid = reader[0].ToString();
                    }
                    reader.Close();
                    conn.Close();

                    conn.Open();
                    cmd = new SqlCommand("SELECT id FROM tblCategory WHERE category LIKE '" + cboCategory.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        cid = reader[0].ToString();
                    }
                    reader.Close();
                    conn.Close();

                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO tblProduct (pcode, pdesc, bid, cid, price) VALUES(@pcode, @pdesc, @bid, @cid, @price)", conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@pcode", txtProductCode.Text);
                    cmd.Parameters.AddWithValue("@pdesc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@bid", bid);
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product has been successfully saved.");
                    Clear();
                    frmProductList.LoadRecords();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string bid = string.Empty;
                    string cid = string.Empty;

                    conn.Open();
                    cmd = new SqlCommand("SELECT id FROM tblBrand WHERE brand LIKE '" + cboBrand.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        bid = reader[0].ToString();
                    }
                    reader.Close();
                    conn.Close();

                    conn.Open();
                    cmd = new SqlCommand("SELECT id FROM tblCategory WHERE category LIKE '" + cboCategory.Text + "'", conn);
                    reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        cid = reader[0].ToString();
                    }
                    reader.Close();
                    conn.Close();

                    conn.Open();
                    cmd = new SqlCommand("UPDATE tblProduct SET pdesc = @pdesc, bid = @bid, cid = @cid, price = @price WHERE pcode = @pcode", conn);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@pcode", txtProductCode.Text);
                    cmd.Parameters.AddWithValue("@pdesc", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@bid", bid);
                    cmd.Parameters.AddWithValue("@cid", cid);
                    cmd.Parameters.AddWithValue("@price", txtPrice.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product has been successfully updated.");
                    Clear();
                    frmProductList.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46)
            {
                // accept . character
            }
            else if (e.KeyChar == 8)
            {
                // accept backspace
            }
            else if (e.KeyChar < 48 || e.KeyChar > 57) // ascii code 48-57 between 0-9
            {
                e.Handled = true;
            }
        }
    }
}
