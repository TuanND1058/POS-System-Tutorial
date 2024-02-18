using POS.Brand;
using POS.Category;
using POS.Product;
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
    public partial class FrmMain : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbConnection = new DBConnection();

        public FrmMain()
        {
            InitializeComponent();

            try
            {
                conn = new SqlConnection(dbConnection.MyConnection());
                conn.Open();

            }
            catch (Exception)
            {
                MessageBox.Show("Connected Failed");
            }

        }

        private void btnMngBrand_Click(object sender, EventArgs e)
        {
            FrmBrandList frmBrandList = new FrmBrandList();
            frmBrandList.TopLevel = false;
            panelMain.Controls.Add(frmBrandList);
            frmBrandList.BringToFront();
            frmBrandList.Show();
        }

        private void btnMngCategory_Click(object sender, EventArgs e)
        {
            FrmCategoryList frmCategoryList = new FrmCategoryList();
            frmCategoryList.TopLevel = false;
            panelMain.Controls.Add(frmCategoryList);
            frmCategoryList.BringToFront();
            frmCategoryList.Show();
        }

        private void btnMngProduct_Click(object sender, EventArgs e)
        {
            FrmProductList frmProductList = new FrmProductList();
            frmProductList.TopLevel = false;
            panelMain.Controls.Add(frmProductList);
            frmProductList.BringToFront();
            frmProductList.LoadRecords();
            frmProductList.Show();
        }
    }
}
