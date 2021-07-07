SELECT Pil#, Nom
FROM dbo.Pilote
WHERE Pil# IN (SELECT Pil# FROM dbo.Pilote
EXCEPT
SELECT Pilote FROM dbo.vol);
