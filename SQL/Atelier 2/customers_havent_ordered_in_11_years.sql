(
    SELECT
        DISTINCT CustomerID
    FROM
        dbo.Customers
)
EXCEPT
    (
        SELECT
            DISTINCT T1.CustomerID
        FROM
            dbo.Customers AS T1
            INNER JOIN dbo.Orders AS T2 ON T1.CustomerID = T2.CustomerID
        WHERE
            DATEDIFF(
                YEAR,
                OrderDate,
                (
                    SELECT
                        GETDATE()
                )
            ) < 11
    );