USE [StagiairesDB]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER Date_Check ON  PARTICIPER_A
   AFTER INSERT
AS 
BEGIN
	IF (SELECT COUNT(*)
	FROM INSERTED) > 1
		BEGIN;
		THROW 66666, 'Insertion invalide', 1;
		ROLLBACK TRANSACTION;
		RETURN
	END;
	IF ((SELECT DATEENTREEFORMATION
		FROM INSERTED) <  (SELECT DATEDEBUTOFFRE
		FROM OFFREFORMATION))
		OR ((SELECT DATESORTIEFORMATION
		FROM INSERTED) >  (SELECT DATEFINOFFRE
		FROM OFFREFORMATION))
		BEGIN;
		THROW 66667, 'Date invalide', 1;
		ROLLBACK TRANSACTION;
		RETURN
	END;
END;
GO		