using GC.RESUME.CORE.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GC.RESUME.API.Controllers
{
    public class BaseController: Controller
    {
        public readonly ResumeContext _context;
        

        public BaseController(ResumeContext context)
        {
            _context = context;
        }
        public async Task<List<TEntity>> Index<TEntity>(DbSet<TEntity> entities) where TEntity : class 
        {
            return entities.ToList();
        }

    }
}
