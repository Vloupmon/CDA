SELECT Pas#, Nom FROM dbo.Passager 
INNER JOIN dbo.AffecteVol ON Pas# = Passager
WHERE Prix > 1000;