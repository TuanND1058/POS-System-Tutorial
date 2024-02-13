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
    public partial class frmMain : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbConnection = new DBConnection();

        public frmMain()
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
            frmBrandList frmBrandList = new frmBrandList();
            frmBrandList.TopLevel = false;
            panelMain.Controls.Add(frmBrandList);
            frmBrandList.BringToFront();
            frmBrandList.Show();
        }
    }
}
