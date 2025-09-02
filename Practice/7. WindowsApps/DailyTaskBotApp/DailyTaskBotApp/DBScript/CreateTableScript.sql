USE [DailyTaskBot]
GO

-- =============================================                                
-- Author      : Rashid Akhtar                               
-- Create date : 2021-12-10                              
-- Description : To Create EmployeeDailyReport Table                           
-- ============================================= 
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[EmployeeDailyReport](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeName] [varchar](100) NOT NULL,
	[YesterdaysTask] [varchar](4000) NOT NULL,
	[TodaysTask] [varchar](4000) NOT NULL,
	[Obstacle] [varchar](4000) NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_EmployeeDailyReport] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


