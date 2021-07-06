SELECT DISTINCT Pilote, Nom 
FROM dbo.vol, dbo.Pilote 
WHERE Pilote = Pil# AND VilleDepart = 'Nice';
