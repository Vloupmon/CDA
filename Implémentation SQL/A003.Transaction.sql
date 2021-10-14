DECLARE @NumCde Int
-- Début de la Transaction
BEGIN TRAN
INSERT INTO [Orders]
	([CustomerID],[EmployeeID],[OrderDate],[RequiredDate],[ShippedDate]
	,[ShipVia],[Freight],[ShipName],[ShipAddress],[ShipCity],[ShipRegion]
	,[ShipPostalCode],ShipCountry)
SELECT
	[CustomerID], [EmployeeID], [OrderDate], [RequiredDate], [ShippedDate], [ShipVia], [Freight], [ShipName], [ShipAddress], [ShipCity]
, [ShipRegion]
, [ShipPostalCode]
, [ShipCountry]
FROM Orders
WHERE OrderId = 10253
-- Récupération du N° de commande
SET @NumCde = SCOPE_IDENTITY()
PRINT @NUMCDE
-- Insertion des lignes de commandes
INSERT INTO [Order Details]
	([OrderID]
	,[ProductID]
	,[UnitPrice]
	,[Quantity]
	,[Discount])
VALUES
	(@Numcde
, 11 -- Mettre Code produit OK ( non en rupture)
, 20.34
, 10
, 0.259)
INSERT INTO [Order Details]
	([OrderID]
	,[ProductID]
	,[UnitPrice]
	,[Quantity]
	,[Discount])
VALUES
	(@Numcde
, 17 -- Code produit non OK (en rupture)
, 20.34
, 10
, 0.259)
-- Validation de la transaction
COMMIT TRAN