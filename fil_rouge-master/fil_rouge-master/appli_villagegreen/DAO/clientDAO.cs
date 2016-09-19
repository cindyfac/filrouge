using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace DAO
{
    public class clientDAO
    {
        SqlConnection maconnexion;
        public clientDAO(string chaine)//constructeur
        {
            maconnexion = new SqlConnection(chaine);
        }
        //----------------------------------------------------------------------
        //ajouter un client
        public void insertclient (Client monclient) //nouvelle instance de la classe client
        {
            maconnexion.Open();
            if (monclient.Client_categorie)
            {
                SqlCommand marequete = new SqlCommand("insert into Client(Client_nom, Client_prenom, Client_categorie, Client_coefficient, Commercial_id, Adresse_id) values (@nom, @prenom, @categorie, @coefficient, @commercial, @reference)", maconnexion);
                marequete.Parameters.AddWithValue("@nom", monclient.Client_nom);
                marequete.Parameters.AddWithValue("@prenom", monclient.Client_prenom);
                marequete.Parameters.AddWithValue("@categorie", monclient.Client_categorie);
                marequete.Parameters.AddWithValue("@coefficient", monclient.Client_coefficient);
                marequete.Parameters.AddWithValue("@commercial", monclient.Commercial_numero);
                marequete.Parameters.AddWithValue("@reference", monclient.Adresse_id); 
                marequete.ExecuteNonQuery();
            }
            else
            {
                SqlCommand marequete = new SqlCommand("insert into Client(Client_nom, Client_prenom, Client_categorie, Client_coefficient, Client_siret, Commercial_id, Adresse_id) values (@nom, @prenom, @categorie, @coefficient, @siret, @commercial, @reference)", maconnexion);
                marequete.Parameters.AddWithValue("@nom", monclient.Client_nom);
                marequete.Parameters.AddWithValue("@prenom", monclient.Client_prenom);
                marequete.Parameters.AddWithValue("@categorie", monclient.Client_categorie);
                marequete.Parameters.AddWithValue("@coefficient", monclient.Client_coefficient);
                marequete.Parameters.AddWithValue("@siret", monclient.Client_siret);
                marequete.Parameters.AddWithValue("@commercial", monclient.Commercial_numero);
                marequete.Parameters.AddWithValue("@reference", monclient.Adresse_id);
                marequete.ExecuteNonQuery();               
            }
            maconnexion.Close();
        }
        //---------------------------------------------------------------------------
        //modifier
        public void updateclient (Client monclient)
        {
            if (monclient.Client_categorie)
            {
                maconnexion.Open();
                SqlCommand marequete = new SqlCommand("update Client set Client_nom=@nom, Client_prenom=@prenom, Client_categorie=@categorie, Client_coefficient=@coefficient, Commercial_id=@commercial, Client_statut =@statut where Client_id=@id", maconnexion);
                marequete.Parameters.AddWithValue("@nom", monclient.Client_nom);
                marequete.Parameters.AddWithValue("@prenom", monclient.Client_prenom);
                marequete.Parameters.AddWithValue("@categorie", monclient.Client_categorie);
                marequete.Parameters.AddWithValue("@coefficient", monclient.Client_coefficient);
                marequete.Parameters.AddWithValue("@commercial", monclient.Commercial_numero);
                marequete.Parameters.AddWithValue("@statut", monclient.Client_statut);
               
                marequete.Parameters.AddWithValue("@id", monclient.Client_id);
                marequete.ExecuteNonQuery();
            }
            else
            {
                SqlCommand marequete = new SqlCommand("update Client set Client_nom=@nom, Client_prenom=@prenom, Client_categorie=@categorie, Client_coefficient=@coefficient, Commercial_id=@commercial, Client_siret=@siret where Client_id=@id", maconnexion);
                marequete.Parameters.AddWithValue("@nom", monclient.Client_nom);
                marequete.Parameters.AddWithValue("@prenom", monclient.Client_prenom);
                marequete.Parameters.AddWithValue("@categorie", monclient.Client_categorie);
                marequete.Parameters.AddWithValue("@coefficient", monclient.Client_coefficient);
                marequete.Parameters.AddWithValue("@siret", monclient.Client_siret);
                marequete.Parameters.AddWithValue("@commercial", monclient.Commercial_numero);
                marequete.Parameters.AddWithValue("@statut", monclient.Client_statut);

                marequete.Parameters.AddWithValue("@id", monclient.Client_id);
                marequete.ExecuteNonQuery();
            }
            maconnexion.Close();
        }
        //-------------------------------------------------------------------------------
        //supprimer
        public void deleteclient (int id)
        {
            maconnexion.Open();
            SqlCommand marequete = new SqlCommand("update Client set Client_statut=@statut where Client_id =@id", maconnexion);
            marequete.Parameters.AddWithValue("@id", id);
            marequete.Parameters.AddWithValue("@statut", 0);
            marequete.ExecuteNonQuery();
            maconnexion.Close();
          
        }
        //----------------------------------------------------------------------------------
        //rechercher
        public Client findclient (int id)
        {
            maconnexion.Open();
            //execution de la requete (uniquement en reader)
            SqlCommand marequete = new SqlCommand("select * from Client where Client_id =" +id , maconnexion);
            //marequete.Parameters.AddWithValue("@id", id); a supprimer
            SqlDataReader resultat = marequete.ExecuteReader();
            //declaration d'une variable de type client
            Client mavariable = new Client();
            //stockage du résultat de la recherche dans la nouvelle variable client
            if (resultat.Read())
            {
                mavariable.Client_id = Convert.ToInt32(resultat["Client_id"]);
                mavariable.Client_nom = Convert.ToString(resultat["Client_nom"]);
                mavariable.Client_prenom = Convert.ToString(resultat["Client_prenom"]);
                mavariable.Client_categorie = Convert.ToBoolean(resultat["Client_categorie"]);
                mavariable.Client_coefficient = Convert.ToInt32(resultat["Client_coefficient"]);
                mavariable.Adresse_id = Convert.ToInt32(resultat["Adresse_id"]);
                mavariable.Commercial_numero = Convert.ToInt32(resultat["Commercial_id"]);
                if (resultat["Client_siret"] == DBNull.Value)
                {
                    mavariable.Client_siret = 0;
                }
                else
                {
                    mavariable.Client_siret = Convert.ToInt32(resultat["Client_siret"]);
                }
            }
            maconnexion.Close();
            return mavariable;
        }
        //------------------------------------------------------------------------------------
        //afficher sous forme de liste
        public List<Client> List()
        {
            maconnexion.Open();
            SqlCommand marequete = new SqlCommand("select * from Client where Client_statut = 1", maconnexion);
            SqlDataReader resultat = marequete.ExecuteReader();
            //declaration d'une variable de type liste pour stocker les résultats
            List <Client> maliste = new List<Client>();

            while (resultat.Read())
            {
                Client monclient = new Client();
                monclient.Client_id = Convert.ToInt32(resultat["Client_id"]);
                monclient.Client_nom = Convert.ToString(resultat["Client_nom"]);
                monclient.Client_prenom = Convert.ToString(resultat["Client_prenom"]);
                monclient.Client_categorie = Convert.ToBoolean(resultat["Client_categorie"]);
                monclient.Client_coefficient = Convert.ToInt32(resultat["Client_coefficient"]);
                //monclient.Client_siret = Convert.ToInt32(resultat["Client_siret"]);
                maliste.Add(monclient);
            }
            resultat.Close();
            maconnexion.Close();
            return maliste;  
            
        }
        //------------------------------------------
       
    }
}
