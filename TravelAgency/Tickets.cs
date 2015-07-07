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
    public partial class Tickets : Form
    {
        public Tickets()
        {
            InitializeComponent();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Now.AddMonths(-1);
            dtpTo.Value = DateTime.Now;
            cboStatus.SelectedIndex = 0;

            var query = from c in TravelAgenceMasterClass.getTravelAgencyContext().Clients
                        select c;

            foreach (var cl in query)
            {
                txtClientName.AutoCompleteCustomSource.Add(cl.FullName);
            }
        }
             

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            SearchTickets();  
        }
        private void SearchTickets()
        {
            dgvTickets.Rows.Clear();
            DateTime dateFrom = dtpFrom.Value.Date;
            DateTime dateTo=dtpTo.Value.Date.AddDays(1);
            int closed = cboStatus.SelectedIndex;
            int ClientID = -1;
            if (txtClientName.Tag != null)
                ClientID = ((Client)txtClientName.Tag).ClientID;
            var query = from t in TravelAgenceMasterClass.getTravelAgencyContext().Tickets
                        where t.DateCreated>=dateFrom && t.DateCreated<=dateTo
                        && (t.IsClosed == (closed == 2) || 0 == closed)
                        && (t.ClientID== ClientID || (ClientID == -1 && ((t.Client.FullName).Contains(txtClientName.Text))))
                        select t;
            foreach (var ticket1 in query)
            {

                DataGridViewRow row = new DataGridViewRow();
                row.Tag = ticket1;
                DataGridViewTextBoxCell Number = new DataGridViewTextBoxCell();
                Number.Value = ticket1.TicketID;
                row.Cells.Add(Number);

                DataGridViewTextBoxCell Client = new DataGridViewTextBoxCell();
                Client.Value = ticket1.Client.FullName;
                row.Cells.Add(Client);
                DataGridViewTextBoxCell status = new DataGridViewTextBoxCell();
                if (ticket1.IsClosed)
                    status.Value = "Closed";
                else
                    status.Value = "Open";
                
                row.Cells.Add(status);
                DataGridViewTextBoxCell date = new DataGridViewTextBoxCell();
                date.Value = ticket1.DateCreated;
                row.Cells.Add(date);
                //row.Tag = Client1;
                dgvTickets.Rows.Add(row);
            }
        }
         
        private void dgvExpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTickets.SelectedRows.Count > 0)
            {
                Ticket t  = (Ticket)dgvTickets.SelectedRows[0].Tag;
                Editticket frmEdit = new Editticket(t);
                frmEdit.ShowDialog();
            }

        }

               private void cmdNew_Click(object sender, EventArgs e)
        {
            Newticket frmTickets = new Newticket();
            frmTickets.ShowDialog();
        }

        private void cmdSearchClients_Click(object sender, EventArgs e)
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

     }
             
}
