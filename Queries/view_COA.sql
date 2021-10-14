USE [ICS]
GO

/****** Object:  View [dbo].[view_Chart_Of_Accounts]    Script Date: 2019-05-31 19:34:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER VIEW [dbo].[view_Chart_Of_Accounts]
AS
SELECT        dbo.acc_Chart_Of_Accounts.ID, dbo.acc_Chart_Of_Accounts.COA_Code, dbo.acc_Chart_Of_Accounts.COA_Statement, dbo.acc_Chart_Of_Accounts.COA_Level, dbo.acc_Chart_Of_Accounts.COA_Type, 
                         dbo.acc_Chart_Of_Accounts.COA_Summary, dbo.acc_Chart_Of_Accounts.COA_Name, dbo.acc_Chart_Of_Accounts.COA_Desc, dbo.acc_Chart_Of_Accounts.COA_Normal, dbo.acc_Chart_Of_Accounts.Notes, 
                         dbo.acc_Chart_Of_Accounts.Added_By, dbo.acc_Chart_Of_Accounts.Added_Date, dbo.acc_Chart_Of_Accounts.Modified_By, dbo.acc_Chart_Of_Accounts.Modified_Date, dbo.acc_Chart_Of_Accounts.COA_Company, 
                         acc_Chart_Of_Accounts_1.COA_Name AS COA_Summary_Name
FROM            dbo.acc_Chart_Of_Accounts LEFT OUTER JOIN
                         dbo.acc_Chart_Of_Accounts AS acc_Chart_Of_Accounts_1 ON dbo.acc_Chart_Of_Accounts.COA_Summary = acc_Chart_Of_Accounts_1.COA_Code
GO


