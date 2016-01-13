using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CitrineHomeHealth.Models
{
    public class Applicant
    {
        public int ApplicantId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte[] fileUpload { get; set; }
    }
}