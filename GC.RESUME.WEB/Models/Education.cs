using System;
using System.Collections.Generic;

namespace GC.RESUME.WEB.Models
{
    public class Education
    {
        public string Title { get; set; }
        public bool ContainsData { get; set; }
        public List<education> Educations { get; set; }
        public class education
        {
            public Guid Id { get; set; }
            public Guid ProfileId { get; set; }
            public string SchoolName { get; set; }
            public string DegreeTitle { get; set; }
            public string DegreePath { get; set; }
            public DateTime fromDt { get; set; }
            public DateTime toDt { get; set; }
            public decimal GPA { get; set; }
        }
    }
}
