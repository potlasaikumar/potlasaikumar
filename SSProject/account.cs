using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml.Schema;

namespace SSProject
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\potla.kumar\Documents\citizenbankDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button1_Click(object sender, EventArgs e)
        {
           
            int bal = 0;
         //   int PIN = 0;

            int BankRegistered = 0;
            
            
                
            
        
            if (NameTb.Text == "" || AccountNoTb.Text == "" || FatherNameTb.Text == "" || PhoneTb.Text == "" || AddressTb.Text == "" || PinTb.Text == "" )
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                { 
                    Con.Open();
                    string query = "insert CitizenData values('" + AccountNoTb.Text + "','" + NameTb.Text + "','" + FatherNameTb.Text + "','" + Dobdate.Value.Date + "','"+PhoneTb.Text +"','"+AddressTb.Text+"',"+bal+ ","+PinTb.Text+",'" + BankRegistered+"')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account will be Progressing ");
                    Con.Close();
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();

                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void account_Load(object sender, EventArgs e)
        {

        }

        private void AddressTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void PinTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
