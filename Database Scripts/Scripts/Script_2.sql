USE [TravelAgency]
GO
/****** Object:  StoredProcedure [dbo].[getLedgerTransactions]    Script Date: 7/9/2015 11:50:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sami Mikhail
-- Create date: <Create Date,R.,R.>
-- Description:	<Description,R.,R.>
-- =============================================
Create  PROCEDURE [dbo].[getLedgerTransactions]
	-- Add the parameters for the stored procedure here
	@GeneralLedgerAccountID INT,
	@LedgerAccountID INT NULL
AS
BEGIN
	Select LTD.Amount,LT.TransactionTime,LT.Description , LTT.Description AS TranType FROM LedgerTransactionDetails LTD
	INNER JOIN LedgerTransactionTypes LTT on LTD.LedgerTransactionTypeID=LTT.LedgerTransactionTypeID
	INNER JOIN LedgerTransactions LT on LT.LedgerTransactionID=LTD.LedgerTransactionID
	INNER JOIN LedgerAccounts LA on LA.LedgerAccountID=LTD.LedgerAccountID
	INNER JOIN GeneralLedgerAccounts GLA on GLA.GeneralLedgerAccountID=LA.GeneralLedgerAccountID
	where GLA.GeneralLedgerAccountID=@GeneralLedgerAccountID 
	AND (@LedgerAccountID IS NULL OR LTD.LedgerAccountID=@LedgerAccountID)

END