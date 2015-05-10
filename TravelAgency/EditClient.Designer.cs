namespace TravelAgency
{
    partial class EditClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbCompany = new System.Windows.Forms.GroupBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblClientPhoto = new System.Windows.Forms.Label();
            this.clientPhotoPicBox = new System.Windows.Forms.PictureBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtVerfiyEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOfficePhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCellPhone2 = new System.Windows.Forms.TextBox();
            this.txtCellPhone1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAccountAlpha = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdAttach = new System.Windows.Forms.Button();
            this.dgvAttachments = new System.Windows.Forms.DataGridView();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemove = new System.Windows.Forms.DataGridViewImageColumn();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.cmdSave = new System.Windows.Forms.Button();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdCreateTicket = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdCreateReservation = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.gbCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPhotoPicBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCompany
            // 
            this.gbCompany.Controls.Add(this.txtFirstName);
            this.gbCompany.Controls.Add(this.lblClientPhoto);
            this.gbCompany.Controls.Add(this.clientPhotoPicBox);
            this.gbCompany.Controls.Add(this.txtAddress);
            this.gbCompany.Controls.Add(this.lblAddress);
            this.gbCompany.Controls.Add(this.txtVerfiyEmail);
            this.gbCompany.Controls.Add(this.label9);
            this.gbCompany.Controls.Add(this.txtEmail);
            this.gbCompany.Controls.Add(this.label10);
            this.gbCompany.Controls.Add(this.txtOfficePhone);
            this.gbCompany.Controls.Add(this.label8);
            this.gbCompany.Controls.Add(this.txtHomePhone);
            this.gbCompany.Controls.Add(this.label7);
            this.gbCompany.Controls.Add(this.txtFax);
            this.gbCompany.Controls.Add(this.label6);
            this.gbCompany.Controls.Add(this.txtCellPhone2);
            this.gbCompany.Controls.Add(this.txtCellPhone1);
            this.gbCompany.Controls.Add(this.label5);
            this.gbCompany.Controls.Add(this.dtpDOB);
            this.gbCompany.Controls.Add(this.txtTitle);
            this.gbCompany.Controls.Add(this.label4);
            this.gbCompany.Controls.Add(this.txtMiddleName);
            this.gbCompany.Controls.Add(this.label3);
            this.gbCompany.Controls.Add(this.txtLastName);
            this.gbCompany.Controls.Add(this.label2);
            this.gbCompany.Controls.Add(this.lblAccountAlpha);
            this.gbCompany.Controls.Add(this.lblAccountNumber);
            this.gbCompany.Location = new System.Drawing.Point(3, 13);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Size = new System.Drawing.Size(983, 220);
            this.gbCompany.TabIndex = 0;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "Client Information";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(336, 36);
            this.txtFirstName.MaxLength = 100;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(145, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblClientPhoto
            // 
            this.lblClientPhoto.BackColor = System.Drawing.Color.Gray;
            this.lblClientPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientPhoto.Image = global::TravelAgency.Properties.Resources.cam32;
            this.lblClientPhoto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblClientPhoto.Location = new System.Drawing.Point(810, 183);
            this.lblClientPhoto.Name = "lblClientPhoto";
            this.lblClientPhoto.Size = new System.Drawing.Size(160, 33);
            this.lblClientPhoto.TabIndex = 55;
            this.lblClientPhoto.Text = "Change Client Photo";
            this.lblClientPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClientPhoto.Click += new System.EventHandler(this.lblClientPhoto_Click);
            // 
            // clientPhotoPicBox
            // 
            this.clientPhotoPicBox.Image = global::TravelAgency.Properties.Resources.download__1_;
            this.clientPhotoPicBox.Location = new System.Drawing.Point(810, 62);
            this.clientPhotoPicBox.Name = "clientPhotoPicBox";
            this.clientPhotoPicBox.Size = new System.Drawing.Size(160, 153);
            this.clientPhotoPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clientPhotoPicBox.TabIndex = 54;
            this.clientPhotoPicBox.TabStop = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(336, 66);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(258, 20);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(249, 66);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 14);
            this.lblAddress.TabIndex = 52;
            this.lblAddress.Text = "Address:";
            // 
            // txtVerfiyEmail
            // 
            this.txtVerfiyEmail.Location = new System.Drawing.Point(337, 167);
            this.txtVerfiyEmail.MaxLength = 100;
            this.txtVerfiyEmail.Name = "txtVerfiyEmail";
            this.txtVerfiyEmail.ReadOnly = true;
            this.txtVerfiyEmail.Size = new System.Drawing.Size(145, 20);
            this.txtVerfiyEmail.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 14);
            this.label9.TabIndex = 49;
            this.label9.Text = "Verify Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 167);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 14);
            this.label10.TabIndex = 47;
            this.label10.Text = "*Email:";
            // 
            // txtOfficePhone
            // 
            this.txtOfficePhone.Location = new System.Drawing.Point(337, 134);
            this.txtOfficePhone.MaxLength = 100;
            this.txtOfficePhone.Name = "txtOfficePhone";
            this.txtOfficePhone.ReadOnly = true;
            this.txtOfficePhone.Size = new System.Drawing.Size(145, 20);
            this.txtOfficePhone.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(249, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 14);
            this.label8.TabIndex = 45;
            this.label8.Text = "Office Phone:";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.Location = new System.Drawing.Point(97, 134);
            this.txtHomePhone.MaxLength = 100;
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.ReadOnly = true;
            this.txtHomePhone.Size = new System.Drawing.Size(145, 20);
            this.txtHomePhone.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 14);
            this.label7.TabIndex = 43;
            this.label7.Text = "Home Phone:";
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(449, 96);
            this.txtFax.MaxLength = 100;
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(145, 20);
            this.txtFax.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 14);
            this.label6.TabIndex = 41;
            this.label6.Text = "Fax:";
            // 
            // txtCellPhone2
            // 
            this.txtCellPhone2.Location = new System.Drawing.Point(249, 99);
            this.txtCellPhone2.MaxLength = 100;
            this.txtCellPhone2.Name = "txtCellPhone2";
            this.txtCellPhone2.ReadOnly = true;
            this.txtCellPhone2.Size = new System.Drawing.Size(145, 20);
            this.txtCellPhone2.TabIndex = 7;
            // 
            // txtCellPhone1
            // 
            this.txtCellPhone1.Location = new System.Drawing.Point(97, 99);
            this.txtCellPhone1.MaxLength = 100;
            this.txtCellPhone1.Name = "txtCellPhone1";
            this.txtCellPhone1.ReadOnly = true;
            this.txtCellPhone1.Size = new System.Drawing.Size(145, 20);
            this.txtCellPhone1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 14);
            this.label5.TabIndex = 38;
            this.label5.Text = "Cell Phones:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Enabled = false;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(97, 66);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(145, 20);
            this.dtpDOB.TabIndex = 4;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(97, 36);
            this.txtTitle.MaxLength = 100;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(145, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 14);
            this.label4.TabIndex = 33;
            this.label4.Text = "Title:";
            // 
            // txtMiddleName
            // 
            this.txtMiddleName.Location = new System.Drawing.Point(590, 33);
            this.txtMiddleName.MaxLength = 100;
            this.txtMiddleName.Name = "txtMiddleName";
            this.txtMiddleName.ReadOnly = true;
            this.txtMiddleName.Size = new System.Drawing.Size(145, 20);
            this.txtMiddleName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(498, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 14);
            this.label3.TabIndex = 31;
            this.label3.Text = "Middle Name:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(825, 33);
            this.txtLastName.MaxLength = 100;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(145, 20);
            this.txtLastName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(741, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "*Last Name:";
            // 
            // lblAccountAlpha
            // 
            this.lblAccountAlpha.AutoSize = true;
            this.lblAccountAlpha.Location = new System.Drawing.Point(10, 72);
            this.lblAccountAlpha.Name = "lblAccountAlpha";
            this.lblAccountAlpha.Size = new System.Drawing.Size(86, 14);
            this.lblAccountAlpha.TabIndex = 21;
            this.lblAccountAlpha.Text = "Date Of Birth:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(249, 39);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(81, 14);
            this.lblAccountNumber.TabIndex = 16;
            this.lblAccountNumber.Text = "*First Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdAttach);
            this.groupBox1.Controls.Add(this.dgvAttachments);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(13, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attachments";
            // 
            // cmdAttach
            // 
            this.cmdAttach.BackColor = System.Drawing.Color.Transparent;
            this.cmdAttach.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAttach.Image = global::TravelAgency.Properties.Resources.attach32;
            this.cmdAttach.Location = new System.Drawing.Point(592, 66);
            this.cmdAttach.Name = "cmdAttach";
            this.cmdAttach.Size = new System.Drawing.Size(107, 40);
            this.cmdAttach.TabIndex = 11;
            this.cmdAttach.Text = "Attach";
            this.cmdAttach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAttach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAttach.UseVisualStyleBackColor = false;
            this.cmdAttach.Click += new System.EventHandler(this.cmdAttach_Click);
            // 
            // dgvAttachments
            // 
            this.dgvAttachments.AllowUserToAddRows = false;
            this.dgvAttachments.AllowUserToDeleteRows = false;
            this.dgvAttachments.AllowUserToResizeColumns = false;
            this.dgvAttachments.AllowUserToResizeRows = false;
            this.dgvAttachments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAttachments.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAttachments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAttachments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAttachments.ColumnHeadersHeight = 4;
            this.dgvAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttachments.ColumnHeadersVisible = false;
            this.dgvAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFileName,
            this.colRemove});
            this.dgvAttachments.Location = new System.Drawing.Point(6, 20);
            this.dgvAttachments.MinimumSize = new System.Drawing.Size(583, 0);
            this.dgvAttachments.Name = "dgvAttachments";
            this.dgvAttachments.ReadOnly = true;
            this.dgvAttachments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAttachments.RowHeadersVisible = false;
            this.dgvAttachments.RowHeadersWidth = 5;
            this.dgvAttachments.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAttachments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAttachments.Size = new System.Drawing.Size(583, 99);
            this.dgvAttachments.TabIndex = 12;
            this.dgvAttachments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttachments_CellContentClick);
            this.dgvAttachments.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttachments_CellMouseEnter);
            this.dgvAttachments.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttachments_CellMouseLeave);
            // 
            // colFileName
            // 
            this.colFileName.HeaderText = "";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Width = 350;
            // 
            // colRemove
            // 
            this.colRemove.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRemove.HeaderText = "";
            this.colRemove.Name = "colRemove";
            this.colRemove.ReadOnly = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdSave.Image = global::TravelAgency.Properties.Resources.save321;
            this.cmdSave.Location = new System.Drawing.Point(688, 372);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(93, 40);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "&Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "ImageFiles|*.jpg";
            this.fileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmdCreateTicket
            // 
            this.cmdCreateTicket.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdCreateTicket.Image = global::TravelAgency.Properties.Resources.ticket32;
            this.cmdCreateTicket.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCreateTicket.Location = new System.Drawing.Point(509, 372);
            this.cmdCreateTicket.Name = "cmdCreateTicket";
            this.cmdCreateTicket.Size = new System.Drawing.Size(173, 40);
            this.cmdCreateTicket.TabIndex = 4;
            this.cmdCreateTicket.Text = "&Create Ticket";
            this.cmdCreateTicket.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCreateTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCreateTicket.UseVisualStyleBackColor = true;
            this.cmdCreateTicket.Click += new System.EventHandler(this.cmdCreateTicket_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdEdit.Image = global::TravelAgency.Properties.Resources.edit32;
            this.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEdit.Location = new System.Drawing.Point(688, 372);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(92, 40);
            this.cmdEdit.TabIndex = 5;
            this.cmdEdit.Text = "&Edit";
            this.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdCreateReservation
            // 
            this.cmdCreateReservation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdCreateReservation.Image = global::TravelAgency.Properties.Resources.reservation32;
            this.cmdCreateReservation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdCreateReservation.Location = new System.Drawing.Point(298, 372);
            this.cmdCreateReservation.Name = "cmdCreateReservation";
            this.cmdCreateReservation.Size = new System.Drawing.Size(205, 40);
            this.cmdCreateReservation.TabIndex = 6;
            this.cmdCreateReservation.Text = "&Create Reservation";
            this.cmdCreateReservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCreateReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCreateReservation.UseVisualStyleBackColor = true;
            this.cmdCreateReservation.Click += new System.EventHandler(this.cmdCreateReservation_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.BackColor = System.Drawing.Color.Transparent;
            this.cmdCancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancel.Image = global::TravelAgency.Properties.Resources.cancel32;
            this.cmdCancel.Location = new System.Drawing.Point(786, 372);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(132, 40);
            this.cmdCancel.TabIndex = 10;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancel.UseVisualStyleBackColor = false;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // EditClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(998, 424);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdCreateReservation);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdCreateTicket);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.gbCompany);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditClient";
            this.Text = "Edit Client";
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientPhotoPicBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbCompany;
        internal System.Windows.Forms.Label lblAccountAlpha;
        internal System.Windows.Forms.TextBox txtFirstName;
        internal System.Windows.Forms.Label lblAccountNumber;
        internal System.Windows.Forms.TextBox txtMiddleName;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtLastName;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtTitle;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        internal System.Windows.Forms.TextBox txtVerfiyEmail;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.TextBox txtOfficePhone;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtHomePhone;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtFax;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtCellPhone2;
        internal System.Windows.Forms.TextBox txtCellPhone1;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView dgvAttachments;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        internal System.Windows.Forms.Button cmdCreateTicket;
        internal System.Windows.Forms.Button cmdEdit;
        internal System.Windows.Forms.Button cmdCreateReservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewImageColumn colRemove;
        private System.Windows.Forms.Label lblClientPhoto;
        private System.Windows.Forms.PictureBox clientPhotoPicBox;
        private System.Windows.Forms.Button cmdAttach;
        private System.Windows.Forms.Button cmdCancel;

    }
}