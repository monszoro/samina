﻿namespace TravelAgency
{
    partial class NewBankAccount
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.gbCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCompany
            // 
            this.gbCompany.Controls.Add(this.txtNumber);
            this.gbCompany.Controls.Add(this.lblAddress);
            this.gbCompany.Controls.Add(this.txtName);
            this.gbCompany.Controls.Add(this.label4);
            this.gbCompany.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.gbCompany.Location = new System.Drawing.Point(3, 12);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Size = new System.Drawing.Size(474, 66);
            this.gbCompany.TabIndex = 0;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "Bank Account Information";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(291, 33);
            this.txtNumber.MaxLength = 100;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(175, 22);
            this.txtNumber.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(225, 36);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(63, 16);
            this.lblAddress.TabIndex = 52;
            this.lblAddress.Text = "Number:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(63, 33);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 22);
            this.txtName.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Name:";
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
            this.cmdCancel.Location = new System.Drawing.Point(364, 84);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(113, 40);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdSave.Image = global::TravelAgency.Properties.Resources.save321;
            this.cmdSave.Location = new System.Drawing.Point(240, 84);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(118, 40);
            this.cmdSave.TabIndex = 2;
            this.cmdSave.Text = "&Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // NewBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(491, 129);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.gbCompany);
            this.Name = "NewBankAccount";
            this.Text = "New Bank Account";
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbCompany;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdSave;
        internal System.Windows.Forms.TextBox txtNumber;
        internal System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}