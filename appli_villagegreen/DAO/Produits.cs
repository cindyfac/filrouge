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
    
    public partial class Produits
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produits()
        {
            this.Contient = new HashSet<Contient>();
            this.Fournit = new HashSet<Fournit>();
        }
    
        public int Produit_reference { get; set; }
        public string Produit_libelle1 { get; set; }
        public string Produit_libelle2 { get; set; }
        public string Produit_photo { get; set; }
        public bool Produit_actif { get; set; }
        public double Produit_prixactuelHT { get; set; }
        public int Rubrique_identifiant { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contient> Contient { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fournit> Fournit { get; set; }
        public virtual Rubrique Rubrique { get; set; }
    }
}