SELECT Av#
FROM dbo.avion
WHERE Localisation != 'Nice'
AND Marque = 'AIRBUS'
AND Capacite IS NOT NULL;
