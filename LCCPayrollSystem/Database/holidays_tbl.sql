USE [payrolldb]
GO

/****** Object:  Table [dbo].[holidays_tbl]    Script Date: 6/4/2023 7:16:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[holidays_tbl](
	[HolidayDate] [date] NULL,
	[HolidayName] [varchar](255) NULL,
	[IsWithPay] [bit] NULL
) ON [PRIMARY]
GO


