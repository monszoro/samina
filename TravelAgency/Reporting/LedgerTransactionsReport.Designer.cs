namespace TravelAgency
{
    partial class LedgerTransactionsReport
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
            this.cboSubLedgerAccount = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGeneralLedgerAccount = new System.Windows.Forms.ComboBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.gbCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCompany
            // 
            this.gbCompany.Controls.Add(this.cboSubLedgerAccount);
            this.gbCompany.Controls.Add(this.label1);
            this.gbCompany.Controls.Add(this.label2);
            this.gbCompany.Controls.Add(this.cboGeneralLedgerAccount);
            this.gbCompany.Controls.Add(this.lblClient);
            this.gbCompany.Controls.Add(this.lblAccountNumber);
            this.gbCompany.Location = new System.Drawing.Point(3, 15);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Size = new System.Drawing.Size(519, 100);
            this.gbCompany.TabIndex = 5;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "Filters";
            // 
            // cboSubLedgerAccount
            // 
            this.cboSubLedgerAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubLedgerAccount.FormattingEnabled = true;
            this.cboSubLedgerAccount.Location = new System.Drawing.Point(183, 61);
            this.cboSubLedgerAccount.Name = "cboSubLedgerAccount";
            this.cboSubLedgerAccount.Size = new System.Drawing.Size(298, 24);
            this.cboSubLedgerAccount.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Sub Ledger Account:";
            // 
            // cboGeneralLedgerAccount
            // 
            this.cboGeneralLedgerAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGeneralLedgerAccount.FormattingEnabled = true;
            this.cboGeneralLedgerAccount.Location = new System.Drawing.Point(183, 26);
            this.cboGeneralLedgerAccount.Name = "cboGeneralLedgerAccount";
            this.cboGeneralLedgerAccount.Size = new System.Drawing.Size(298, 24);
            this.cboGeneralLedgerAccount.TabIndex = 34;
            this.cboGeneralLedgerAccount.SelectedIndexChanged += new System.EventHandler(this.cboGeneralLedgerAccount_SelectedIndexChanged);
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(146, 26);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(0, 16);
            this.lblClient.TabIndex = 28;
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(15, 27);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(162, 16);
            this.lblAccountNumber.TabIndex = 16;
            this.lblAccountNumber.Text = "General Ledger Account:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdCancel.Image = global::TravelAgency.Properties.Resources.cancel32;
            this.cmdCancel.Location = new System.Drawing.Point(361, 157);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(131, 40);
            this.cmdCancel.TabIndex = 36;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Enabled = false;
            this.cmdSave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdSave.Image = global::TravelAgency.Properties.Resources.ok32;
            this.cmdSave.Location = new System.Drawing.Point(223, 157);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(131, 40);
            this.cmdSave.TabIndex = 35;
            this.cmdSave.Text = "&Ok";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // LedgerTransactionsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(534, 211);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.gbCompany);
            this.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LedgerTransactionsReport";
            this.Text = "Ledger Transactions Report";
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbCompany;
        internal System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cboGeneralLedgerAccount;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.ComboBox cboSubLedgerAccount;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label2;

    }
}