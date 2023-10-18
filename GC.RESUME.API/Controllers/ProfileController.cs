using Microsoft.AspNetCore.Mvc;
using GC.RESUME.CORE.DAL.Entities;

namespace GC.RESUME.API.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class ProfileController : BaseController
    {
        public ProfileController(ResumeContext context) : base(context) { }

        [HttpGet]

        public async Task<List<Profile>> Index()
        {
            try
            {
                return base.Index(_context.Profiles).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public IEnumerable<Profile> Get()
        //{
        //    return _context.Profiles;
        //}

        [HttpGet("{id}")]
        public Profile Get(Guid id)
        {
            return _context.Profiles.FirstOrDefault(s => s.Id == id);
        }
    }
}
