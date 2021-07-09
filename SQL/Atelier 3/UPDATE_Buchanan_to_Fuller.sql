DECLARE @FullerID INT;

DECLARE @BuchananID INT;

SELECT
    @FullerID = EmployeeID
FROM
    dbo.Employees
WHERE
    LastName = 'Fuller'
SELECT
    @BuchananID = EmployeeID
FROM
    dbo.Employees
WHERE
    LastName = 'Buchanan'
UPDATE
    dbo.Employees
SET
    ReportsTo = @FullerID
FROM
    dbo.Employees
WHERE
    ReportsTo = @BuchananID;