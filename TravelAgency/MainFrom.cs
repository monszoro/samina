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
    public partial class MainFrom : Form
    {
        public MainFrom()
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

        private void butTickets_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(Tickets ))
                {
                    f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    return;
                }
            }
            Tickets t = new Tickets();
            t.MdiParent = this;
            t.WindowState = FormWindowState.Maximized;
            t.Show();
         }

            private void btnClients_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(ManageClients))
                {
                    f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    return;
                }
            }
            ManageClients m = new ManageClients(true);
            m.MdiParent = this;
            m.WindowState = FormWindowState.Maximized;
            m.Show();
        }

        private void MainFrom_FormClosing(object sender, FormClosingEventArgs e)
        
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            { 
                e.Cancel = true;
               // this.Close();
                //
            }
        }

        private void MainFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnReservations_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(Reservations ))
                {
                    f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    return;
                }
            }
            Reservations m = new Reservations();
            m.MdiParent = this;
            m.WindowState = FormWindowState.Maximized;
            m.Show();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(ManageVendors ))
                {
                    f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    return;
                }
            }
            ManageVendors m = new ManageVendors();
            m.MdiParent = this;
            m.WindowState = FormWindowState.Maximized;
            m.Show();

        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(Adminstration))
                {
                    f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    return;
                }
            }
            Adminstration m = new Adminstration();
            m.MdiParent = this;
            m.WindowState = FormWindowState.Maximized;
            m.Show();

        }

        private void btnClientGroups_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.GetType() == typeof(ManageClientGroups))
                {
                    f.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                    return;
                }
            }
            ManageClientGroups m = new ManageClientGroups();
            m.MdiParent = this;
            m.WindowState = FormWindowState.Maximized;
            m.Show();

        }

        private void btnFinancial_Click(object sender, EventArgs e)
        {
            Financial m = new Financial();
            m.MdiParent = this;
            m.WindowState = FormWindowState.Maximized;
            m.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            CheckForNewTickets();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            timer1.Start();
            CheckForNewTickets();


            
        }
        private void CheckForNewTickets()
        {

            var query = from t in TravelAgenceMasterClass.TravelAgencyContext.Tickets
                        where t.AssigneeUserID == TravelAgenceMasterClass.CurrentUser.UserID
                        select t;
            if (query.Count() > 0)
            {
                notifyIcon1.BalloonTipTitle = "Check New Tickets";
                notifyIcon1.BalloonTipText = "New Tickets";
                notifyIcon1.ShowBalloonTip(10000);
            }


        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            butTickets_Click(null,null);

        }
    }
}
