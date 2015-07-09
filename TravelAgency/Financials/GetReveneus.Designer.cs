namespace TravelAgency.Financials
{
    partial class GetReveneus
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
            this.uc_accountCurrenciesAmount = new TravelAgency.UserControls.AccountCurrenciesAmount();
            this.SuspendLayout();
            // 
            // uc_accountCurrenciesAmount
            // 
            this.uc_accountCurrenciesAmount.Location = new System.Drawing.Point(24, 12);
            this.uc_accountCurrenciesAmount.Name = "uc_accountCurrenciesAmount";
            this.uc_accountCurrenciesAmount.Size = new System.Drawing.Size(409, 194);
            this.uc_accountCurrenciesAmount.TabIndex = 0;
            // 
            // GetReveneus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 250);
            this.Controls.Add(this.uc_accountCurrenciesAmount);
            this.Name = "GetReveneus";
            this.Text = "GetReveneus";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.AccountCurrenciesAmount uc_accountCurrenciesAmount;

    }
}