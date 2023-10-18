using System;
using System.Collections.Generic;

#nullable disable

namespace GC.RESUME.CORE.DAL.Entities
{
    public partial class Education
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string SchoolName { get; set; }
        public string DegreeTitle { get; set; }
        public string DegreePath { get; set; }
        public DateTime FromDt { get; set; }
        public DateTime ToDt { get; set; }
        public decimal Gpa { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
