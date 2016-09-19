using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;

namespace DAO
{
    public class adresseDAO
    {
        //ajouter
        //modifier
        //supprimer
        //afficher
        //rechercher

        SqlConnection maconnexion;

        public adresseDAO (string chaine)//constructeur
        {
            maconnexion = new SqlConnection(chaine);
        }
        public adresseclient findadresse (int id)
        {
            maconnexion.Open();
            //execution de la requete (uniquement en reader)
            SqlCommand marequete = new SqlCommand("select * from Adresse where Adresse_id =@id", maconnexion);
            marequete.Parameters.AddWithValue("@id", id);
            SqlDataReader resultat = marequete.ExecuteReader();
            //declaration d'une variable de type client
            adresseclient mavariable = new adresseclient();
            //stockage du résultat de la recherche dans la nouvelle variable client
            if (resultat.Read())
            {
                mavariable.adresse_rue = Convert.ToString(resultat["Adresse_rue"]);
                mavariable.adresse_codepostal = Convert.ToInt32(resultat["Adresse_codepostal"]);
                mavariable.adresse_ville = Convert.ToString(resultat["Adresse_ville"]);                
                mavariable.adresse_mail = Convert.ToString(resultat["Adresse_mail"]);
                mavariable.adresse_telephone = Convert.ToString(resultat["Adresse_telephone"]);
                mavariable.adresse_id = Convert.ToInt32(resultat["adresse_id"]);
            }
            maconnexion.Close();
            return mavariable;
        }
        //-----------------------------------------------------------------
        //ajouter
        public int insertadresse(adresseclient nouvelleadresse)
        {
            maconnexion.Open();
            SqlCommand marequete = new SqlCommand("insert into Adresse(Adresse_rue, Adresse_codepostal, Adresse_ville, Adresse_mail, Adresse_telephone) values (@rue, @codepostal, @ville, @mail, @telephone); SELECT CAST(scope_identity() AS int)", maconnexion);
            marequete.Parameters.AddWithValue("@rue", nouvelleadresse.adresse_rue);
            marequete.Parameters.AddWithValue("@ville", nouvelleadresse.adresse_ville);
            marequete.Parameters.AddWithValue("@codepostal", nouvelleadresse.adresse_codepostal);
            marequete.Parameters.AddWithValue("@telephone", nouvelleadresse.adresse_telephone);
            marequete.Parameters.AddWithValue("@mail", nouvelleadresse.adresse_mail);

            int adresseId = (int)marequete.ExecuteScalar();
            maconnexion.Close();
            return adresseId;
        }

        //-----------------------------------------------------------------
        //update
        public void updateadresse(adresseclient updateadresse)
        {
            maconnexion.Open();
            SqlCommand marequete = new SqlCommand("update Adresse set Adresse_rue=@rue, Adresse_codepostal=@codepostal, Adresse_ville=@ville, Adresse_mail=@mail, Adresse_telephone=@telephone where Adresse_id =@id", maconnexion);
            marequete.Parameters.AddWithValue("@rue", updateadresse.adresse_rue);
            marequete.Parameters.AddWithValue("@codepostal", updateadresse.adresse_codepostal);
            marequete.Parameters.AddWithValue("@ville", updateadresse.adresse_ville);
            marequete.Parameters.AddWithValue("@mail", updateadresse.adresse_mail);
            marequete.Parameters.AddWithValue("@telephone", updateadresse.adresse_telephone);
            marequete.Parameters.AddWithValue("@id", updateadresse.adresse_id);
            marequete.ExecuteNonQuery();
           
            maconnexion.Close();
       

        }
    }
}
    