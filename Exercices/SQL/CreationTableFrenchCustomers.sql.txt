USE [ComptoirAnglais_V1]
GO

/****** Object:  Table [dbo].[Customers]    Script Date: 07/06/2015 10:03:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[FrenchCustomers](
	[CustomerID] [char](5) NOT NULL,
	[CompanyName] [varchar](40) NULL,
	[ContactName] [varchar](30) NULL,
	[ContactTitle] [varchar](30) NULL,
	[Address] [varchar](60) NULL,
	[City] [varchar](15) NULL,
	[Region] [varchar](15) NULL,
	[PostalCode] [varchar](10) NULL,
	[Country] [varchar](15) NULL,
	[Phone] [varchar](24) NULL,
	[Fax] [varchar](24) NULL,
	[IdPays2] [int] NULL,
 CONSTRAINT [PK_FrenchCustomers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


