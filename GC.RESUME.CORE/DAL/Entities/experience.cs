using System;
using System.Collections.Generic;

#nullable disable

namespace GC.RESUME.CORE.DAL.Entities
{
    public partial class Experience
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string Title { get; set; }
        public string Employer { get; set; }
        public DateTime? FromDt { get; set; }
        public DateTime? ToDt { get; set; }
        public string Description { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
