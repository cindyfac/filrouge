using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public partial class Commande
    {
        public string InfoCommande
        {
            get
            {
               return string.Format("Ref : {0} Date : {1} Total : {2} €", Commande_id, Commande_date, Commande_totalTTC);
            }
        }
    }
}
