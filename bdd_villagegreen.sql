use master
go
--drop filrouge
go
create database villagegreen
go
use villagegreen
go
DECLARE @Fournisseur_type bit
Set @Fournisseur_type = 1 /* true Fournisseur fabricant */
Set @Fournisseur_type = 0  /* false Fournisseur import */

CREATE TABLE Fournisseur(
	Fournisseur_id      int identity NOT NULL ,
	Fournisseur_type       bit NOT NULL,
	Fournisseur_nom        VARCHAR (50) NOT NULL ,
	Fournisseur_pays       VARCHAR (25)  NOT NULL,
	Fournisseur_adresse    VARCHAR (250) NOT NULL ,
	Fournisseur_codepostal VARCHAR (25) NOT NULL,
	Fournisseur_ville      VARCHAR (200) NOT NULL ,
	Fournisseur_mail       VARCHAR (25) NOT NULL  ,
	Fournisseur_telephone  VARCHAR (25) NOT NULL  ,
	CONSTRAINT prk_constraint__Fournisseur PRIMARY KEY NONCLUSTERED (Fournisseur_id)
)

DECLARE @Produit_actif bit
Set @Produit_actif = 1  /* true actif dans le catalogue*/
Set @Produit_actif = 0  /* false inactif dans le catalogue*/

CREATE TABLE Produit(
	Produit_id    INT IDENTITY  NOT NULL ,
	Produit_libelle1     VARCHAR (100) NOT NULL ,
	Produit_libelle2     VARCHAR (2500)  ,
	Produit_photo        VARCHAR (100) ,
	Produit_actif        bit  NOT NULL  ,
	Produit_prixactuelHT FLOAT NOT NULL ,
	Rubrique_id INT NOT NULL ,
	CONSTRAINT prk_constraint_produits PRIMARY KEY NONCLUSTERED (Produit_id)
)
CREATE TABLE Adresse(
	Adresse_id  INT IDENTITY  NOT NULL ,
	Adresse_nom        VARCHAR (250)  ,
	Adresse_pays       VARCHAR (25) NULL ,
	Adresse_rue        CHAR (250)  NOT NULL ,
	Adresse_codepostal VARCHAR (25) NOT NULL ,
	Adresse_ville      VARCHAR (250) NOT NULL ,
	Adresse_mail       VARCHAR (250) NOT NULL ,
	Adresse_telephone  VARCHAR (25)  ,
	CONSTRAINT prk_constraint_Adresse PRIMARY KEY NONCLUSTERED (Adresse_id)
)

DECLARE @Commercial_type bit
Set @Commercial_type = 1  /* true commercial particulier*/
Set @Commercial_type = 0  /* false commercial professionnel*/

CREATE TABLE Commercial(
	Commercial_id     INT IDENTITY (1,1) NOT NULL ,
	Commercial_nom        VARCHAR (100) NOT NULL ,
	Commercial_prenom     VARCHAR (50)NOT NULL  ,
	Commercial_pays       VARCHAR (25) NULL ,
	Commercial_adresse    VARCHAR (250) NOT NULL ,
	Commercial_codepostal VARCHAR (25) NOT NULL ,
	Commercial_ville      VARCHAR (25) NOT NULL ,
	Commercial_mail       VARCHAR (250)NOT NULL  ,
	Commercial_telephone  VARCHAR (25) NOT NULL ,
	Commercial_type       bit  NOT NULL ,
	CONSTRAINT prk_constraint__Commercial PRIMARY KEY NONCLUSTERED (Commercial_id)
)
--alter table Commande
--add Commande_datepaiement Datetime 

CREATE TABLE Commande(
	Commande_id    INT IDENTITY  NOT NULL,
	Commande_etat         VARCHAR (250) NOT NULL ,
	Commande_paiement     bit  NOT NULL ,
	Commande_modepaiement VARCHAR (250) NOT NULL ,
	Commande_date         DATETIME not null ,
	Commande_datepaiement Datetime not null,
	Commande_totalHT      FLOAT NOT NULL  ,
	Commande_totalTTC     FLOAT NOT NULL  ,
	Client_id         INT NOT NULL ,
	Adresse_id     INT NOT NULL  ,
	Tva_id            INT NOT NULL  ,
	CONSTRAINT prk_constraint__Commande PRIMARY KEY NONCLUSTERED (Commande_id)
)
CREATE TABLE Bonlivraison(
	Bonlivraison_id INT IDENTITY  NOT NULL ,
	Bonlivraison_date   DATETIME NULL DEFAULT GETDATE() ,
	Commande_id  INT NOT NULL  ,
	Adresse_id   INT NOT NULL  ,
	CONSTRAINT prk_constraint_Bonlivraison PRIMARY KEY NONCLUSTERED (Bonlivraison_id)
)
CREATE TABLE Tva(
	Tva_id INT IDENTITY (1,1) NOT NULL ,
	Tva_date   DATETIME not NULL,
	Tva_taux   FLOAT NOT NULL ,
	CONSTRAINT prk_constraint_Tva PRIMARY KEY NONCLUSTERED (Tva_id)
)

CREATE TABLE Client(
	Client_id      INT IDENTITY  NOT NULL ,
	Client_nom         VARCHAR (25) NOT NULL ,
	Client_prenom      VARCHAR (25)  ,
	Client_categorie   bit NOT NULL ,
	Client_coefficient INT NOT NULL,
	Commercial_id  INT NOT NULL,
	Adresse_id  INT not null,
	Client_siret int null,
	CONSTRAINT prk_constraint_Client PRIMARY KEY NONCLUSTERED (Client_id)
)
CREATE TABLE Rubrique(
	Rubrique_id   INT IDENTITY (1,1) NOT NULL ,
	Rubrique_nom           VARCHAR (25)  NOT NULL ,
	Rubrique_id_1 INT   , /* peut être nul car les rubriques principales n'apparitiennent à aucune rubrique*/
	CONSTRAINT prk_constraint_Rubrique PRIMARY KEY NONCLUSTERED (Rubrique_id)
)
CREATE TABLE Fournit(
	Produit_idfou INT IDENTITY (1,1) NOT NULL,
	Produit_date           DATETIME NOT NULL ,
	Produit_quantite       INT NOT NULL  ,
	Fournisseur_id       INT  NOT NULL ,
	Produit_id      INT  NOT NULL ,
	CONSTRAINT prk_constraint__Fourni PRIMARY KEY NONCLUSTERED (Fournisseur_id,Produit_idfou)
)
CREATE TABLE Contient(
	Produit_qtcommande INT NOT NULL,
	Produit_prixHT     FLOAT NOT NULL ,
	Produit_id  INT  NOT NULL ,
	Commande_id int NOT NULL ,
	CONSTRAINT prk_constraint_Contient PRIMARY KEY NONCLUSTERED (Produit_id,Commande_id)
)
CREATE TABLE _Contient(
	Produit_qtlivre     INT  NOT NULL ,
	Bonlivraison_id INT  NOT NULL ,
	Produit_id   INT  NOT NULL ,
	CONSTRAINT prk_constraint__Contient PRIMARY KEY NONCLUSTERED (Bonlivraison_id,Produit_id)
)



ALTER TABLE Produit ADD CONSTRAINT FK_produit_Rubrique_id FOREIGN KEY (Rubrique_id) REFERENCES Rubrique(Rubrique_id);
ALTER TABLE Commande ADD CONSTRAINT FK_Commande_Client_id FOREIGN KEY (Client_id) REFERENCES Client(Client_id);
ALTER TABLE Commande ADD CONSTRAINT FK_Commande_Adresse_id FOREIGN KEY (Adresse_id) REFERENCES Adresse(Adresse_id);
ALTER TABLE Commande ADD CONSTRAINT FK_Commande_Tva_id FOREIGN KEY (Tva_id) REFERENCES Tva(Tva_id);
ALTER TABLE Bonlivraison ADD CONSTRAINT FK_Bonlivraison_Commande_id FOREIGN KEY (Commande_id) REFERENCES Commande(Commande_id);
ALTER TABLE Bonlivraison ADD CONSTRAINT FK_Bonlivraison_Adresse_id FOREIGN KEY (Adresse_id) REFERENCES Adresse(Adresse_id);
ALTER TABLE Client ADD CONSTRAINT FK_Client_Commercial_id FOREIGN KEY (Commercial_id) REFERENCES Commercial(Commercial_id);
ALTER TABLE Client ADD CONSTRAINT FK_Client_Adresse_id FOREIGN KEY (Adresse_id) REFERENCES Adresse(Adresse_id);
ALTER TABLE Rubrique ADD CONSTRAINT FK_Rubrique_Rubrique_id_1 FOREIGN KEY (Rubrique_id_1) REFERENCES Rubrique(Rubrique_id);
ALTER TABLE Fournit ADD CONSTRAINT FK_Fournit_Fournisseur_id FOREIGN KEY (Fournisseur_id) REFERENCES Fournisseur(Fournisseur_id);
ALTER TABLE Fournit ADD CONSTRAINT FK_Fournit_Produit_id FOREIGN KEY (Produit_id ) REFERENCES Produit(Produit_id);
ALTER TABLE Contient ADD CONSTRAINT FK_Contient_Produit_id FOREIGN KEY (Produit_id) REFERENCES Produit(Produit_id);
ALTER TABLE Contient ADD CONSTRAINT FK_Contient_Commande_id FOREIGN KEY (Commande_id) REFERENCES Commande(Commande_id);
ALTER TABLE _Contient ADD CONSTRAINT FK__Contient_Bonlivraison_id FOREIGN KEY (Bonlivraison_id) REFERENCES Bonlivraison(Bonlivraison_id);
ALTER TABLE _Contient ADD CONSTRAINT FK__Contient_Produit_id FOREIGN KEY (Produit_id) REFERENCES Produit(Produit_id);
