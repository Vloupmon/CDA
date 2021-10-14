USE [StagiairesDB]
GO

BEGIN TRANSACTION
GO
ALTER TABLE STAGIAIRE
	ADD CONSTRAINT CKC_MATRICULE CHECK (
		MATRICULESTAGIAIRE
		LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'
	)
GO
COMMIT
GO