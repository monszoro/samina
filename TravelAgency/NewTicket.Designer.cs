namespace TravelAgency
{
    partial class Newticket
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
            this.cboclients = new System.Windows.Forms.ComboBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAssignee = new System.Windows.Forms.ComboBox();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCompany
            // 
            this.gbCompany.Controls.Add(this.cboclients);
            this.gbCompany.Controls.Add(this.richTextBox2);
            this.gbCompany.Controls.Add(this.cmdCancel);
            this.gbCompany.Controls.Add(this.cmdSave);
            this.gbCompany.Controls.Add(this.label1);
            this.gbCompany.Controls.Add(this.cboAssignee);
            this.gbCompany.Controls.Add(this.lblWarehouse);
            this.gbCompany.Controls.Add(this.lblAccountNumber);
            this.gbCompany.Location = new System.Drawing.Point(4, 15);
            this.gbCompany.Margin = new System.Windows.Forms.Padding(4);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Padding = new System.Windows.Forms.Padding(4);
            this.gbCompany.Size = new System.Drawing.Size(795, 419);
            this.gbCompany.TabIndex = 5;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "Ticket Information";
            // 
            // cboclients
            // 
            this.cboclients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboclients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboclients.FormattingEnabled = true;
            this.cboclients.Location = new System.Drawing.Point(147, 27);
            this.cboclients.Margin = new System.Windows.Forms.Padding(4);
            this.cboclients.Name = "cboclients";
            this.cboclients.Size = new System.Drawing.Size(229, 24);
            this.cboclients.TabIndex = 30;
            this.cboclients.SelectedIndexChanged += new System.EventHandler(this.cboclients_SelectedIndexChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.Color.Red;
            this.richTextBox2.Location = new System.Drawing.Point(147, 122);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(639, 221);
            this.richTextBox2.TabIndex = 29;
            this.richTextBox2.Text = "";
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdCancel.Image = global::TravelAgency.Properties.Resources.cancel32;
            this.cmdCancel.Location = new System.Drawing.Point(649, 360);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(137, 41);
            this.cmdCancel.TabIndex = 9;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdSave.Image = global::TravelAgency.Properties.Resources.save321;
            this.cmdSave.Location = new System.Drawing.Point(512, 360);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(132, 41);
            this.cmdSave.TabIndex = 8;
            this.cmdSave.Text = "&Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Notes:";
            // 
            // cboAssignee
            // 
            this.cboAssignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssignee.FormattingEnabled = true;
            this.cboAssignee.Location = new System.Drawing.Point(147, 65);
            this.cboAssignee.Margin = new System.Windows.Forms.Padding(4);
            this.cboAssignee.Name = "cboAssignee";
            this.cboAssignee.Size = new System.Drawing.Size(229, 24);
            this.cboAssignee.TabIndex = 3;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(15, 69);
            this.lblWarehouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(67, 16);
            this.lblWarehouse.TabIndex = 24;
            this.lblWarehouse.Text = "Assignee:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(15, 27);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(48, 16);
            this.lblAccountNumber.TabIndex = 16;
            this.lblAccountNumber.Text = "Client:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Newticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(815, 458);
            this.Controls.Add(this.gbCompany);
            this.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Newticket";
            this.Text = "New Ticket";
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdSave;
        internal System.Windows.Forms.GroupBox gbCompany;
        internal System.Windows.Forms.ComboBox cboAssignee;
        internal System.Windows.Forms.Label lblWarehouse;
        internal System.Windows.Forms.Label lblAccountNumber;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        internal System.Windows.Forms.ComboBox cboclients;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}