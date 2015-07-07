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
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }
      private void cmdBrowse_Click(object sender, EventArgs e)
        {
            attachmentsFileDialog.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string s = fileDialog.FileName;
            clientPhotoPicBox.ImageLocation = s;
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

            if (string.IsNullOrEmpty(txtCellPhone1.Text) && !string.IsNullOrEmpty(txtCellPhone2.Text))
            {
                errorProvider1.SetError(txtCellPhone2, "Please enter cellphone1 first");
                ExitSave = true;
            }
            else
            {
                errorProvider1.SetError(txtCellPhone2, "");
                if (string.IsNullOrEmpty(txtCellPhone1.Text))
                {
                    errorProvider1.SetError(txtCellPhone1, "Required Field");
                    ExitSave = true;
                }
                else
                {
                    errorProvider1.SetError(txtCellPhone1, "");
                }
            }
            if (!txtEmail.Text.Equals(txtVerfiyEmail.Text))
            {
                errorProvider1.SetError(txtVerfiyEmail, "the email doesn't match");
            }
            else
                errorProvider1.SetError(txtVerfiyEmail, "");

            if (ExitSave == true)
                return;
            
            Client c = new Client();
            c.FirstName=txtFirstName.Text;
            c.LastName=txtLastName.Text;
            c.Title=txtTitle.Text;
            c.Email=txtEmail.Text;
            c.CreationUserID = TravelAgenceMasterClass.CurrentUser.UserID;
            c.BranchID = 1;
            c.MiddleName=txtMiddleName.Text;
            c.Address = txtAddress.Text;
            c.CellPhone1 = txtCellPhone1.Text;
            c.CellPhone2 = txtCellPhone2.Text;
            c.DateCreated = DateTime.Now;
            c.DateOfBirth = dtpDOB.Value;
           
         
            TravelAgenceMasterClass.getTravelAgencyContext().Clients.Add(c);
            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
            if (!Directory.Exists(TravelAgenceMasterClass.CurrentBranch.FilesPath))
            {
                Directory.CreateDirectory(TravelAgenceMasterClass.CurrentBranch.FilesPath);
            }
            Directory.CreateDirectory(TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + c.DateCreated.Value.Year + "\\" + c.ClientID);

            if (clientPhotoPicBox.ImageLocation != null && !clientPhotoPicBox.ImageLocation.Equals(""))
           {
                File.Copy(clientPhotoPicBox.ImageLocation, TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + c.DateCreated.Value.Year
                    + "\\" + c.ClientID + "\\" + clientPhotoPicBox.ImageLocation.Split(new char[] { '\\' }).Last());

                c.ProfilePictureName = clientPhotoPicBox.ImageLocation.Split(new char[] { '\\' }).Last();
            }
            foreach (DataGridViewRow row in dgvAttachments.Rows)
            {
                File.Copy(row.Cells[0].Tag.ToString(), TravelAgenceMasterClass.CurrentBranch.FilesPath + "\\" + c.DateCreated.Value.Year
                    + "\\" + c.ClientID + "\\" + row.Cells[0].Value.ToString().Split(new char[] { '\\' }).Last());
            }

            TravelAgenceMasterClass.getTravelAgencyContext().SaveChanges();
            Close();
        }

        private void openFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            DataGridViewTextBoxCell FileName = new DataGridViewTextBoxCell();
            FileName.Value = attachmentsFileDialog.FileName.Split(new char[] { '\\' }).Last();
            FileName.Tag = attachmentsFileDialog.FileName;
            row.Cells.Add(FileName);
            DataGridViewImageCell image = new DataGridViewImageCell();
            image.Value = TravelAgency.Properties.Resources.remove16;
            row.Cells.Add(image);
            dgvAttachments.Rows.Add(row);
            //dgvAttachments.Height += row.Height;
        }
         private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void dgvAttachments_CellContentClick(object sender, DataGridViewCellEventArgs e)
         {
             if (e.RowIndex >= 0)
             {
                 if (e.ColumnIndex == 1)
                 {
                     dgvAttachments.Rows.RemoveAt(e.RowIndex);
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
            fileDialog.ShowDialog();
        }

        private void lblClientPhoto_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;

        }

        private void lblClientPhoto_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
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
