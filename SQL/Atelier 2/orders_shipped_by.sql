SELECT
    T1.ShipperID,
    COUNT(*) AS Orders
FROM
    (
        SELECT
            T1.ShipperID
        FROM
            dbo.Shippers AS T1
            INNER JOIN dbo.Orders AS T2 ON T1.ShipperID = T2.ShipVia
    ) AS T1
GROUP BY
    T1.ShipperID
ORDER BY
    T1.ShipperID;