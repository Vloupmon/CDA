UPDATE
    dbo.Products
SET
    P.UnitPrice = CASE
        CASE
            WHEN C.CategoryName = 'Seafood' THEN P.UnitPrice * 1.10
            WHEN C.CategoryName = 'Grains/Cereals' THEN P.UnitPrice * 1.05
            ELSE P.UnitPrice * 1.02
        END
        FROM
            dbo.Products P
            INNER JOIN dbo.Categories C ON P.CategoryID = C.CategoryID;