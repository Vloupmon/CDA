USE [Papyrus]
GO
/****** Objet?: Table [PRODUIT] ******/
CREATE TABLE [PRODUIT](
	[CODART] [char](4) NOT NULL,
	[LIBART] [varchar](25) NOT NULL,
	[STKALE] [smallint] NOT NULL,
	[STKPHY] [smallint] NOT NULL,
	[QTEANN] [smallint] NOT NULL,
	[UNIMES] [char](5) NOT NULL,
CONSTRAINT [PK_PRODUIT] PRIMARY KEY CLUSTERED
(
	[CODART] ASC
)WITH (PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Objet?: Table [FOURNIS] ******/
CREATE TABLE [FOURNIS](
	[NUMFOU] [int] NOT NULL,
	[NOMFOU] [varchar](30) NOT NULL,
	[RUEFOU] [varchar](30) NOT NULL,
	[POSFOU] [char](5) NOT NULL,
	[VILFOU] [varchar](25) NOT NULL,
	[CONFOU] [varchar](15) NOT NULL,
	[SATISF] [tinyint]  NULL,
CONSTRAINT [PK_FOURNIS] PRIMARY KEY CLUSTERED
(
	[NUMFOU] ASC
)WITH (PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Objet?: Table [VENTE] ******/
CREATE TABLE [VENTE](
	[CODART] [char](4) NOT NULL,
	[NUMFOU] [int] NOT NULL,
	[DELLIV] [smallint] NOT NULL,
	[QTE1] [smallint] NOT NULL,
	[PRIX1] [money] NOT NULL,
	[QTE2] [smallint] NULL,
	[PRIX2] [money] NULL,
	[QTE3] [smallint] NULL,
	[PRIX3] [money] NULL,
CONSTRAINT [PK_VENTE] PRIMARY KEY CLUSTERED
(
	[CODART] ASC,
[NUMFOU] ASC
)WITH (PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/****** Contrainte?: Vente-Fournisseur ******/
ALTER TABLE [VENTE] WITH CHECK ADD CONSTRAINT [FK_VENTE_FOURNIS]
	FOREIGN KEY([NUMFOU])
	REFERENCES [FOURNIS] ([NUMFOU])
GO

/****** Contrainte?: Vente-produit ******/
ALTER TABLE [VENTE] WITH CHECK ADD CONSTRAINT [FK_VENTE_PRODUIT]
	FOREIGN KEY([CODART])
	REFERENCES [PRODUIT] ([CODART])
GO
