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
    public partial class ReportingForm : Form
    {
        public ReportingForm(string report)
        {
            InitializeComponent();
            this.reportViewer.LocalReport.ReportEmbeddedResource = report;
        }

        private void ReportingForm_Load(object sender, EventArgs e)
        {

            this.reportViewer.RefreshReport();
        }
    }
}
