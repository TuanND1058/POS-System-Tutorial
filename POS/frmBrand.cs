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
    public partial class frmBrand : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbConnection = new DBConnection();
        frmBrandList _frmBrandList;

        public frmBrand(frmBrandList frmBrandList)
        {
            InitializeComponent();

            try
            {
                conn = new SqlConnection(dbConnection.MyConnection());
                _frmBrandList = frmBrandList;
            }
            catch (Exception)
            {

            }
        }

        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtBrandName.Clear();
            txtBrandName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBrandName.Text.Length == 0)
                {
                    MessageBox.Show("Please input brand name.");
                    return;
                }

                if (MessageBox.Show("Are you want to save this brand?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO tblBrand(brand) VALUES (@brand)", conn);
                    cmd.Parameters.AddWithValue("@brand", txtBrandName.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Record has been succesfully saved.");
                    Clear();

                    _frmBrandList.LoadRecords();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
