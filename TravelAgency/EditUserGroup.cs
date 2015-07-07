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
    public partial class EditUserGroup : Form{

        public Boolean userGroupUpdated;
        public UserGroup userGroup;

        public EditUserGroup(UserGroup userGroup)
        {
            InitializeComponent();
            userGroupUpdated = false;
            this.userGroup = userGroup;
            txtGroupName.Text = userGroup.GroupName;
            txtGroupDescription.Text = userGroup.Description;
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
            
            userGroup = TravelAgenceMasterClass.getTravelAgencyContext().UserGroups.Where(ug => ug.UserGroupID == userGroup.UserGroupID).SingleOrDefault();
            userGroup.GroupName = txtGroupName.Text;
            userGroup.Description = txtGroupDescription.Text;
            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();   
            userGroupUpdated = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
