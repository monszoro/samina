using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace TravelAgency
{
    public partial class ManageClients : Form
    {
        Boolean allowDetails;
        Client selectedClient;
        public ManageClients(Boolean allowDetails)
        {
            InitializeComponent();
            this.allowDetails = allowDetails;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            fileDialog.ShowDialog();
//            string t = fileDialog.FileName;
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string s = fileDialog.FileName;
         }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in gbClients.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            dgvClients.Rows.Clear();
        }

        private void cmdSearch_Click(object sender, EventArgs e)
        {
            SearchClients();
        }
        public void SearchClients()
        {
            dgvClients.Rows.Clear();
            
            DateTime d = dateTimePicker1.Value.Date;
            var query = from u in TravelAgenceMasterClass.TravelAgencyContext.Clients
                        where u.Title.Contains(txtTitle.Text) && u.FirstName.Contains(txtFirstName.Text)
                        && u.MiddleName.Contains(txtMiddleName.Text) && u.LastName.Contains(txtLastName.Text)
                        && u.CellPhone1.Contains(txtCellPhone1.Text) && u.CellPhone2.Contains(txtCellPhone1.Text)
                        && u.Email.Contains(txtEmail.Text)
                        && ((checkBox1.Checked && u.DateOfBirth.Value.Equals(d)) || !checkBox1.Checked)
                        select u;
            foreach (var client in query)
            {
                
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCheckBoxCell chk = new DataGridViewCheckBoxCell();
                chk.Value = false;
                row.Cells.Add(chk);
                DataGridViewTextBoxCell ID = new DataGridViewTextBoxCell();
                ID.Value = TravelAgenceMasterClass.CurrentBranch.BranchID.ToString() + client.DateCreated.Value.Year.ToString() + client.ClientID.ToString();
                row.Cells.Add(ID);
                DataGridViewTextBoxCell Name = new DataGridViewTextBoxCell();
                Name.Value = client.FirstName + " " + client.MiddleName + " " + client.LastName;
                row.Cells.Add(Name);
                DataGridViewTextBoxCell CellPhone = new DataGridViewTextBoxCell();
                CellPhone.Value = client.CellPhone1;
                row.Cells.Add(CellPhone);
                DataGridViewTextBoxCell Email = new DataGridViewTextBoxCell();
                Email.Value = client.Email;
                row.Cells.Add(Email);
                row.Tag = client;
                dgvClients.Rows.Add(row);
            }
        }
        private void cmdNew_Click(object sender, EventArgs e)
        {
            NewClient frmNewClient = new NewClient();
            frmNewClient.ShowDialog();
        }

        private void dgvExpense_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          if (dgvClients.SelectedRows.Count > 0)
            {
                selectedClient = (Client)dgvClients.SelectedRows[0].Tag;
                if (allowDetails)
                {
                    EditClient frmEdit = new EditClient(this, selectedClient);
                    frmEdit.ShowDialog();
                }
                else
                {
                    Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                dateTimePicker1.Enabled = true;
            else
                dateTimePicker1.Enabled = false;    
        }
        public List<Client> ReturnClientSelection()
        {
            cmdNew.Visible = false;
            cmdOk.Visible = true;
            colChkBox.Visible = true;
            this.ShowDialog();
            List<Client> lst = new List<Client>();
            foreach (DataGridViewRow row in dgvClients.Rows)
            {
                if (row.Cells[0].Value.Equals(true))
                {
                    lst.Add((Client)row.Tag);
                }
             
             }
            return lst;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Client getSelectedClient()
        {
            return selectedClient;
        }
    }
 
}