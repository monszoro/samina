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
    public partial class Newticket : Form{
    
        private Client client;

        private bool blnLoading=false;
        public Newticket()
        {
            blnLoading = true;
            InitializeComponent();
            loadUsers();
            loadClients();
            blnLoading = false;
        }

        public Newticket(Client client)
        {
            blnLoading = true;
            InitializeComponent();
            loadUsers();
            loadClients();
            setClient(client);
            blnLoading = false;
         }

        private void setClient(Client client)
        {
            this.client = client;
            int i;
            for (i = 0; i < cboclients.Items.Count; i++)
            {
                if (this.client.ClientID == ((Client)cboclients.Items[i]).ClientID) 
                {
                    cboclients.SelectedIndex = i;
                    return;
                }
            }

         //   lblClient.Text = client.FirstName + " " + client.LastName;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (this.client == null || string.IsNullOrEmpty(cboclients.Text))
            {
                errorProvider1.SetError(cboclients, "Please Choose Client");
                return;
            }
            else errorProvider1.SetError(cboclients, "");

            var query = from u in TravelAgenceMasterClass.getTravelAgencyContext().Users
                        where u.Login.Equals(cboAssignee.Text)
                        select u;

            var user = query.First();

            Ticket t = new Ticket();
            t.DateCreated= DateTime.Now;
            t.CreationUserID= TravelAgenceMasterClass.CurrentUser.UserID;
            t.AssigneeUserID=user.UserID;
            t.ClientID = client.ClientID;
            t.IsClosed = false;
            TravelAgenceMasterClass.getTravelAgencyContext().Tickets.Add(t);
            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
            Note n = new Note();
            n.NoteBody = richTextBox2.Text ;
            n.DateCreated = DateTime.Now;
            n.TicketID = t.TicketID;
            n.CreationUserID = TravelAgenceMasterClass.CurrentUser.UserID;
            TravelAgenceMasterClass.getTravelAgencyContext().Notes.Add(n);
            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
           Close();
        }

        private void loadUsers()
        {
            var query = from u in TravelAgenceMasterClass.getTravelAgencyContext().Users
                        select u;
            foreach (var user in query)
            {
                cboAssignee.Items.Add(user.Login);
                if(user.UserID==TravelAgenceMasterClass.CurrentUser.UserID)
                cboAssignee.SelectedIndex=cboAssignee.Items.Count-1;
            }
        }
        private void loadClients()
        {
            cboclients.ValueMember = "FullName";
                var query = from c in TravelAgenceMasterClass.getTravelAgencyContext().Clients
                        select c;
            foreach (var client in query)
            {
                cboclients.Items.Add(client);
            }
        }

        private void cboclients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!blnLoading)
            {
                if (cboclients.SelectedItem != null)
                {
                    this.client= ((Client)cboclients.SelectedItem);
                }
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
    }
 
}
