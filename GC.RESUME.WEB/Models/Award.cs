using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GC.RESUME.WEB.Models
{
    
    public partial class Award
    {
        public string Title { get; set; }
        public bool ContainsData { get; set; }
        public List<award> Awards { get; set; }
        public class award
        {
            public Guid Id { get; set; }
            public Guid ProfileId { get; set; }
            public string Place { get; set; }
            public string Location { get; set; }
            public string CompName { get; set; }
            public int YearRec { get; set; }
        }
    }
}
