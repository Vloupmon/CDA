USE [ComptoirInternational];
GO

DROP PROCEDURE IF EXISTS dbo.UserAuth;
DROP PROCEDURE IF EXISTS dbo.UserCreate;
DROP PROCEDURE IF EXISTS dbo.PasswordChange;
DROP PROCEDURE IF EXISTS dbo.PasswordRetrieval;
GO

CREATE PROCEDURE UserAuth
    @idInput VARCHAR(64),
    @passwordInput VARCHAR(255)
AS
BEGIN
    DECLARE @id VARCHAR(64),
@password VARCHAR(255),
@tries INT,
@locked BIT
    SELECT
        @id = IDUtilisateur,
        @password = MotPasse,
        @tries = NbreEssaisInfructueux,
        @locked = CompteBloque
    FROM
        dbo.Utilisateurs
    WHERE
    IDUtilisateur = @idInput
    IF @id IS NULL RETURN (-101)
    IF @locked = 1 RETURN (-102)
    IF @passwordInput IS NULL
        OR @passwordInput != @password BEGIN
        SET
    @tries += 1
        IF @tries >= 3 BEGIN
            UPDATE
    dbo.Utilisateurs
SET
    CompteBloque = 1,
    NbreEssaisInfructueux = @tries
WHERE
    IDUtilisateur = @id
        END
        RETURN (-103)
    END
    RETURN (0)
END;
GO

CREATE PROCEDURE UserCreate
    @idInput VARCHAR(64),
    @passwordInput VARCHAR(255)
AS
BEGIN
    DECLARE @id VARCHAR(64),
@password VARCHAR(255),
@tries INT,
@locked BIT
    SELECT
        @id = IDUtilisateur,
        @password = MotPasse,
        @tries = NbreEssaisInfructueux,
        @locked = CompteBloque
    FROM
        dbo.Utilisateurs
    WHERE
    IDUtilisateur = @idInput
    IF @id IS NULL RETURN (-101)
    IF @locked = 1 RETURN (-102)
    IF @passwordInput IS NULL
        OR @passwordInput != @password BEGIN
        SET
    @tries += 1
        IF @tries >= 3 BEGIN
            UPDATE
    dbo.Utilisateurs
SET
    CompteBloque = 1,
    NbreEssaisInfructueux = @tries
WHERE
    IDUtilisateur = @id
        END
        RETURN (-103)
    END
    RETURN (0)
END;
GO