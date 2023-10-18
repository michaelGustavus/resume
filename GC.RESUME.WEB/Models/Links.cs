using System;
using System.Collections.Generic;

namespace GC.RESUME.WEB.Models
{
    public class Links
    {
        public string Title { get; set; }
        public bool ContainsData { get; set; }
        public List<link> links { get; set; }
        public class link
        {
            public Guid Id { get; set; }
            public Guid profileId { get; set; }
            public string LinkedInURL { get; set; }
            public string FacebookURL { get; set; }
            public string GithubURL { get; set; }
            public string TwitterURL { get; set; }
        }
    }
}
