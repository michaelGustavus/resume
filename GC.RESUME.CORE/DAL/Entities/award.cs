using System;
using System.Collections.Generic;

#nullable disable

namespace GC.RESUME.CORE.DAL.Entities
{
    public partial class Award
    {
        public Guid Id { get; set; }
        public Guid ProfileId { get; set; }
        public string Place { get; set; }
        public string Location { get; set; }
        public string CompName { get; set; }
        public int YearRec { get; set; }

        public virtual Profile Profile { get; set; }
    }
}
