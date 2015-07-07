namespace TravelAgency.Administration
{
    partial class ManageCurrencies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCurrencies = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdNew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgvCurrencies);
            this.groupBox1.Location = new System.Drawing.Point(5, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 232);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currencies ";
            // 
            // dgvCurrencies
            // 
            this.dgvCurrencies.AllowUserToAddRows = false;
            this.dgvCurrencies.AllowUserToDeleteRows = false;
            this.dgvCurrencies.AllowUserToResizeColumns = false;
            this.dgvCurrencies.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.dgvCurrencies.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCurrencies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCurrencies.BackgroundColor = System.Drawing.Color.White;
            this.dgvCurrencies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCurrencies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCurrencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Sign});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCurrencies.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCurrencies.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvCurrencies.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgvCurrencies.Location = new System.Drawing.Point(8, 20);
            this.dgvCurrencies.MultiSelect = false;
            this.dgvCurrencies.Name = "dgvCurrencies";
            this.dgvCurrencies.RowHeadersVisible = false;
            this.dgvCurrencies.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvCurrencies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCurrencies.Size = new System.Drawing.Size(384, 212);
            this.dgvCurrencies.TabIndex = 0;
            this.dgvCurrencies.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCurrency_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.HeaderText = "Name";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Sign
            // 
            this.Sign.HeaderText = "Sign";
            this.Sign.Name = "Sign";
            // 
            // cmdNew
            // 
            this.cmdNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdNew.BackColor = System.Drawing.Color.Transparent;
            this.cmdNew.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdNew.Image = global::TravelAgency.Properties.Resources.New32;
            this.cmdNew.Location = new System.Drawing.Point(231, 249);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(172, 46);
            this.cmdNew.TabIndex = 13;
            this.cmdNew.Text = "New Currency";
            this.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdNew.UseVisualStyleBackColor = false;
            this.cmdNew.Click += new System.EventHandler(this.cmdNew_Click_1);
            // 
            // ManageCurrencies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 306);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdNew);
            this.Name = "ManageCurrencies";
            this.Text = "Manage Currencies";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCurrencies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgvCurrencies;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sign;
    }
}