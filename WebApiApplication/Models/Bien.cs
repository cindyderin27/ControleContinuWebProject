//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bien
    {
        public int Id { get; set; }
        public System.DateTime DateCreation { get; set; }
        public string Nom { get; set; }
        public int IdProprietaire { get; set; }
    
        public virtual Proprietaire Proprietaire { get; set; }
    }
}
