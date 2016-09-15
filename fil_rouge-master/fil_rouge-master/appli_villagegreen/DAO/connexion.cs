using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;//

namespace DAO
{
   public class connexion
    {
        public SqlConnection maconnexion;
        public connexion (string chainedeconnexion) //methode de connexion
        {
            
            maconnexion = new SqlConnection(chainedeconnexion);
        }
    }
}
