/* Liste des produits de la cat�gorie Produits de la mer */
select productid, productname from Products
	inner join Categories
		on products.CategoryID=Categories.CategoryID
where Categories.CategoryName='seafood'
--
/* Liste des clients n'ayant pas command� depuis 5 ans 
Il est n�cessaire de traiter les clients n'ayant jamais command� 

Attention aux op�rations sur dates et portions de date
*/
-- incorrecte retient le client dont l'une des commandes r�pond � la condition
select distinct C.customerID,C.CompanyName 
from Customers C inner join Orders O
on c.CustomerID = O.CustomerID
Where DATEADD(year,-5,GETDATE()) > o.OrderDate
order by C.CustomerID;
-- idem pr�c�dent mais avec ceux qui n'ont pas command�
select distinct C.customerID,C.CompanyName 
from Customers C left outer join Orders O
on c.CustomerID = O.CustomerID
Where DATEADD(year,-5,GETDATE()) > o.OrderDate 
or o.OrderDate is null
order by CustomerID;

-- correct mais compliqu� et peu performant (corr�lation requ�te interne et externe)
select customerID,CompanyName from Customers
where customerID not in (select customerID from Orders)
union 
select C.customerID,C.CompanyName from Customers C
Where DATEADD(year,-5,GETDATE()) > all (select OrderDate from Orders where Orders.CustomerID = C.customerID)
order by CustomerID

/* plus simple et plus performant */ 

select customerID,CompanyName from Customers
where customerID not in 
(select O.customerID from orders O
Where O.OrderDate > DATEADD(year,-5,GETDATE()))


/*
Fournisseurs avec moins de 3 produits r�f�renc�s  
*/
select Products.SupplierID, suppliers.CompanyName, count(products.SupplierID) as "NombreR�f�rences"
from Products
inner join suppliers on Products.SupplierID=Suppliers.SupplierID
group by Products.SupplierID, suppliers.CompanyName
having count(products.SupplierID)<3

/*
Salari�s avec leur responsable hi�rarchique  
*/
select E2.LastName "Responsable", E1.LastName, E1.Address, E1.City, E1.PostalCode
from Employees E1
	inner join Employees E2
		on E1.ReportsTo=E2.EmployeeID
order by E2.LastName

/*
Nombre de commandes par soci�t� de livraison
*/
select shippers.ShipperID, Shippers.CompanyName, count (orders.ShipVia) as  "NbreCommandes"
from Orders
inner join Shippers on orders.ShipVia=Shippers.ShipperID
group by shippers.ShipperID, Shippers.CompanyName
order by shippers.ShipperID

/*
D�lai moyen de livraison
*/
select AVG(DATEDIFF(day, Orders.OrderDate, Orders.ShippedDate)) as "D�laiMoyen"
from Orders

/*
Ratio de commandes trait�es par soci�t� de livraison
Illustration des nouvelles possibilit�s offertes par SQL 3 
Expression ou Valeur peut �tre une requ�te
*/
select shippers.ShipperID, Shippers.CompanyName, 
cast(round ( count (orders.ShipVia)/(select COUNT(orders.ShipVia)*1.00 from orders)*100.00, 3) as decimal(6,3)) as  "NbreCommandes"
from Orders
inner join Shippers on orders.ShipVia=Shippers.ShipperID
group by shippers.ShipperID, Shippers.CompanyName
order by shippers.ShipperID

/*
Les vues CA par Ann�e et par autre crit�re pour publication des donn�es
sous forme d'un tableau dynamique
Il est aussi possible de mettre en facteur ce qui est commun � chaque vue 
*/
CREATE VIEW [dbo].[CA_Categories_Annee] As -- Par cat�gorie et ann�e
SELECT     Categories.CategoryID,Categories.CategoryName,
 ROUND(
 SUM(dbo.[Order Details].Quantity * (dbo.[Order Details].UnitPrice * (1 - dbo.[Order Details].Discount)))
 , 2) AS CA,
 DATEPART(year,dbo.Orders.OrderDate) AS Annee
FROM         dbo.Customers INNER JOIN
                      dbo.Orders ON dbo.Customers.CustomerID = dbo.Orders.CustomerID INNER JOIN
                      dbo.[Order Details] ON dbo.Orders.OrderID = dbo.[Order Details].OrderID
					INNER join PRODUCTS on dbo.[Order Details].Productid = Products.Productid
					INNER JOIN Categories on Products.CategoryID = Categories.CategoryID
					
GROUP BY Categories.CategoryID,CategoryName, DATEPART(year, dbo.Orders.OrderDate)
GO

CREATE VIEW [dbo].[CA_Pays_Annee] As -- Par pays et ann�e
SSELECT dbo.Customers.IdPays2, dbo.Pays.LibellePays, YEAR(dbo.Orders.OrderDate) AS Annee, 
               ROUND(SUM(dbo.[Order Details].Quantity * (dbo.[Order Details].UnitPrice - dbo.[Order Details].UnitPrice * dbo.[Order Details].Discount)), 3) AS CA
FROM  dbo.Customers INNER JOIN
               dbo.Orders ON dbo.Customers.CustomerID = dbo.Orders.CustomerID INNER JOIN
               dbo.[Order Details] ON dbo.Orders.OrderID = dbo.[Order Details].OrderID INNER JOIN
               dbo.Pays ON dbo.Customers.IdPays2 = dbo.Pays.idPays2
GROUP BY dbo.Customers.IdPays2, YEAR(dbo.Orders.OrderDate), dbo.Pays.LibellePays
GO

CREATE VIEW [dbo].[CA_Employe_Annee] As -- Par Employe et ann�e
SELECT     dbo.Orders.EmployeeID,LastName,Address,City,PostalCode,Country,
 CAST(ROUND(
 SUM(dbo.[Order Details].Quantity * (dbo.[Order Details].UnitPrice * (1 - dbo.[Order Details].Discount)))
 , 2) As Decimal(9,2)) AS CA,
 DATEPART(year,dbo.Orders.OrderDate) AS Annee
FROM    dbo.Orders  INNER JOIN
                      dbo.[Order Details] ON dbo.Orders.OrderID = dbo.[Order Details].OrderID
					INNER join EMPLOYEES on Orders.EmployeeID = Employees.EmployeeID
GROUP BY dbo.Orders.EmployeeID,LastName,Address,City,PostalCode,Country, DATEPART(year, dbo.Orders.OrderDate)
GO
/*
Les vues CA par Ann�e et par autre crit�re pour publication des donn�es
sous forme d'un tableau dynamique
Il est aussi possible de mettre en facteur ce qui est commun � chaque vue : le CA d'une ligne de commande
Les attributs pour liaisons futurs sont conserv�s ici dans un souci de simplification des autres vues d�pendantes
*/
CREATE VIEW [dbo].CALigneCommande
AS
SELECT DATEPART(yy, dbo.Orders.OrderDate) AS Ann�e, ROUND((dbo.[Order Details].Quantity * dbo.[Order Details].UnitPrice) * (1 - dbo.[Order Details].Discount), 2) 
               AS CA, dbo.[Order Details].OrderID, dbo.[Order Details].ProductID, dbo.Orders.CustomerID, dbo.Orders.EmployeeID as Vendeur
FROM  dbo.[Order Details] INNER JOIN
               dbo.Orders ON dbo.[Order Details].OrderID = dbo.Orders.OrderID

GO
-- Par cat�gorie et ann�e
CREATE VIEW [dbo].CA_Categories_Annee
AS
SELECT VG.Ann�e, C.CategoryName, ROUND(SUM(VG.CA), 2) AS CA
FROM  dbo.Categories AS C INNER JOIN
               dbo.Products AS P ON C.CategoryID = P.CategoryID INNER JOIN
               dbo.CALigneCommande AS VG ON P.ProductID = VG.ProductID
GROUP BY VG.Ann�e, C.CategoryName
GO
