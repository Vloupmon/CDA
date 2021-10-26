USE `Bibliotheque`;
 
/* SQLINES DEMO *** redProcedure [dbo].[Adherent_Delete]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Suppresion sur la table dbo.Adherent
-- SQLINES DEMO *** ============================

-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Adherent_Delete
    (
    p_IdAdherent nchar(10)
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
    DELETE FROM `dbo`.`Adherent`
WHERE
IdAdherent=p_IdAdherent;
END;
//

DELIMITER ;


/* SQLINES DEMO *** redProcedure [dbo].[Adherent_Insert]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Insertion sur la table dbo.Adherent
-- SQLINES DEMO *** ============================

-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Adherent_Insert
    (
    p_IdAdherent nchar(10),
    p_NomAdherent nvarchar(50),
    p_PrenomAdherent nvarchar(50)/* =null */
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
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

    -- SQLINES LICENSE FOR EVALUATION USE ONLY
    SELECT IdAdherent,
        NomAdherent,
        PrenomAdherent INTO p_IdAdherent, p_NomAdherent, p_PrenomAdherent
    FROM Adherent
    Where p_IdAdherent = IdAdherent;
END;
//

DELIMITER ;


/* SQLINES DEMO *** redProcedure [dbo].[Adherent_Update]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Modification sur la table dbo.Adherent
-- SQLINES DEMO *** ============================
-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Adherent_Update
    (
    p_IdAdherent nchar(10),
    p_NomAdherent nvarchar(50),
    p_PrenomAdherent nvarchar(50)/* =null */
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
    UPDATE Adherent
SET
NomAdherent=p_NomAdherent,
PrenomAdherent=p_PrenomAdherent
WHERE
IdAdherent=p_IdAdherent;
END;
//

DELIMITER ;


/* SQLINES DEMO *** redProcedure [dbo].[Exemplaire_Delete]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Suppresion sur la table dbo.Exemplaire
-- SQLINES DEMO *** ============================

-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Exemplaire_Delete
    (
    p_IdExemplaire int
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
    DELETE FROM `dbo`.`Exemplaire`
WHERE
IdExemplaire=p_IdExemplaire;
END;
//

DELIMITER ;


/* SQLINES DEMO *** redProcedure [dbo].[Exemplaire_Insert]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Insertion sur la table dbo.Exemplaire
-- SQLINES DEMO *** ============================

-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Exemplaire_Insert
    (
    OUT p_IdExemplaire int,
    p_Empruntable tinyint,
    p_ISBN nchar(10)
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
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

    -- SQLINES LICENSE FOR EVALUATION USE ONLY
    SELECT IdExemplaire,
        Empruntable,
        ISBN INTO p_IdExemplaire, p_Empruntable, p_ISBN
    FROM Exemplaire
    Where p_IdExemplaire = IdExemplaire;
END;
//

DELIMITER ;


/* SQLINES DEMO *** redProcedure [dbo].[Exemplaire_Update]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Modification sur la table dbo.Exemplaire
-- SQLINES DEMO *** ============================
-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Exemplaire_Update
    (
    p_IdExemplaire int,
    p_Empruntable tinyint,
    p_ISBN nchar(10)
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
    UPDATE Exemplaire
SET
Empruntable=p_Empruntable,
ISBN=p_ISBN
WHERE
IdExemplaire=p_IdExemplaire;
END;
//

DELIMITER ;


/* SQLINES DEMO *** redProcedure [dbo].[Livre_Delete]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Suppresion sur la table dbo.Livre
-- SQLINES DEMO *** ============================

-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Livre_Delete
    (
    p_ISBN nchar(10)
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
    DELETE FROM `dbo`.`Livre`
WHERE
ISBN=p_ISBN;
END;
//

DELIMITER ;


/* SQLINES DEMO *** redProcedure [dbo].[Livre_Insert]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Insertion sur la table dbo.Livre
-- SQLINES DEMO *** ============================

-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Livre_Insert
    (
    p_ISBN nchar(10),
    p_Titre nvarchar(150)
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
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

    -- SQLINES LICENSE FOR EVALUATION USE ONLY
    SELECT ISBN,
        Titre INTO p_ISBN, p_Titre
    FROM Livre
    Where p_ISBN = ISBN;
END;
//

DELIMITER ;


/* SQLINES DEMO *** redProcedure [dbo].[Livre_Update]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Modification sur la table dbo.Livre
-- SQLINES DEMO *** ============================
-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Livre_Update
    (
    p_ISBN nchar(10),
    p_Titre nvarchar(150)
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
    UPDATE Livre
SET
Titre=p_Titre
WHERE
ISBN=p_ISBN;
END;
//

DELIMITER ;


/* SQLINES DEMO *** redProcedure [dbo].[Pret_Delete]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Suppresion sur la table dbo.Pret
-- SQLINES DEMO *** ============================

-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Pret_Delete
    (
    p_IdAdherent nchar(10),
    p_IdExemplaire int,
    p_DateEmprunt date
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
    DELETE FROM `dbo`.`Pret`
WHERE
IdAdherent=p_IdAdherent AND IdExemplaire=p_IdExemplaire AND DateEmprunt=p_DateEmprunt;
END;
//

DELIMITER ;


/* SQLINES DEMO *** redProcedure [dbo].[Pret_Insert]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Insertion sur la table dbo.Pret
-- SQLINES DEMO *** ============================

-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Pret_Insert
    (
    p_IdAdherent nchar(10),
    p_IdExemplaire int,
    p_DateEmprunt date,
    p_DateRetour date/* =null */
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
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

    -- SQLINES LICENSE FOR EVALUATION USE ONLY
    SELECT IdAdherent,
        IdExemplaire,
        DateEmprunt,
        DateRetour INTO p_IdAdherent, p_IdExemplaire, p_DateEmprunt, p_DateRetour
    FROM Pret
    Where p_IdAdherent = IdAdherent AND p_IdExemplaire = IdExemplaire AND p_DateEmprunt = DateEmprunt;
END;
//

DELIMITER ;


/* SQLINES DEMO *** redProcedure [dbo].[Pret_Update]    Script Date: 08/02/2020 21:54:33 ******/
/* SET ANSI_NULLS ON */
 
/* SET QUOTED_IDENTIFIER ON */
 
-- SQLINES DEMO *** ============================
-- SQLINES DEMO *** Bost
-- SQLINES DEMO *** nche 22 septembre 2019
-- SQLINES DEMO *** édure stockée de l'opération Modification sur la table dbo.Pret
-- SQLINES DEMO *** ============================
-- SQLINES LICENSE FOR EVALUATION USE ONLY
DELIMITER //

CREATE procedure Pret_Update
    (
    p_IdAdherent nchar(10),
    p_IdExemplaire int,
    p_DateEmprunt date,
    p_DateRetour date/* =null */
)

BEGIN
    -- SQLINES DEMO *** ded to prevent extra result sets from
    -- SQLINES DEMO *** SELECT statements.
    -- SET NOCOUNT ON;
    UPDATE Pret
SET
DateRetour=p_DateRetour
WHERE
IdAdherent=p_IdAdherent AND IdExemplaire=p_IdExemplaire AND DateEmprunt=p_DateEmprunt;
END;
//

DELIMITER ;


