using Microsoft.AspNetCore.Mvc;
using GC.RESUME.CORE.DAL.Entities;

namespace GC.RESUME.API.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class LanguagesController : BaseController
    {
        public LanguagesController(ResumeContext context) : base(context) { }

        [HttpGet]

        public async Task<List<Language>> Index()
        {
            try
            {
                return base.Index(_context.Languages).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public IEnumerable<Language> Get()
        //{
        //    return _context.Languages;
        //}

        [HttpGet("{id}")]
        public Language Get(Guid id)
        {
            return _context.Languages.FirstOrDefault(s => s.Id == id);
        }
    }
}
