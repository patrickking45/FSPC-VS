//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _420_476_VIVLIO.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Offer
    {
        public int OfferID { get; set; }
        public int MatiereID { get; set; }
        public int NiveauID { get; set; }
        public int UserID { get; set; }
        public decimal Price { get; set; }
        public System.DateTime CreationDate { get; set; }
        public Nullable<System.DateTime> PostedDate { get; set; }
        public string Status { get; set; }
        public byte[] Photo { get; set; }
        public string Author_CompanyName { get; set; }
        public string Condition { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
    
        public virtual Matiere Matiere { get; set; }
        public virtual Niveau Niveau { get; set; }
        public virtual User User { get; set; }
    }
}
