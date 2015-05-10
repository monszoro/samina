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
    public partial class NewUserGroup : Form{

        public Boolean NewGroupAdded;
        public NewUserGroup()
        {
            InitializeComponent();
            NewGroupAdded = false;
        }

        private void Tickets_Load(object sender, EventArgs e)
        {

        }

        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }


        private void gbCompany_Enter(object sender, EventArgs e)
        {

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
            UserGroup ug =new  UserGroup();
            ug.GroupName=txtGroupName.Text;
            ug.Description = txtGroupDescription.Text;
            TravelAgenceMasterClass.TravelAgencyContext.UserGroups.Add(ug);
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            NewGroupAdded = true;
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 
}
