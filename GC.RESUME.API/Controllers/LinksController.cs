using Microsoft.AspNetCore.Mvc;
using GC.RESUME.CORE.DAL.Entities;

namespace GC.RESUME.API.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class LinksController : BaseController
    {
        public LinksController(ResumeContext context) : base(context) { }

        [HttpGet]

        public async Task<List<Link>> Index()
        {
            try
            {
                return base.Index(_context.Links).Result;
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
        public Link Get(Guid id)
        {
            return _context.Links.FirstOrDefault(s => s.Id == id);
        }
    }
}
