USE [ICS]
GO

/****** Object:  View [dbo].[view_Balances]    Script Date: 2019-05-31 19:34:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[view_Balances]
AS
SELECT        dbo.acc_Balances.ID, dbo.acc_Chart_Of_Accounts.COA_Code, dbo.acc_Chart_Of_Accounts.COA_Statement, dbo.acc_Chart_Of_Accounts.COA_Level, dbo.acc_Chart_Of_Accounts.COA_Type, 
                         dbo.acc_Chart_Of_Accounts.COA_Summary, dbo.acc_Chart_Of_Accounts.COA_Name, dbo.acc_Chart_Of_Accounts.COA_Desc, dbo.acc_Chart_Of_Accounts.COA_Normal, dbo.acc_Balances.Balance_Start_Debit, 
                         dbo.acc_Balances.Balance_Start_Credit, dbo.acc_Balances.Date_Range_Start, dbo.acc_Balances.Date_Range_Debit, dbo.acc_Balances.Date_Range_Credit, dbo.acc_Balances.Balance_End_Debit, 
                         dbo.acc_Balances.Balance_End_Credit, dbo.acc_Balances.Date_Range_End, dbo.acc_Balances.Notes, dbo.acc_Balances.Balance_Status, dbo.acc_Balances.Added_By, dbo.acc_Balances.Added_Date, 
                         dbo.acc_Balances.Modified_By, dbo.acc_Balances.Modified_Date, dbo.acc_Balances.Approved_By, dbo.acc_Balances.Approved_Date, dbo.acc_Balances.COA_Summary AS Expr1
FROM            dbo.acc_Chart_Of_Accounts LEFT OUTER JOIN
                         dbo.acc_Balances ON dbo.acc_Chart_Of_Accounts.COA_Code = dbo.acc_Balances.COA_Code
GO


