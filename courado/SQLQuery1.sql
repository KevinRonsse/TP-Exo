CREATE TABLE [dbo].[contact] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [last_name]  VARCHAR (100) NULL,
    [first_name] VARCHAR (100) NULL,
    [phone]      VARCHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

DROP TABLE contact;



