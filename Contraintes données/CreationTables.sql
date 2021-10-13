create table EMPLOYE (
   EMPCODE              numeric              identity,
   UNITCOD              char(4)              not null,
   CODQUAL              char(4)              not null,
   NOM                  char(20)             not null,
   JOBCODE              char(4)              not null,
   NIVEAU               char(4)              not null,
   TITRE                char(30)             not null,
   SEXE                 char(1)              not null
      constraint CKC_SEXE_EMPLOYE check (SEXE in ('M','F')),
   DATNAISS             datetime             not null,
   SALAIRE              numeric(7,2)         not null,
   constraint PK_EMPLOYE primary key nonclustered (EMPCODE)
)
go

/*==============================================================*/
/* Index : QUALIF_PRINCIPALE_FK                                 */
/*==============================================================*/
create index QUALIF_PRINCIPALE_FK on EMPLOYE (
CODQUAL ASC
)
go

/*==============================================================*/
/* Index : TRAVAILLE_FK                                         */
/*==============================================================*/
create index TRAVAILLE_FK on EMPLOYE (
UNITCOD ASC
)
go

/*==============================================================*/
/* Table : EMPSQUAL                                             */
/*==============================================================*/
create table EMPSQUAL (
   EMPCODE              numeric              not null,
   CODQUAL              char(4)              not null,
   constraint PK_EMPSQUAL primary key (EMPCODE, CODQUAL)
)
go

/*==============================================================*/
/* Index : EMPSQUAL_FK                                          */
/*==============================================================*/
create index EMPSQUAL_FK on EMPSQUAL (
CODQUAL ASC
)
go

/*==============================================================*/
/* Index : EMPSQUAL2_FK                                         */
/*==============================================================*/
create index EMPSQUAL2_FK on EMPSQUAL (
EMPCODE ASC
)
go

/*==============================================================*/
/* Table : POSTES                                               */
/*==============================================================*/
create table POSTES (
   CODQUAL              char(4)              not null,
   UNITCOD              char(4)              not null,
   NOMBRE               int                  not null
      constraint CKC_NOMBRE_POSTES check (NOMBRE between 1 and 100),
   BUDGETPOSTE          numeric(7)           not null,
   constraint PK_POSTES primary key (UNITCOD, CODQUAL)
)
go

/*==============================================================*/
/* Index : POSTES_FK                                            */
/*==============================================================*/
create index POSTES_FK on POSTES (
UNITCOD ASC
)
go

/*==============================================================*/
/* Index : POSTES2_FK                                           */
/*==============================================================*/
create index POSTES2_FK on POSTES (
CODQUAL ASC
)
go

/*==============================================================*/
/* Table : QUALIF                                               */
/*==============================================================*/
create table QUALIF (
   CODQUAL              char(4)              not null,
   QUALIBEL             char(30)             not null,
   constraint PK_QUALIF primary key nonclustered (CODQUAL)
)
go

/*==============================================================*/
/* Table : UNITE                                                */
/*==============================================================*/
create table UNITE (
   UNITCOD              char(4)              not null,
   UNITEMERE            char(4)              null,
   UNITE                char(40)             not null,
   BUDGET               numeric(7)           not null,
   constraint PK_UNITE primary key nonclustered (UNITCOD) 
)
go

/*==============================================================*/
/* Index : ASSOCIATION_5_FK                                     */
/*==============================================================*/
create index ASSOCIATION_5_FK on UNITE (
UNITEMERE ASC
)
go
