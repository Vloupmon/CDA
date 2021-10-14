IF NOT EXISTS(SELECT *
FROM sys.databases
WHERE name = 'StagiairesDB')
  BEGIN
	CREATE DATABASE [StagiairesDB]
END
GO

USE [StagiairesDB]
GO
/****** Object:  Table [dbo].[PERSONNE]    Script Date: 10/11/2016 08:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT *
FROM sys.objects
WHERE object_id = OBJECT_ID(N'[dbo].[PERSONNE]') AND type in (N'U'))
BEGIN
	CREATE TABLE [dbo].[PERSONNE]
	(
		[IDPERSONNE] [int] NOT NULL,
		[PRENOM] [varchar](255) NOT NULL,
		[NOM] [varchar](255) NOT NULL,
		[ADRESSEMAIL] [varchar](255) NULL,
		CONSTRAINT [PK_PERSONNE] PRIMARY KEY NONCLUSTERED 
(
	[IDPERSONNE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ENTREPRISE]    Script Date: 10/11/2016 08:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT *
FROM sys.objects
WHERE object_id = OBJECT_ID(N'[dbo].[ENTREPRISE]') AND type in (N'U'))
BEGIN
	CREATE TABLE [dbo].[ENTREPRISE]
	(
		[SIRET] [char](14) NOT NULL,
		[RAISONSOCIALE] [varchar](255) NOT NULL,
		CONSTRAINT [PK_ENTREPRISE] PRIMARY KEY NONCLUSTERED 
(
	[SIRET] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FORMATEUR]    Script Date: 10/11/2016 08:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT *
FROM sys.objects
WHERE object_id = OBJECT_ID(N'[dbo].[FORMATEUR]') AND type in (N'U'))
BEGIN
	CREATE TABLE [dbo].[FORMATEUR]
	(
		[IDPERSONNE] [int] NOT NULL,
		[MATRICULEFORMATEUR] [char](7) NOT NULL,
		CONSTRAINT [PK_FORMATEUR] PRIMARY KEY CLUSTERED 
(
	[IDPERSONNE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMPLOYER]    Script Date: 10/11/2016 08:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT *
FROM sys.objects
WHERE object_id = OBJECT_ID(N'[dbo].[EMPLOYER]') AND type in (N'U'))
BEGIN
	CREATE TABLE [dbo].[EMPLOYER]
	(
		[SIRET] [char](14) NOT NULL,
		[IDPERSONNE] [int] NOT NULL,
		CONSTRAINT [PK_EMPLOYER] PRIMARY KEY CLUSTERED 
(
	[SIRET] ASC,
	[IDPERSONNE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STAGIAIRE]    Script Date: 10/11/2016 08:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT *
FROM sys.objects
WHERE object_id = OBJECT_ID(N'[dbo].[STAGIAIRE]') AND type in (N'U'))
BEGIN
	CREATE TABLE [dbo].[STAGIAIRE]
	(
		[IDPERSONNE] [int] NOT NULL,
		[DATENAISSANCE] [date] NOT NULL,
		[MATRICULESTAGIAIRE] [char](8) NOT NULL,
		CONSTRAINT [PK_STAGIAIRE] PRIMARY KEY CLUSTERED 
(
	[IDPERSONNE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OFFREFORMATION]    Script Date: 10/11/2016 08:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT *
FROM sys.objects
WHERE object_id = OBJECT_ID(N'[dbo].[OFFREFORMATION]') AND type in (N'U'))
BEGIN
	CREATE TABLE [dbo].[OFFREFORMATION]
	(
		[IDOFFRE] [int] NOT NULL,
		[IDResponsable] [int] NOT NULL,
		[LIBELLEOFFRE] [varchar](255) NOT NULL,
		[DATEDEBUTOFFRE] [date] NOT NULL,
		[DATEFINOFFRE] [date] NOT NULL,
		CONSTRAINT [PK_OFFREFORMATION] PRIMARY KEY NONCLUSTERED 
(
	[IDOFFRE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PARTICIPER_A]    Script Date: 10/11/2016 08:48:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT *
FROM sys.objects
WHERE object_id = OBJECT_ID(N'[dbo].[PARTICIPER_A]') AND type in (N'U'))
BEGIN
	CREATE TABLE [dbo].[PARTICIPER_A]
	(
		[IDPERSONNE] [int] NOT NULL,
		[IDOFFRE] [int] NOT NULL,
		[DATEENTREEFORMATION] [datetime] NULL,
		[DATESORTIEFORMATION] [datetime] NULL,
		CONSTRAINT [PK__PARTICIPER_A] PRIMARY KEY CLUSTERED 
(
	[IDPERSONNE] ASC,
	[IDOFFRE] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
	) ON [PRIMARY]
END
GO
/****** Object:  ForeignKey [FK_EMPLOYER_EMPLOYER_ENTREPRI]    Script Date: 10/11/2016 08:48:07 ******/
IF NOT EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK_EMPLOYER_EMPLOYER_ENTREPRI]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYER]'))
ALTER TABLE [dbo].[EMPLOYER]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYER_EMPLOYER_ENTREPRI] FOREIGN KEY([SIRET])
REFERENCES [dbo].[ENTREPRISE] ([SIRET])
GO
IF  EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK_EMPLOYER_EMPLOYER_ENTREPRI]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYER]'))
ALTER TABLE [dbo].[EMPLOYER] CHECK CONSTRAINT [FK_EMPLOYER_EMPLOYER_ENTREPRI]
GO
/****** Object:  ForeignKey [FK_EMPLOYER_EMPLOYER2_PERSONNE]    Script Date: 10/11/2016 08:48:07 ******/
IF NOT EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK_EMPLOYER_EMPLOYER2_PERSONNE]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYER]'))
ALTER TABLE [dbo].[EMPLOYER]  WITH CHECK ADD  CONSTRAINT [FK_EMPLOYER_EMPLOYER2_PERSONNE] FOREIGN KEY([IDPERSONNE])
REFERENCES [dbo].[PERSONNE] ([IDPERSONNE])
GO
IF  EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK_EMPLOYER_EMPLOYER2_PERSONNE]') AND parent_object_id = OBJECT_ID(N'[dbo].[EMPLOYER]'))
ALTER TABLE [dbo].[EMPLOYER] CHECK CONSTRAINT [FK_EMPLOYER_EMPLOYER2_PERSONNE]
GO
/****** Object:  ForeignKey [FK_FORMATEUR_PERSONNE]    Script Date: 10/11/2016 08:48:07 ******/
IF NOT EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMATEUR_PERSONNE]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMATEUR]'))
ALTER TABLE [dbo].[FORMATEUR]  WITH CHECK ADD  CONSTRAINT [FK_FORMATEUR_PERSONNE] FOREIGN KEY([IDPERSONNE])
REFERENCES [dbo].[PERSONNE] ([IDPERSONNE])
GO
IF  EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK_FORMATEUR_PERSONNE]') AND parent_object_id = OBJECT_ID(N'[dbo].[FORMATEUR]'))
ALTER TABLE [dbo].[FORMATEUR] CHECK CONSTRAINT [FK_FORMATEUR_PERSONNE]
GO
/****** Object:  ForeignKey [FK_OFFREFORMATION_FORMATEUR]    Script Date: 10/11/2016 08:48:07 ******/
IF NOT EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK_OFFREFORMATION_FORMATEUR]') AND parent_object_id = OBJECT_ID(N'[dbo].[OFFREFORMATION]'))
ALTER TABLE [dbo].[OFFREFORMATION]  WITH CHECK ADD  CONSTRAINT [FK_OFFREFORMATION_FORMATEUR] FOREIGN KEY([IDResponsable])
REFERENCES [dbo].[FORMATEUR] ([IDPERSONNE])
GO
IF  EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK_OFFREFORMATION_FORMATEUR]') AND parent_object_id = OBJECT_ID(N'[dbo].[OFFREFORMATION]'))
ALTER TABLE [dbo].[OFFREFORMATION] CHECK CONSTRAINT [FK_OFFREFORMATION_FORMATEUR]
GO
/****** Object:  ForeignKey [FK__PARTICI__PARTICIP_OFFREFOR]    Script Date: 10/11/2016 08:48:07 ******/
IF NOT EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK__PARTICI__PARTICIP_OFFREFOR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PARTICIPER_A]'))
ALTER TABLE [dbo].[PARTICIPER_A]  WITH CHECK ADD  CONSTRAINT [FK__PARTICI__PARTICIP_OFFREFOR] FOREIGN KEY([IDOFFRE])
REFERENCES [dbo].[OFFREFORMATION] ([IDOFFRE])
GO
IF  EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK__PARTICI__PARTICIP_OFFREFOR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PARTICIPER_A]'))
ALTER TABLE [dbo].[PARTICIPER_A] CHECK CONSTRAINT [FK__PARTICI__PARTICIP_OFFREFOR]
GO
/****** Object:  ForeignKey [FK__PARTICI__PARTICIP_STAGIAIR]    Script Date: 10/11/2016 08:48:07 ******/
IF NOT EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK__PARTICI__PARTICIP_STAGIAIR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PARTICIPER_A]'))
ALTER TABLE [dbo].[PARTICIPER_A]  WITH CHECK ADD  CONSTRAINT [FK__PARTICI__PARTICIP_STAGIAIR] FOREIGN KEY([IDPERSONNE])
REFERENCES [dbo].[STAGIAIRE] ([IDPERSONNE])
GO
IF  EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK__PARTICI__PARTICIP_STAGIAIR]') AND parent_object_id = OBJECT_ID(N'[dbo].[PARTICIPER_A]'))
ALTER TABLE [dbo].[PARTICIPER_A] CHECK CONSTRAINT [FK__PARTICI__PARTICIP_STAGIAIR]
GO
/****** Object:  ForeignKey [FK_STAGIAIR_SPECIALIS_PERSONNE]    Script Date: 10/11/2016 08:48:07 ******/
IF NOT EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK_STAGIAIR_SPECIALIS_PERSONNE]') AND parent_object_id = OBJECT_ID(N'[dbo].[STAGIAIRE]'))
ALTER TABLE [dbo].[STAGIAIRE]  WITH CHECK ADD  CONSTRAINT [FK_STAGIAIR_SPECIALIS_PERSONNE] FOREIGN KEY([IDPERSONNE])
REFERENCES [dbo].[PERSONNE] ([IDPERSONNE])
GO
IF  EXISTS (SELECT *
FROM sys.foreign_keys
WHERE object_id = OBJECT_ID(N'[dbo].[FK_STAGIAIR_SPECIALIS_PERSONNE]') AND parent_object_id = OBJECT_ID(N'[dbo].[STAGIAIRE]'))
ALTER TABLE [dbo].[STAGIAIRE] CHECK CONSTRAINT [FK_STAGIAIR_SPECIALIS_PERSONNE]
GO
