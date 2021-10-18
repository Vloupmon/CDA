USE [ComptoirAnglais_V1]
GO

CREATE TRIGGER [dbo].[MaintenanceStockRéservé] 
   ON  [dbo].[Order Details] 
   AFTER INSERT,UPDATE
   AS
BEGIN
    IF (SELECT COUNT(*)
    FROM INSERTED) > 1
		BEGIN;
        THROW 66666, 'Insertion invalide', 1;
    END;
    UPDATE [dbo].[Products]
    SET UnitsReserved = UnitsReserved + (SELECT Quantity
    FROM INSERTED)
    WHERE ProductID = (SELECT ProductID
    FROM INSERTED)
END;
GO

ALTER TABLE [dbo].[Order Details] ENABLE TRIGGER [MaintenanceStockRéservé]
GO
