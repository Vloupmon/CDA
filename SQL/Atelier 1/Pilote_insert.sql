SET IDENTITY_INSERT dbo.Pilote ON;
INSERT INTO dbo.Pilote (Pil#, Nom, Ville, CodePostal, DateNaissance, DateDebutActivite, DateFinActivite, SalaireBrut)
VALUES (55, 'Loupmon', 'Saint-Augustin', '19390','1990-08-14','2000-01-01', NULL, 66666);
SET IDENTITY_INSERT dbo.Pilote OFF;
