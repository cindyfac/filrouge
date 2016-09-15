

use master
go
--drop database villagegreen
go
create database villagegreen
go



CREATE TABLE Fournisseur(
        Fournisseur_code       Varchar (25) NOT NULL ,
        Fournisseur_type       bit,
        Fournisseur_nom        Varchar (50) ,
        Fournisseur_prenom     Varchar (50) ,
        Fournisseur_pays       Varchar (25) ,
        Fournisseur_adresse    Varchar (250) ,
        Fournisseur_codepostal Varchar (25) ,
        Fournisseur_ville      Varchar (200) ,
        Fournisseur_mail       Varchar (25) ,
        Fournisseur_telephone  Varchar (25) ,
        PRIMARY KEY (Fournisseur_code )
)



CREATE TABLE Produits(
        Produit_reference    int identity NOT NULL ,
        Produit_libelle1     Varchar (50) ,
        Produit_libelle2     Varchar (2500) ,
        Produit_photo        Varchar (100) ,
        Produit_rubrique     Varchar (250) ,
        Produit_sousrubrique Varchar (25) ,
        Produit_actif        bit ,
        Produit_prixactuelHT Float ,
        Rubrique_identifiant Int ,
        PRIMARY KEY (Produit_reference )
)



CREATE TABLE Adresse(
        Adresse_reference  int identity  NOT NULL ,
        Adresse_nom        Varchar (250) ,
        Adresse_pays       Varchar (25) ,
        Adresse_rue        Char (250) ,
        Adresse_codepostal Varchar (25) ,
        Adresse_ville      Varchar (250) ,
        Adresse_mail       Varchar (250) ,
        Adresse_telephone  Varchar (25) ,
        PRIMARY KEY (Adresse_reference )
)



CREATE TABLE Commercial(
        Commercial_numero     int identity  NOT NULL ,
        Commercial_nom        Varchar (100) ,
        Commercial_prenom     Varchar (50) ,
        Commercial_pays       Varchar (25) ,
        Commercial_adresse    Varchar (250) ,
        Commercial_codepostal Varchar (25) ,
        Commercial_ville      Varchar (25) ,
        Commercial_mail       Varchar (250) ,
        Commercial_telephone  Varchar (25) ,
        Commercial_type       bit ,
        PRIMARY KEY (Commercial_numero )
)



CREATE TABLE Commande(
        Commande_reference    Varchar (25) NOT NULL ,
        Commande_etat         Varchar (250) ,
        Commande_paiement     bit ,
        Commande_modepaiement Varchar (250) ,
        Commande_totalHT      Float ,
        Commande_date         Date ,
        Commande_date_passe   Date ,
        Commande_numero       int identity,
        Client_numero         Int ,
        Adresse_reference     Int ,
        TVA_numero            Int ,
        PRIMARY KEY (Commande_reference )
)


CREATE TABLE Bondelivraison(
        Bonlivraison_numero int identity  NOT NULL ,
        Bonlivraison_date   Date ,
        Commande_reference  Varchar (25) ,
        Adresse_reference   Int ,
        PRIMARY KEY (Bonlivraison_numero )
)



CREATE TABLE TVA(
        TVA_numero int identity  NOT NULL ,
        TVA_date   Date ,
        TVA_taux   Float ,
        PRIMARY KEY (TVA_numero )
)



CREATE TABLE Client(
        Client_numero      int identity  NOT NULL ,
        Client_nom         Varchar (25) ,
        Client_prenom      Varchar (25) ,
        Client_categorie   bit ,
        Client_coefficient Int ,
        Commercial_numero  Int ,
        Adresse_reference  Int ,
        PRIMARY KEY (Client_numero )
)



CREATE TABLE Rubrique(
        Rubrique_identifiant   int identity  NOT NULL ,
        Rubrique_nom           Varchar (25) ,
        Rubrique_identifiant_1 Int ,
        PRIMARY KEY (Rubrique_identifiant )
)

CREATE TABLE Fourni(
        Produit_reffournisseur int identity  ,
        Produit_date           Date ,
        Produit_quantite       Int ,
        Fournisseur_code       Varchar (25) NOT NULL ,
        Produit_reference      Int NOT NULL ,
        PRIMARY KEY (Fournisseur_code ,Produit_reference )
)


CREATE TABLE Contient(
        Produit_qtcommande Int ,
        Produit_prixHT     Float ,
        Produit_reference  Int NOT NULL ,
        Commande_reference Varchar (25) NOT NULL ,
        PRIMARY KEY (Produit_reference ,Commande_reference )
)

CREATE TABLE _Contient(
        Produit_qtlivre     Int ,
        Bonlivraison_numero Int NOT NULL ,
        Produit_reference   Int NOT NULL ,
        PRIMARY KEY (Bonlivraison_numero ,Produit_reference )
)

ALTER TABLE Produits ADD CONSTRAINT FK_Produits_Rubrique_identifiant FOREIGN KEY (Rubrique_identifiant) REFERENCES Rubrique(Rubrique_identifiant);
ALTER TABLE Commande ADD CONSTRAINT FK_Commande_Client_numero FOREIGN KEY (Client_numero) REFERENCES Client(Client_numero);
ALTER TABLE Commande ADD CONSTRAINT FK_Commande_Adresse_reference FOREIGN KEY (Adresse_reference) REFERENCES Adresse(Adresse_reference);
ALTER TABLE Commande ADD CONSTRAINT FK_Commande_TVA_numero FOREIGN KEY (TVA_numero) REFERENCES TVA(TVA_numero);
ALTER TABLE Bondelivraison ADD CONSTRAINT FK_Bondelivraison_Commande_reference FOREIGN KEY (Commande_reference) REFERENCES Commande(Commande_reference);
ALTER TABLE Bondelivraison ADD CONSTRAINT FK_Bondelivraison_Adresse_reference FOREIGN KEY (Adresse_reference) REFERENCES Adresse(Adresse_reference);
ALTER TABLE Client ADD CONSTRAINT FK_Client_Commercial_numero FOREIGN KEY (Commercial_numero) REFERENCES Commercial(Commercial_numero);
ALTER TABLE Client ADD CONSTRAINT FK_Client_Adresse_reference FOREIGN KEY (Adresse_reference) REFERENCES Adresse(Adresse_reference);
ALTER TABLE Rubrique ADD CONSTRAINT FK_Rubrique_Rubrique_identifiant_1 FOREIGN KEY (Rubrique_identifiant_1) REFERENCES Rubrique(Rubrique_identifiant);
ALTER TABLE Fourni ADD CONSTRAINT FK_Fourni_Fournisseur_code FOREIGN KEY (Fournisseur_code) REFERENCES Fournisseur(Fournisseur_code);
ALTER TABLE Fourni ADD CONSTRAINT FK_Fourni_Produit_reference FOREIGN KEY (Produit_reference) REFERENCES Produits(Produit_reference);
ALTER TABLE Contient ADD CONSTRAINT FK_Contient_Produit_reference FOREIGN KEY (Produit_reference) REFERENCES Produits(Produit_reference);
ALTER TABLE Contient ADD CONSTRAINT FK_Contient_Commande_reference FOREIGN KEY (Commande_reference) REFERENCES Commande(Commande_reference);
ALTER TABLE _Contient ADD CONSTRAINT FK__Contient_Bonlivraison_numero FOREIGN KEY (Bonlivraison_numero) REFERENCES Bondelivraison(Bonlivraison_numero);
ALTER TABLE _Contient ADD CONSTRAINT FK__Contient_Produit_reference FOREIGN KEY (Produit_reference) REFERENCES Produits(Produit_reference);
