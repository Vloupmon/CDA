USE [StagiairesDB]

BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_PERSONNE
(
	IDPERSONNE int NOT NULL IDENTITY (1, 1),
	PRENOM varchar(255) NOT NULL,
	NOM varchar(255) NOT NULL,
	ADRESSEMAIL varchar(255) NULL
)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_PERSONNE SET (LOCK_ESCALATION = TABLE)
GO
SET IDENTITY_INSERT dbo.Tmp_PERSONNE ON
GO
IF EXISTS(SELECT *
FROM dbo.PERSONNE)
	 EXEC('INSERT INTO dbo.Tmp_PERSONNE (IDPERSONNE, PRENOM, NOM, ADRESSEMAIL)
		SELECT IDPERSONNE, PRENOM, NOM, ADRESSEMAIL FROM dbo.PERSONNE WITH (HOLDLOCK TABLOCKX)')
GO
SET IDENTITY_INSERT dbo.Tmp_PERSONNE OFF
GO
ALTER TABLE dbo.EMPLOYER
	DROP CONSTRAINT FK_EMPLOYER_EMPLOYER2_PERSONNE
GO
ALTER TABLE dbo.FORMATEUR
	DROP CONSTRAINT FK_FORMATEUR_PERSONNE
GO
ALTER TABLE dbo.STAGIAIRE
	DROP CONSTRAINT FK_STAGIAIR_SPECIALIS_PERSONNE
GO
DROP TABLE dbo.PERSONNE
GO
EXECUTE sp_rename N'dbo.Tmp_PERSONNE', N'PERSONNE', 'OBJECT' 
GO
ALTER TABLE dbo.PERSONNE ADD CONSTRAINT
	PK_PERSONNE PRIMARY KEY NONCLUSTERED 
	(
	IDPERSONNE
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Tmp_STAGIAIRE
(
	IDPERSONNE int NOT NULL,
	DATENAISSANCE date NOT NULL,
	MATRICULESTAGIAIRE char(8) NOT NULL
)  ON [PRIMARY]
GO
ALTER TABLE dbo.Tmp_STAGIAIRE SET (LOCK_ESCALATION = TABLE)
GO
IF EXISTS(SELECT *
FROM dbo.STAGIAIRE)
	 EXEC('INSERT INTO dbo.Tmp_STAGIAIRE (IDPERSONNE, DATENAISSANCE, MATRICULESTAGIAIRE)
		SELECT IDPERSONNE, DATENAISSANCE, MATRICULESTAGIAIRE FROM dbo.STAGIAIRE WITH (HOLDLOCK TABLOCKX)')
GO
ALTER TABLE dbo.PARTICIPER_A
	DROP CONSTRAINT FK__PARTICI__PARTICIP_STAGIAIR
GO
DROP TABLE dbo.STAGIAIRE
GO
EXECUTE sp_rename N'dbo.Tmp_STAGIAIRE', N'STAGIAIRE', 'OBJECT' 
GO
ALTER TABLE dbo.STAGIAIRE ADD CONSTRAINT
	PK_STAGIAIRE PRIMARY KEY CLUSTERED 
	(
	IDPERSONNE
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.STAGIAIRE ADD CONSTRAINT
	FK_STAGIAIR_SPECIALIS_PERSONNE FOREIGN KEY
	(
	IDPERSONNE
	) REFERENCES dbo.PERSONNE
	(
	IDPERSONNE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PARTICIPER_A ADD CONSTRAINT
	FK__PARTICI__PARTICIP_STAGIAIR FOREIGN KEY
	(
	IDPERSONNE
	) REFERENCES dbo.STAGIAIRE
	(
	IDPERSONNE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PARTICIPER_A SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.FORMATEUR ADD CONSTRAINT
	FK_FORMATEUR_PERSONNE FOREIGN KEY
	(
	IDPERSONNE
	) REFERENCES dbo.PERSONNE
	(
	IDPERSONNE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.FORMATEUR SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.EMPLOYER ADD CONSTRAINT
	FK_EMPLOYER_EMPLOYER2_PERSONNE FOREIGN KEY
	(
	IDPERSONNE
	) REFERENCES dbo.PERSONNE
	(
	IDPERSONNE
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.EMPLOYER SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
GO