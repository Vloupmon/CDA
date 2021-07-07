SELECT
    T1.Pil#, T2.Pil#
FROM
    dbo.Pilote T1
    INNER JOIN dbo.Pilote T2 ON T1.Ville = T2.Ville
    AND T1.Pil# < T2.Pil#;