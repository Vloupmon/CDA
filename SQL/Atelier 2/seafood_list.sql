SELECT DISTINCT ProductName
FROM dbo.Categories AS T1 INNER JOIN dbo.Products AS T2 ON
T1.CategoryID = T2.CategoryID
WHERE CategoryName = 'Seafood';