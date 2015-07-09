namespace TravelAgency.Financials
{
    partial class ExchangeCurrency
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
            this.accountCurrenciesAmount1 = new TravelAgency.UserControls.AccountCurrenciesAmount();
            this.SuspendLayout();
            // 
            // accountCurrenciesAmount1
            // 
            this.accountCurrenciesAmount1.Location = new System.Drawing.Point(-4, -4);
            this.accountCurrenciesAmount1.Name = "accountCurrenciesAmount1";
            this.accountCurrenciesAmount1.Size = new System.Drawing.Size(302, 141);
            this.accountCurrenciesAmount1.TabIndex = 0;
            // 
            // ExchangeCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.accountCurrenciesAmount1);
            this.Name = "ExchangeCurrency";
            this.Text = "ExchangeCurrency";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.AccountCurrenciesAmount accountCurrenciesAmount1;
    }
}