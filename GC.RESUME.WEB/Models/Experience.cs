using System;
using System.Collections.Generic;

namespace GC.RESUME.WEB.Models
{
    public class Experience
    {
        public string Title { get; set; }
        public bool ContainsData { get; set; }
        public List<experience> experiences { get; set; }
        public class experience
        {
            public Guid Id { get; set; }
            public Guid ProfileId { get; set; }
            public string title { get; set; }
            public string employer { get; set; }
            public DateTime fromDt { get; set; }
            public DateTime toDt { get; set; }
            public string description { get; set; }
        }
    }
}
