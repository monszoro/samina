namespace TravelAgency
{
    partial class Editticket
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
            this.gbCompany = new System.Windows.Forms.GroupBox();
            this.tableNotes = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.cboAssignee = new System.Windows.Forms.ComboBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.gbCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCompany
            // 
            this.gbCompany.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbCompany.Controls.Add(this.tableNotes);
            this.gbCompany.Controls.Add(this.richTextBox1);
            this.gbCompany.Controls.Add(this.lblClient);
            this.gbCompany.Controls.Add(this.cboAssignee);
            this.gbCompany.Controls.Add(this.lblWarehouse);
            this.gbCompany.Controls.Add(this.lblAccountNumber);
            this.gbCompany.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.gbCompany.Location = new System.Drawing.Point(4, 4);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Size = new System.Drawing.Size(865, 435);
            this.gbCompany.TabIndex = 5;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "Ticket Information";
            // 
            // tableNotes
            // 
            this.tableNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableNotes.ColumnCount = 1;
            this.tableNotes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableNotes.Location = new System.Drawing.Point(110, 80);
            this.tableNotes.Name = "tableNotes";
            this.tableNotes.RowCount = 1;
            this.tableNotes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableNotes.Size = new System.Drawing.Size(740, 254);
            this.tableNotes.TabIndex = 31;
            this.tableNotes.Paint += new System.Windows.Forms.PaintEventHandler(this.tableNotes_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(110, 340);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(740, 89);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(110, 21);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(0, 16);
            this.lblClient.TabIndex = 28;
            // 
            // cboAssignee
            // 
            this.cboAssignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssignee.FormattingEnabled = true;
            this.cboAssignee.Location = new System.Drawing.Point(110, 48);
            this.cboAssignee.Name = "cboAssignee";
            this.cboAssignee.Size = new System.Drawing.Size(173, 24);
            this.cboAssignee.TabIndex = 3;
            this.cboAssignee.SelectedIndexChanged += new System.EventHandler(this.cboDefaultWarehouse_SelectedIndexChanged);
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(11, 56);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(67, 16);
            this.lblWarehouse.TabIndex = 24;
            this.lblWarehouse.Text = "Assignee:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(11, 22);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(48, 16);
            this.lblAccountNumber.TabIndex = 16;
            this.lblAccountNumber.Text = "Client:";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdCancel.Image = global::TravelAgency.Properties.Resources.cancel32;
            this.cmdCancel.Location = new System.Drawing.Point(766, 459);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(106, 41);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdSave.Image = global::TravelAgency.Properties.Resources.save321;
            this.cmdSave.Location = new System.Drawing.Point(661, 459);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(99, 41);
            this.cmdSave.TabIndex = 8;
            this.cmdSave.Text = "&Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // Editticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(884, 504);
            this.Controls.Add(this.gbCompany);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Name = "Editticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Ticket";
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbCompany;
        internal System.Windows.Forms.ComboBox cboAssignee;
        internal System.Windows.Forms.Label lblWarehouse;
        internal System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TableLayoutPanel tableNotes;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdSave;

    }
}