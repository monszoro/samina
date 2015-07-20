USE [TravelAgency]
GO
/****** Object:  StoredProcedure [dbo].[getReservationInfo]    Script Date: 7/9/2015 11:50:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sami Mikhail
-- Create date: <Create Date,R.,R.>
-- Description:	<Description,R.,R.>
-- =============================================
ALTER PROCEDURE [dbo].[getReservationInfo]
	-- Add the parameters for the stored procedure here
	@ReservationID INT 
AS
BEGIN
	

	Select R.DateCreated
      ,R.DateFrom
      ,R.DateTo
      ,R.BasicPrice
      ,R.Taxes
      ,R.CommitionRatio
      ,R.NetPrice
      ,R.Commission
      ,R.Note
      ,R.PaidAmount
      ,R.BalanceDue
	  ,u.UserName
	  ,C.FullName
	  ,RT.Description AS ReservationType
	  ,RS.Description AS ReservationStatus
	  ,Hr.DoubleRooms
	  ,Hr.HotelName
	  ,Hr.Location
	  ,Hr.QuadRooms
	  ,Hr.SingleRooms
	  ,Hr.TripleRooms
	  ,Vr.Country
	  ,Vr.VisaType
	  ,Fl.AirLine
	  ,Fl.FromLocation
	  ,Fl.RefAirLine
	  ,FL.RefSystem
	  ,Fl.TicketNo
	  ,Fl.ToLocation
	  
	from Reservations R 
	inner join users U on R.CreationUserID=u.UserID
	inner join Clients C on R.ClientID=C.ClientID
	inner join ReservationTypes RT on R.TypeID=RT.TypeId 
	inner join ReservationStatuses RS on R.StatusID=RS.StatusId
	left join HotelReservations HR on R.ReservationID=Hr.ReservationID
	left join VisaReservations VR on R.ReservationID=VR.ReservationID
	left join FlightReservations FL on R.ReservationID=Fl.ReservationID
	where R.ReservationID=@ReservationID

END
