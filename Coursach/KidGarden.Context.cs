﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Coursach
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Kid_GardenEntities : DbContext
    {
        public Kid_GardenEntities()
            : base("name=Kid_GardenEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Kid_Garden> Kid_Gardens { get; set; }
        public virtual DbSet<Kids__Personal_Account> Kids__Personal_Account { get; set; }
        public virtual DbSet<Month> Months { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<Podrazdelenie> Podrazdelenies { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Visit_Tabel> Visit_Tabel { get; set; }
    }
}
