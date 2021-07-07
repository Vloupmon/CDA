SELECT
    DISTINCT Nom
FROM
    dbo.Pilote,
    dbo.vol,
    dbo.avion
WHERE
    Pil# = Pilote
    AND Avion = Av#
    AND Marque = 'Airbus'
    AND Localisation = Ville;