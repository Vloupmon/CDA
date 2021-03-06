USE [ADO_Net]
GO
/****** Object:  Table [dbo].[Mere]    Script Date: 07/20/2015 08:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mere](
	[IdMere] [int] IDENTITY(1,1) NOT NULL,
	[NomMere] [nvarchar](50) NOT NULL,
	[TS] [RowVersion] NOT NULL,
 CONSTRAINT [PK_Mere] PRIMARY KEY CLUSTERED 
(
	[IdMere] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Fille]    Script Date: 07/20/2015 08:41:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fille](
	[IdMere] [int] NOT NULL,
	[IdFille] [int] NOT NULL,
	[NomFille] [varchar](50) NOT NULL,
	[TS] [RowVersion] NOT NULL,
 CONSTRAINT [PK_Fille] PRIMARY KEY CLUSTERED 
(
	[IdMere] ASC,
	[IdFille] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[psMere_update]    Script Date: 07/20/2015 08:41:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[psMere_update]
	( @IdMere          	int
	, @NomMere         	nvarchar(50)
	, @TS_E            	RowVersion
	, @TS              	RowVersion output )
as

if not exists (select 1 from dbo.Mere
where IdMere = @IdMere
  and TS = @TS_E ) 
	return -2

update dbo.Mere
	set NomMere = @NomMere
where IdMere = @IdMere
  and TS = @TS_E

set nocount on
select @TS=TS from Mere where IdMere = @IdMere

return 0
GO
/****** Object:  StoredProcedure [dbo].[psMere_selectByID]    Script Date: 07/20/2015 08:41:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[psMere_selectByID]
	( @IdMere          	int
 )
as

select * from dbo.Mere
where IdMere = @IdMere
GO
/****** Object:  StoredProcedure [dbo].[psMere_selectAll]    Script Date: 07/20/2015 08:41:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[psMere_selectAll]
as

select * from dbo.Mere
GO
/****** Object:  StoredProcedure [dbo].[psMere_insert]    Script Date: 07/20/2015 08:41:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[psMere_insert]
	( @IdMere          	int output
	, @NomMere         	nvarchar(50)
	, @TS              	RowVersion output )
as

insert dbo.Mere
	( NomMere
) values (
	@NomMere
)

set nocount on
select @IdMere = SCOPE_IDENTITY()
select @TS=TS from Mere where IdMere = @IdMere
return 0
GO
/****** Object:  StoredProcedure [dbo].[psMere_delete]    Script Date: 07/20/2015 08:41:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[psMere_delete]
	( @IdMere          	int
	, @TS_E            	RowVersion )
as

if not exists (select 1 from Mere
where IdMere = @IdMere
  and TS = @TS_E ) 
	return -3

delete from dbo.Mere
where IdMere = @IdMere
  and TS = @TS_E

return 0
GO
/****** Object:  StoredProcedure [dbo].[psFille_update]    Script Date: 07/20/2015 08:41:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[psFille_update]
	( @IdMere           	int
	, @IdFille          	int
	, @NomFille         	varchar(50)
	, @TS_E             	RowVersion
	, @TS               	RowVersion output )
as

if not exists (select 1 from dbo.Fille
where IdMere = @IdMere
  and IdFille = @IdFille
  and TS = @TS_E ) 
	return -2

update dbo.Fille
	set NomFille = @NomFille
where IdMere = @IdMere
  and IdFille = @IdFille
  and TS = @TS_E

set nocount on
select @TS=TS from Fille where IdMere = @IdMere
  and IdFille = @IdFille

return 0
GO
/****** Object:  StoredProcedure [dbo].[psFille_selectByID]    Script Date: 07/20/2015 08:41:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[psFille_selectByID]
	( @IdMere           	int
	, @IdFille          	int
 )
as

select * from dbo.Fille
where IdMere = @IdMere
  and IdFille = @IdFille
GO
/****** Object:  StoredProcedure [dbo].[psFille_selectAll]    Script Date: 07/20/2015 08:41:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[psFille_selectAll]
as

select * from dbo.Fille
GO
/****** Object:  StoredProcedure [dbo].[psFille_insert]    Script Date: 07/20/2015 08:41:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[psFille_insert]
	( @IdMere           	int
	, @IdFille          	int=null
	, @NomFille         	varchar(50)
	, @TS               	RowVersion output)
as

insert dbo.Fille
	( IdMere
	, IdFille
	, NomFille
) values (
	@IdMere
	, @IdFille
	, @NomFille
)

set nocount on
select @TS=TS from Fille where IdMere = @IdMere
  and IdFille = @IdFille
return 0
GO
/****** Object:  StoredProcedure [dbo].[psFille_delete]    Script Date: 07/20/2015 08:41:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[psFille_delete]
	( @IdMere           	int
	, @IdFille          	int
	, @TS_E             	RowVersion )
as

if not exists (select 1 from Fille
where IdMere = @IdMere
  and IdFille = @IdFille
  and TS = @TS_E ) 
	return -3

delete from dbo.Fille
where IdMere = @IdMere
  and IdFille = @IdFille
  and TS = @TS_E

return 0
GO
/****** Object:  ForeignKey [FK_Fille_Mere]    Script Date: 07/20/2015 08:41:01 ******/
ALTER TABLE [dbo].[Fille]  WITH CHECK ADD  CONSTRAINT [FK_Fille_Mere] FOREIGN KEY([IdMere])
REFERENCES [dbo].[Mere] ([IdMere])
GO
ALTER TABLE [dbo].[Fille] CHECK CONSTRAINT [FK_Fille_Mere]
GO
