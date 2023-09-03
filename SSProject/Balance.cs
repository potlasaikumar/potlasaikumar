using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SSProject
{
    public partial class Balance : Form
    {
        public Balance()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            AccountNolbl.Text = Home.AccountNo;
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\potla.kumar\Documents\citizenbankDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from CitizenData where AccountNo='" + AccountNolbl.Text + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Balancelbl.Text = "Rs " + dt.Rows[0][0].ToString();

                

            Con.Close();
        }

        private void Balance_Load(object sender, EventArgs e)
        {
            AccountNolbl.Text = Home.AccountNo;
            getbalance();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }
    }
}
