using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frmBrandList : Form
    {
        public frmBrandList()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add(i + 1, "1", "Brand " + i + 1);
            }
        }
    }
}
