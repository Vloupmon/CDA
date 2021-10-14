IF NOT EXISTS(SELECT *
FROM sys.databases
WHERE name = 'Geoperso')
  BEGIN
   CREATE DATABASE [Geoperso]
END
GO

USE [Geoperso]
GO

/*==============================================================*/
/* Table : QUALIF                                               */
/*==============================================================*/
CREATE TABLE QUALIF
(
   CODQUAL char(4) NOT NULL,
   QUALIBEL char(30) NOT NULL,
   CONSTRAINT PK_QUALIF PRIMARY KEY nonclustered (CODQUAL)
)
GO
/*==============================================================*/
/* Table : UNITE                                                */
/*==============================================================*/
CREATE TABLE UNITE
(
   UNITCOD char(4) NOT NULL,
   UNITEMERE char(4) NULL,
   UNITE char(40) NOT NULL,
   BUDGET numeric(7) NOT NULL,
   CONSTRAINT PK_UNITE PRIMARY KEY nonclustered (UNITCOD)
)
GO
/*==============================================================*/
/* Table : EMPLOYE                                                */
/*==============================================================*/
CREATE TABLE EMPLOYE
(
   EMPCODE numeric identity,
   UNITCOD char(4) NOT NULL CONSTRAINT FK_Employe_Unit FOREIGN KEY (UNITCOD) REFERENCES UNITE(UNITCOD),
   CODQUAL char(4) NOT NULL CONSTRAINT FK_Employe_Qual FOREIGN KEY (CODQUAL) REFERENCES QUALIF(CODQUAL),
   NOM char(20) NOT NULL,
   JOBCODE char(4) NOT NULL,
   NIVEAU char(4) NOT NULL,
   TITRE char(30) NOT NULL,
   SEXE char(1) NOT NULL CONSTRAINT CKC_SEXE_EMPLOYE CHECK (SEXE IN ('M', 'F')),
   DATNAISS datetime NOT NULL,
   SALAIRE numeric(7, 2) NOT NULL,
   CONSTRAINT PK_EMPLOYE PRIMARY KEY nonclustered (EMPCODE),
)
GO
/*==============================================================*/
/* Index : ORDRE_ALPHABETIQUE_COL                                 */
/*==============================================================*/
CREATE INDEX ORDRE_ALPHABETIQUE_COL ON EMPLOYE (NOM ASC)
GO
/*==============================================================*/
/* Index : QUALIF_PRINCIPALE_FK                                 */
/*==============================================================*/
CREATE INDEX QUALIF_PRINCIPALE_FK ON EMPLOYE (CODQUAL ASC)
GO
/*==============================================================*/
/* Index : TRAVAILLE_FK                                         */
/*==============================================================*/
CREATE INDEX TRAVAILLE_FK ON EMPLOYE (UNITCOD ASC)
GO
/*==============================================================*/
/* Table : EMPSQUAL                                             */
/*==============================================================*/
CREATE TABLE EMPSQUAL
(
   EMPCODE numeric NOT NULL CONSTRAINT FK_EMPSQUAL_EMP FOREIGN KEY (EMPCODE) REFERENCES EMPLOYE(EMPCODE),
   CODQUAL char(4) NOT NULL CONSTRAINT FK_EMPSQUAL_QUAL FOREIGN KEY (CODQUAL) REFERENCES QUALIF(CODQUAL),
   CONSTRAINT PK_EMPSQUAL PRIMARY KEY (EMPCODE, CODQUAL)
)
GO
/*==============================================================*/
/* Index : EMPSQUAL_FK                                          */
/*==============================================================*/
CREATE INDEX EMPSQUAL_FK ON EMPSQUAL (CODQUAL ASC)
GO
/*==============================================================*/
/* Index : EMPSQUAL2_FK                                         */
/*==============================================================*/
CREATE INDEX EMPSQUAL2_FK ON EMPSQUAL (EMPCODE ASC)
GO
/*==============================================================*/
/* Table : POSTES                                               */
/*==============================================================*/
CREATE TABLE POSTES
(
   CODQUAL char(4) NOT NULL CONSTRAINT FK_POSTES_QUAL FOREIGN KEY (CODQUAL) REFERENCES QUALIF(CODQUAL),
   UNITCOD char(4) NOT NULL,
   NOMBRE int NOT NULL CONSTRAINT CKC_NOMBRE_POSTES CHECK (
         NOMBRE BETWEEN 1
         AND 100
      ),
   BUDGETPOSTE numeric(7) NOT NULL CONSTRAINT CKC_POSTES_BUDGET CHECK (
      BUDGETPOSTE > 0
   ),
   CONSTRAINT PK_POSTES PRIMARY KEY (UNITCOD, CODQUAL)
)
GO
/*==============================================================*/
/* Index : POSTES_FK                                            */
/*==============================================================*/
CREATE INDEX POSTES_FK ON POSTES (UNITCOD ASC)
GO
/*==============================================================*/
/* Index : POSTES2_FK                                           */
/*==============================================================*/
CREATE INDEX POSTES2_FK ON POSTES (CODQUAL ASC)
GO
/*==============================================================*/
/* Index : ASSOCIATION_5_FK                                     */
/*==============================================================*/
CREATE INDEX ASSOCIATION_5_FK ON UNITE (UNITEMERE ASC)
GO

INSERT INTO QUALIF
   (CODQUAL, QUALIBEL)
VALUES
   ('1110', 'Secrétaire'),
   ('1120', 'Ingénieur Mécanicien'),
   ('1130', 'Ingénieur Electronique'),
   ('1330', 'Dessinateur'),
   ('1350', 'Responsable')
GO

INSERT INTO POSTES
   (CODQUAL, UNITCOD, NOMBRE, BUDGETPOSTE)
VALUES
   ('1110', '2000', '2', '1500'),
   ('1350', '2000', '1', '50000'),
   ('1110', '2100', '3', '1000'),
   ('1350', '2100', '1', '2500'),
   ('1110', '2110', '1', '1500'),
   ('1350', '2110', '1', '3500'),
   ('1130', '2111', '10', '5000'),
   ('1350', '2111', '1', '4500')
GO

INSERT INTO UNITE
   (UNITCOD, UNITE, BUDGET)
VALUES
   (2000, 'un', 10),
   (2100, 'deux' , 20),
   (2110, 'trois', 30),
   (2111, 'quatre', 40)
GO

SET IDENTITY_INSERT EMPLOYE ON
INSERT INTO EMPLOYE
   (EMPCODE, UNITCOD, CODQUAL, NOM, JOBCODE, NIVEAU, TITRE, SEXE, DATNAISS, SALAIRE)
VALUES
   ('84205', '2000', '1110', 'LYNN, K.R.', '0100', 'EXPT', 'Secrétaire', 'F', (SELECT CONVERT(datetime, '21/01/1953', 103)), '2240.25'),
   ('91230', '2000', '1350', 'PETERSON, N.M.', '5000', 'CONF', 'Responsable de Division', 'M', (SELECT CONVERT(datetime, '07/06/1956', 103)), '3521.20'),
   ('78541', '2100', '1110', 'CALLAGAN, R.F.', '0100', 'CONF', 'Secrétaire', 'F', (SELECT CONVERT(datetime, '17/05/1984', 103)), '1855.25'),
   ('95200', '2100', '1350', 'CARR, P.I.', '5000', 'CONF', 'Responsable Dept. Etudes', 'F', (SELECT CONVERT(datetime, '02/07/1985', 103)), '3621.20'),
   ('99120', '2110', '1110', 'HARRIS, D.L.', '0100', 'CONF', 'Secrétaire', 'M', (SELECT CONVERT(datetime, '07/07/1965', 103)), '1855.36'),
   ('85417', '2110', '1350', 'GUTTMAN, G.J.', '5000', 'EXPT', 'Responsable Groupe Système', 'M', (SELECT CONVERT(datetime, '28/03/1991', 103)), '4520.00'),
   ('14541', '2111', '1130', 'GARBER, R.E.', '2400', 'EXPT', 'Ingénieur Electronicien', 'F', (SELECT CONVERT(datetime, '04/08/1965', 103)), '2500.00'),
   ('12578', '2111', '1130', 'HENDERSON', '2400', 'EXPT', 'Ingénieur Electronicien', 'M', (SELECT CONVERT(datetime, '25/01/1996', 103)), '2500.00'),
   ('11206', '2111', '1350', 'COMPTON, D.R.', '5000', 'EXPT', 'Responsable des Couts', 'F', (SELECT CONVERT(datetime, '02/07/1986', 103)), '4600.00')
GO
SET IDENTITY_INSERT EMPLOYE OFF

INSERT INTO EMPSQUAL
   (EMPCODE, CODQUAL)
VALUES
   ('91230', '1350'),
   ('85417', '1350')
GO