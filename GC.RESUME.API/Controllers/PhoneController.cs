using Microsoft.AspNetCore.Mvc;
using GC.RESUME.CORE.DAL.Entities;

namespace GC.RESUME.API.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class PhoneController : BaseController
    {
        public PhoneController(ResumeContext context) : base(context) { }

        [HttpGet]

        public async Task<List<Phone>> Index()
        {
            try
            {
                return base.Index<Phone>(_context.Phones).Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public IEnumerable<Phone> Get()
        //{
        //    return _context.Phones;
        //}

        [HttpGet("{id}")]
        public Phone Get(Guid id)
        {
            return _context.Phones.FirstOrDefault(s => s.Id == id);
        }
    }
}
