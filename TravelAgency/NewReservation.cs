using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace TravelAgency
{
    public partial class NewReservation : Form
    {
        private Client client;
        private bool blnLoading;
        private Reservation CurReservation;
        private enum ReservationTypes
        {
            Hotel = 1,
            Flight = 2,
            Visa = 3,
            Insurance = 4,
            Transfer = 5,
            Other = 6
        }
        
        private enum ReservationStatuses
        {
            Pending = 1,
            Confirmed = 2,
            Cancelled = 3,
            Refunded = 4
        }
        public NewReservation()
        {
            blnLoading = true;
            InitializeComponent();
            LoadComboBoxes();
            UpdateUI();
            blnLoading = false;
        }

        public NewReservation(Reservation Res)
        {
            blnLoading = true;
            InitializeComponent();
            CurReservation = Res;
            LoadComboBoxes();
            LoadReservationInfo();
            UpdateUI();
            blnLoading = false;
        }
        private void LoadReservationInfo()
        {
            cboclients.Text = CurReservation.Client.FirstName + ' ' + CurReservation.Client.LastName;
            lblReservationStatus.Text = CurReservation.ReservationStatus.Description;
            dtpFromDate.Value = CurReservation.DateFrom;
            dtpToDate.Value = CurReservation.DateTo;
            txtFareBasic.Text = CurReservation.BasicPrice.ToString();
            txtTaxes.Text = CurReservation.Taxes.ToString();
            txtCommitionRatio.Text = CurReservation.CommitionRatio.ToString();
            txtNetPrice.Text = CurReservation.NetPrice.ToString();
            txtCommition.Text = CurReservation.Commission.ToString();
            txtNotes.Text = CurReservation.Note;
            switch (CurReservation.TypeID)
            {
                case 1:
                  //  CurReservation.HotelReservationReference.Load();
                    txtHotelName.Text = CurReservation.HotelReservation.HotelName;
                    txtHotelLocation.Text = CurReservation.HotelReservation.Location;
                    singleRoomsUpDown.Value = CurReservation.HotelReservation.SingleRooms;
                    DoubleRoomsUpDown.Value = CurReservation.HotelReservation.DoubleRooms;
                    TripleRoomsUpDown.Value = CurReservation.HotelReservation.TripleRooms;
                    QuadRoomsUpDown.Value = CurReservation.HotelReservation.QuadRooms;
                  //  cboRoomCapacity.SelectedIndex = CurReservation.HotelReservation.RoomCapacity - 1;
                    break;
                case 2:
                    //CurReservation.FlightReservationReference.Load();
                    txtAirLine.Text = CurReservation.FlightReservation.AirLine;
                    txtRefAirLine.Text = CurReservation.FlightReservation.RefAirLine;
                    txtRefSystem.Text = CurReservation.FlightReservation.RefSystem;
                    txtDepartureLocation.Text = CurReservation.FlightReservation.FromLocation;
                    txtArrivalLocation.Text = CurReservation.FlightReservation.ToLocation;
                    txtTicketNo.Text = CurReservation.FlightReservation.TicketNo;
                    break;
                case 3:
                    //CurReservation.VisaReservationReference.Load();
                    txtVisaCountry.Text = CurReservation.VisaReservation.Country;
                    txtVisaType.Text = CurReservation.VisaReservation.VisaType;
                    break;
            }
            foreach (ReservationClient  rc in CurReservation.ReservationClients)
            {
                DataGridViewRow dgr = new DataGridViewRow();
                DataGridViewTextBoxCell  ClientName = new DataGridViewTextBoxCell();
                ClientName.Value=rc.ClientName ;
                dgr.Cells.Add(ClientName);
                ClientNamesGridView.Rows.Add(dgr);
             }
        }
        public NewReservation(Client _client)
        {
            blnLoading = true;
            InitializeComponent();
            LoadComboBoxes();
            setClient(_client);
            blnLoading = false;
        }
        private void UpdateUI()
        {
            if (CurReservation != null)
            {
                switch (this.CurReservation.StatusID)
            {
                case (int)ReservationStatuses.Pending:
                    cmdEdit.Visible = true;
                    cmdConfirm.Visible = true;
                    cmdCancelReservation.Visible = true;
                    break;
                case (int)ReservationStatuses.Cancelled:
                    cmdReOpen.Visible = true;
                    cmdConfirm.Visible = false;
                    cmdCancelReservation.Visible = false;
                    break;
                case (int)ReservationStatuses.Confirmed:
                    CmdChange.Visible = true;
                    cmdReFund.Visible = true;
                    break;
                case (int)ReservationStatuses.Refunded:
                    cmdEdit.Visible = false;
                    cmdConfirm.Visible = false;
                    cmdCancelReservation.Visible = false;
                    cmdSave.Visible = false;
                    break;
            }
                lblReservationStatus.Visible = true;
                lblStatus.Visible = true;
                
                gbPricing.Enabled = false;
                gboxHotel.Enabled = false;
                gboxFlight.Enabled = false;
                gboxVisa.Enabled = false;
                txtNotes.Enabled = false;
                cboclients.Enabled = false;
                cboType.Enabled = false;
                cboVendors.Enabled = false;
                dtpFromDate.Enabled = false;
                dtpToDate.Enabled = false;
                ClientNamesGridView.Enabled = false;

            }
            else
            {
                cmdSave.Visible = true;
                cmdCancel.Visible = true;
}
        }

        private void setClient(Client client)
        {
            this.client = client;
            int i;
            for (i = 0; i < cboclients.Items.Count; i++)
            {
                if (this.client.ClientID == ((Client)cboclients.Items[i]).ClientID)
                {
                    cboclients.SelectedIndex = i;
                    return;
                }
            }

            //   lblClient.Text = client.FirstName + " " + client.LastName;
        }
        private void LoadComboBoxes()
        {
            cboclients.ValueMember = "FullName";
            var queryClients = from c in TravelAgenceMasterClass.TravelAgencyContext.Clients
                        select c;
            foreach (var client in queryClients)
            {
                cboclients.Items.Add(client);
                if (CurReservation != null && client.ClientID  == CurReservation.TypeID)
                {
                    cboType.SelectedItem = client;
                }
            }


            var q = from rt in TravelAgenceMasterClass.TravelAgencyContext.ReservationTypes
                    select rt;
            cboType.ValueMember = "Description";
            foreach (var resType in q)
            {
                cboType.Items.Add(resType);
                if (CurReservation != null && resType.TypeId == CurReservation.TypeID)
                {
                    cboType.SelectedItem = resType;
                }
            }
            var query = from v in TravelAgenceMasterClass.TravelAgencyContext.Vendors
                        select v;
            cboVendors.ValueMember = "Name";
            foreach (var vendor in query)
            {
                cboVendors.Items.Add(vendor);
                if (CurReservation != null && vendor.VendorID == CurReservation.VendorID)
                {
                    cboVendors.SelectedItem = vendor;
                }
            }

        }


        private void cmdSave_Click(object sender, EventArgs e)
        {
            bool exitSave = false;

            if (CurReservation==null &&( this.client == null || string.IsNullOrEmpty(cboclients.Text)))
            {
                errProvider.SetError(cboclients, "Please Choose Client");
                exitSave = true;
            }
            else errProvider.SetError(cboclients, "");


            if (cboType.SelectedIndex == -1)
            {
                errProvider.SetError(cboType, "You must select Reservation Type");
                exitSave = true;
            }
            else
                errProvider.SetError(cboType, "");

            if (string.IsNullOrEmpty(cboVendors.Text))
            {
                errProvider.SetError(cboVendors, "You must select Vendor");
                exitSave = true;
            }
            else
                errProvider.SetError(cboVendors, "");

            if (cboType.SelectedItem == null)
            {
                errProvider.SetError(cboType, "Required Field");
            }
            else if (((ReservationType)cboType.SelectedItem).Description.Equals("Hotel"))
            {
                errProvider.SetError(cboType, "");
                if (String.IsNullOrEmpty(txtHotelName.Text))
                {
                    errProvider.SetError(txtHotelName, "Rquired Field");
                    exitSave = true;
                }
                else
                    errProvider.SetError(txtHotelName, "");

                if (String.IsNullOrEmpty(txtHotelLocation.Text))
                {
                    errProvider.SetError(txtHotelLocation, "Rquired Field");
                    exitSave = true;
                }
                else
                    errProvider.SetError(txtHotelLocation, "");

                if (singleRoomsUpDown.Value == 0 && DoubleRoomsUpDown.Value == 0 && TripleRoomsUpDown.Value == 0 && QuadRoomsUpDown.Value == 0)
                {
                    MessageBox.Show("You must select at least one room.", "Warning", MessageBoxButtons.OK);
                    exitSave = true;
                }

            }
            else if (((ReservationType)cboType.SelectedItem).Description.Equals("Flight"))
            {
                errProvider.SetError(cboType, "");
                if (String.IsNullOrEmpty(txtAirLine.Text))
                {
                    errProvider.SetError(txtAirLine, "Rquired Field");
                    exitSave = true;
                }
                else
                    errProvider.SetError(txtAirLine, "");

                if (String.IsNullOrEmpty(txtRefAirLine.Text))
                {
                    errProvider.SetError(txtRefAirLine, "Rquired Field");
                    exitSave = true;
                }
                else
                    errProvider.SetError(txtRefAirLine, "");

                if (String.IsNullOrEmpty(txtRefSystem.Text))
                {
                    errProvider.SetError(txtRefSystem, "Rquired Field");
                    exitSave = true;
                }
                else
                    errProvider.SetError(txtRefSystem, "");


                if (String.IsNullOrEmpty(txtArrivalLocation.Text))
                {
                    errProvider.SetError(txtArrivalLocation, "Rquired Field");
                    exitSave = true;
                }
                else
                    errProvider.SetError(txtArrivalLocation, "");

                if (String.IsNullOrEmpty(txtDepartureLocation.Text))
                {
                    errProvider.SetError(txtDepartureLocation, "Rquired Field");
                    exitSave = true;
                }
                else
                    errProvider.SetError(txtDepartureLocation, "");

                //
                if (String.IsNullOrEmpty(txtTicketNo.Text))
                {
                    errProvider.SetError(txtTicketNo, "Rquired Field");
                    exitSave = true;
                }
                else
                    errProvider.SetError(txtTicketNo, "");

            }
            else if (((ReservationType)cboType.SelectedItem).Description.Equals("Visa"))
            {
                errProvider.SetError(cboType, "");
                if (String.IsNullOrEmpty(txtVisaCountry.Text))
                {
                    errProvider.SetError(txtVisaCountry, "Rquired Field");
                    exitSave = true;
                }
                else
                    errProvider.SetError(txtVisaCountry, "");

                if (String.IsNullOrEmpty(txtVisaType.Text))
                {
                    errProvider.SetError(txtVisaType, "Rquired Field");
                    exitSave = true;
                }
                else
                    errProvider.SetError(txtVisaType, "");
            }
            if (String.IsNullOrEmpty(txtFareBasic.Text))
            {
                errProvider.SetError(txtFareBasic, "Rquired Field");
                exitSave = true;
            }
            else
                errProvider.SetError(txtFareBasic, "");

            if (String.IsNullOrEmpty(txtTaxes.Text))
            {
                errProvider.SetError(txtTaxes, "Rquired Field");
                exitSave = true;
            }
            else
                errProvider.SetError(txtTaxes, "");


            if (String.IsNullOrEmpty(txtCommitionRatio.Text))
            {
                errProvider.SetError(txtCommitionRatio, "Rquired Field");
                exitSave = true;
            }
            else
                errProvider.SetError(txtCommitionRatio, "");

            if (String.IsNullOrEmpty(txtNetPrice.Text))
            {
                errProvider.SetError(txtNetPrice, "Rquired Field");
                exitSave = true;
            }
            else
                errProvider.SetError(txtNetPrice, "");

            if (String.IsNullOrEmpty(txtCommition.Text))
            {
                errProvider.SetError(txtCommition, "Rquired Field");
                exitSave = true;
            }
            else
                errProvider.SetError(txtCommition, "");


            if (exitSave)
                return;

            if (ClientNamesGridView.Rows.Count == 1)
                if (MessageBox.Show("You didnot enter clients' names." + Environment.NewLine + "Are you sure you want to save?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            Vendor vendor = null;
            if (cboVendors.SelectedIndex == -1)
                if (MessageBox.Show("This vendor doesnot exist" + Environment.NewLine + "Are you sure you want to create a new vendor?", "Warning", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
                else
                {
                    vendor = new Vendor();
                    vendor.Name = cboVendors.Text;
                    vendor.DateCreated = DateTime.Now;
                    vendor.CreationUserID = TravelAgenceMasterClass.CurrentUser.UserID;
                    TravelAgenceMasterClass.TravelAgencyContext.Vendors.Add(vendor);
                    TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
                }
            

            if (CurReservation != null)
                saveCurrentReservation();
            else
                saveNewReservation(vendor);
            
         Close();
   }
    public void  saveCurrentReservation()
      {

          //int clientID = this.client.ClientID;
          //int userID = TravelAgenceMasterClass.CurrentUser.UserID;
          int vendorId = ((Vendor)cboVendors.SelectedItem).VendorID;
          CurReservation.VendorID = vendorId;

          CurReservation.DateFrom = dtpFromDate.Value;
          CurReservation.DateTo = dtpToDate.Value;
        CurReservation.BasicPrice=decimal.Parse(txtFareBasic.Text);
        CurReservation.CommitionRatio =decimal.Parse(txtCommitionRatio .Text);
        CurReservation.Commission=decimal.Parse(txtCommition.Text);
        CurReservation.Taxes=decimal.Parse(txtTaxes.Text);
        CurReservation.NetPrice = decimal.Parse(txtNetPrice.Text);
        CurReservation.Note = txtNotes.Text;
      
        TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();


        switch (((ReservationType)cboType.SelectedItem).TypeId)
        {
            case 1:
                CurReservation.HotelReservation.HotelName = txtHotelName.Text;
                CurReservation.HotelReservation.Location = txtHotelLocation.Text;
                CurReservation.HotelReservation.SingleRooms = int.Parse(singleRoomsUpDown.Value.ToString());
                CurReservation.HotelReservation.DoubleRooms =int.Parse(DoubleRoomsUpDown.Value.ToString());
                CurReservation.HotelReservation.TripleRooms = int.Parse(TripleRoomsUpDown.Value.ToString());
                CurReservation.HotelReservation.QuadRooms = int.Parse(QuadRoomsUpDown.Value.ToString());
                break;
            case 2:
                CurReservation.FlightReservation.FromLocation = txtDepartureLocation.Text;
                CurReservation.FlightReservation.ToLocation = txtArrivalLocation.Text;
                CurReservation.FlightReservation.AirLine = txtAirLine.Text;
                CurReservation.FlightReservation.RefAirLine = txtRefAirLine.Text;
                CurReservation.FlightReservation.TicketNo = txtRefAirLine.Text;
                CurReservation.FlightReservation.RefSystem = txtRefSystem.Text;
                break;
            case 3:
                CurReservation.VisaReservation.VisaType = txtVisaType.Text;
                CurReservation.VisaReservation.Country = txtVisaCountry.Text;
                break;
            default:
                break;
        }
            if (CurReservation.StatusID == 2)
            {
                CurReservation.StatusID = 4;
            }


            CurReservation = TravelAgenceMasterClass.TravelAgencyContext.Reservations.Where(Rc => Rc.ReservationID == CurReservation.ReservationID).SingleOrDefault();
        while(CurReservation.ReservationClients.Count>0)
        {
          ReservationClient RClient = CurReservation.ReservationClients.ElementAt(0);
        RClient = TravelAgenceMasterClass.TravelAgencyContext.ReservationClients.Where(Rc => Rc.ReservationClientID == RClient.ReservationClientID).SingleOrDefault();
        CurReservation.ReservationClients.Remove(RClient);

        TravelAgenceMasterClass.TravelAgencyContext.ReservationClients.Remove(RClient);
        } 
            //TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            foreach (DataGridViewRow d in ClientNamesGridView.Rows)
            {
              if (d.Index < ClientNamesGridView.Rows.Count - 1)
              {
                  ReservationClient rc = new ReservationClient();
                  rc.ReservationID= CurReservation.ReservationID;
                  rc.ClientName = d.Cells[0].Value.ToString();
                  TravelAgenceMasterClass.TravelAgencyContext.ReservationClients.Add(rc);
              }
            }
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
      }
        
private void  saveNewReservation(Vendor vendor) {

            int clientID = this.client.ClientID;
            int userID = TravelAgenceMasterClass.CurrentUser.UserID;
            int vendorId;
            if (vendor == null)
            {
                vendor = (Vendor)cboVendors.SelectedItem;
            }
            vendorId = vendor.VendorID;
            ReservationTypes typeId;
            switch (((ReservationType)cboType.SelectedItem).Description)
            {
                case "Hotel":
                    typeId = ReservationTypes.Hotel;
                    break;
                case "Flight":
                    typeId = ReservationTypes.Flight; ;
                    break;
                case "Visa":
                    typeId = ReservationTypes.Visa; ;
                    break;
                case "Insurance":
                    typeId = ReservationTypes.Insurance;
                    break;
                case "Transfer":
                    typeId = ReservationTypes.Transfer;
                    break;
                case "Other":
                    typeId = ReservationTypes.Other;
                    break;
                default:
                    typeId = 0;
                    break;
            }
            Reservation r = new Reservation();
            r.ClientID = clientID;
            r.CreationUserID = userID;
            r.DateCreated = DateTime.Now;
            r.TypeID = (int)typeId;
            r.DateFrom = dtpFromDate.Value;
            r.DateTo = dtpToDate.Value;
            r.StatusID = (int)ReservationStatuses.Pending;
    
    r.VendorID=vendorId;
    r.BasicPrice= decimal.Parse(txtFareBasic.Text);
    r.Taxes=decimal.Parse(txtTaxes.Text);
    r.CommitionRatio=decimal.Parse(txtCommitionRatio.Text);
    r.NetPrice=decimal.Parse(txtNetPrice.Text);
    r.Commission = decimal.Parse(txtCommition.Text);
    r.PaidAmount = 0;
            r.Note = txtNotes.Text;
            TravelAgenceMasterClass.TravelAgencyContext.Reservations.Add (r);
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();

            switch (typeId)
            {
                case ReservationTypes.Hotel:
                    HotelReservation hr =new  HotelReservation();
                    hr.ReservationID= r.ReservationID;
                    hr.HotelName=txtHotelName.Text;
                    hr.Location = txtHotelLocation.Text;
                    hr.SingleRooms = int.Parse(singleRoomsUpDown.Value.ToString());
                    hr.DoubleRooms = int.Parse(DoubleRoomsUpDown.Value.ToString());
                    hr.TripleRooms = int.Parse(TripleRoomsUpDown.Value.ToString());
                    hr.QuadRooms = int.Parse(QuadRoomsUpDown.Value.ToString());
                    TravelAgenceMasterClass.TravelAgencyContext.HotelReservations.Add(hr);
                    break;
                case ReservationTypes.Flight:
                    FlightReservation fr =new  FlightReservation();
                    fr.ReservationID= r.ReservationID;
                    fr.FromLocation= txtDepartureLocation.Text;
                    fr.ToLocation = txtArrivalLocation.Text;
                    fr.AirLine = txtAirLine.Text;
                    fr.RefAirLine = txtRefAirLine.Text;
                    fr.TicketNo = txtTicketNo .Text;
                    fr.RefSystem = txtRefSystem.Text;
                    TravelAgenceMasterClass.TravelAgencyContext.FlightReservations.Add(fr);
                    break;
                case ReservationTypes.Visa:
                    VisaReservation vr = new VisaReservation();
                    vr.ReservationID=r.ReservationID;
                    vr.Country= txtVisaCountry.Text;
                    vr.VisaType = txtVisaType.Text;
                    TravelAgenceMasterClass.TravelAgencyContext.VisaReservations.Add(vr);
                    break;
                default:
                    break;
            }
                   
                    foreach (DataGridViewRow d in ClientNamesGridView.Rows)
                    {
                        if (d.Index < ClientNamesGridView.Rows.Count - 1)
                        {
                            ReservationClient rc = new ReservationClient();
                            rc.ReservationID=r.ReservationID;
                            rc.ClientName=d.Cells[0].Value.ToString();
                            TravelAgenceMasterClass.TravelAgencyContext.ReservationClients.Add(rc);
                        }
                    }
                    TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
}
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
            {
                gboxHotel.Visible = true;
                gboxFlight.Visible = false;
                gboxVisa.Visible = false;
            }
            else if (cboType.SelectedIndex == 1)
            {
                gboxHotel.Visible = false;
                gboxFlight.Visible = true;
                gboxVisa.Visible = false;
            }
            else if (cboType.SelectedIndex == 2)
            {
                gboxHotel.Visible = false;
                gboxFlight.Visible = false;
                gboxVisa.Visible = true;
            }
            else
            {
                gboxHotel.Visible = false;
                gboxFlight.Visible = false;
                gboxVisa.Visible = false;
            }
        }

        private void cboclients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!blnLoading)
            {
                if (cboclients.SelectedItem != null)
                {
                    this.client = ((Client)cboclients.SelectedItem);
                }
            }
        }

        private void ClietNamesGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex<0 )
            //    return ;
            //Object value=ClientNamesGridView.Rows[e.RowIndex].Cells[0].Value;
            //if (value ==null || String.IsNullOrEmpty(value.ToString().Trim ()))
            //{
            //    ClientNamesGridView.Rows.RemoveAt(e.RowIndex);
            //}
        }

        private void ClientNamesGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == ClientNamesGridView.Rows.Count - 1)
                return;
            Object value = ClientNamesGridView.Rows[e.RowIndex].Cells[0].Value;
            if (value == null || String.IsNullOrEmpty(value.ToString().Trim()))
            {
                ClientNamesGridView.Rows.RemoveAt(e.RowIndex);
            }
        }
        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdConfirm_Click(object sender, EventArgs e)
        {
            if (CurReservation.StatusID == 1)
            {
                CurReservation.StatusID = 2;
                TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
                Close();
            }
            else
            {
                gbPricing.Enabled = true;
                cmdConfirm.Visible = false;
                cmdEdit.Visible = false;
            }
        }

        private void cmdCancelReservation_Click(object sender, EventArgs e)
        {
            CurReservation.StatusID = 3;
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            Close();
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            gbPricing .Enabled = true;
            switch (CurReservation.TypeID)
            {
                case 1:
                    gboxHotel.Enabled = true;
                    break;
                case 2:
                    gboxFlight.Enabled = true;
                    break;
                case 3:
                    gboxVisa.Enabled = true;
                    break;
            }
            gbPricing.Enabled = true;
            txtNotes.Enabled = true;
            cmdConfirm.Visible = false;
            cmdEdit.Visible = false;
            cmdCancelReservation.Visible = false;
            cmdSave.Visible = true;
            dtpToDate.Enabled = true;
            dtpFromDate.Enabled = true;
            ClientNamesGridView.Enabled = true;
            CurReservation.StatusID = 1;
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
        }

        private void cmdReOpen_Click(object sender, EventArgs e)
        {
            CurReservation .StatusID = (int)ReservationStatuses.Pending;
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            cmdReOpen.Visible = false;
            LoadReservationInfo();
        }

        private void cmdReFund_Click(object sender, EventArgs e)
        {
            CurReservation.StatusID = (int)ReservationStatuses.Refunded;
            TravelAgenceMasterClass.TravelAgencyContext.SaveChanges();
            cmdReFund.Visible = false;
            CmdChange.Visible = false;
            LoadReservationInfo();
        }
    }
}
