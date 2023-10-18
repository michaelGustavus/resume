using System;
using System.Collections.Generic;

namespace GC.RESUME.WEB.Models
{
    public class Profiles
    {
        public string Title { get; set; }
        public string ObjectiveTitle { get; set; }
        public bool ContainsData { get; set; }
        public List<profile> profiles { get; set; }
        public class profile { 
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string firstName { get; set; }
        public string midName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string about { get; set; }
        public string interests { get; set; }
        public string picURL { get; set; }
        }
    }
}
