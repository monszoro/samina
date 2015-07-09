using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency.Financials
{
    public partial class GetReveneus : Form
    {
        public GetReveneus()
        {
            InitializeComponent();
            uc_accountCurrenciesAmount.loadControl(true);
        }
    }
}
