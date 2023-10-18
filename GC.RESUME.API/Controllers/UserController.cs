using Microsoft.AspNetCore.Mvc;
using GC.RESUME.CORE.DAL.Entities;

namespace GC.RESUME.API.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class UserController : BaseController
    {
        public UserController(ResumeContext context) : base(context) { }

        [HttpGet]

        public async Task<List<User>> Index()
        {
            return base.Index(_context.Users).Result;
        }


        //public IEnumerable<user> Get()
        //{
        //    return _context.user;
        //}

        [HttpGet("{id}")]
        public User Get(Guid id)
        {
            return _context.Users.FirstOrDefault(s => s.Id == id);
        }
    }
}
