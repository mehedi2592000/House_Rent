﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Entity_Layer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class House_RentEntities : DbContext
    {
        public House_RentEntities()
            : base("name=House_RentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Caretaker> Caretakers { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Tanant> Tanants { get; set; }
    }
}