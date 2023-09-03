using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSProject
{
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\potla.kumar\Documents\citizenbankDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Account = Login.AccountNo;
        private void addtransaction()
        {
            string TrType = "Deposit";
            try
            {
                Con.Open();
                string query = "insert TransactionTable values('" + Account + "','" + TrType + "'," + DepositAmountTb.Text + ",'" + DateTime.Today.Date.ToString() + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();   
               
                Con.Close();
                
               // Login log = new Login();
                //log.Show();
                //this.Hide();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(DepositAmountTb.Text == "" || Convert.ToInt32(DepositAmountTb.Text) <= 0)
           
            {
                MessageBox.Show("Enter The Amount to Deposit ");
            }
            else
            {
                
                newbalance = oldbalance + Convert.ToInt32(DepositAmountTb.Text);
                try
                {
                    Con.Open();
                    string query = "update CitizenData set Balance=" + newbalance + " where AccountNo='" + Account + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Success Deposit");
                    Con.Close();
                    addtransaction();
                    Home home = new Home();
                    home.Show();
                    this.Hide();

                    

                }catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }
        //    SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\potla.kumar\Documents\citizenbankDb.mdf;Integrated Security=True;Connect Timeout=30");
        int oldbalance, newbalance;
        private void getbalance()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(" select Balance from CitizenData where AccountNo='" +Account+ "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            oldbalance = Convert.ToInt32(dt.Rows[0][0].ToString());
            Con.Close();
        }

        private void DepositAmountTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            getbalance();
        }
    }
}
