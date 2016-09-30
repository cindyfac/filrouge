using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAO
{
   public class commercialDAO
    {
        SqlConnection maconnexion;
        public commercialDAO(string chaine)//constructeur
        {
            maconnexion = new SqlConnection(chaine);
        }
        public List<commercial> List()
        {            
            maconnexion.Open();
            SqlCommand marequete = new SqlCommand("select * from Commercial", maconnexion);
            SqlDataReader resultat = marequete.ExecuteReader();

            //declaration d'une variable de type liste pour stocker les résultats
            List<commercial> maliste = new List<commercial>();

            while (resultat.Read())
            {
                commercial moncommercial = new commercial();
                moncommercial.Commercial_id = Convert.ToInt32(resultat["Commercial_id"]);
                moncommercial.Commercial_prenom = Convert.ToString(resultat["Commercial_prenom"]);
                moncommercial.Commercial_nom = Convert.ToString(resultat["Commercial_nom"]);

                maliste.Add(moncommercial);
            }
            resultat.Close();
            maconnexion.Close();
            return maliste;
        }


        public commercial findcommercial(int id)
        {
            maconnexion.Open();
            //execution de la requete (uniquement en reader)
            SqlCommand marequete = new SqlCommand("select * from Commercial where Commercial_id =" + id, maconnexion);
            //marequete.Parameters.AddWithValue("@id", id); a supprimer
            SqlDataReader resultat = marequete.ExecuteReader();
            //declaration d'une variable de type commercial
            commercial mavariable = new commercial();
            //stockage du résultat de la recherche dans la nouvelle variable commercial
            if (resultat.Read())
            {
                mavariable.Commercial_id = Convert.ToInt32(resultat["Commercial_id"]);
                mavariable.Commercial_nom = Convert.ToString(resultat["Commercial_nom"]);
                mavariable.Commercial_prenom = Convert.ToString(resultat["Commercial_prenom"]);
              
            }
            maconnexion.Close();
            return mavariable;
        }

    }
}
