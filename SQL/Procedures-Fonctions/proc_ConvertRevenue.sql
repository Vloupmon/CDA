USE [ComptoirInternational];
GO

DROP PROCEDURE IF EXISTS dbo.ConvertRevenue;
GO

CREATE PROCEDURE ConvertRevenue
    @year INT
AS
RETURN (SELECT LibellePays, Annee, dbo.ConvertCurrency(CA, 'USD', IdPays2, DEFAULT, DEFAULT)
FROM dbo.CA_Pays_Annee);
GO