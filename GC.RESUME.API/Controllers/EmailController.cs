using Microsoft.AspNetCore.Mvc;
using GC.RESUME.CORE.DAL.Entities;

namespace GC.RESUME.API.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class EmailController : BaseController
    {
        public EmailController(ResumeContext context) : base(context) { }

        [HttpGet]

        public async Task<List<email>> Index()
        {
            try
            {
                return base.Index(_context.Emails).Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public IEnumerable<Email> Get()
        //{
        //    return _context.Emails;
        //}

        [HttpGet("{id}")]
        public email Get(Guid id)
        {
            return _context.Emails.FirstOrDefault(s => s.Id == id);
        }
    }
}
