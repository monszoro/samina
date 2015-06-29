namespace TravelAgency
{
    partial class NewReservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewReservation));
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.attachmentsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gboxHotel = new System.Windows.Forms.GroupBox();
            this.QuadRoomsUpDown = new System.Windows.Forms.NumericUpDown();
            this.TripleRoomsUpDown = new System.Windows.Forms.NumericUpDown();
            this.DoubleRoomsUpDown = new System.Windows.Forms.NumericUpDown();
            this.singleRoomsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHotelLocation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHotelName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gboxVisa = new System.Windows.Forms.GroupBox();
            this.txtVisaType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVisaCountry = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gboxFlight = new System.Windows.Forms.GroupBox();
            this.txtDepartureLocation = new System.Windows.Forms.TextBox();
            this.lblDepartureLocation = new System.Windows.Forms.Label();
            this.txtArrivalLocation = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAirLine = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRefAirLine = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtRefSystem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTicketNo = new System.Windows.Forms.TextBox();
            this.lblTicketNo = new System.Windows.Forms.Label();
            this.gbPricing = new System.Windows.Forms.GroupBox();
            this.txtCommition = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtFareBasic = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtTaxes = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCommitionRatio = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNetPrice = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboVendors = new System.Windows.Forms.ComboBox();
            this.ClientNamesGridView = new System.Windows.Forms.DataGridView();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboclients = new System.Windows.Forms.ComboBox();
            this.CmdPrint = new System.Windows.Forms.Button();
            this.cmdReOpen = new System.Windows.Forms.Button();
            this.CmdChange = new System.Windows.Forms.Button();
            this.cmdReFund = new System.Windows.Forms.Button();
            this.cmdEdit = new System.Windows.Forms.Button();
            this.cmdConfirm = new System.Windows.Forms.Button();
            this.cmdCancelReservation = new System.Windows.Forms.Button();
            this.lblReservationStatus = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gboxHotel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuadRoomsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TripleRoomsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleRoomsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleRoomsUpDown)).BeginInit();
            this.gboxVisa.SuspendLayout();
            this.gboxFlight.SuspendLayout();
            this.gbPricing.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientNamesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // fileDialog
            // 
            this.fileDialog.Filter = "ImageFiles|*.jpg";
            // 
            // attachmentsFileDialog
            // 
            this.attachmentsFileDialog.FileName = "*";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.MinimumWidth = 20;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.ToolTipText = "remove";
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdCancel.Image = global::TravelAgency.Properties.Resources.cancel32;
            this.cmdCancel.Location = new System.Drawing.Point(841, 528);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(108, 41);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "&Cancel";
            this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Visible = false;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdSave.Image = global::TravelAgency.Properties.Resources.save321;
            this.cmdSave.Location = new System.Drawing.Point(730, 529);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(103, 41);
            this.cmdSave.TabIndex = 7;
            this.cmdSave.Text = "&Save";
            this.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Visible = false;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Location = new System.Drawing.Point(29, 31);
            this.lblAccountNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(48, 16);
            this.lblAccountNumber.TabIndex = 29;
            this.lblAccountNumber.Text = "Client:";
            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.Color.Red;
            this.txtNotes.Location = new System.Drawing.Point(125, 427);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(815, 53);
            this.txtNotes.TabIndex = 6;
            this.txtNotes.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 436);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Notes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Type:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(416, 26);
            this.cboType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(204, 24);
            this.cboType.TabIndex = 0;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "From:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpFromDate.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(83, 64);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(204, 22);
            this.dtpFromDate.TabIndex = 1;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtpToDate.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dtpToDate.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(83, 96);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(204, 22);
            this.dtpToDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "To:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Vendor:";
            // 
            // gboxHotel
            // 
            this.gboxHotel.Controls.Add(this.QuadRoomsUpDown);
            this.gboxHotel.Controls.Add(this.TripleRoomsUpDown);
            this.gboxHotel.Controls.Add(this.DoubleRoomsUpDown);
            this.gboxHotel.Controls.Add(this.singleRoomsUpDown);
            this.gboxHotel.Controls.Add(this.label15);
            this.gboxHotel.Controls.Add(this.label23);
            this.gboxHotel.Controls.Add(this.label6);
            this.gboxHotel.Controls.Add(this.label12);
            this.gboxHotel.Controls.Add(this.txtHotelLocation);
            this.gboxHotel.Controls.Add(this.label8);
            this.gboxHotel.Controls.Add(this.txtHotelName);
            this.gboxHotel.Controls.Add(this.label7);
            this.gboxHotel.Location = new System.Drawing.Point(20, 225);
            this.gboxHotel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxHotel.Name = "gboxHotel";
            this.gboxHotel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxHotel.Size = new System.Drawing.Size(921, 93);
            this.gboxHotel.TabIndex = 2;
            this.gboxHotel.TabStop = false;
            this.gboxHotel.Text = "Hotel Reservation";
            this.gboxHotel.Visible = false;
            // 
            // QuadRoomsUpDown
            // 
            this.QuadRoomsUpDown.Location = new System.Drawing.Point(620, 44);
            this.QuadRoomsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.QuadRoomsUpDown.Name = "QuadRoomsUpDown";
            this.QuadRoomsUpDown.Size = new System.Drawing.Size(96, 22);
            this.QuadRoomsUpDown.TabIndex = 47;
            // 
            // TripleRoomsUpDown
            // 
            this.TripleRoomsUpDown.Location = new System.Drawing.Point(620, 18);
            this.TripleRoomsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TripleRoomsUpDown.Name = "TripleRoomsUpDown";
            this.TripleRoomsUpDown.Size = new System.Drawing.Size(96, 22);
            this.TripleRoomsUpDown.TabIndex = 46;
            // 
            // DoubleRoomsUpDown
            // 
            this.DoubleRoomsUpDown.Location = new System.Drawing.Point(412, 46);
            this.DoubleRoomsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.DoubleRoomsUpDown.Name = "DoubleRoomsUpDown";
            this.DoubleRoomsUpDown.Size = new System.Drawing.Size(96, 22);
            this.DoubleRoomsUpDown.TabIndex = 45;
            // 
            // singleRoomsUpDown
            // 
            this.singleRoomsUpDown.Location = new System.Drawing.Point(412, 18);
            this.singleRoomsUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.singleRoomsUpDown.Name = "singleRoomsUpDown";
            this.singleRoomsUpDown.Size = new System.Drawing.Size(96, 22);
            this.singleRoomsUpDown.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(515, 47);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 16);
            this.label15.TabIndex = 43;
            this.label15.Text = "Quad Rooms :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(515, 22);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(98, 16);
            this.label23.TabIndex = 42;
            this.label23.Text = "Triple Rooms :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Double Rooms :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(307, 22);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 16);
            this.label12.TabIndex = 40;
            this.label12.Text = "Single Rooms :";
            // 
            // txtHotelLocation
            // 
            this.txtHotelLocation.Location = new System.Drawing.Point(131, 47);
            this.txtHotelLocation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHotelLocation.Name = "txtHotelLocation";
            this.txtHotelLocation.Size = new System.Drawing.Size(132, 22);
            this.txtHotelLocation.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 50);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Location:";
            // 
            // txtHotelName
            // 
            this.txtHotelName.Location = new System.Drawing.Point(131, 19);
            this.txtHotelName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHotelName.Name = "txtHotelName";
            this.txtHotelName.Size = new System.Drawing.Size(132, 22);
            this.txtHotelName.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Hotel Name:";
            // 
            // gboxVisa
            // 
            this.gboxVisa.Controls.Add(this.txtVisaType);
            this.gboxVisa.Controls.Add(this.label9);
            this.gboxVisa.Controls.Add(this.txtVisaCountry);
            this.gboxVisa.Controls.Add(this.label10);
            this.gboxVisa.Location = new System.Drawing.Point(20, 225);
            this.gboxVisa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxVisa.Name = "gboxVisa";
            this.gboxVisa.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxVisa.Size = new System.Drawing.Size(921, 63);
            this.gboxVisa.TabIndex = 3;
            this.gboxVisa.TabStop = false;
            this.gboxVisa.Text = "Visa Reservation";
            this.gboxVisa.Visible = false;
            // 
            // txtVisaType
            // 
            this.txtVisaType.Location = new System.Drawing.Point(420, 21);
            this.txtVisaType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVisaType.Name = "txtVisaType";
            this.txtVisaType.Size = new System.Drawing.Size(132, 22);
            this.txtVisaType.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(297, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Visa Type:";
            // 
            // txtVisaCountry
            // 
            this.txtVisaCountry.Location = new System.Drawing.Point(131, 21);
            this.txtVisaCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVisaCountry.Name = "txtVisaCountry";
            this.txtVisaCountry.Size = new System.Drawing.Size(132, 22);
            this.txtVisaCountry.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 30);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 16);
            this.label10.TabIndex = 37;
            this.label10.Text = "Country";
            // 
            // gboxFlight
            // 
            this.gboxFlight.Controls.Add(this.txtDepartureLocation);
            this.gboxFlight.Controls.Add(this.lblDepartureLocation);
            this.gboxFlight.Controls.Add(this.txtArrivalLocation);
            this.gboxFlight.Controls.Add(this.label16);
            this.gboxFlight.Controls.Add(this.txtAirLine);
            this.gboxFlight.Controls.Add(this.label14);
            this.gboxFlight.Controls.Add(this.txtRefAirLine);
            this.gboxFlight.Controls.Add(this.label13);
            this.gboxFlight.Controls.Add(this.txtRefSystem);
            this.gboxFlight.Controls.Add(this.label11);
            this.gboxFlight.Controls.Add(this.txtTicketNo);
            this.gboxFlight.Controls.Add(this.lblTicketNo);
            this.gboxFlight.Location = new System.Drawing.Point(20, 225);
            this.gboxFlight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxFlight.Name = "gboxFlight";
            this.gboxFlight.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxFlight.Size = new System.Drawing.Size(921, 93);
            this.gboxFlight.TabIndex = 0;
            this.gboxFlight.TabStop = false;
            this.gboxFlight.Text = "Flight Reservation";
            this.gboxFlight.Visible = false;
            // 
            // txtDepartureLocation
            // 
            this.txtDepartureLocation.Location = new System.Drawing.Point(392, 60);
            this.txtDepartureLocation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDepartureLocation.Name = "txtDepartureLocation";
            this.txtDepartureLocation.Size = new System.Drawing.Size(164, 22);
            this.txtDepartureLocation.TabIndex = 4;
            // 
            // lblDepartureLocation
            // 
            this.lblDepartureLocation.AutoSize = true;
            this.lblDepartureLocation.Location = new System.Drawing.Point(259, 63);
            this.lblDepartureLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartureLocation.Name = "lblDepartureLocation";
            this.lblDepartureLocation.Size = new System.Drawing.Size(133, 16);
            this.lblDepartureLocation.TabIndex = 47;
            this.lblDepartureLocation.Text = "Departure Location:";
            // 
            // txtArrivalLocation
            // 
            this.txtArrivalLocation.Location = new System.Drawing.Point(689, 60);
            this.txtArrivalLocation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtArrivalLocation.Name = "txtArrivalLocation";
            this.txtArrivalLocation.Size = new System.Drawing.Size(132, 22);
            this.txtArrivalLocation.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(567, 63);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 16);
            this.label16.TabIndex = 45;
            this.label16.Text = "Arrival Location:";
            // 
            // txtAirLine
            // 
            this.txtAirLine.Location = new System.Drawing.Point(105, 28);
            this.txtAirLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAirLine.Name = "txtAirLine";
            this.txtAirLine.Size = new System.Drawing.Size(132, 22);
            this.txtAirLine.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 43;
            this.label14.Text = "AirLine:";
            // 
            // txtRefAirLine
            // 
            this.txtRefAirLine.AcceptsReturn = true;
            this.txtRefAirLine.Location = new System.Drawing.Point(392, 28);
            this.txtRefAirLine.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRefAirLine.Name = "txtRefAirLine";
            this.txtRefAirLine.Size = new System.Drawing.Size(164, 22);
            this.txtRefAirLine.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(259, 31);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 16);
            this.label13.TabIndex = 41;
            this.label13.Text = "Ref AirLine:";
            // 
            // txtRefSystem
            // 
            this.txtRefSystem.Location = new System.Drawing.Point(689, 28);
            this.txtRefSystem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtRefSystem.Name = "txtRefSystem";
            this.txtRefSystem.Size = new System.Drawing.Size(132, 22);
            this.txtRefSystem.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(567, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 39;
            this.label11.Text = "Ref System:";
            // 
            // txtTicketNo
            // 
            this.txtTicketNo.Location = new System.Drawing.Point(105, 60);
            this.txtTicketNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTicketNo.Name = "txtTicketNo";
            this.txtTicketNo.Size = new System.Drawing.Size(132, 22);
            this.txtTicketNo.TabIndex = 3;
            // 
            // lblTicketNo
            // 
            this.lblTicketNo.AutoSize = true;
            this.lblTicketNo.Location = new System.Drawing.Point(8, 63);
            this.lblTicketNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTicketNo.Name = "lblTicketNo";
            this.lblTicketNo.Size = new System.Drawing.Size(71, 16);
            this.lblTicketNo.TabIndex = 37;
            this.lblTicketNo.Text = "Ticket No:";
            // 
            // gbPricing
            // 
            this.gbPricing.Controls.Add(this.txtCommition);
            this.gbPricing.Controls.Add(this.label17);
            this.gbPricing.Controls.Add(this.label18);
            this.gbPricing.Controls.Add(this.txtFareBasic);
            this.gbPricing.Controls.Add(this.label19);
            this.gbPricing.Controls.Add(this.txtTaxes);
            this.gbPricing.Controls.Add(this.label20);
            this.gbPricing.Controls.Add(this.txtCommitionRatio);
            this.gbPricing.Controls.Add(this.label21);
            this.gbPricing.Controls.Add(this.txtNetPrice);
            this.gbPricing.Controls.Add(this.label22);
            this.gbPricing.Location = new System.Drawing.Point(20, 324);
            this.gbPricing.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPricing.Name = "gbPricing";
            this.gbPricing.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbPricing.Size = new System.Drawing.Size(921, 93);
            this.gbPricing.TabIndex = 5;
            this.gbPricing.TabStop = false;
            this.gbPricing.Text = "Pricing";
            // 
            // txtCommition
            // 
            this.txtCommition.Location = new System.Drawing.Point(392, 54);
            this.txtCommition.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCommition.Name = "txtCommition";
            this.txtCommition.Size = new System.Drawing.Size(164, 22);
            this.txtCommition.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(259, 62);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 16);
            this.label17.TabIndex = 47;
            this.label17.Text = "Commition:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(831, 26);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 16);
            this.label18.TabIndex = 45;
            this.label18.Text = "%";
            // 
            // txtFareBasic
            // 
            this.txtFareBasic.Location = new System.Drawing.Point(105, 22);
            this.txtFareBasic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFareBasic.Name = "txtFareBasic";
            this.txtFareBasic.Size = new System.Drawing.Size(132, 22);
            this.txtFareBasic.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 26);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 16);
            this.label19.TabIndex = 43;
            this.label19.Text = "Fare basic :";
            // 
            // txtTaxes
            // 
            this.txtTaxes.Location = new System.Drawing.Point(392, 22);
            this.txtTaxes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTaxes.Name = "txtTaxes";
            this.txtTaxes.Size = new System.Drawing.Size(164, 22);
            this.txtTaxes.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(259, 26);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 16);
            this.label20.TabIndex = 41;
            this.label20.Text = "Taxes:";
            // 
            // txtCommitionRatio
            // 
            this.txtCommitionRatio.Location = new System.Drawing.Point(689, 22);
            this.txtCommitionRatio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCommitionRatio.Name = "txtCommitionRatio";
            this.txtCommitionRatio.Size = new System.Drawing.Size(132, 22);
            this.txtCommitionRatio.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(567, 26);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 16);
            this.label21.TabIndex = 39;
            this.label21.Text = "Commition ratio:";
            // 
            // txtNetPrice
            // 
            this.txtNetPrice.Location = new System.Drawing.Point(105, 54);
            this.txtNetPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNetPrice.Name = "txtNetPrice";
            this.txtNetPrice.Size = new System.Drawing.Size(132, 22);
            this.txtNetPrice.TabIndex = 3;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 58);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 16);
            this.label22.TabIndex = 37;
            this.label22.Text = "Net price:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboVendors);
            this.groupBox2.Controls.Add(this.ClientNamesGridView);
            this.groupBox2.Controls.Add(this.dtpToDate);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpFromDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(21, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(921, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservation Info";
            // 
            // cboVendors
            // 
            this.cboVendors.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboVendors.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboVendors.FormattingEnabled = true;
            this.cboVendors.Location = new System.Drawing.Point(83, 29);
            this.cboVendors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboVendors.Name = "cboVendors";
            this.cboVendors.Size = new System.Drawing.Size(204, 24);
            this.cboVendors.TabIndex = 68;
            // 
            // ClientNamesGridView
            // 
            this.ClientNamesGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientNamesGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientNamesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientNamesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientName});
            this.ClientNamesGridView.Location = new System.Drawing.Point(347, 21);
            this.ClientNamesGridView.Name = "ClientNamesGridView";
            this.ClientNamesGridView.Size = new System.Drawing.Size(559, 121);
            this.ClientNamesGridView.TabIndex = 47;
            this.ClientNamesGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientNamesGridView_CellEndEdit);
            this.ClientNamesGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClietNamesGridView_CellValueChanged);
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientName.HeaderText = "Client Name";
            this.ClientName.Name = "ClientName";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // cboclients
            // 
            this.cboclients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboclients.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboclients.FormattingEnabled = true;
            this.cboclients.Location = new System.Drawing.Point(104, 21);
            this.cboclients.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboclients.Name = "cboclients";
            this.cboclients.Size = new System.Drawing.Size(204, 24);
            this.cboclients.TabIndex = 34;
            this.cboclients.SelectedIndexChanged += new System.EventHandler(this.cboclients_SelectedIndexChanged);
            // 
            // CmdPrint
            // 
            this.CmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdPrint.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.CmdPrint.Location = new System.Drawing.Point(2, 528);
            this.CmdPrint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdPrint.Name = "CmdPrint";
            this.CmdPrint.Size = new System.Drawing.Size(165, 41);
            this.CmdPrint.TabIndex = 65;
            this.CmdPrint.Text = "&Print Reservation";
            this.CmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CmdPrint.UseVisualStyleBackColor = true;
            this.CmdPrint.Click += new System.EventHandler(this.CmdPrint_Click);
            // 
            // cmdReOpen
            // 
            this.cmdReOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdReOpen.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdReOpen.Location = new System.Drawing.Point(625, 528);
            this.cmdReOpen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdReOpen.Name = "cmdReOpen";
            this.cmdReOpen.Size = new System.Drawing.Size(87, 41);
            this.cmdReOpen.TabIndex = 64;
            this.cmdReOpen.Text = "&ReOpen";
            this.cmdReOpen.UseVisualStyleBackColor = true;
            this.cmdReOpen.Visible = false;
            // 
            // CmdChange
            // 
            this.CmdChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdChange.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.CmdChange.Location = new System.Drawing.Point(633, 528);
            this.CmdChange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CmdChange.Name = "CmdChange";
            this.CmdChange.Size = new System.Drawing.Size(79, 41);
            this.CmdChange.TabIndex = 63;
            this.CmdChange.Text = "&Change";
            this.CmdChange.UseVisualStyleBackColor = true;
            this.CmdChange.Visible = false;
            // 
            // cmdReFund
            // 
            this.cmdReFund.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdReFund.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdReFund.Location = new System.Drawing.Point(523, 528);
            this.cmdReFund.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdReFund.Name = "cmdReFund";
            this.cmdReFund.Size = new System.Drawing.Size(79, 41);
            this.cmdReFund.TabIndex = 62;
            this.cmdReFund.Text = "&Refund";
            this.cmdReFund.UseVisualStyleBackColor = true;
            this.cmdReFund.Visible = false;
            // 
            // cmdEdit
            // 
            this.cmdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdEdit.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdEdit.Image = global::TravelAgency.Properties.Resources.edit32;
            this.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEdit.Location = new System.Drawing.Point(620, 529);
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Size = new System.Drawing.Size(92, 40);
            this.cmdEdit.TabIndex = 61;
            this.cmdEdit.Text = "&Edit";
            this.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdEdit.UseVisualStyleBackColor = true;
            this.cmdEdit.Visible = false;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdConfirm
            // 
            this.cmdConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdConfirm.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdConfirm.Location = new System.Drawing.Point(396, 528);
            this.cmdConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdConfirm.Name = "cmdConfirm";
            this.cmdConfirm.Size = new System.Drawing.Size(206, 41);
            this.cmdConfirm.TabIndex = 59;
            this.cmdConfirm.Text = "&Confirm Reservation";
            this.cmdConfirm.UseVisualStyleBackColor = true;
            this.cmdConfirm.Visible = false;
            this.cmdConfirm.Click += new System.EventHandler(this.cmdConfirm_Click_1);
            // 
            // cmdCancelReservation
            // 
            this.cmdCancelReservation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancelReservation.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.cmdCancelReservation.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelReservation.Image")));
            this.cmdCancelReservation.Location = new System.Drawing.Point(175, 528);
            this.cmdCancelReservation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCancelReservation.Name = "cmdCancelReservation";
            this.cmdCancelReservation.Size = new System.Drawing.Size(212, 41);
            this.cmdCancelReservation.TabIndex = 58;
            this.cmdCancelReservation.Text = "&Cancel Reservation";
            this.cmdCancelReservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdCancelReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdCancelReservation.UseVisualStyleBackColor = true;
            this.cmdCancelReservation.Visible = false;
            // 
            // lblReservationStatus
            // 
            this.lblReservationStatus.AutoSize = true;
            this.lblReservationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReservationStatus.Location = new System.Drawing.Point(714, 31);
            this.lblReservationStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReservationStatus.Name = "lblReservationStatus";
            this.lblReservationStatus.Size = new System.Drawing.Size(0, 13);
            this.lblReservationStatus.TabIndex = 67;
            this.lblReservationStatus.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(651, 31);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 16);
            this.lblStatus.TabIndex = 66;
            this.lblStatus.Text = "Status:";
            this.lblStatus.Visible = false;
            // 
            // NewReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 577);
            this.Controls.Add(this.gboxHotel);
            this.Controls.Add(this.lblReservationStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.CmdPrint);
            this.Controls.Add(this.cmdReOpen);
            this.Controls.Add(this.CmdChange);
            this.Controls.Add(this.cmdReFund);
            this.Controls.Add(this.cmdEdit);
            this.Controls.Add(this.cmdConfirm);
            this.Controls.Add(this.cmdCancelReservation);
            this.Controls.Add(this.cboclients);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPricing);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAccountNumber);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.gboxFlight);
            this.Controls.Add(this.gboxVisa);
            this.Font = new System.Drawing.Font("Georgia", 9.75F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Reservation";
            this.gboxHotel.ResumeLayout(false);
            this.gboxHotel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuadRoomsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TripleRoomsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoubleRoomsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.singleRoomsUpDown)).EndInit();
            this.gboxVisa.ResumeLayout(false);
            this.gboxVisa.PerformLayout();
            this.gboxFlight.ResumeLayout(false);
            this.gboxFlight.PerformLayout();
            this.gbPricing.ResumeLayout(false);
            this.gbPricing.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientNamesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cmdCancel;
        internal System.Windows.Forms.Button cmdSave;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.OpenFileDialog attachmentsFileDialog;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        internal System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.RichTextBox txtNotes;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gboxHotel;
        private System.Windows.Forms.TextBox txtHotelName;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gboxVisa;
        private System.Windows.Forms.TextBox txtVisaType;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVisaCountry;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHotelLocation;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gboxFlight;
        private System.Windows.Forms.TextBox txtAirLine;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRefAirLine;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtRefSystem;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTicketNo;
        internal System.Windows.Forms.Label lblTicketNo;
        private System.Windows.Forms.TextBox txtDepartureLocation;
        internal System.Windows.Forms.Label lblDepartureLocation;
        private System.Windows.Forms.TextBox txtArrivalLocation;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox gbPricing;
        private System.Windows.Forms.TextBox txtCommition;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtFareBasic;
        internal System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtTaxes;
        internal System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtCommitionRatio;
        internal System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNetPrice;
        internal System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errProvider;
        internal System.Windows.Forms.ComboBox cboclients;
        private System.Windows.Forms.DataGridView ClientNamesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        internal System.Windows.Forms.Button CmdPrint;
        internal System.Windows.Forms.Button cmdReOpen;
        internal System.Windows.Forms.Button CmdChange;
        internal System.Windows.Forms.Button cmdReFund;
        internal System.Windows.Forms.Button cmdEdit;
        internal System.Windows.Forms.Button cmdConfirm;
        internal System.Windows.Forms.Button cmdCancelReservation;
        internal System.Windows.Forms.Label lblReservationStatus;
        internal System.Windows.Forms.Label lblStatus;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown QuadRoomsUpDown;
        private System.Windows.Forms.NumericUpDown TripleRoomsUpDown;
        private System.Windows.Forms.NumericUpDown DoubleRoomsUpDown;
        private System.Windows.Forms.NumericUpDown singleRoomsUpDown;
        internal System.Windows.Forms.ComboBox cboVendors;

    }
}