using System;
using System.Collections.Generic;

namespace GC.RESUME.WEB.Models
{
    public class Phone
    {
        public string Title { get; set; }
        public bool ContainsData { get; set; }
        public List<phone> phones { get; set; }
        public class phone
        {
            public Guid Id { get; set; }
            public Guid ProfileId { get; set; }
            public string phone1 { get; set; }
        }
    }
}
