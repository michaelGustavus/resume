using Microsoft.AspNetCore.Mvc;
using GC.RESUME.CORE.DAL.Entities;

namespace GC.RESUME.API.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class ExperienceController : BaseController
    {
        public ExperienceController(ResumeContext context) : base(context) { }

        [HttpGet]

        public async Task<List<Experience>> Index()
        {
            try
            {
                return base.Index(_context.Experiences).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public IEnumerable<Experience> Get()
        //{
        //    return _context.Experiences;
        //}

        [HttpGet("{id}")]
        public Experience Get(Guid id)
        {
            return _context.Experiences.FirstOrDefault(s => s.Id == id);
        }
    }
}
