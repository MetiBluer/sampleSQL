using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SampleMySql
{
    public partial class frmSqL : Form
    {   //connection string
        string connStr = "server=localhost; database=dbsample; uid=root; pwd=uslt; port=3306";
        MySqlConnection conn;
        DataTable dt = new DataTable();


        public frmSqL()
        {
            InitializeComponent();
        }

        private void frmSqL_Load(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            string query = "select * from student where fname='"+txtSearch.Text+"'; ";
            conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter(query,conn);
            adapter.Fill(dt);
            dgvSql.DataSource = dt;
        }
    }
}
