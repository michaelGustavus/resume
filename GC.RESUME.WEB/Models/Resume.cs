using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace GC.RESUME.WEB.Models
{
    public class Resume
    {
        public Award awards = new Award();
        public Profiles profiles = new Profiles();
        public Email emails = new Email();
        public Education educations = new Education();
        public Certification certifications = new Certification();
        public Experience Experiences = new Experience();
        public Languages languages = new Languages();
        public Links links = new Links();
        public Phone phones = new Phone();
        public List<User> users = new List<User>();

    }
}
