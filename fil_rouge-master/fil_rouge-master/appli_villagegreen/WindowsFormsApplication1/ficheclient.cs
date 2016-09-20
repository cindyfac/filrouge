using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using System.Data.SqlClient;
using System.Configuration;


namespace WindowsFormsApplication1
{
    public partial class Form_client : Form
    {
        //mes variables
        ContexteFormulaire moncas = 0;
        int marecherche = 0;
        clientDAO clientDao;
        adresseDAO adresseDao;
        commandeDAO commandeDao;
        commercialDAO commercialDao;
        bool monbooleen = false;

        public void initialisationclient()
        {
            //le groupe box devient modifiable
            gpbx_coordonnees.Enabled = true;
            lbl_reference.Visible = false;
            tb_reference.Visible = false;
            tb_adresse.Clear();
            tb_codepostal.Clear();
            tb_coefficient.Clear();
            tb_mail.Clear();
            tb_nom.Clear();
            tb_prenom.Clear();
            tb_reference.Clear();
            tb_siret.Clear();
            tb_telephone.Clear();
            tb_ville.Clear();
            rb_particulier.Checked = false;
            rb_professionnel.Checked = false;
            lb_commande.Visible = false;
            lbl_commandes.Visible = false;
            btn_valider.Visible = true;
        }

        public Form_client()
        {
            InitializeComponent();
            string connexionDbConfig = ConfigurationManager.AppSettings["connexionDb"];
            clientDao = new clientDAO(connexionDbConfig);
            adresseDao = new adresseDAO(connexionDbConfig);
            commandeDao = new commandeDAO(connexionDbConfig);
            commercialDao = new commercialDAO(connexionDbConfig);
        }

        private void Form_client_Load(object sender, EventArgs e)
        {
            //displaymember et valuemember à mettre AVANT le datasource
            lb_client.DisplayMember = "Client_nom";//valeur affichée dans la listBox
            lb_client.ValueMember = "Client_id";//valeur réelle dans la listBox
            cb_recherchenom.DisplayMember = "Client_nom";
            cb_recherchenumero.DisplayMember = "Client_id";
            cb_recherchenom.ValueMember = "Client_id";
            cb_recherchenumero.ValueMember = "Client_id";
            cb_commercial.DisplayMember = "Commercial_nom";//valeur affichée dans la listBox
            cb_commercial.ValueMember = "Commercial_id";//valeur réelle dans la listBox    
            lb_commande.DisplayMember = "InfoCommande";
            lb_commande.ValueMember = "Commande_id";
            RechargerLesListesclients();
        }

        private void RechargerLesListesclients()
        {
            //fonction pour afficher une liste
            lb_client.DataSource = clientDao.List();                 
            cb_recherchenom.DataSource = clientDao.List();
            cb_recherchenumero.DataSource = clientDao.List();
        }

        private void lb_client_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(lb_client.SelectedValue);
          //----------------------------------------------------
          //affichage ds le combobox commercial                   
            cb_commercial.DataSource = commercialDao.List();//fonction pour afficher une liste
            cb_commercial.SelectedIndex = 0; //la selection est sur le premier de la liste
            //instanciation des variables adresses et clients
            Client marecherche = new Client();
            adresseclient monadresse = new adresseclient();
            List <Commande> macommande = new List<Commande>();//liste de type commande
            commercial moncommercial = new commercial();           
            //--------------------------------------------------------------------
           //appel de la fonction find
            marecherche = clientDao.findclient((int)lb_client.SelectedValue);
            monadresse = adresseDao.findadresse(marecherche.Adresse_id);
            macommande = commandeDao.List((int)lb_client.SelectedValue);          
            moncommercial = commercialDao.findcommercial((int)lb_client.SelectedValue);
          
            //---------------------------------------------------------------------          
            //affichage dans le formulaire
            tb_nom.Text = marecherche.Client_nom.ToString();
            tb_adresse.Text = monadresse.adresse_rue.ToString();
            tb_prenom.Text = marecherche.Client_prenom.ToString();
            tb_siret.Text = marecherche.Client_siret.ToString();
            tb_coefficient.Text = marecherche.Client_coefficient.ToString();
            tb_codepostal.Text = monadresse.adresse_codepostal.ToString();
            tb_ville.Text = monadresse.adresse_ville.ToString();
            tb_telephone.Text = monadresse.adresse_telephone.ToString();
            tb_mail.Text = monadresse.adresse_mail.ToString(); ;           
            cb_commercial.SelectedValue = marecherche.Commercial_numero;
            tb_reference.Text = marecherche.Client_id.ToString();
            
            //---------------------------------------------
            //affichage dans la listebox commandes
            lb_commande.DataSource = macommande;

            //----------------------------------------------------
            //cochage des radiobtn
            rb_particulier.Checked = marecherche.Client_categorie;
            rb_professionnel.Checked = !marecherche.Client_categorie; 

            //équivalent à ce qu'il y a au dessus
            //if (marecherche.Client_categorie)
            //{
            //    rb_particulier.Checked = true;
            //    Console.WriteLine("particulier");
            //}
            //else
            //{
            //    rb_professionnel.Checked = true;
            //    Console.WriteLine("professionnel");
            //}     
        }   

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //appel de la fonction d'initialisation
            initialisationclient();
            moncas = ContexteFormulaire.Ajouter;          
       }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            switch(moncas)
            {
                case ContexteFormulaire.Ajouter:
                    AjouterNouveauClient();
                    break;
                case ContexteFormulaire.Modification:
                    ModifierClient();
                    break;
                //case ContexteFormulaire.Supprimer:
                //    SupprimerClient();
                //    break;
            }
            gpbx_coordonnees.Enabled = false;            
        }

        private void SupprimerClient()
        {
            DialogResult result1 = MessageBox.Show("Souhaitez vous supprimer ce client ?", "Important Query", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result1 == DialogResult.Yes)
            {
               // Client clientsupprime = clientDao.findclient((int)lb_client.SelectedValue);
                clientDao.deleteclient((int)lb_client.SelectedValue);
                RechargerLesListesclients();
            }
        }

        private void AjouterNouveauClient()
        {
            //variable pour stocker l'id de l'adresse
            int idadresse = 0;

            //enregistrement de l'adresse
            adresseclient nouvelleadresse = new adresseclient();
            nouvelleadresse.adresse_rue = tb_adresse.Text;
            nouvelleadresse.adresse_codepostal = Convert.ToInt32(tb_codepostal.Text);
            nouvelleadresse.adresse_ville = tb_ville.Text;
            nouvelleadresse.adresse_mail = tb_mail.Text;
            nouvelleadresse.adresse_telephone = tb_telephone.Text;

            idadresse = adresseDao.insertadresse(nouvelleadresse);

            //création d'un nouveau client 
            Client nouveauclient = new Client();
            if (rb_particulier.Checked)
            {
                nouveauclient.Client_categorie = true;
            }
            if (rb_professionnel.Checked)
            {
                nouveauclient.Client_categorie = false;
            }
            if (nouveauclient.Client_categorie)
            {
                nouveauclient.Client_nom = tb_nom.Text;
                nouveauclient.Client_prenom = tb_prenom.Text;
                nouveauclient.Commercial_numero = (int)cb_commercial.SelectedValue;
                nouveauclient.Adresse_id = idadresse;
            }
            else
            {
                nouveauclient.Client_nom = tb_nom.Text;
                nouveauclient.Client_prenom = tb_prenom.Text;
                nouveauclient.Client_siret = tb_siret.Text;
                nouveauclient.Commercial_numero = (int)cb_commercial.SelectedValue;
                nouveauclient.Adresse_id = idadresse;
            }
            clientDao.insertclient(nouveauclient);
            RechargerLesListesclients();
        }

        private void ModifierClient()
        {
            //int idadresse = 0;

            Client UpdateClient = clientDao.findclient((int)lb_client.SelectedValue);
            adresseclient UpdateAdresse = adresseDao.findadresse(UpdateClient.Adresse_id);

            UpdateAdresse.adresse_rue = tb_adresse.Text;
            UpdateAdresse.adresse_codepostal = Convert.ToInt32(tb_codepostal.Text);
            UpdateAdresse.adresse_ville = tb_ville.Text;
            UpdateAdresse.adresse_telephone = tb_telephone.Text;
            UpdateAdresse.adresse_mail = tb_mail.Text;
            
            adresseDao.updateadresse(UpdateAdresse);

            if (rb_particulier.Checked)
            {
                UpdateClient.Client_categorie = true;
            }
            if (rb_professionnel.Checked)
            {
                UpdateClient.Client_categorie = false;
            }
            if (UpdateClient.Client_categorie)
            {
                UpdateClient.Client_nom = tb_nom.Text;
                UpdateClient.Client_prenom = tb_prenom.Text;
                UpdateClient.Commercial_numero = (int)cb_commercial.SelectedValue;
                UpdateClient.Client_id = Convert.ToInt32(tb_reference.Text);                          
            }
            else
            {
                UpdateClient.Client_nom = tb_nom.Text;
                UpdateClient.Client_prenom = tb_prenom.Text;
                UpdateClient.Client_siret = tb_siret.Text;
                UpdateClient.Commercial_numero = (int)cb_commercial.SelectedValue;
                UpdateClient.Client_id = Convert.ToInt32(tb_reference.Text);
            }
            clientDao.updateclient(UpdateClient);
            RechargerLesListesclients();           
    }

        private void rb_particulier_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_particulier.Checked)
            {
                tb_siret.Enabled = false;
                tb_siret.Clear();
            }
            else
            {
                tb_siret.Enabled = true;
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            lbl_commandes.Visible = false;
            lbl_commande.Visible = false;
            btn_valider.Visible = true;
            moncas = ContexteFormulaire.Modification;
            gpbx_coordonnees.Enabled = true;
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            //  moncas = ContexteFormulaire.Supprimer;
            SupprimerClient();
        }

        private void cb_recherchenom_SelectedValueChanged(object sender, EventArgs e)
        {
            //Permet de s'assurer qu'il y a bien une valeur dans SelectedValue
            //avant de caster en int.
            if(cb_recherchenom.SelectedValue != null)
            {
                int idSelectionne = (int)cb_recherchenom.SelectedValue;
                Client clientSelectionne = clientDao.findclient(idSelectionne);
                lb_client.SelectedValue = idSelectionne;
            }
        }

        private void tb_nom_Validating(object sender, CancelEventArgs e)
        {
            mesclasses fonction = new mesclasses();
            fonction.VerifString(tb_nom.Text, errorProvider1, tb_nom);
        }

        private void tb_prenom_Validating(object sender, CancelEventArgs e)
        {
            mesclasses fonction = new mesclasses();
            fonction.VerifString(tb_prenom.Text, errorProvider1, tb_prenom);
        }

        private void tb_codepostal_Validating(object sender, CancelEventArgs e)
        {
            mesclasses fonction = new mesclasses();
            fonction.VerifInt(tb_codepostal.Text, 5, tb_codepostal, errorProvider1);
        }

   
        private void tb_siret_Validating(object sender, CancelEventArgs e)
        {
            if(rb_professionnel.Checked)
            {
                mesclasses fonction = new mesclasses();
                fonction.VerifInt(tb_siret.Text, 14, tb_siret, errorProvider1);
            }
                        
        }

        private void tb_ville_Validating(object sender, CancelEventArgs e)
        {
            mesclasses fonction = new mesclasses();
            fonction.VerifString(tb_ville.Text, errorProvider1, tb_ville);
        }

        private void tb_mail_Validating(object sender, CancelEventArgs e)
        {
            mesclasses fonction = new mesclasses();
            fonction.VerifMail(tb_mail.Text, errorProvider1, tb_mail);
        }


        private void tb_telephone_Validating(object sender, CancelEventArgs e)
        {
            mesclasses fonction = new mesclasses();
            fonction.VerifInt(tb_telephone.Text, 10, tb_telephone, errorProvider1);
        }
    }
}

