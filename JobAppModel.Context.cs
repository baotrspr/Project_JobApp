﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_JobApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class JobAppDFContext : DbContext
    {
        public JobAppDFContext()
            : base("name=JobAppDFContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCOUNT> ACCOUNT { get; set; }
        public virtual DbSet<COMPANY> COMPANY { get; set; }
        public virtual DbSet<CONGVIEC> CONGVIEC { get; set; }
        public virtual DbSet<JOBSEEKER> JOBSEEKER { get; set; }
        public virtual DbSet<UNGTUYEN> UNGTUYEN { get; set; }
    }
}