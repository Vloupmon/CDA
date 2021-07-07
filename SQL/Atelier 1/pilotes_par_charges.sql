SELECT *, SalaireBrut * 0.75 as Charges
FROM dbo.Pilote
ORDER BY Charges DESC;
