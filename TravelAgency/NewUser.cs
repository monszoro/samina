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
    public partial class NewUser : Form{

        public Boolean NewUserAdded;
        public UserGroup UGroup;
        public NewUser(UserGroup UGroup)
        {
            InitializeComponent();
            NewUserAdded = false;
            var query = from g in TravelAgenceMasterClass.TravelAgencyContext.UserGroups
                        select g;

            cboUserGroups.ValueMember = "GroupName";
            foreach (var userGroup in query)
            {
                cboUserGroups.Items.Add(userGroup);
                if (userGroup.UserGroupID == UGroup.UserGroupID)
                {
                    cboUserGroups.SelectedItem = userGroup;
                }
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                errorProvider1.SetError(txtUserName, "Required Field");
                return;
            }
            else
            {
                errorProvider1.SetError(txtUserName, "");
            }
            User u = new User();
            u.UserName =txtUserName.Text;
            u.Login= txtLogin.Text;
            u.Password=txtPassword.Text;
            u.UserGroup = ((UserGroup)cboUserGroups.SelectedItem);
            u.isActive = true;
            TravelAgenceMasterClass.TravelAgencyContext.Users.Add(u);
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            NewUserAdded = true;
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 
}
