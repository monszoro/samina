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
    public partial class AddEditClientGroup : Form
    {

        public Boolean clientGroupUpdated;
        public ClientGroup clientGroup;
        public bool NewGroupAdded;

        public AddEditClientGroup(ClientGroup clientGroup)
        {
            InitializeComponent();
            clientGroupUpdated = false;
            this.clientGroup = clientGroup;
            txtGroupName.Text = clientGroup.Name;
            txtGroupDescription.Text = clientGroup.Description;
        }
        public AddEditClientGroup()
        {
            InitializeComponent();
        }
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtGroupName.Text))
            {
                errorProvider1.SetError(txtGroupName, "Required Field");
                return;
            }
            else
            {
                errorProvider1.SetError(txtGroupName, "");
            }
            if (this.clientGroup != null)
            {
                clientGroup = TravelAgenceMasterClass.TravelAgencyContext.ClientGroups.Where(ug => ug.ClientGroupID == clientGroup.ClientGroupID).SingleOrDefault();
                clientGroup.Name = txtGroupName.Text;
                clientGroup.Description = txtGroupDescription.Text;
                TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
                clientGroupUpdated = true;
                this.Close();
            }
            else
            {
                clientGroup = new ClientGroup();
                clientGroup.Name = txtGroupName.Text;
                clientGroup.Description = txtGroupDescription.Text;
                TravelAgenceMasterClass.TravelAgencyContext.ClientGroups.Add(clientGroup);
                TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
                NewGroupAdded = true;
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
