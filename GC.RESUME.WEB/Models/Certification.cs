using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GC.RESUME.WEB.Models
{

    public class Certification
    {
        public string Title { get; set; }
        public bool ContainsData { get; set; }
        public List<certification> certifications { get; set; }
        public class certification
        {
            public Guid Id { get; set; }
            public Guid ProfileId { get; set; }
            public string recievedFrom { get; set; }
            public string certTitle { get; set; }
        }
    }
}
