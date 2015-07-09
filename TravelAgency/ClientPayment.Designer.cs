namespace TravelAgency
{
    partial class ClientPayment
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
            this.cboClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.uc_accountCurrenciesAmount = new TravelAgency.UserControls.AccountCurrenciesAmount();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // cboClients
            // 
            this.cboClients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboClients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboClients.FormattingEnabled = true;
            this.cboClients.Location = new System.Drawing.Point(97, 23);
            this.cboClients.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboClients.Name = "cboClients";
            this.cboClients.Size = new System.Drawing.Size(204, 21);
            this.cboClients.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Client:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 84;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(275, 226);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 85;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // uc_accountCurrenciesAmount
            // 
            this.uc_accountCurrenciesAmount.Location = new System.Drawing.Point(-13, 50);
            this.uc_accountCurrenciesAmount.Name = "uc_accountCurrenciesAmount";
            this.uc_accountCurrenciesAmount.Size = new System.Drawing.Size(409, 170);
            this.uc_accountCurrenciesAmount.TabIndex = 86;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // ClientPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 266);
            this.Controls.Add(this.uc_accountCurrenciesAmount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboClients);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(382, 305);
            this.Name = "ClientPayment";
            this.Text = "Client Payment";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox cboClients;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private UserControls.AccountCurrenciesAmount uc_accountCurrenciesAmount;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}