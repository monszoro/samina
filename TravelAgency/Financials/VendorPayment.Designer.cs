namespace TravelAgency
{
    partial class VendorPayment
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
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.cboCashiers = new System.Windows.Forms.ComboBox();
            this.cboVendor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboBankAccounts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBankAccount = new System.Windows.Forms.Panel();
            this.pnlCashier = new System.Windows.Forms.Panel();
            this.cboPaymentTypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCurrencies = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.nudExchangeRate = new System.Windows.Forms.NumericUpDown();
            this.pnlBankAccount.SuspendLayout();
            this.pnlCashier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExchangeRate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(36, 6);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(45, 13);
            this.lblAccountNumber.TabIndex = 35;
            this.lblAccountNumber.Text = "Cashier:";
            // 
            // cboCashiers
            // 
            this.cboCashiers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCashiers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCashiers.FormattingEnabled = true;
            this.cboCashiers.Location = new System.Drawing.Point(89, 3);
            this.cboCashiers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCashiers.Name = "cboCashiers";
            this.cboCashiers.Size = new System.Drawing.Size(204, 21);
            this.cboCashiers.TabIndex = 69;
            // 
            // cboVendor
            // 
            this.cboVendor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVendor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVendor.FormattingEnabled = true;
            this.cboVendor.Location = new System.Drawing.Point(97, 98);
            this.cboVendor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboVendor.Name = "cboVendor";
            this.cboVendor.Size = new System.Drawing.Size(204, 21);
            this.cboVendor.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 70;
            this.label1.Text = "Vendor:";
            // 
            // cboBankAccounts
            // 
            this.cboBankAccounts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboBankAccounts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboBankAccounts.FormattingEnabled = true;
            this.cboBankAccounts.Location = new System.Drawing.Point(89, 3);
            this.cboBankAccounts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboBankAccounts.Name = "cboBankAccounts";
            this.cboBankAccounts.Size = new System.Drawing.Size(204, 21);
            this.cboBankAccounts.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Bank Account:";
            // 
            // pnlBankAccount
            // 
            this.pnlBankAccount.Controls.Add(this.cboBankAccounts);
            this.pnlBankAccount.Controls.Add(this.label2);
            this.pnlBankAccount.Location = new System.Drawing.Point(8, 61);
            this.pnlBankAccount.Name = "pnlBankAccount";
            this.pnlBankAccount.Size = new System.Drawing.Size(342, 28);
            this.pnlBankAccount.TabIndex = 74;
            // 
            // pnlCashier
            // 
            this.pnlCashier.Controls.Add(this.cboCashiers);
            this.pnlCashier.Controls.Add(this.lblAccountNumber);
            this.pnlCashier.Location = new System.Drawing.Point(8, 61);
            this.pnlCashier.Name = "pnlCashier";
            this.pnlCashier.Size = new System.Drawing.Size(342, 29);
            this.pnlCashier.TabIndex = 75;
            // 
            // cboPaymentTypes
            // 
            this.cboPaymentTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPaymentTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPaymentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentTypes.FormattingEnabled = true;
            this.cboPaymentTypes.Location = new System.Drawing.Point(97, 29);
            this.cboPaymentTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboPaymentTypes.Name = "cboPaymentTypes";
            this.cboPaymentTypes.Size = new System.Drawing.Size(132, 21);
            this.cboPaymentTypes.TabIndex = 76;
            this.cboPaymentTypes.SelectedIndexChanged += new System.EventHandler(this.cboPaymentTypes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Payment Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Currency :";
            // 
            // cboCurrencies
            // 
            this.cboCurrencies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCurrencies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCurrencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrencies.FormattingEnabled = true;
            this.cboCurrencies.Location = new System.Drawing.Point(97, 155);
            this.cboCurrencies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCurrencies.Name = "cboCurrencies";
            this.cboCurrencies.Size = new System.Drawing.Size(132, 21);
            this.cboCurrencies.TabIndex = 78;
            this.cboCurrencies.SelectedIndexChanged += new System.EventHandler(this.cboCurrencies_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 81;
            this.label5.Text = "Exchange Rate :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 83;
            this.label6.Text = "Amount :";
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
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.Location = new System.Drawing.Point(97, 126);
            this.nudAmount.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudAmount.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(79, 20);
            this.nudAmount.TabIndex = 86;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAmount.ThousandsSeparator = true;
            // 
            // nudExchangeRate
            // 
            this.nudExchangeRate.DecimalPlaces = 3;
            this.nudExchangeRate.Location = new System.Drawing.Point(97, 192);
            this.nudExchangeRate.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudExchangeRate.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.nudExchangeRate.Name = "nudExchangeRate";
            this.nudExchangeRate.Size = new System.Drawing.Size(79, 20);
            this.nudExchangeRate.TabIndex = 87;
            this.nudExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudExchangeRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // VendorPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 266);
            this.Controls.Add(this.nudExchangeRate);
            this.Controls.Add(this.nudAmount);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCurrencies);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboPaymentTypes);
            this.Controls.Add(this.pnlCashier);
            this.Controls.Add(this.pnlBankAccount);
            this.Controls.Add(this.cboVendor);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(382, 305);
            this.Name = "VendorPayment";
            this.Text = "Pay to vendor";
            this.pnlBankAccount.ResumeLayout(false);
            this.pnlBankAccount.PerformLayout();
            this.pnlCashier.ResumeLayout(false);
            this.pnlCashier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudExchangeRate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblAccountNumber;
        internal System.Windows.Forms.ComboBox cboCashiers;
        internal System.Windows.Forms.ComboBox cboVendor;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox cboBankAccounts;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlBankAccount;
        private System.Windows.Forms.Panel pnlCashier;
        internal System.Windows.Forms.ComboBox cboPaymentTypes;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cboCurrencies;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.NumericUpDown nudAmount;
        private System.Windows.Forms.NumericUpDown nudExchangeRate;
    }
}