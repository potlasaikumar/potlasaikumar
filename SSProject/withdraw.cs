using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSProject
{
    public partial class withdraw : Form
    {
        public withdraw()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\potla.kumar\Documents\citizenbankDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Account = Login.AccountNo;
        int bal;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from CitizenData where AccountNo='" + Account + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            balancelbl.Text = "Balance:  Rs " + dt.Rows[0][0].ToString();
            bal = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }
        private void addtransaction()
        {
            string TrType = "Withdraw";
            try
            {
                Con.Open();
                string query = "insert TransactionTable values('" + Account + "','" + TrType + "'," + WithdrawTb .Text + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();

                Con.Close();

                Login log = new Login();
                log.Show();
                this.Hide();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void withdraw_Load(object sender, EventArgs e)
        {
            getbalance();
        }
        int newbalance;
        private void button1_Click(object sender, EventArgs e)
        {
            if(WithdrawTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if(Convert.ToInt32(WithdrawTb.Text) <= 0)
            {

                MessageBox.Show("Enter a Valid Amount");
            }
            else if(Convert.ToInt32(WithdrawTb.Text) > bal)
            {
                MessageBox.Show("Balance Can not be negative");
            }
            else
            {
                try
                {
                    newbalance = bal - Convert.ToInt32(WithdrawTb.Text);
                    try
                    {
                        Con.Open();
                        string query = "update CitizenData set Balance=" + newbalance + " where AccountNo='" + Account + "';";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Successfully Withdraw");
                        Con.Close();
                        addtransaction();
                        //Home home = new Home();
                        //home.Show();
                        //this.Hide();




                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void WithdrawTb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Home log = new Home();
            log.Show();
            this.Hide();
        }
    }
}
