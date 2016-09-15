using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
    public class commandeDAO
    {
        SqlConnection maconnexion;
        public commandeDAO(string chaine)//constructeur
        {
            maconnexion = new SqlConnection(chaine);
        }
        //-----------------------------------------------------------------
        //ajouter
        public void insertcommande(Commande macommande)
        {
            maconnexion.Open();
            SqlCommand marequete = new SqlCommand("insert into Commande(Commande_id, Commande_etat, Commande_paiement, Commande_modepaiement, Commande_date, Commande_TotalHT, Commande_TotalTTC) value (@reference, @etat, @paiement, @modepaiement, @date,@totalHT,@totalttc)", maconnexion);
            marequete.Parameters.AddWithValue("@reference", macommande.Commande_id);
            marequete.Parameters.AddWithValue("@etat", macommande.Commande_etat);
            marequete.Parameters.AddWithValue("@paiement", macommande.Commande_paiement);
            marequete.Parameters.AddWithValue("@modepaiement", macommande.Commande_modepaiement);
            marequete.Parameters.AddWithValue("@date", macommande.Commande_date);
            marequete.Parameters.AddWithValue("@totalht", macommande.Commande_totalHT);
            marequete.Parameters.AddWithValue("@totalttc", macommande.Commande_totalTTC);
            marequete.ExecuteNonQuery();
            maconnexion.Close();
        }
        //-------------------------------------------------------------------
        //modifier
        public void updatecommande (Commande macommande)
        {
            maconnexion.Open();
            SqlCommand marequete = new SqlCommand("update into Commande(Commande_id, Commande_etat, Commande_paiement, Commande_modepaiement, Commande_date, Commande_TotalHT, Commande_TotalTTC) value (@reference, @etat, @paiement, @modepaiement, @date,@totalHT,@totalttc) where Commande_id = @id", maconnexion);
            marequete.Parameters.AddWithValue("@reference", macommande.Commande_id);
            marequete.Parameters.AddWithValue("@etat", macommande.Commande_etat);
            marequete.Parameters.AddWithValue("@paiement", macommande.Commande_paiement);
            marequete.Parameters.AddWithValue("@modepaiement", macommande.Commande_modepaiement);
            marequete.Parameters.AddWithValue("@date", macommande.Commande_date);
            marequete.Parameters.AddWithValue("@totalht", macommande.Commande_totalHT);
            marequete.Parameters.AddWithValue("@totalttc", macommande.Commande_totalTTC);
            marequete.ExecuteNonQuery();
            maconnexion.Close();
        }
        //------------------------------------------------------------------
        //suprimer
        public void deletecommande (int id)
        {
            maconnexion.Open();
            SqlCommand marequete = new SqlCommand("delete from Commande where Commande_id = @id", maconnexion);
            marequete.Parameters.AddWithValue("@id", id);
            marequete.ExecuteNonQuery();
            maconnexion.Close();
        }
        //-------------------------------------------------------------------
        //afficher
        public List<Commande> List(int id)
        {
            maconnexion.Open();
            SqlCommand marequete = new SqlCommand("select * from Commande where Client_id =@id", maconnexion);
            marequete.Parameters.AddWithValue("@id", id);
            SqlDataReader resultat = marequete.ExecuteReader();
            //declaration d'une variable de type liste pour stocker les résultats
            List<Commande> maliste = new List<Commande>();

            while (resultat.Read())
            {
                Commande macommande = new Commande();
                macommande.Commande_id = Convert.ToInt32(resultat["Commande_id"]);
                macommande.Commande_etat = Convert.ToString(resultat["Commande_etat"]);
                macommande.Commande_modepaiement = Convert.ToString(resultat["Commande_modepaiement"]);
                macommande.Commande_paiement = Convert.ToBoolean(resultat["Commande_paiement"]);
                macommande.Commande_date = Convert.ToDateTime(resultat["Commande_date"]);
                macommande.Commande_totalHT = Convert.ToInt32(resultat["Commande_totalHT"]);
                macommande.Commande_totalTTC = Convert.ToInt32(resultat["Commande_totalTTC"]);
                maliste.Add(macommande);
            }
            resultat.Close();
            maconnexion.Close();
            return maliste;

        }
    
    //---------------------------------------------------------------------------
        //rechercher
         public Commande findcommande (int id)
        {
            maconnexion.Open();
            //execution de la requete (uniquement en reader)
            SqlCommand marequete = new SqlCommand("select * from Commande where Client_id =@id" , maconnexion);
            marequete.Parameters.AddWithValue("@id", id);
            SqlDataReader resultat = marequete.ExecuteReader();
            //declaration d'une variable de type client
            Commande mavariable = new Commande();
            //stockage du résultat de la recherche dans la nouvelle variable client
            if (resultat.Read())
            {
                mavariable.Commande_id = Convert.ToInt32(resultat["Commande_id"]);
                mavariable.Commande_etat = Convert.ToString(resultat["Commande_etat"]);
                mavariable.Commande_paiement = Convert.ToBoolean(resultat["Commande_paiement"]);
                mavariable.Commande_modepaiement = Convert.ToString(resultat["Commande_modepaiement"]);
                mavariable.Commande_date = Convert.ToDateTime(resultat["Commande_date"]);
                mavariable.Commande_totalHT = Convert.ToInt32(resultat["Commande_totalHT"]);
                mavariable.Commande_totalHT = Convert.ToInt32(resultat["Commande_totalTTC"]);
                mavariable.Client_id = Convert.ToInt32(resultat["Client_id"]);
            }
            maconnexion.Close();
            return mavariable;
        }
    }
}
