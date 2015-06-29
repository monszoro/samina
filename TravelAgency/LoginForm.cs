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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            txtUserName.Text = "michael";
            txtPassword.Text = "12345678";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var query = from u in TravelAgenceMasterClass.getTravelAgencyContext().Users
                        where u.Login.Equals(txtUserName.Text)
                        && u.Password.Equals(txtPassword.Text)
                        && u.isActive.Equals(true)
                        select u;
         
            if (query.Count() > 0)
            {
                TravelAgenceMasterClass.CurrentUser = query.First();
                var queryBranches = from B in TravelAgenceMasterClass.getTravelAgencyContext().Branches
                                    select B;
                TravelAgenceMasterClass.CurrentBranch = queryBranches.First();
                this.Hide();
                MainFrom f = new MainFrom();
                f.ShowDialog();
            }
            else
            {
               
                MessageBox.Show("Invalid User Name And/Or Password","Cannot Login");
            }

            

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }
    }
}
