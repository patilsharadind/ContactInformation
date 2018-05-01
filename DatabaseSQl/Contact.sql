USE [Sharad_TestDB]
GO

/****** Object:  Table [dbo].[Contact]    Script Date: 4/28/2018 8:21:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Contact](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](15) NOT NULL,
	[LastName] [varchar](15) NOT NULL,
	[PhoneNumber] [varchar](10) NOT NULL,
	[EmailAddress] [varchar](25) NULL,
	[Status] [varchar](8) NOT NULL,
 CONSTRAINT [PK_ContactId] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


