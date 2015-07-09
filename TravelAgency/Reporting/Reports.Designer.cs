namespace TravelAgency
{
    partial class Reports
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Label1 = new System.Windows.Forms.Label();
            this.cmdLedgerTransactions = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.Label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmdLedgerTransactions, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.78049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.21951F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 407);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Location = new System.Drawing.Point(3, 126);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(210, 15);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Ledger Transactions";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmdLedgerTransactions
            // 
            this.cmdLedgerTransactions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdLedgerTransactions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLedgerTransactions.FlatAppearance.BorderSize = 0;
            this.cmdLedgerTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdLedgerTransactions.Image = global::TravelAgency.Properties.Resources._1418405900_electronic_billing_machine;
            this.cmdLedgerTransactions.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdLedgerTransactions.Location = new System.Drawing.Point(21, 0);
            this.cmdLedgerTransactions.Margin = new System.Windows.Forms.Padding(0);
            this.cmdLedgerTransactions.Name = "cmdLedgerTransactions";
            this.cmdLedgerTransactions.Size = new System.Drawing.Size(173, 126);
            this.cmdLedgerTransactions.TabIndex = 8;
            this.cmdLedgerTransactions.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cmdLedgerTransactions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.cmdLedgerTransactions.Click += new System.EventHandler(this.cmdLedgerTransactions_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 407);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Reports";
            this.Text = "Reports";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button cmdLedgerTransactions;
    }
}