﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectPrepared.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class projectDBEntities : DbContext
    {
        public projectDBEntities()
            : base("name=projectDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminRegistration> AdminRegistrations { get; set; }
        public virtual DbSet<applicaition> applicaitions { get; set; }
        public virtual DbSet<appPROFILE> appPROFILEs { get; set; }
        public virtual DbSet<financialstatu> financialstatus { get; set; }
        public virtual DbSet<posttable> posttables { get; set; }
        public virtual DbSet<Registration> Registrations { get; set; }
        public virtual DbSet<transact> transacts { get; set; }
        public virtual DbSet<viewapplicant> viewapplicants { get; set; }
    }
}
