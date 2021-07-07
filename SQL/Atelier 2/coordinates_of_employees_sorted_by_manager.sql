SELECT
    CONCAT(T1.LastName, ' ', T1.FirstName) AS Manager,
    T2.LastName,
    T2.FirstName,
    T2.Address,
    T2.City,
    T2.Region,
    T2.PostalCode,
    T2.Country,
    T2.HomePhone,
    T2.Extension
FROM
    dbo.Employees AS T1
    INNER JOIN (
        SELECT
            T1.ReportsTo,
            T2.LastName,
            T2.FirstName,
            T2.Address,
            T2.City,
            T2.Region,
            T2.PostalCode,
            T2.Country,
            T2.HomePhone,
            T2.Extension
        FROM
            dbo.Employees AS T1
            INNER JOIN dbo.Employees AS T2 ON T1.ReportsTo = T2.EmployeeID
    ) AS T2 ON T1.EmployeeID = T2.ReportsTo
ORDER BY
    Manager;