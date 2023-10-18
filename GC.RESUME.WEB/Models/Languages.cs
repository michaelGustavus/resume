using System;
using System.Collections.Generic;

namespace GC.RESUME.WEB.Models
{
    public class Languages
    {
        public string Title { get; set; }
        public bool ContainsData { get; set; }
        public List<language> Language { get; set; }
        public class language
        {
            public Guid Id { get; set; }
            public Guid ProfileId { get; set; }
            public string langName { get; set; }
        }
    }
}
