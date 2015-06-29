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
    public partial class EditUser : Form{

        public Boolean userUpdated;
        public User user;
        public EditUser(User user)
        {
            InitializeComponent();
            this.user = user;
            userUpdated  = false;
            var query = from g in TravelAgenceMasterClass.TravelAgencyContext.UserGroups
                        select g;

            cboUserGroups.ValueMember = "GroupName";
            foreach (var userGroup in query)
            {
                cboUserGroups.Items.Add(userGroup);
                if (userGroup.UserGroupID == user.UserGroup.UserGroupID)
                {
                    cboUserGroups.SelectedItem = userGroup;
                }
            }
            txtGroupName.Text = user.UserName;
            txtLogin.Text = user.Login;
            txtPassword.Text = user.Password;
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
            user = TravelAgenceMasterClass.TravelAgencyContext.Users.Where(u => u.UserID == user.UserID).SingleOrDefault();
            user.UserName = txtGroupName.Text;
            user.Login = txtLogin.Text;
            user.Password = txtPassword.Text;
            user.GroupID = ((UserGroup)cboUserGroups.SelectedItem).UserGroupID;
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            userUpdated = true;
            this.Close();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

             
    }
 
}
