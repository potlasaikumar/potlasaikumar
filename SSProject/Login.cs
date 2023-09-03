using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace SSProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            account account = new account();
            account.Show();
            this.Hide();
        }
        public static String AccountNo;
        public static bool AccountStatus;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\potla.kumar\Documents\citizenbankDb.mdf;Integrated Security=True;Connect Timeout=30");
       
        private void button1_Click(object sender, EventArgs e)
        { 
            
            bool Account_Status = AccountStatus;

            string connection;
            SqlConnection Con;
            connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\potla.kumar\Documents\citizenbankDb.mdf;Integrated Security=True;Connect Timeout=30";
            Con = new SqlConnection(connection);

            Con.Open();
            string  Account = "";
            string sql = "Select  AccountStatus from CitizenData where AccountNo = '"+ AccountNoTb.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, Con);
            
            SqlDataReader dataReader = cmd.ExecuteReader();
            
            while (dataReader.Read())
            {
                Account_Status = dataReader.GetBoolean(0);
              //  Account_Status = dataReader.GetBoolean 
            }
            Console.Write(Account_Status);
            Con.Close();



          //  if (dt.Rows[0][0].ToString() == "1")
            if (Account_Status == false )
            {
                MessageBox.Show("Account is under Review ");
            }
            else if (Account_Status == true)
            {
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CitizenData where AccountNo='" + AccountNoTb.Text + "' and PIN =" + PinTb.Text + "", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    AccountNo = AccountNoTb.Text;
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong Account Number Or PIN ");
                }
                Con.Close();
            }


            


           





            /*bool Account_Status  = AccountStatus;
            string PIN = PinTb.Text;
            Con.Open();
            sql = Select AccountStatus from CitizenData where PIN = "+PinTb.Text+", Con);
            cmd = new SqlCommand(sql, Con);
            dreader = cmd.ExecuteReader();
            while (dreader.Read())
            {
                output = output + dreader.GetValue(0) + " - " +
                                    dreader.GetValue(1) + "\n";
            }
            Console.Write(output);
            dreader.Close();
            cmd.Dispose();
            Con.Close();*/


            /*  if (Account_Status == false )
              {

                  MessageBox.Show("you are granted with access");


              }


              else
              {

                  MessageBox.Show("you are not granted with access");
              }*/

           /* Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CitizenData where AccountNo='"+AccountNoTb.Text+"' and PIN ="+PinTb.Text+"", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                AccountNo = AccountNoTb.Text;
                Home home = new Home();
                home.Show();
                this.Hide();
                Con.Close();
            }else
            {
                MessageBox.Show("Wrong Account Number Or PIN ");
            }
            Con.Close();*/

        }

        private void PinTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void PinTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }

    }
