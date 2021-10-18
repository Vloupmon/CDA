USE [ComptoirAnglais_V1]
GO

CREATE TRIGGER [dbo].[VerifierLivraison] 
   ON  [dbo].[Order Details] 
   AFTER INSERT,UPDATE
AS 
BEGIN
	if (exists(select 1
	from inserted I inner join Products P
		on i.ProductID = p.ProductID inner join Orders O on
	i.OrderID = o.OrderID
	where p.Discontinued='true'
		AND DATEDIFF(WEEK,o.OrderDate,o.RequiredDate)<3))
	Begin;
		throw 60001,'La livraison de commande ne peut pas être honorée du fait de la rupture de stock d''un des produits commandés',1
	end
END
GO

ALTER TABLE [dbo].[Order Details] ENABLE TRIGGER [VerifierLivraison]
GO
