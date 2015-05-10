using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TravelAgency
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
            ManageBankAccounts t = new ManageBankAccounts();
            t.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManageExpenses  t = new ManageExpenses();
            t.ShowDialog();         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageCashiers t = new ManageCashiers();
            t.ShowDialog();   
        }     
  
    }
}
