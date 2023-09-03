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
using System.Xml.Serialization;

namespace SSProject
{
    public partial class Mini_Statement : Form
    {
        public Mini_Statement()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\potla.kumar\Documents\citizenbankDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Account = Login.AccountNo;
        private void populate()
        {
            Con.Open();
            string query = "select * from TransactionTable where AccountNo='" + Account + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            MinistatementDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Mini_Statement_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
