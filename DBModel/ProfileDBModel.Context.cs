﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyProjectProfile.DBModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProfileDBContext : DbContext
    {
        public ProfileDBContext()
            : base("name=ProfileDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Profile_table> Profile_table { get; set; }
        public virtual DbSet<Greeting> Greetings { get; set; }
        public virtual DbSet<Industry_Worked> Industry_Worked { get; set; }
        public virtual DbSet<Terms_Conditions> Terms_Conditions { get; set; }
        public virtual DbSet<Profile_Industry_Intermediate_Table> Profile_Industry_Intermediate_Table { get; set; }
    }
}
