using System;
using System.Collections.Generic;

#nullable disable

namespace GC.RESUME.CORE.DAL.Entities
{
    public partial class Profile
    {
        public Profile()
        {
            Awards = new HashSet<Award>();
            Certifications = new HashSet<Certification>();
            Educations = new HashSet<Education>();
            Emails = new HashSet<email>();
            Experiences = new HashSet<Experience>();
            Languages = new HashSet<Language>();
            Links = new HashSet<Link>();
            Phones = new HashSet<Phone>();
        }

        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string About { get; set; }
        public string Interests { get; set; }
        public string PicUrl { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Award> Awards { get; set; }
        public virtual ICollection<Certification> Certifications { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
        public virtual ICollection<email> Emails { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<Language> Languages { get; set; }
        public virtual ICollection<Link> Links { get; set; }
        public virtual ICollection<Phone> Phones { get; set; }
    }
}
