using GC.RESUME.WEB.Controllers;
using GC.RESUME.WEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace GC.WEB.Controllers
{
    public class ResumeController : BaseController
    {
        IConfiguration _configuration;
        public ResumeController(IConfiguration configuration) 
        { 
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            Resume resume = new Resume();
            string baseUri = _configuration.GetValue<string>("apiUrl");


            resume.profiles.profiles = GetList<Profiles.profile>(new Uri($"{baseUri}/profile"));
            if (resume.profiles == null || resume.profiles.profiles.Count == 0) { resume.profiles.Title = string.Empty; resume.profiles.ContainsData = false; resume.profiles.ObjectiveTitle = string.Empty; } else {resume.profiles.Title = "About"; resume.profiles.ContainsData = true; resume.profiles.ObjectiveTitle = "Objective"; }

            resume.emails.Emails = GetList<Email.email>(new Uri($"{baseUri}/email"));
            if (resume.emails == null || resume.emails.Emails.Count == 0) { resume.emails.Title = string.Empty; resume.emails.ContainsData = false; } else { resume.emails.Title = "Emails"; resume.emails.ContainsData = true; }

            resume.certifications.certifications = GetList<Certification.certification>(new Uri($"{baseUri}/certification"));
            if (resume.certifications == null || resume.certifications.certifications.Count == 0) { resume.certifications.Title = string.Empty; resume.certifications.ContainsData = false; } else { resume.certifications.Title = "Certifications"; resume.certifications.ContainsData = true; }

            resume.educations.Educations = GetList<Education.education>(new Uri($"{baseUri}/education"));
            if (resume.educations == null || resume.educations.Educations.Count == 0) { resume.educations.Title = string.Empty; resume.educations.ContainsData = false; } else { resume.educations.Title = "Educations"; resume.educations.ContainsData = true; }

            resume.Experiences.experiences = GetList<Experience.experience>(new Uri($"{baseUri}/experience"));
            if (resume.Experiences == null || resume.Experiences.experiences.Count == 0) { resume.Experiences.Title = string.Empty; resume.Experiences.ContainsData = false; } else { resume.Experiences.Title = "Experieces"; resume.Experiences.ContainsData = true; }

            resume.languages.Language = GetList<Languages.language>(new Uri($"{baseUri}/languages"));
            if (resume.languages == null || resume.languages.Language.Count == 0) { resume.languages.Title = string.Empty; resume.languages.ContainsData = false; } else { resume.languages.Title = "Skills"; resume.languages.ContainsData = true; }

            resume.links.links = GetList<Links.link>(new Uri($"{baseUri}/links"));
            if (resume.links == null || resume.links.links.Count == 0) { resume.links.Title = string.Empty; resume.links.ContainsData = false; } else { resume.links.Title = "Links"; resume.links.ContainsData = true; }

            resume.phones.phones = GetList<Phone.phone>(new Uri($"{baseUri}/phone"));
            if (resume.phones == null || resume.phones.phones.Count == 0) { resume.phones.Title = string.Empty; resume.phones.ContainsData = false; } else { resume.phones.Title = "Phones"; resume.phones.ContainsData = true; }

            resume.users = GetList<User>(new Uri($"{baseUri}/user"));

            resume.awards.Awards = GetList<Award.award>(new Uri($"{baseUri}/Awards/Index"));
            if (resume.awards == null || resume.awards.Awards.Count == 0) { resume.awards.Title = string.Empty; resume.awards.ContainsData = false; } else { resume.awards.Title = "Awards"; resume.awards.ContainsData = true; }
            return View(resume);
        }
    }
}
