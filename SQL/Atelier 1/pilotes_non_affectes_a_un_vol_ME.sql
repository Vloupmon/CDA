SELECT Pil#, Nom
FROM dbo.Pilote
WHERE Pil# NOT IN (SELECT Pilote FROM dbo.vol);
