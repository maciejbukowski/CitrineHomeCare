using CitrineHomeHealth.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CitrineHomeHealth.Data_Layer
{
    public class ApplicantConfiguration : EntityTypeConfiguration<Applicant>
    {
        public ApplicantConfiguration()
        {
            Property(a => a.Phone).HasMaxLength(15).IsOptional();
        }
    }
}