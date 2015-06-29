using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Database;
namespace Reporting
{
    public partial class ReportingForm : Form
    {
        public ReportingForm()
        {
            InitializeComponent();
        }
        public void viewReservationReport(Reservation r)
        {
            ReservationReport rep = new ReservationReport();
            rep.SetParameterValue(0, r.ReservationID);
            this.crystalReportViewer1.ReportSource = rep;
            this.ShowDialog();
        }
    }
}
