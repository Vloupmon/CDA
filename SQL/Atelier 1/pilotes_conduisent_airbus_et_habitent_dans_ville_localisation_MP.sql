SELECT
    DISTINCT T.Nom
FROM
    dbo.avion,
    (
        SELECT
            DISTINCT Nom,
            Ville
        FROM
            dbo.Pilote
            INNER JOIN dbo.vol ON Pil# = Pilote
            INNER JOIN dbo.avion ON Avion = Av#
        WHERE
            Marque = 'Airbus'
    ) AS T
WHERE
    Localisation = Ville;