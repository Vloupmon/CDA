SELECT Pas#, Nom FROM dbo.Passager, dbo.AffecteVol
WHERE Pas# = Passager AND Prix > 1000;