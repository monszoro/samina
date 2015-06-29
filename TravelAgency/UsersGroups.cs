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
    public partial class UsersGroups : Form
    {
        public UsersGroups()
        {
            InitializeComponent();
            LoadGroups();
        }

        public void LoadGroups()
        {

            dgvUserGroups.Rows.Clear();
         
            var query = from uG in TravelAgenceMasterClass.TravelAgencyContext.UserGroups
                        select uG;
            foreach (var UGroup in query)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell();
                ID.Value = UGroup.UserGroupID;
                row.Cells.Add(ID);
                DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
                Name.Value = UGroup.GroupName;
                row.Cells.Add(Name);
                DataGridViewTextBoxCell Description = new DataGridViewTextBoxCell();
                Description.Value = UGroup.Description;
                row.Cells.Add(Description);
                row.Tag = UGroup;
                dgvUserGroups.Rows.Add(row);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
          //  TravelAgencyEntities t = new TravelAgencyEntities();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            NewUserGroup userGroup = new NewUserGroup();
            userGroup.ShowDialog();
            if (userGroup.NewGroupAdded)
                LoadGroups();
        }

        private void dgvUserGroups_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserGroups.SelectedRows.Count > 0)
            {
                EditUserGroup userGroup = new EditUserGroup((UserGroup)dgvUserGroups.SelectedRows[0].Tag);
                userGroup.ShowDialog();
                if (userGroup.userGroupUpdated)
                    LoadGroups();
            }
        }

        private void dgvUserGroups_SelectionChanged(object sender, EventArgs e)
        {
            LoadUsersForSelectedGtoup();

        }

        private void LoadUsersForSelectedGtoup()
        {
            if (dgvUserGroups.SelectedRows.Count == 0)
            {
                return;
            }
            UserGroup Ug = (UserGroup)dgvUserGroups.SelectedRows[0].Tag;
            dgvUsers.Rows.Clear();
            foreach (User u in Ug.Users)
            {
                if (u.isActive)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell();
                    ID.Value = u.UserID;
                    row.Cells.Add(ID);
                    DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
                    Name.Value = u.UserName;
                    row.Cells.Add(Name);
                    DataGridViewTextBoxCell Description = new DataGridViewTextBoxCell();
                    Description.Value = u.Login;
                    row.Cells.Add(Description);
                    row.Tag = u;
                    dgvUsers.Rows.Add(row);
                }
            }


        
        }
        private void cmdNewUser_Click(object sender, EventArgs e)
        {
            if (dgvUserGroups.Rows.Count == 0)
            {
                MessageBox.Show("you must add new user group to be able to create the user");
                return;
            }
            else if (dgvUserGroups.SelectedRows.Count == 0)
            {
                MessageBox.Show("you must select user group to be able to create the user");
                return;
            }
            else
            {
                NewUser user = new NewUser((UserGroup)dgvUserGroups.SelectedRows[0].Tag);
                user.ShowDialog();
                if (user.NewUserAdded)
                {
                    LoadUsersForSelectedGtoup();
                }

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUserGroups.SelectedRows.Count == 0)
                return;

            EditUser user = new EditUser((User)dgvUsers.SelectedRows[0].Tag);
            user.ShowDialog();
            if (user.userUpdated)
            {
                LoadUsersForSelectedGtoup();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete the selected user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int id = ((User)dgvUsers.SelectedRows[0].Tag).UserID;
                User user = TravelAgenceMasterClass.TravelAgencyContext.Users.Where(u => u.UserID == id).SingleOrDefault();
                user.isActive = false;
                TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
                LoadUsersForSelectedGtoup();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
    }
}
