using Microsoft.AspNetCore.Mvc;
using GC.RESUME.CORE.DAL.Entities;


namespace GC.RESUME.API.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class EducationController : BaseController
    {
        public EducationController(ResumeContext context) : base(context) { }

        [HttpGet]

        public async Task<List<Education>> Index()
        {
            try
            {
                return base.Index(_context.Educations).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public IEnumerable<Education> Get()
        //{
        //    return _context.Educations;
        //}

        [HttpGet("{id}")]
        public Education Get(Guid id)
        {
            return _context.Educations.FirstOrDefault(s => s.Id == id);
        }
    }
}
