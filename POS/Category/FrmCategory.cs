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
    public partial class FrmCategory : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbConnection = new DBConnection();
        FrmCategoryList _frmCategoryList;

        public FrmCategory(FrmCategoryList frmCategoryList)
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection(dbConnection.MyConnection());
                _frmCategoryList = frmCategoryList;
            }
            catch (Exception)
            {

            }
        }

        public void ShowSave()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtCategoryName.Clear();
            txtCategoryName.Focus();
        }

        public void ShowUpdate()
        {
            btnSave.Enabled = false;
            btnUpdate.Enabled = true;
            txtCategoryName.Focus();
        }

        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            txtCategoryName.Clear();
            txtCategoryName.Focus();
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
                if (txtCategoryName.Text.Length == 0)
                {
                    MessageBox.Show("Please input category name.");
                    return;
                }

                if (MessageBox.Show("Are you want to save this category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO tblCategory(category) VALUES (@category)", conn);
                    cmd.Parameters.AddWithValue("@category", txtCategoryName.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Record has been succesfully saved.");
                    Clear();

                    _frmCategoryList.LoadRecords();
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
                if (MessageBox.Show("Are you sure you want to update this category?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cmd = new SqlCommand("UPDATE tblCategory SET category = @category WHERE id like '" + lblID.Text + "'", conn);
                    cmd.Parameters.AddWithValue("@category", txtCategoryName.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("category has been successfuly updated.");
                    Clear();
                    _frmCategoryList.LoadRecords();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
