﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _420_476_VIVLIO.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FSPCEntities : DbContext
    {
        public FSPCEntities()
            : base("name=FSPCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Matiere> Matiere { get; set; }
        public virtual DbSet<Message> Message { get; set; }
        public virtual DbSet<Niveau> Niveau { get; set; }
        public virtual DbSet<Offer> Offer { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}