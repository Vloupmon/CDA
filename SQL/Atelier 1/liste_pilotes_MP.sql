SELECT Pil#, Nom, Av#, Marque, TypeAvion,
VilleDepart, VilleArrivee, HeureDepart, HeureArrivee
FROM dbo.Pilote
INNER JOIN dbo.vol ON Pil# = Pilote
INNER JOIN dbo.avion ON Avion = Av#;
