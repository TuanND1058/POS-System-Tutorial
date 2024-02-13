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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        DBConnection dbConnection = new DBConnection();

        public Form1()
        {
            InitializeComponent();
            try
            {
                conn = new SqlConnection(dbConnection.MyConnection());
                conn.Open();
                MessageBox.Show("Connected Success");

            }
            catch (Exception)
            {
                MessageBox.Show("Connected Failed");
            }

        }
    }
}
