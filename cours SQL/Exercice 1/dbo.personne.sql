CREATE TABLE [dbo].[personne] (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [titre]     VARCHAR (4)   NULL,
    [prenom]    VARCHAR (100) NULL,
    [nom]       VARCHAR (100) NULL,
    [email]     VARCHAR (100) NULL,
    [telephone] VARCHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

