using CitrineHomeHealth.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CitrineHomeHealth.Data_Layer
{
    public class ApplicantDbContext : DbContext
    {
        public ApplicantDbContext() : base()
        {
        }
        public DbSet<Applicant> Applicants { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            ////Configure default schema
            //modelBuilder.HasDefaultSchema("Applicant");

            ////Map entity to table
            //modelBuilder.Entity<Applicant>().ToTable("ApplicantInfo");

            modelBuilder.Configurations.Add(new ApplicantConfiguration());

            base.OnModelCreating(modelBuilder);

            
        }
    }
}