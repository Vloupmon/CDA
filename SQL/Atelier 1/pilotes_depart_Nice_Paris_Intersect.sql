SELECT Pilote FROM dbo.vol WHERE VilleDepart = 'Nice'
INTERSECT
SELECT Pilote FROM dbo.vol WHERE VilleDepart = 'Paris'
