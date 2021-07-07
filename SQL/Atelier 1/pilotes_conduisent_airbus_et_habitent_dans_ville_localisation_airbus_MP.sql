SELECT
    DISTINCT Nom
FROM
    dbo.Pilote
    INNER JOIN dbo.vol ON Pil# = Pilote
    INNER JOIN dbo.avion ON Avion = Av#
WHERE
    Marque = 'Airbus'
    AND Ville = Localisation;