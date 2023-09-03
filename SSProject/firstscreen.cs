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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      //      if (Program.WPF == true)
        //    {
          //      MessageBox.Show("WPF is activated!*");
           // }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        int starting = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            starting += 1;
           // Myprogress.Value = starting;
           // Percentage.Text = "" + starting;
           // if(Myprogress.Value == 100) 
            {
                //Myprogress.Value = 0;
                timer1.Stop();
            }
            {
                
                timer1.Stop();
                Login login = new Login();
                this.Hide();
                this.Show();
            }
        }

        private void Percentage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            EnterATMPIN pin = new EnterATMPIN();
            pin.Show();
            this.Hide();
        }
    }
}
