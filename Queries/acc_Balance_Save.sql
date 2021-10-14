USE [ICS]
GO
/****** Object:  StoredProcedure [dbo].[acc_Balance_Save]    Script Date: 2019-05-31 19:33:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Kirkey Psalms>
-- Create date: <5-21-2019>
-- Description:	<Trial Balance Save>
-- =============================================

ALTER PROCEDURE [dbo].[acc_Balance_Save]
	-- Add the parameters for the stored procedure here
	@COA_Code				nvarchar(20),
	@COA_Summary			nvarchar(20),
	@Date_Range_Start		date,
	@Date_Range_Debit		money,
	@Date_Range_Credit		money,
	@Date_Range_End			date,
	@Balance_End_Debit		money,
	@Balance_End_Credit		money,
	@Balance_Status			varchar(20),
	@Notes					varchar(max),
	@Added_By				varchar(20),
	@Added_Date				datetime,
	@Modified_By			varchar(20),
	@Modified_Date			datetime
AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	-- Check if exist
	--IF EXISTS(SELECT COA_Code Date_Range_Start FROM acc_Balances WHERE COA_Code LIKE @COA_Code AND Date_Range_Start LIKE @Date_Range_Start)
	--RETURN

	IF EXISTS(SELECT COA_Code, Date_Range_Start FROM acc_Balances WHERE COA_Code LIKE @COA_Code AND Date_Range_Start LIKE CONVERT(VARCHAR(10), @Date_Range_Start, 23))
		BEGIN
			--Update if exist
			UPDATE acc_Balances
			SET COA_Summary =			@COA_Summary,
				Date_Range_Debit =		@Date_Range_Debit,
				Date_Range_Credit =		@Date_Range_Credit,
				Date_Range_End =		@Date_Range_End,
				Balance_End_Debit =		@Balance_End_Debit,
				Balance_End_Credit =	@Balance_End_Credit,
				Balance_Status =		@Balance_Status,
				Modified_By =			@Modified_By,
				Modified_Date =			@Modified_Date,
				Notes =					@Notes
			
			WHERE COA_Code LIKE @COA_Code AND Date_Range_Start LIKE CONVERT(VARCHAR(10), @Date_Range_Start, 23)
		END
	ELSE
		BEGIN
			--Insert if not exist
			INSERT INTO acc_Balances(COA_Code, COA_Summary, Date_Range_Start, Date_Range_Debit, Date_Range_Credit, Date_Range_End, Balance_End_Debit, Balance_End_Credit, Balance_Status, Added_By, Added_Date, Notes)
			VALUES (@COA_Code, @COA_Summary, @Date_Range_Start, @Date_Range_Debit, @Date_Range_Credit, @Date_Range_End, @Balance_End_Debit, @Balance_End_Credit, @Balance_Status, @Added_By, @Added_Date, @Notes)
		END
END




