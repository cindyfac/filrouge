//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fournit
    {
        public int Produit_reffournisseur { get; set; }
        public System.DateTime Produit_date { get; set; }
        public int Produit_quantite { get; set; }
        public int Fournisseur_code { get; set; }
        public int Produit_reference { get; set; }
    
        public virtual Fournisseur Fournisseur { get; set; }
        public virtual Produits Produits { get; set; }
    }
}