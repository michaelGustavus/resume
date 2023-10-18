using System;
using System.Collections.Generic;

namespace GC.RESUME.WEB.Models
{
    public class Email
    {
        public string Title { get; set; }
        public bool ContainsData { get; set; }
        public List<email> Emails { get; set; }
        public class email
        {
            public Guid Id { get; set; }
            public Guid ProfileId { get; set; }
            public string email1 { get; set; }
        }
    }
}
