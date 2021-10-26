USE [Bibliotheque]
GO
/****** Object:  Table [dbo].[Adherent]    Script Date: 18/09/2019 20:40:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adherent](
	[IdAdherent] [nchar](10) NOT NULL,
	[NomAdherent] [nvarchar](50) NOT NULL,
	[PrenomAdherent] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Adherent] PRIMARY KEY CLUSTERED 
(
	[IdAdherent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exemplaire]    Script Date: 18/09/2019 20:40:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exemplaire](
	[IdExemplaire] [int] IDENTITY(1,1) NOT NULL,
	[Empruntable] [bit] NOT NULL,
	[ISBN] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Exemplaire] PRIMARY KEY CLUSTERED 
(
	[IdExemplaire] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Livre]    Script Date: 18/09/2019 20:40:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Livre](
	[ISBN] [nchar](10) NOT NULL,
	[Titre] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_Livre] PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pret]    Script Date: 18/09/2019 20:40:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pret](
	[IdAdherent] [nchar](10) NOT NULL,
	[IdExemplaire] [int] NOT NULL,
	[DateEmprunt] [date] NOT NULL,
	[DateRetour] [date] NULL,
 CONSTRAINT [PK_Pret] PRIMARY KEY CLUSTERED 
(
	[IdAdherent] ASC,
	[IdExemplaire] ASC,
	[DateEmprunt] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Adherent] ([IdAdherent], [NomAdherent], [PrenomAdherent]) VALUES (N'A001      ', N'Bost', N'Vincentico')
INSERT [dbo].[Adherent] ([IdAdherent], [NomAdherent], [PrenomAdherent]) VALUES (N'A002      ', N'Morillon', N'Jeannot')
INSERT [dbo].[Adherent] ([IdAdherent], [NomAdherent], [PrenomAdherent]) VALUES (N'A003      ', N'Goddaert', N'Elisabeth')
INSERT [dbo].[Adherent] ([IdAdherent], [NomAdherent], [PrenomAdherent]) VALUES (N'A007      ', N'Alertino', N'Jose')
INSERT [dbo].[Adherent] ([IdAdherent], [NomAdherent], [PrenomAdherent]) VALUES (N'A8700     ', N'Lauterbach', N'Roberto')
INSERT [dbo].[Adherent] ([IdAdherent], [NomAdherent], [PrenomAdherent]) VALUES (N'A8702     ', N'Lauterbach', N'Dekel')
INSERT [dbo].[Adherent] ([IdAdherent], [NomAdherent], [PrenomAdherent]) VALUES (N'A9087     ', N'Feugeas', N'Anatole')
INSERT [dbo].[Adherent] ([IdAdherent], [NomAdherent], [PrenomAdherent]) VALUES (N'GB01223452', N'Guionie', N'Lucien')
SET IDENTITY_INSERT [dbo].[Exemplaire] ON 

INSERT [dbo].[Exemplaire] ([IdExemplaire], [Empruntable], [ISBN]) VALUES (1, 1, N'0123456789')
INSERT [dbo].[Exemplaire] ([IdExemplaire], [Empruntable], [ISBN]) VALUES (2, 0, N'1234567890')
INSERT [dbo].[Exemplaire] ([IdExemplaire], [Empruntable], [ISBN]) VALUES (3, 1, N'0123456789')
INSERT [dbo].[Exemplaire] ([IdExemplaire], [Empruntable], [ISBN]) VALUES (4, 1, N'1234567890')
INSERT [dbo].[Exemplaire] ([IdExemplaire], [Empruntable], [ISBN]) VALUES (5, 1, N'2345678901')
INSERT [dbo].[Exemplaire] ([IdExemplaire], [Empruntable], [ISBN]) VALUES (6, 1, N'2345678901')
SET IDENTITY_INSERT [dbo].[Exemplaire] OFF
INSERT [dbo].[Livre] ([ISBN], [Titre]) VALUES (N'0123456789', N'Linq to EF Core')
INSERT [dbo].[Livre] ([ISBN], [Titre]) VALUES (N'1234567890', N'Design Patterns catalogue de conception réutilisables')
INSERT [dbo].[Livre] ([ISBN], [Titre]) VALUES (N'2345678901', N'Pratique du Design web')
INSERT [dbo].[Livre] ([ISBN], [Titre]) VALUES (N'3456789012', N'SOA microservices API Management')
INSERT [dbo].[Pret] ([IdAdherent], [IdExemplaire], [DateEmprunt], [DateRetour]) VALUES (N'A001      ', 1, CAST(N'2020-01-01' AS Date), CAST(N'2020-01-05' AS Date))
INSERT [dbo].[Pret] ([IdAdherent], [IdExemplaire], [DateEmprunt], [DateRetour]) VALUES (N'A001      ', 2, CAST(N'2020-01-02' AS Date), NULL)
INSERT [dbo].[Pret] ([IdAdherent], [IdExemplaire], [DateEmprunt], [DateRetour]) VALUES (N'A002      ', 1, CAST(N'2020-01-06' AS Date), CAST(N'2020-01-15' AS Date))
INSERT [dbo].[Pret] ([IdAdherent], [IdExemplaire], [DateEmprunt], [DateRetour]) VALUES (N'A002      ', 3, CAST(N'2020-01-01' AS Date), NULL)
INSERT [dbo].[Pret] ([IdAdherent], [IdExemplaire], [DateEmprunt], [DateRetour]) VALUES (N'A8700     ', 1, CAST(N'2020-01-16' AS Date), CAST(N'2020-01-17' AS Date))
ALTER TABLE [dbo].[Exemplaire]  WITH CHECK ADD  CONSTRAINT [FK_Exemplaire_Livre] FOREIGN KEY([ISBN])
REFERENCES [dbo].[Livre] ([ISBN])
GO
ALTER TABLE [dbo].[Exemplaire] CHECK CONSTRAINT [FK_Exemplaire_Livre]
GO
ALTER TABLE [dbo].[Pret]  WITH CHECK ADD  CONSTRAINT [FK_Pret_Adherent] FOREIGN KEY([IdAdherent])
REFERENCES [dbo].[Adherent] ([IdAdherent])
GO
ALTER TABLE [dbo].[Pret] CHECK CONSTRAINT [FK_Pret_Adherent]
GO
ALTER TABLE [dbo].[Pret]  WITH CHECK ADD  CONSTRAINT [FK_Pret_Exemplaire] FOREIGN KEY([IdExemplaire])
REFERENCES [dbo].[Exemplaire] ([IdExemplaire])
GO
ALTER TABLE [dbo].[Pret] CHECK CONSTRAINT [FK_Pret_Exemplaire]
GO
