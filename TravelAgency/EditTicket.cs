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
    public partial class Editticket : Form{
    
        private Ticket ticket;

        public Editticket(Ticket t)
        {
            InitializeComponent();
            this.ticket  = t;
            lblClient.Text = t.Client.FirstName;

            var query = from u in TravelAgenceMasterClass.getTravelAgencyContext().Users
                        select u;

            foreach (var user in query)
            {
                cboAssignee.Items.Add(user.Login);
                if (ticket.AssigneeUserID == user.UserID)
                    cboAssignee.SelectedItem = user.Login ;
            }
            var query2 = from n in TravelAgenceMasterClass.getTravelAgencyContext().Notes
                    where n.TicketID == t.TicketID
                    orderby n.DateCreated
                    select n;

            foreach (var note in query2)
            {
                RichTextBox r = new RichTextBox();
                r.Size = new System.Drawing.Size(800, 60);
                r.Text =note.User.Login + "{"+note.DateCreated.ToString() +"}:"+
                    Environment.NewLine +note.NoteBody;
                r.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
                r.ReadOnly = true;
                r.BackColor = Color.White;
                tableNotes.RowCount += 1;
                tableNotes.Controls.Add(r, 0, tableNotes.RowCount - 1);               
            }
        }

          private void cmdSave_Click(object sender, EventArgs e)
        {
            saveTicket(false);
           Close();
            
        }
        private void saveTicket(Boolean closeTicket )
        {
            var query = from u in TravelAgenceMasterClass.getTravelAgencyContext().Users
                        where u.Login.Equals(cboAssignee.Text)
                        select u;

            var user = query.First();
            ticket = TravelAgenceMasterClass.getTravelAgencyContext().Tickets.Where(t => t.TicketID == ticket.TicketID).SingleOrDefault();
            ticket.AssigneeUserID = user.UserID;
            if (richTextBox1.Text != null && richTextBox1.Text != "")
            {
                Note n =new  Note();
                n.NoteBody= richTextBox1.Text;
                n.DateCreated=DateTime.Now;
                n.TicketID=ticket.TicketID;
                n.CreationUserID = TravelAgenceMasterClass.CurrentUser.UserID;
                TravelAgenceMasterClass.getTravelAgencyContext().Notes.Add(n);
            }
            if (closeTicket)
                ticket.IsClosed = true;
            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
            
        }

        private void cboDefaultWarehouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tableNotes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdCloseTicket_Click(object sender, EventArgs e)
        {
            saveTicket(true);
            this.Close();
        }
    }
 
}
