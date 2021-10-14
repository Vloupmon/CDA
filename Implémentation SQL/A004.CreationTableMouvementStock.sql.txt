USE [ComptoirAnglais_V1]
GO

IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MouvementDeStock_Products]') AND parent_object_id = OBJECT_ID(N'[dbo].[MouvementDeStock]'))
ALTER TABLE [dbo].[MouvementDeStock] DROP CONSTRAINT [FK_MouvementDeStock_Products]
GO

IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF_MouvementDeStock_dateLouvement]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[MouvementDeStock] DROP CONSTRAINT [DF_MouvementDeStock_dateLouvement]
END

GO

USE [ComptoirAnglais_V1]
GO

/****** Object:  Table [dbo].[MouvementDeStock]    Script Date: 07/15/2015 10:29:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MouvementDeStock]') AND type in (N'U'))
DROP TABLE [dbo].[MouvementDeStock]
GO

USE [ComptoirAnglais_V1]
GO

/****** Object:  Table [dbo].[MouvementDeStock]    Script Date: 07/15/2015 10:29:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[MouvementDeStock](
	[idMouvement] [int] IDENTITY(1,1) NOT NULL,
	[productID] [int] NOT NULL,
	[qteMouvement] [int] NOT NULL,
	[typeMouvement] [char](2) NOT NULL,
	[libelleMouvement] [nvarchar](100) NOT NULL,
	[dateMouvement] [datetime] NOT NULL,
 CONSTRAINT [PK_MouvementDeStock] PRIMARY KEY CLUSTERED 
(
	[idMouvement] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[MouvementDeStock]  WITH CHECK ADD  CONSTRAINT [FK_MouvementDeStock_Products] FOREIGN KEY([productID])
REFERENCES [dbo].[Products] ([ProductID])
GO

ALTER TABLE [dbo].[MouvementDeStock] CHECK CONSTRAINT [FK_MouvementDeStock_Products]
GO

ALTER TABLE [dbo].[MouvementDeStock] ADD  CONSTRAINT [DF_MouvementDeStock_dateLouvement]  DEFAULT (getdate()) FOR [dateMouvement]
GO


