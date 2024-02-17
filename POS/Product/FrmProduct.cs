using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS.Product
{
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
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
