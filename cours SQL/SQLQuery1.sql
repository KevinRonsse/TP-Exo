-- LDD Langage de définition des données

-- création des Tables
CREATE TABLE personne (
	numero int  not null PRIMARY KEY IDENTITY(1,1),
	nom varchar(100),
	prenom varchar(100),
	telephone varchar(10),
);

-- Supprimer ine Table
DROP TABLE personne;

-- Modifier une TABLE
ALTER TABLE personne ADD age int not null 

-- LMD Langage de manipulation des données 

-- Insertion des données

INSERT INTO personne (nom,prenom,telephone) 
OUTPUT inserted.numero values('toto','tata','0665698560');

-- UPDATE
UPDATE personne set nom='toto',prenom='tata' WHERE numero > 1;

--DELETE
DELETE FROM personne;

--Requettes
--order by ascendant
SELECT * FROM personne where numero > 1;
SELECT * FROM personne where numero > 1 order by nom desc;
SELECT nom , prenom FROM personne where numero > 1 order by nom desc;
SELECT TOP 1 nom , prenom FROM personne where numero > 1 order by nom desc;