SELECT
    T2.SupplierID,
    T1.CompanyName
FROM
    dbo.Suppliers AS T1,
    (
        SELECT
            T1.SupplierID
        FROM
            dbo.Products AS T1
        GROUP BY
            T1.SupplierID
        HAVING
            COUNT(T1.SupplierID) < 3
    ) AS T2
WHERE
    T1.SupplierID = T2.SupplierID;