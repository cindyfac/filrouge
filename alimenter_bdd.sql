
/*Fournisseurs*/
insert into Fournisseur(Fournisseur_type, Fournisseur_nom, Fournisseur_pays, Fournisseur_adresse, Fournisseur_codepostal, Fournisseur_ville, Fournisseur_mail, Fournisseur_telephone)
Values (1, 'AB instrument', 'France', '15 rue de la Fontaine', '62000', 'Arras', 'sercieco@abinstrument.com', '0321564478')
insert into Fournisseur (Fournisseur_type, Fournisseur_nom, Fournisseur_pays, Fournisseur_adresse, Fournisseur_codepostal, Fournisseur_ville, Fournisseur_mail, Fournisseur_telephone)
Values (1, 'Music en Stock', 'France', '30 rue des champs', '95000', 'Cergy', 'contact@musicenstock.com', '0125336985')
insert into Fournisseur (Fournisseur_type, Fournisseur_nom, Fournisseur_pays, Fournisseur_adresse, Fournisseur_codepostal, Fournisseur_ville, Fournisseur_mail, Fournisseur_telephone)
	Values(2, 'Guitarplus', 'Belgique', '16 rue Limnander', '1070', 'Bruxelles', 'contact@guitarplus.com', '0032025580350')
insert into Fournisseur (Fournisseur_type, Fournisseur_nom, Fournisseur_pays, Fournisseur_adresse, Fournisseur_codepostal, Fournisseur_ville, Fournisseur_mail, Fournisseur_telephone)
	Values (2, 'Gidem', 'France', '1 rue de l''Europe', '02700', 'Tergnier', 'contact@gidem.com', '0323524408')

/*Rubrique*/
insert into Rubrique (Rubrique_nom)
Values ('Guitares Basses')
insert into Rubrique (Rubrique_nom)
Values ('Batteries')
insert into Rubrique (Rubrique_nom)
Values ('Claviers')
insert into Rubrique (Rubrique_nom)
Values ('Vents')
/* Sous rubrique 1*/
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Guitares electriques', 1)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Guitares classiques', 1)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Guitares acoustiques', 1)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Basse electriques', 1)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Batteries acoustiques', 2)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Batteries electroniques', 2)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Percussions', 2)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Piano num�rique', 3)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Synth�tiseur', 3)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Piano � queue', 3)
/*sous rubrique 2*/
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Guitares 6 cordes', 5)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Guitares 7 cordes', 5)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Guitares 8 cordes', 5)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Guitares classiques 3/4', 6)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Guitares classiques 1/4', 6)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Guitares classiques 4/4', 6)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Guitares classiques gaucher', 6)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Basses 4 cordes', 8)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Basses 5 cordes', 8)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Basses 6 cordes', 8)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Piano num�rique classique', 12)
insert into Rubrique (Rubrique_nom, Rubrique_id_1)
Values ('Piano num�rique compact', 12)

/*Produits*/
/*guitares �lectriques, cat5*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('LAG ROXANE GOLD TIGER RGT2000', 'Guitare �lectrique exceptionnelle, une �dition limit�e en Gold Tiger limit�e � 36 exemplaires, fabrication totalement fran�aise ! Une table en �rable flamm�, �quip�e de 2 excellents micros DiMarzio, touche �b�ne, manche coll�...Une beaut� qui prendra une place d''honneur dans votre collection !', 1, 1300, 5)
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('LAG - RR2000VBL', 'Guitare Electrique, Corps Sculpt� en peuplier Am�ricain massif, Finition Corps, manche et t�te coordonn�s / Vernis brillant', 1, 1700, 5)
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('LTD - EC-1000 SSP SILVER SPARKLE', 'Guitare �lectrique Eclipse 1000 Deluxe s�rie sp�ciale avec micros EMG, manche coll�, binding en purfling sur le corps, la t�te et le manche, finition argent paillet�. ', 1, 1100, 5)
/*guitares classiques 3/4, cat18*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('IBANEZ - G10 3Q NT', 'La G10 3Q NT est une guitare classique Ibanez dimension 3/4 fabriqu�e avec une table massive.', 1, 150, 18)
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('STAGG - C430 M BLUE', 'Guitare classique 3/4 bleue avec table en tilleul, une taille recommand�e pour les enfants d''environ 9-12 ans.', 1, 60, 18)
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('STAGG - C530 DRAGONFLY', 'Une guitare classique pour d�butant de taille 3/4, id�ale pour les enfants de 7 � 10 ans. Cette guitare est un vrai instrument d�initiation � la guitare classique. Cette guitare poss�de une touche et un chevalet �rable massif peint et une finition vernis brillant.', 1, 80, 18)
/*guitares classiques 1/4, cat19*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('STAGG - C505', 'Guitare classique 1/4 naturelle avec table en tilleul, touche et chevalet en �rable massif, finition vernis brillant. Une taille recommand�e pour les enfants d''environ 5-6 ans.', 1, 60, 19)
/*guitares classiques 4/4, cat20*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('CUENCA - 70-R', 'Guitare classique espagnole avec table en �pic�a allemand massif, manche, dos et �clisses en palissandre d''Inde massif, touche �b�ne.', 1, 1000, 20)
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('YAMAHA - C40 BL', 'Guitare Classique Black, Table �pic�a, Dos et �clisses M�ranti Manche Nato', 1, 140, 20)
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('FENDER - ESC105', 'Guitare Classique Fender ESC105 est une tr�s bonne guitare d''�tude. Garantie 5 ans, c''est une guitare id�ale pour bien d�buter la guitare classique', 1, 100, 20)
/*basses 4 cordes 22*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('FENDER - AMERICAN STANDARD JAZZ BASS - 3 TONS SUNBURST - RW', 'La nouvelle Jazz Bass Fender poss�de des micros Custom Shop ''60s. Une finition et une dynamique incroyable !!', 1, 1600, 22)
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('FENDER - AMERICAN STANDARD PRECISION BASS - BLACK MN', 'La nouvelle Precision Bass Fender poss�de un nouveau chevalet vintage � haute densit�, Une sous-couche de peinture plus fine sur l�ensemble du corps afin de laisser le bois mieux respirer et am�liorer la r�sonance, des tonnes d''am�lioration pour une basse', 1, 1400, 22)
/*basses 5 cordes 23*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('SQUIER - SQUIER DELUXE DIMENSION BASS V MAPLE BLACK', 'Basse �lectrique 5 cordes Squier Deluxe Dimension Bass V Maple Black', 1, 350, 23)
/*basses 6 cordes 24*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('IBANEZ - BTB686SC-NTF NATURAL FLAT', 'Basse �lectrique Ibanez Mod�le BTB686SC-NTF, cette basse Ibanez est �quip�e d''une egualisation EQBS III � 3 bandes. Basse 6 cordes qui poss�de deux magnifiques micros Bartolini BH1.', 1, 1020, 24)
/*batteries acoustiques 9*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('NATAL - FUSION 20" ASH 4 F�TS WHITE SWIRL', 'De plus petites tailles de f�ts deviennent le choix pr�f�r� pour les batteurs de funk et hip/hop. Les f�ts plus petits et plus peu profonds proposent un son plus serr� pour un punch suppl�mentaire et ce kit propose une grosse caisse de 20 pouces.', 1, 1200, 9)
/*batteries electroniques 10*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('Millenium MPS-250 USB E-Drum Set', '184 sons, 20 kits de batterie, 50 patterns, M�tronome, Mode enregistrement, Sortie casque sur mini Jack st�r�o 3,5 mm, Sortie ligne sur mini Jack st�r�o 3,5 thomann mm', 1, 250,10)
/*percussions 11*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('LAROSA - JORGE PALOMO', 'Cajon signature Jorge Palomo, dans un coloris en racine d''olivier tr�s belle. Tout en bouleau, avec une caisse plus �paisse de 12mm et un son tr�s travaill� pour le style fusion. 100% fait main en Espagne avec des mat�riaux de haute qualit�.', 1, 540, 11)
/*pianos num�riques classiques 25*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('Yamaha YDP-143 B Arius', '88 touches, Clavier GHS, G�n�rateur de sons Pure CF, Intelligent Acoustic Control (IAC), Optimisation acoustique', 1, 790, 25)
/*pianos num�riques compacts 26*/
insert into Produit(Produit_libelle1,Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('Thomann DP-26', 1, 290, 26)
/*synth�tiseurs 13*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('YAMAHA - REFACE CP', 'Le piano �lectrique compact est pourvu de 37 mini-touches et rassemble 6 pianos �lectriques et effets l�gendaires des ann�es 70 dans un bo�tier r�tro distingu� et compact.', 1, 399, 13)
/*piano � queue 14*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('Steinway & Sons O-180 Makassar', 'Steinway & Sons O-180 grand piano, finish: polished coromandel wood, rebuilt by our Steinway specialists and our master thomann piano builder.', 1, 39000, 14)
/*vents cat4*/
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('Saxophone ALYS�E - BH-401L', 'Bugle BH-401L Alys�e', 1, 440, 4)
insert into Produit(Produit_libelle1, Produit_libelle2, Produit_actif, Produit_prixactuelHT, Rubrique_id)
values ('Trompette LEVANTE - TR5205', 'Trompette en Sib Vernis Levante. livr� en �tui souple. Juste et facile � jouer, une parfaite trompette d''�tude !', 1, 270, 4)

/*Fournit*/
/*fournisseur 1*/
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('10/12/2015', 12, 1, 1)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('8/10/2015', 8, 1, 2)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id ,Produit_id)
values('10/03/2016', 5, 1, 3)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('10/07/2015', 2, 1, 4)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('10/12/2014', 9, 1, 5)
/*fournisseur 2*/
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('10/12/2015', 7, 2, 6)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('10/12/2015', 15, 2, 7)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('10/12/2015', 19, 2, 8)
/*fournisseur 3*/
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('10/08/2015', 12, 3, 9)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('7/12/2014', 17, 3, 10)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('27/03/2016', 6, 3, 11)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('16/05/2016', 8, 3, 12)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('25/07/2015', 14, 3, 13)
/*fournisseur 4*/
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('08/12/2016', 20, 4, 14)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('02/07/2015', 12, 4, 15)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('03/05/2016', 6, 4, 16)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('14/08/2015', 2, 4, 17)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('14/08/2015', 1, 4, 18)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('14/08/2015', 14, 4, 19)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('14/08/2015', 5, 4, 20)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('14/08/2015', 1, 4, 21)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('23/01/2016', 8, 4, 22)
insert into Fournit(Produit_date, Produit_quantite, Fournisseur_id, Produit_id)
values('18/11/2015', 2, 4, 23)

/*Commercial*/
Insert into Commercial(Commercial_nom, Commercial_prenom, Commercial_pays, Commercial_adresse, Commercial_codepostal, Commercial_ville, Commercial_mail, Commercial_telephone, Commercial_type)
values ('Hubert', 'Patrick', 'France', '25 route de Paris', '80000', 'Amiens', 'hubertpatrick@gmail.com', '0655478963', 0)
Insert into Commercial(Commercial_nom, Commercial_prenom, Commercial_pays, Commercial_adresse, Commercial_codepostal, Commercial_ville, Commercial_mail, Commercial_telephone, Commercial_type)
values ('Dupont', 'Marie', 'France', '135 rue Nationale', '59000', 'Lille', 'dupontmarie@gmail.com', '0654789912', 0)
Insert into Commercial(Commercial_nom, Commercial_prenom, Commercial_pays, Commercial_adresse, Commercial_codepostal, Commercial_ville, Commercial_mail, Commercial_telephone, Commercial_type)
values ('Caffin', 'Christophe', 'France', '3 rue des Coteaux', '60112', 'Milly-sur-Th�rain', 'caffinchristophe@gmail.com', '0625448963', 1)


/*Adresse*/
Insert into Adresse(Adresse_nom, Adresse_pays, Adresse_rue, Adresse_codepostal, Adresse_ville, Adresse_mail, Adresse_telephone)
values ('Royez Musik', 'France', '22 rue des Vergeaux', '80000', 'Amiens', 'contact@royezmusik.com', '0322145879')
Insert into Adresse(Adresse_nom, Adresse_pays, Adresse_rue, Adresse_codepostal, Adresse_ville, Adresse_mail, Adresse_telephone)
values ('Royez Musik', 'France', '156 Rue du Molinel', '59800', 'Lille', 'contact@royezmusik.com', '0321145699')
Insert into Adresse(Adresse_nom, Adresse_pays, Adresse_rue, Adresse_codepostal, Adresse_ville, Adresse_mail, Adresse_telephone)
values ('Broc''N''Roll', 'France', '2 rue Flatters', '80090', 'Amiens', 'contact@brocnroll.com', '032248578')
Insert into Adresse(Adresse_pays, Adresse_rue, Adresse_codepostal, Adresse_ville, Adresse_mail, Adresse_telephone)
values ('France', '2 rue du moulin', '80000', 'Amiens', 'trucmuche@gmail.com', '0322789641')
Insert into Adresse(Adresse_pays, Adresse_rue, Adresse_codepostal, Adresse_ville, Adresse_mail, Adresse_telephone)
values ('France', '256 route de Paris', '80000', 'Amiens', 'abcdefg@gmail.com', '0322256959')

/*Clients*/
Insert into Client(Client_nom, Client_categorie, Client_coefficient, Commercial_id, Adresse_id)
values ('Royez Musik', 0, 12, 1, 1)
Insert into Client(Client_nom, Client_categorie, Client_coefficient, Commercial_id, Adresse_id)
values ('Broc''N''ROll', 0, 10, 2, 3)
Insert into Client(Client_nom,Client_prenom, Client_categorie, Client_coefficient, Commercial_id, Adresse_id)
values ('Roger', 'Jean', 1, 2, 3, 4)
Insert into Client(Client_nom,Client_prenom, Client_categorie, Client_coefficient, Commercial_id, Adresse_id)
values ('Dupuis', 'Audrey', 1, 4, 3, 5)

/*TVA*/
Insert into Tva(Tva_taux, Tva_date)
values ('19.6', '01/01/2015')

/*Commande*/
Insert into Commande(Client_id, Commande_etat, Commande_paiement, Commande_modepaiement, Commande_date, Commande_totalHT, Commande_totalTTC, Adresse_id, Tva_id, Commande_datepaiement )
values (1, 'en cours de pr�paration', 1, 'ch�que', '10/07/2016', 2950, 3528, 1, 2, '15/07/2016')
Insert into Commande(Client_id, Commande_etat, Commande_paiement, Commande_modepaiement, Commande_date, Commande_totalHT, Commande_totalTTC, Adresse_id, Tva_id, Commande_datepaiement)
values (1, 'en attente', 0, 'ch�que', '18/07/2016', 800, 956.8, 3, 2, '18/07/2016')
Insert into Commande(Client_id, Commande_etat, Commande_paiement, Commande_modepaiement, Commande_date, Commande_totalHT, Commande_totalTTC,  Adresse_id, Tva_id, Commande_datepaiement)
values (2, 'commande exp�di�e', 1, 'CB', '08/07/2016', 100, 119.6, 4, 2, '11/07/2016')
Insert into Commande(Client_id, Commande_etat, Commande_paiement, Commande_modepaiement, Commande_date, Commande_totalHT, Commande_totalTTC,  Adresse_id, Tva_id, Commande_datepaiement)
values (2, 'commande exp�di�e', 1, 'CB', '10/02/2016', 1000, 1196, 5, 2, '12/02/2016')


/*contient*/
Insert into Contient(Produit_qtcommande, Produit_prixHT, Produit_id, Commande_id)
values (1, 1300, 1, 10)
Insert into Contient(Produit_qtcommande, Produit_prixHT, Produit_id, Commande_id)
values (1, 440, 22, 10)
Insert into Contient(Produit_qtcommande, Produit_prixHT, Produit_id, Commande_id)
values (3, 140, 2, 10)
Insert into Contient(Produit_qtcommande, Produit_prixHT, Produit_id, Commande_id)
values (1, 790, 18, 10)
Insert into Contient(Produit_qtcommande, Produit_prixHT, Produit_id, Commande_id)
values (5, 60, 5, 11)
Insert into Contient(Produit_qtcommande, Produit_prixHT, Produit_id, Commande_id)
values (2, 250, 16, 11)
Insert into Contient(Produit_qtcommande, Produit_prixHT, Produit_id, Commande_id)
values (1, 100, 10, 12)
Insert into Contient(Produit_qtcommande, Produit_prixHT, Produit_id, Commande_id)
values (1, 1000, 3, 12)

/*Bon de livraison*/
insert into Bonlivraison(Bonlivraison_date, Commande_id, Adresse_id)
values ('12/07/2016', 12, 4)
insert into Bonlivraison(Bonlivraison_date, Commande_id, Adresse_id)
values ('15/07/2016', 12, 5)

/*_Contient*/
Insert into _Contient(Produit_qtlivre, Bonlivraison_id, Produit_id)
values (1, 5, 10)
Insert into _Contient(Produit_qtlivre, Bonlivraison_id, Produit_id)
values (1, 6,13)


