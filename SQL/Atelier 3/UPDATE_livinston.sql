UPDATE dbo.Employees
SET BirthDate = CONVERT(DATETIME, '1973-06-30', 102)
WHERE LastName = 'livinston' AND FirstName = 'Janet';