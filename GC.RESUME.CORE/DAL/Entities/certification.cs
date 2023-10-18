using System;
using System.Collections.Generic;

#nullable disable

namespace GC.RESUME.CORE.DAL.Entities
{
    public partial class Certification
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string recievedFrom { get; set; }
        public string CertTitle { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
