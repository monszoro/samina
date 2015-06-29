using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Database;
namespace TravelAgency
{
    public partial class EditClient : Form
    {
        private Client cl;
        private bool FileDialogOpenedFromImage;
        private ManageClients frmManageClients;
        public EditClient(ManageClients frmManageClients, Client c)
        {
            InitializeComponent();
            this.cl = c;
            this.frmManageClients = frmManageClients;
            txtAddress.Text = c.Address;
            txtFirstName.Text = c.FirstName;
            txtLastName.Text = c.LastName;
            txtMiddleName.Text = c.MiddleName;
            txtEmail.Text = c.Email;
            txtTitle.Text = c.Title;
            txtCellPhone1.Text = c.CellPhone1;
            txtCellPhone2.Text = c.CellPhone2;
            txtHomePhone.Text = c.HomePhone;
            txtOfficePhone.Text = c.OfficePhone;
            txtVerfiyEmail.Text = c.Email;
            if (!(string.IsNullOrEmpty(c.ProfilePictureName)))
            clientPhotoPicBox.ImageLocation = TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" +c.DateCreated.Value.Year+"\\"+c.ClientID.ToString()+"\\"+ c.ProfilePictureName;
            if (Directory.Exists(TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + c.DateCreated.Value.Year + "\\" + c.ClientID.ToString()))
            {
                String[] files = Directory.GetFiles(TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + c.DateCreated.Value.Year + "\\" + c.ClientID.ToString());
                foreach (string file in files)
                {
                    if (!file.Equals(clientPhotoPicBox.ImageLocation))
                    {
                        DataGridViewRow row = new DataGridViewRow();
                        DataGridViewTextBoxCell FileName = new DataGridViewTextBoxCell();
                        FileName.Value = file.Split(new char[] { '\\' }).Last();
                        FileName.Tag = file;
                        row.Cells.Add(FileName);
                        DataGridViewImageCell image = new DataGridViewImageCell();
                        image.Value = TravelAgency.Properties.Resources.remove16;
                        row.Cells.Add(image);
                        dgvAttachments.Rows.Add(row);
                        dgvAttachments.Height += row.Height;
                    }
                }
            }

        }
        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            FileDialogOpenedFromImage = false;
            fileDialog.ShowDialog();
        }

          private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            if (FileDialogOpenedFromImage)
            {
                string s = fileDialog.FileName;
                clientPhotoPicBox.ImageLocation = s;
            }
            else
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell FileName = new DataGridViewTextBoxCell();
                FileName.Value = fileDialog.FileName.Split(new char[]{'\\'}).Last();
                FileName.Tag = fileDialog.FileName;
                row.Cells.Add(FileName);
                DataGridViewImageCell image = new DataGridViewImageCell();
                image.Value = TravelAgency.Properties.Resources.remove16;
                row.Cells.Add(image);
                dgvAttachments.Rows.Add(row);
                dgvAttachments.Height += row.Height;
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            bool ExitSave = false;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                errorProvider1.SetError(txtFirstName, "Required Field");
                ExitSave = true;
            }
            else
                errorProvider1.SetError(txtFirstName, "");

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                errorProvider1.SetError(txtLastName, "Required Field");
                ExitSave = true;
            }
            else
                errorProvider1.SetError(txtLastName, "");

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Required Field");
                ExitSave = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");

                if (!txtEmail.Text.Equals(txtVerfiyEmail.Text))
                {
                    errorProvider1.SetError(txtVerfiyEmail, "the email doesn't match");
                    ExitSave = true;
                }
                else
                    errorProvider1.SetError(txtVerfiyEmail, "");
            }
            if (ExitSave == true)
                return;
            cl = TravelAgenceMasterClass.getTravelAgencyContext().Clients.Where(u => u.ClientID == cl.ClientID).SingleOrDefault();
            if (!Directory.Exists(TravelAgenceMasterClass.CurrentBranch.FilesPath))
            {
                Directory.CreateDirectory(TravelAgenceMasterClass.CurrentBranch.FilesPath);
            }
            Directory.CreateDirectory(TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + cl.DateCreated.Value.Year + "\\" + cl.ClientID);
            if (clientPhotoPicBox.ImageLocation != null && !clientPhotoPicBox.ImageLocation.Equals("") && !clientPhotoPicBox.ImageLocation.Contains(TravelAgenceMasterClass.CurrentBranch.FilesPath))
            {
                if (File.Exists(TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + cl.DateCreated.Value.Year
                    + "\\" + cl.ClientID + "\\" + clientPhotoPicBox.ImageLocation.Split(new char[] { '\\' }).Last()))
                {
                    MessageBox.Show("The profile picture is already attached to this customer.", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    return;
                }
                File.Copy(clientPhotoPicBox.ImageLocation, TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + cl.DateCreated.Value.Year
                    + "\\" + cl.ClientID + "\\" + clientPhotoPicBox.ImageLocation.Split(new char[] { '\\' }).Last());
                if (File.Exists(TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + cl.DateCreated.Value.Year
                    + "\\" + cl.ClientID + "\\" + cl.ProfilePictureName))
                File.Delete(TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + cl.DateCreated.Value.Year
                    + "\\" + cl.ClientID + "\\" + cl.ProfilePictureName);
                cl.ProfilePictureName = clientPhotoPicBox.ImageLocation.Split(new char[] { '\\' }).Last();
            }
            cl.FirstName = txtFirstName.Text;
            cl.LastName = txtLastName.Text;
            cl.MiddleName = txtMiddleName.Text;
            cl.Title = txtTitle.Text;
            cl.Email = txtEmail.Text;
            cl.Address = txtAddress.Text;
            cl.CellPhone1 = txtCellPhone1.Text;
            cl.CellPhone2 = txtCellPhone2.Text;
            cl.DateCreated = DateTime.Now;
            cl.DateOfBirth = dtpDOB.Value;

            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
            foreach (DataGridViewRow row in dgvAttachments.Rows)
            {
                if(!row.Visible)
                File.Delete(TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + cl.DateCreated.Value.Year + "\\" + cl.ClientID + "\\" + row.Cells[0].Value.ToString().Split(new char[] { '\\' }).Last());
                else if (!File.Exists(TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + cl.DateCreated.Value.Year + "\\" + cl.ClientID + "\\" + row.Cells[0].Value.ToString().Split(new char[] { '\\' }).Last()))
                {
                    File.Copy(row.Cells[0].Tag.ToString(), TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + cl.DateCreated.Value.Year
                        + "\\" + cl.ClientID + "\\" + row.Cells[0].Value.ToString().Split(new char[] { '\\' }).Last());
                }
            }
            frmManageClients.SearchClients();
            Close();
          }

        private void cmdCreateTicket_Click(object sender, EventArgs e)
        {
            Newticket frmNewTicket = new Newticket(this.cl);
            frmNewTicket.ShowDialog();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            cmdAttach.Visible = true;
            foreach (Control c in this.Controls)
            {
                foreach (Control c1 in c.Controls)
                {
                    if (c1 is TextBox)
                        ((TextBox)c1).ReadOnly = false;
                    else if (c1 is DateTimePicker)
                        ((DateTimePicker)c1).Enabled = true;
                }
            }
            groupBox1.Enabled = true;
            clientPhotoPicBox.Enabled = true;
            cmdEdit.SendToBack();
        }

        private void cmdCreateReservation_Click(object sender, EventArgs e)
        {
            NewReservation frmNewReservation = new NewReservation(this.cl);
            frmNewReservation.ShowDialog();
        }

        private void dgvAttachments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 1)
                {
                    dgvAttachments.Rows[e.RowIndex].Visible = false;
                }
                else if (e.ColumnIndex == 0)
                {
                    string filePath = "";
                    if (dgvAttachments.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag != null)
                        filePath = dgvAttachments.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag.ToString();
                    if (File.Exists(filePath))
                        System.Diagnostics.Process.Start(filePath);
                }
                        
            }

        }

        private void lblClientPhoto_Click(object sender, EventArgs e)
        {
            FileDialogOpenedFromImage = true;
            fileDialog.ShowDialog();

        }

        private void cmdAttach_Click(object sender, EventArgs e)
        {
            FileDialogOpenedFromImage = false;
            fileDialog.ShowDialog();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAttachments_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }
        private void dgvAttachments_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

    }
}
