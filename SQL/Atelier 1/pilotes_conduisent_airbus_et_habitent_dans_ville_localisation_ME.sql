SELECT DISTINCT T.Nom
FROM dbo.avion, (SELECT DISTINCT Nom, Ville
FROM dbo.Pilote, dbo.vol, dbo.avion
WHERE Pil# = Pilote
    AND Avion = Av#
    AND Marque = 'Airbus') AS T
WHERE Localisation = T.Ville;