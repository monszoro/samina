namespace TravelAgency
{
    partial class EditCurrency
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
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.gbCompany = new System.Windows.Forms.GroupBox();
            this.tbxSign = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdCancel.Image = global::TravelAgency.Properties.Resources.cancel32;
            this.cmdCancel.Location = new System.Drawing.Point(148, 130);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(113, 40);
            this.cmdCancel.TabIndex = 6;
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
            this.cmdSave.Location = new System.Drawing.Point(24, 130);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(118, 40);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "&Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // gbCompany
            // 
            this.gbCompany.Controls.Add(this.tbxSign);
            this.gbCompany.Controls.Add(this.label1);
            this.gbCompany.Controls.Add(this.txtName);
            this.gbCompany.Controls.Add(this.label4);
            this.gbCompany.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.gbCompany.Location = new System.Drawing.Point(12, 12);
            this.gbCompany.Name = "gbCompany";
            this.gbCompany.Size = new System.Drawing.Size(249, 112);
            this.gbCompany.TabIndex = 4;
            this.gbCompany.TabStop = false;
            this.gbCompany.Text = "Currency Information";
            // 
            // tbxSign
            // 
            this.tbxSign.Location = new System.Drawing.Point(63, 73);
            this.tbxSign.MaxLength = 100;
            this.tbxSign.Name = "tbxSign";
            this.tbxSign.Size = new System.Drawing.Size(156, 22);
            this.tbxSign.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Sign:";
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
            // EditCurrency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(283, 193);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.gbCompany);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EditCurrency";
            this.Text = "Edit Currency";
            this.gbCompany.ResumeLayout(false);
            this.gbCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdSave;
        internal System.Windows.Forms.GroupBox gbCompany;
        internal System.Windows.Forms.TextBox tbxSign;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;


    }
}