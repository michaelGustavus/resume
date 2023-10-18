using Microsoft.AspNetCore.Mvc;
using GC.RESUME.CORE.DAL.Entities;


namespace GC.RESUME.API.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class CertificationController : BaseController
    {
        public CertificationController(ResumeContext context) : base(context) { }


        [HttpGet]

        public async Task<List<Certification>> Index()
        {
            try
            {
                return base.Index(_context.Certifications).Result;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }


        //public IEnumerable<Certification> Get()
        //{
        //    return _context.Certifications;
        //}

        [HttpGet("{id}")]
        public Certification Get(Guid id)
        {
            return _context.Certifications.FirstOrDefault(s => s.Id == id);
        }
    }
}
