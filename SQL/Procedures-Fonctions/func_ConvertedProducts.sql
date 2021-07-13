USE [ComptoirInternational];
GO

DROP FUNCTION IF EXISTS dbo.ConvertedProducts;
GO

CREATE FUNCTION ConvertedProducts (
    @targetCountry VARCHAR(2) = NULL,
    @targetCurrency VARCHAR(3) = NULL,
    @date DATE = NULL
)
RETURNS TABLE
AS
RETURN (
    SELECT ProductID, ProductName,
    dbo.ConvertCurrency(UnitPrice, 'USD', @targetCountry, @targetCurrency, @date) as UnitPrice
FROM dbo.Products
    );
GO