USE [TestDB]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 1/26/2024 4:14:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](30) NULL,
	[LastName] [varchar](50) NULL,
	[Address1] [varchar](100) NULL,
	[PayPerHour] [decimal](5, 2) NULL,
	[AnnualSalary] [decimal](10, 2) NULL,
	[MaxExpenseAmount] [decimal](10, 2) NULL,
	[EmployeeTypeID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Employees]  WITH CHECK ADD FOREIGN KEY([EmployeeTypeID])
REFERENCES [dbo].[EmployeeTypes] ([EmployeeTypeID])
GO


