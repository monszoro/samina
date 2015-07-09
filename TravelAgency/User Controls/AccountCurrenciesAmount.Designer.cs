namespace TravelAgency.UserControls
{
    partial class AccountCurrenciesAmount
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.exchangeRatePaanel = new System.Windows.Forms.Panel();
            this.nudExchangeRate = new System.Windows.Forms.NumericUpDown();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboBankAccounts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboCurrencies = new System.Windows.Forms.ComboBox();
            this.pnlCashier = new System.Windows.Forms.Panel();
            this.cboCashiers = new System.Windows.Forms.ComboBox();
            this.pnlBankAccount = new System.Windows.Forms.Panel();
            this.cboPaymentTypes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAmount = new System.Windows.Forms.NumericUpDown();
            this.exchangeRatePaanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExchangeRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.pnlCashier.SuspendLayout();
            this.pnlBankAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 99;
            this.label5.Text = "Exchange Rate :";
            // 
            // exchangeRatePaanel
            // 
            this.exchangeRatePaanel.Controls.Add(this.nudExchangeRate);
            this.exchangeRatePaanel.Controls.Add(this.label5);
            this.exchangeRatePaanel.Location = new System.Drawing.Point(3, 130);
            this.exchangeRatePaanel.Name = "exchangeRatePaanel";
            this.exchangeRatePaanel.Size = new System.Drawing.Size(356, 30);
            this.exchangeRatePaanel.TabIndex = 110;
            // 
            // nudExchangeRate
            // 
            this.nudExchangeRate.DecimalPlaces = 3;
            this.nudExchangeRate.Location = new System.Drawing.Point(107, 5);
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
            this.nudExchangeRate.TabIndex = 100;
            this.nudExchangeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudExchangeRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 105;
            this.label3.Text = "Payment Type:";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Currency :";
            // 
            // cboCurrencies
            // 
            this.cboCurrencies.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboCurrencies.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboCurrencies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCurrencies.FormattingEnabled = true;
            this.cboCurrencies.Location = new System.Drawing.Point(110, 108);
            this.cboCurrencies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCurrencies.Name = "cboCurrencies";
            this.cboCurrencies.Size = new System.Drawing.Size(132, 21);
            this.cboCurrencies.TabIndex = 106;
            this.cboCurrencies.SelectedIndexChanged += new System.EventHandler(this.cboCurrencies_SelectedIndexChanged);
            // 
            // pnlCashier
            // 
            this.pnlCashier.Controls.Add(this.cboCashiers);
            this.pnlCashier.Controls.Add(this.lblAccountNumber);
            this.pnlCashier.Location = new System.Drawing.Point(21, 44);
            this.pnlCashier.Name = "pnlCashier";
            this.pnlCashier.Size = new System.Drawing.Size(342, 29);
            this.pnlCashier.TabIndex = 103;
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
            // pnlBankAccount
            // 
            this.pnlBankAccount.Controls.Add(this.cboBankAccounts);
            this.pnlBankAccount.Controls.Add(this.label2);
            this.pnlBankAccount.Location = new System.Drawing.Point(21, 44);
            this.pnlBankAccount.Name = "pnlBankAccount";
            this.pnlBankAccount.Size = new System.Drawing.Size(342, 28);
            this.pnlBankAccount.TabIndex = 102;
            // 
            // cboPaymentTypes
            // 
            this.cboPaymentTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboPaymentTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboPaymentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPaymentTypes.FormattingEnabled = true;
            this.cboPaymentTypes.Location = new System.Drawing.Point(110, 12);
            this.cboPaymentTypes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboPaymentTypes.Name = "cboPaymentTypes";
            this.cboPaymentTypes.Size = new System.Drawing.Size(132, 21);
            this.cboPaymentTypes.TabIndex = 104;
            this.cboPaymentTypes.SelectedIndexChanged += new System.EventHandler(this.cboPaymentTypes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 108;
            this.label6.Text = "Amount :";
            // 
            // nudAmount
            // 
            this.nudAmount.DecimalPlaces = 2;
            this.nudAmount.Location = new System.Drawing.Point(110, 79);
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
            this.nudAmount.TabIndex = 109;
            this.nudAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAmount.ThousandsSeparator = true;
            // 
            // AccountCurrenciesAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exchangeRatePaanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCurrencies);
            this.Controls.Add(this.pnlCashier);
            this.Controls.Add(this.pnlBankAccount);
            this.Controls.Add(this.cboPaymentTypes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nudAmount);
            this.Name = "AccountCurrenciesAmount";
            this.Size = new System.Drawing.Size(409, 170);
            this.exchangeRatePaanel.ResumeLayout(false);
            this.exchangeRatePaanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudExchangeRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.pnlCashier.ResumeLayout(false);
            this.pnlCashier.PerformLayout();
            this.pnlBankAccount.ResumeLayout(false);
            this.pnlBankAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel exchangeRatePaanel;
        private System.Windows.Forms.NumericUpDown nudExchangeRate;
        private System.Windows.Forms.ErrorProvider errProvider;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.ComboBox cboCurrencies;
        private System.Windows.Forms.Panel pnlCashier;
        internal System.Windows.Forms.ComboBox cboCashiers;
        internal System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Panel pnlBankAccount;
        internal System.Windows.Forms.ComboBox cboBankAccounts;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cboPaymentTypes;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAmount;



    }
}
