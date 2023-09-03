using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSProject
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Balance bal = new Balance();
            this.Hide();
            bal.Show();
        }
        public static String AccountNo;
        private void Home_Load(object sender, EventArgs e)
        {
            AccountNolbl.Text = "Account Number:" + Login.AccountNo;
            AccountNo = Login.AccountNo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deposit depo = new Deposit();
            depo.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangePin pin = new ChangePin();
            pin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            withdraw wd = new withdraw();
            wd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Mini_Statement mini = new Mini_Statement();
            mini.Show();
            this.Hide();
        }

       
    }
}
