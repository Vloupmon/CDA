DELIMITER //

CREATE procedure Adherent_Insert
(
p_IdAdherent nchar(10),
p_NomAdherent nvarchar(50),
p_PrenomAdherent nvarchar(50)
)

BEGIN  

INSERT INTO Adherent
(
IdAdherent,
NomAdherent,
PrenomAdherent
)
VALUES
(
p_IdAdherent,
p_NomAdherent,
p_PrenomAdherent
);

SELECT IdAdherent,
NomAdherent,
PrenomAdherent INTO p_IdAdherent, p_NomAdherent, p_PrenomAdherent FROM Adherent
Where p_IdAdherent = IdAdherent;

END;

//

DELIMITER ;Adherent_Insert

DELIMITER //

CREATE procedure Adherent_Update
(
p_IdAdherent nchar(10),
p_NomAdherent nvarchar(50),
p_PrenomAdherent nvarchar(50)
)

BEGIN  

UPDATE Adherent
SET
NomAdherent=p_NomAdherent,
PrenomAdherent=p_PrenomAdherent
WHERE
IdAdherent=p_IdAdherent;
END;
//

DELIMITER ;


DELIMITER //

CREATE procedure Exemplaire_Delete
(
p_IdExemplaire int
)

BEGIN 
DELETE FROM `dbo`.`Exemplaire`
WHERE
IdExemplaire=p_IdExemplaire;
END;
//

DELIMITER ;


DELIMITER //

CREATE procedure Exemplaire_Insert
(
OUT p_IdExemplaire  int,
p_Empruntable tinyint,
p_ISBN nchar(10)
)

BEGIN

INSERT INTO Exemplaire
(
Empruntable,
ISBN
)
VALUES
(
p_Empruntable,
p_ISBN	
);
SET p_IdExemplaire = LAST_INSERT_ID(); 

SELECT IdExemplaire,
 Empruntable,
 ISBN INTO p_IdExemplaire, p_Empruntable, p_ISBN FROM Exemplaire
Where p_IdExemplaire = IdExemplaire;
END;
//

DELIMITER ;


DELIMITER //

CREATE procedure Exemplaire_Update
(
p_IdExemplaire int,
p_Empruntable tinyint,
p_ISBN nchar(10)
)

BEGIN  

UPDATE Exemplaire
SET
Empruntable=p_Empruntable,
ISBN=p_ISBN
WHERE
IdExemplaire=p_IdExemplaire;
END;
//

DELIMITER ;

DELIMITER //

CREATE procedure Livre_Delete
(
p_ISBN nchar(10)
)

BEGIN 

DELETE FROM `dbo`.`Livre`
WHERE
ISBN=p_ISBN;
END;
//

DELIMITER ;

DELIMITER //

CREATE procedure Livre_Insert
(
p_ISBN nchar(10),
p_Titre nvarchar(50)
)

BEGIN

INSERT INTO Livre
(
ISBN,
Titre
)
VALUES
(
p_ISBN,
p_Titre	
);

SELECT ISBN,
 Titre INTO p_ISBN, p_Titre FROM Livre
Where p_ISBN = ISBN;
END;
//

DELIMITER ;

DELIMITER //

CREATE procedure Livre_Update
(
p_ISBN nchar(10),
p_Titre nvarchar(50)
)

BEGIN  

UPDATE Livre
SET
Titre=p_Titre
WHERE
ISBN=p_ISBN;
END;
//

DELIMITER ;

DELIMITER //

CREATE procedure Pret_Delete
(
p_IdAdherent nchar(10),
p_IdExemplaire int,
p_DateEmprunt date
)

BEGIN 

DELETE FROM `dbo`.`Pret`
WHERE
IdAdherent=p_IdAdherent AND IdExemplaire=p_IdExemplaire AND DateEmprunt=p_DateEmprunt;
END;
//

DELIMITER ;

DELIMITER //

CREATE procedure Pret_Insert
(
p_IdAdherent nchar(10),
p_IdExemplaire int,
p_DateEmprunt date,
p_DateRetour date/* =null */
)

BEGIN

INSERT INTO Pret
(
IdAdherent,
IdExemplaire,
DateEmprunt,
DateRetour
)
VALUES
(
p_IdAdherent,
p_IdExemplaire,
p_DateEmprunt,
p_DateRetour	
);

SELECT IdAdherent,
 IdExemplaire,
 DateEmprunt,
 DateRetour INTO p_IdAdherent, p_IdExemplaire, p_DateEmprunt, p_DateRetour FROM Pret
Where p_IdAdherent = IdAdherent AND p_IdExemplaire = IdExemplaire AND p_DateEmprunt = DateEmprunt;
END;
//

DELIMITER ;

DELIMITER //

CREATE procedure Pret_Update
(
p_IdAdherent nchar(10),
p_IdExemplaire int,
p_DateEmprunt date,
p_DateRetour date/* =null */
)

BEGIN  

UPDATE Pret
SET
DateRetour=p_DateRetour
WHERE
IdAdherent=p_IdAdherent AND IdExemplaire=p_IdExemplaire AND DateEmprunt=p_DateEmprunt;
END;
//

DELIMITER ;

