using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravelAgency.Financials
{
    public partial class Financial : Form
    {
        public Financial()
        {
            InitializeComponent();
           
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SplashForm f = new SplashForm();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VendorPayment t = new VendorPayment();
            t.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ExpensesPayment t = new ExpensesPayment();
            t.ShowDialog();         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClientPayment clientPayment = new ClientPayment();
            clientPayment.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientRefund clientRefund = new ClientRefund();
            clientRefund.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetReveneus getReveneus = new GetReveneus();
            getReveneus.ShowDialog();
        }     
  
    }
}
