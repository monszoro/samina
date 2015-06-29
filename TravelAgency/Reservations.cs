using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Database;
namespace TravelAgency
{
    public partial class Reservations : Form
    {
        public Reservations()
        {
            InitializeComponent();
            ResetControls();
        }

        private void ResetControls(){
            cboReservationStatuses.Items.Add("All");
            var query = from rs in TravelAgenceMasterClass.TravelAgencyContext.ReservationStatuses
                        select rs;
            cboReservationStatuses.ValueMember = "Description";
            foreach (var reservationStatus in query)
            {
                cboReservationStatuses.Items.Add(reservationStatus);
            }
            cboReservationStatuses.SelectedIndex = 0;

            dtpFrom.Value = DateTime.Now.AddMonths(-1);
            dtpTo.Value = DateTime.Now;

            var queryClients = from c in TravelAgenceMasterClass.TravelAgencyContext.Clients
                        select c;

            foreach (var cl in queryClients)
            {
                txtClientName.AutoCompleteCustomSource.Add(cl.FullName);
            }
    }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            dgvReservations.Rows.Clear();
            
            DateTime dateTo=dtpTo.Value.Date.AddDays(1);
            DateTime dateFrom=dtpFrom.Value.Date;
            int ClientID = -1;
            if (txtClientName.Tag != null)
                ClientID = ((Client)txtClientName.Tag).ClientID;

            var query = from r in TravelAgenceMasterClass.TravelAgencyContext.Reservations 
                        where 
                     (r.ClientID== ClientID || (ClientID == -1 && r.Client.FullName.Contains(txtClientName.Text)))
                    && r.DateCreated>=dateFrom && r.DateCreated<=dateTo
                    && (cboReservationStatuses.SelectedIndex==0 || r.StatusID== cboReservationStatuses.SelectedIndex)
                        select r;
                     
                foreach (var res in query)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Tag = res;
                    DataGridViewTextBoxCell Number = new DataGridViewTextBoxCell();
                    Number.Value = res.ReservationID;
                    row.Cells.Add(Number);

                    DataGridViewTextBoxCell Client = new DataGridViewTextBoxCell();
                    Client.Value = res.Client.FullName;
                    row.Cells.Add(Client);
                    DataGridViewTextBoxCell date = new DataGridViewTextBoxCell();
                    date.Value = res.DateCreated;
                    row.Cells.Add(date);
                    //row.Tag = Client1;
                    dgvReservations.Rows.Add(row);
                }
            

        }

         private void dgvExpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                Reservation r  = (Reservation)dgvReservations.SelectedRows[0].Tag;
                NewReservation frmEdit = new NewReservation(r);
                frmEdit.ShowDialog();
            }

        }

        private void cmdSearchClient_Click(object sender, EventArgs e)
        {
            ManageClients frmClients = new ManageClients(false);
            frmClients.ShowDialog();
            Client client = frmClients.getSelectedClient();
            if (client != null)
            {
                txtClientName.Text = client.FullName;
                txtClientName.Tag = client;
            }
                
        }

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            txtClientName.Tag = null;
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            NewReservation newReservationWindow = new NewReservation();
            newReservationWindow.ShowDialog();
        }

    }
}
