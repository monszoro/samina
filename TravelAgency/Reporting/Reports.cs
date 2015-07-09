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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
           
        }

     

        
        private void cmdLedgerTransactions_Click(object sender, EventArgs e)
        {
            LedgerTransactionsReport ltRep = new LedgerTransactionsReport ();
            ltRep.ShowDialog();
        }

        
  
    }
}
