namespace TravelAgency
{
    partial class EditUserGroup
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
            this.txtGroupDescription = new System.Windows.Forms.RichTextBox();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.lblClient = new System.Windows.Forms.Label();
            this.lblWarehouse = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.gbCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCompany
            // 
            this.gbCompany.Controls.Add(this.txtGroupDescription);
            this.gbCompany.Controls.Add(this.txtGroupName);
            this.gbCompany.Controls.Add(this.lblClient);
            this.gbCompany.Controls.Add(this.lblWarehouse);
            this.gbCompany.Controls.Add(this.lblAccountNumber);
            this.gbCompany.Location = new System.Drawing.Point(4, 15);
            this.gbCompany.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbCompany.Size = new System.Drawing.Size(407, 238);
            this.gbCompany.TabIndex = 5;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "User Group Information";
            // 
            // txtGroupDescription
            // 
            this.txtGroupDescription.Location = new System.Drawing.Point(107, 61);
            this.txtGroupDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGroupDescription.Name = "txtGroupDescription";
            this.txtGroupDescription.Size = new System.Drawing.Size(296, 159);
            this.txtGroupDescription.TabIndex = 30;
            this.txtGroupDescription.Text = "";
            // 
            // txtGroupName
            // 
            this.txtGroupName.Location = new System.Drawing.Point(105, 27);
            this.txtGroupName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(297, 22);
            this.txtGroupName.TabIndex = 29;
            // 
            // lblClient
            // 
            this.lblClient.AutoSize = true;
            this.lblClient.Location = new System.Drawing.Point(147, 26);
            this.lblClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClient.Name = "lblClient";
            this.lblClient.Size = new System.Drawing.Size(0, 16);
            this.lblClient.TabIndex = 28;
            // 
            // lblWarehouse
            // 
            this.lblWarehouse.AutoSize = true;
            this.lblWarehouse.Location = new System.Drawing.Point(15, 61);
            this.lblWarehouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWarehouse.Name = "lblWarehouse";
            this.lblWarehouse.Size = new System.Drawing.Size(84, 16);
            this.lblWarehouse.TabIndex = 24;
            this.lblWarehouse.Text = "Description:";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(15, 27);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(55, 16);
            this.lblAccountNumber.TabIndex = 16;
            this.lblAccountNumber.Text = "Name*:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TravelAgency.Properties.Resources.cancel32;
            this.button1.Location = new System.Drawing.Point(272, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 39);
            this.button1.TabIndex = 32;
            this.button1.Text = "Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.BackColor = System.Drawing.Color.Transparent;
            this.cmdSave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Image = global::TravelAgency.Properties.Resources.save321;
            this.cmdSave.Location = new System.Drawing.Point(140, 269);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(123, 39);
            this.cmdSave.TabIndex = 31;
            this.cmdSave.Text = "Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSave.UseVisualStyleBackColor = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // EditUserGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gbCompany);
            this.Controls.Add(this.cmdSave);
            this.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "EditUserGroup";
            this.Text = "New User Group";
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gbCompany;
        internal System.Windows.Forms.Label lblWarehouse;
        internal System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblClient;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.RichTextBox txtGroupDescription;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmdSave;

    }
}