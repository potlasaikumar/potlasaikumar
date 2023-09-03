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

namespace SSProject
{
    public partial class EnterATMPIN : Form
    {
        public EnterATMPIN()
        {
            InitializeComponent();
        }
        public static String PIN;
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\potla.kumar\Documents\citizenbankDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void PinTb_TextChanged(object sender, EventArgs e)
        {
            
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from CitizenData where PIN =" + PinTb.Text + "", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    PIN = PinTb.Text;
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Wrong PIN ");
                }
                Con.Close();

            
        }

        private void EnterATMPIN_Load(object sender, EventArgs e)
        {

        }
    }
}
