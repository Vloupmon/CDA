USE [ContactsDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 07/09/2021 09:52:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posts]    Script Date: 07/09/2021 09:52:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[Body] [nvarchar](max) NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 07/09/2021 09:52:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Address_Street] [nvarchar](max) NULL,
	[Address_Suite] [nvarchar](max) NULL,
	[Address_City] [nvarchar](max) NULL,
	[Address_ZipCode] [nvarchar](max) NULL,
	[Address_Geo_Latitude] [nvarchar](max) NULL,
	[Address_Geo_Longitude] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[BirthDay] [datetime2](7) NOT NULL,
	[PhotoUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191117193316_ContactsDBInit', N'3.0.0')
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (1, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'fkvxleut.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (3, N'Morillon', N'Jean Morillon', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'wk1gc3ab.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (4, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'UsersPhotos/1.png')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (5, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'UsersPhotos/1.png')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (6, N'Morillon', N'Jean Morillon', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (7, N'Morillon', N'Jean Morillon', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (8, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (9, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (10, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (11, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (12, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (13, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (14, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (15, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (16, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (17, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (18, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (19, N'Morillon', N'Jean Morillon', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (20, N'Morillon', N'Jean Morillon', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (21, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (22, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (23, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (24, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (25, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (26, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (27, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (28, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (29, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (30, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (31, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (32, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (33, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (34, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (35, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (36, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (37, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (38, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (39, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'qweb3rpj.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (40, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (41, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (42, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (43, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (44, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'okoukgkc.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (45, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'kgw4eucu.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (46, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'41tha5nq.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (47, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'zd54eiie.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (48, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'je25mord.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (49, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'wxpvunmf.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (50, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'cmz5epdk.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (51, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'kchvhgn2.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (52, N'LE THOMAS', N'YannLETHOMAS', N'exerebro@gmail.com', N'25 route de Marennes Oléron', N'', N'La Clisse', N'17600', N'45.7318', N'-0.7651', N'05 46 74 50 49', CAST(N'1996-11-04T00:00:00.0000000' AS DateTime2), N'C:\fakepath\YogaPA.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (53, N'LE THOMAS', N'YannLETHOMAS', N'exerebro@gmail.com', N'25 route la flemme', N'', N'La Clisse', N'17600', N'45.7318', N'-0.7651', N'05 05 05 05 05', CAST(N'1996-11-04T00:00:00.0000000' AS DateTime2), N'')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (54, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'v23y0hdw.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (55, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'00qqtdna.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (56, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (57, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'jmblhr33.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (58, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'5qxs2zp2.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (59, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (60, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'is2ds0la.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (61, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'42hatcfg.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (62, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'4nn4a4ad.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (63, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'cmeek3lx.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (64, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'rrvv4xrx.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (65, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'44ce4mij.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (66, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'olthopxv.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (67, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (68, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'2iab1tqg.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (69, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'yz0rypez.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (70, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (71, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (72, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'rcnen2he.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (73, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'dbxjdq20.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (74, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'sipc03f1.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (75, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'itda4jt0.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (76, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'mk4ajxz1.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (77, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'30smfoqq.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (78, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (79, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'eeipagqv.jpg')
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (80, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), NULL)
INSERT [dbo].[Users] ([UserId], [Name], [UserName], [Email], [Address_Street], [Address_Suite], [Address_City], [Address_ZipCode], [Address_Geo_Latitude], [Address_Geo_Longitude], [Phone], [BirthDay], [PhotoUrl]) VALUES (81, N'Bost', N'Vincent Bost', N'vincent.bost@afpa.fr', N'2 route de la Maurie Haut', N'La Maurie', N'Sainte Féréole', N'19270', N'45.2281', N'1.5828', N'06 40 75 27 78', CAST(N'1962-01-13T00:00:00.0000000' AS DateTime2), N'buh1hlbb.jpg')
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[Posts]  WITH CHECK ADD  CONSTRAINT [FK_Posts_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Posts] CHECK CONSTRAINT [FK_Posts_Users_UserId]
GO
