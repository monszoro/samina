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
    public partial class ManageClientGroups : Form
    {
        public ManageClientGroups()
        {
            InitializeComponent();
            LoadGroups();
        }
        public void LoadGroups()
        {
            dgvGroups.Rows.Clear();
            TravelAgencyEntities t = new TravelAgencyEntities();
            var query = from clientGrp in t.ClientGroups
                        select clientGrp;
            foreach (var clientGrp in query)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
                Name.Value = clientGrp.Name;
                row.Cells.Add(Name);
                DataGridViewTextBoxCell Desc = new DataGridViewTextBoxCell();
                Desc.Value = clientGrp.Description;
                row.Cells.Add(Desc);
                row.Tag = clientGrp;
                dgvGroups.Rows.Add(row);
            }
        }
        private void cmdNew_Click(object sender, EventArgs e)
        {
            ManageClients  frmClients = new ManageClients(true);
            List<Client> lstclients=frmClients.ReturnClientSelection();
            ClientGroup selectedGroup = (ClientGroup)dgvGroups.SelectedRows[0].Tag;
            selectedGroup = TravelAgenceMasterClass.getTravelAgencyContext().ClientGroups.Where(cg => cg.ClientGroupID == selectedGroup.ClientGroupID).SingleOrDefault();                     
            
            dgvClients.Rows.Clear();
            int i;
           if (lstclients.Count > 0)
            {
                for (i = 0; i < lstclients.Count;i++ )
                {

                Client clientToAdd = lstclients.ElementAt(i);
                if (!selectedGroup.Clients.Contains(clientToAdd))
                {
                    Client c = TravelAgenceMasterClass.getTravelAgencyContext().Clients.Where(client => client.ClientID == clientToAdd.ClientID).SingleOrDefault();
                    selectedGroup.Clients.Add(c);
                }
              }
            }
           TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
            LoadClientsForSelectedGtoup();
        }

        private void dgvGroups_SelectionChanged(object sender, EventArgs e)
        {
            ClientGroup clientGroup = (ClientGroup)dgvGroups.SelectedRows[0].Tag;
            if (clientGroup.ClientGroupID == 1)
            {
                cmdRemoveClient.Enabled = false;
                cmdNew.Enabled = false;
            }
            else
            {
                cmdRemoveClient.Enabled = true;
                cmdNew.Enabled = true;

            }
            LoadClientsForSelectedGtoup();
        }

        private void LoadClientsForSelectedGtoup()
        {
            if (dgvGroups.SelectedRows.Count == 0)
            {
                return;
            }
            ClientGroup cg = (ClientGroup)dgvGroups.SelectedRows[0].Tag;
            cg = TravelAgenceMasterClass.getTravelAgencyContext().ClientGroups.Where(c => c.ClientGroupID == cg.ClientGroupID).SingleOrDefault();
            dgvClients.Rows.Clear();
            foreach (Client Client1 in cg.Clients)
            {

                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell();
                ID.Value = TravelAgenceMasterClass.CurrentBranch.BranchID.ToString() + Client1.DateCreated.Value.Year.ToString() + Client1.ClientID.ToString();
                row.Cells.Add(ID);
                DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
                Name.Value = Client1.FirstName + " " + Client1.MiddleName + " " + Client1.LastName;
                row.Cells.Add(Name);
                DataGridViewTextBoxCell CellPhone = new DataGridViewTextBoxCell();
                CellPhone.Value = Client1.CellPhone1;
                row.Cells.Add(CellPhone);
                DataGridViewTextBoxCell Email = new DataGridViewTextBoxCell();
                Email.Value = Client1.Email;
                row.Cells.Add(Email);
                row.Tag = Client1;
                dgvClients.Rows.Add(row);
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            String emails = "";
            foreach (DataGridViewRow row in dgvClients.Rows)
            {
                emails = emails + row.Cells[3].Value.ToString();
            }
            MessageBox.Show(emails);
        }

        private void cmdRemoveClient_Click(object sender, EventArgs e)
        {
            if (dgvGroups.SelectedRows.Count == 0 || dgvClients.SelectedRows.Count==0)
            {              
                return;
            }
            ClientGroup clientGroup = (ClientGroup)dgvGroups.SelectedRows[0].Tag;
            clientGroup = TravelAgenceMasterClass.getTravelAgencyContext().ClientGroups.Where(cg => cg.ClientGroupID == clientGroup.ClientGroupID).SingleOrDefault();
            Client client = (Client)dgvClients.SelectedRows[0].Tag;
            client = TravelAgenceMasterClass.getTravelAgencyContext().Clients.Where(c => c.ClientID == client.ClientID).SingleOrDefault();

            clientGroup.Clients.Remove(client);
            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
            
            LoadClientsForSelectedGtoup();
                       

        }

        private void cmdNewGroup_Click(object sender, EventArgs e)
        {
            AddEditClientGroup clientGroupWindow = new AddEditClientGroup();
            clientGroupWindow.ShowDialog();
            if (clientGroupWindow.NewGroupAdded)
                LoadGroups();

        }

        private void dgvGroups_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGroups.SelectedRows.Count == 0)
                return;
            ClientGroup clientGroup = (ClientGroup)dgvGroups.SelectedRows[0].Tag;
            if (clientGroup.ClientGroupID == 1)
                return;
            AddEditClientGroup addEditClientGroup = new AddEditClientGroup(clientGroup);

            addEditClientGroup.ShowDialog();
            if (addEditClientGroup.clientGroupUpdated)
            {
                LoadGroups();
            }

        }
        
    }
 
}
