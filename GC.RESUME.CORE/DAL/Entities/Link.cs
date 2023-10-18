using System;
using System.Collections.Generic;

#nullable disable

namespace GC.RESUME.CORE.DAL.Entities
{
    public partial class Link
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string LinkedInUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string GithubUrl { get; set; }
        public string TwitterUrl { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
