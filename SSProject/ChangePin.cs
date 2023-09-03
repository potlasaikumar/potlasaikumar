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
using System.Security.Principal;

namespace SSProject
{
    public partial class ChangePin : Form
    {
        public ChangePin()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\potla.kumar\Documents\citizenbankDb.mdf;Integrated Security=True;Connect Timeout=30");
        string Account = Login.AccountNo;
        private void button1_Click(object sender, EventArgs e)
        {
            if (NewPinTb.Text == "" || ConfirmPinTb.Text == "")

            {
                MessageBox.Show("Enter And confirm the new PIN ");
            }
            else if(ConfirmPinTb.Text != NewPinTb.Text)
            {
                MessageBox.Show("NewPin and ConfirmPin are Different");
            }
            {

             
                try
                {
                    Con.Open();
                    string query = "update CitizenData set PIN=" + NewPinTb.Text + " where AccountNo='" + Account + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PIN Successfully Updated ");
                    Con.Close();
                    Login home = new Login();
                    home.Show();
                    this.Hide();



                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void ChangePin_Load(object sender, EventArgs e)
        {

        }
    }
    
}
