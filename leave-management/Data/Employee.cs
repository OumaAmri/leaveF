using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Data
{
    public class Employee : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Phone { get; set; }
        public string Matricule { get; set; }
        public string Tower { get; set; }
        public string Manager { get; set; }


        public DateTime StartDate { get; set; }


        public DateTime EndDate { get; set; }


        public DateTime EnboardingDate { get; set; }
        public string JobTitle { get; set; }

        public string SkillSet { get; set; }
        public string MainSpeciality { get; set; }
        public string Certification { get; set; }
        public string OtherRequiredSkill { get; set; }
        public string Provider { get; set; }
        public string SubcoName { get; set; }


        public DateTime CreationDate { get; set; }

        public string Rate { get; set; }
    }
}
