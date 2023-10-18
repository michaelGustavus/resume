using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GC.RESUME.CORE.DAL.Entities;

namespace GC.RESUME.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AwardsController : BaseController
    {

        public AwardsController(ResumeContext context) : base(context) { }

        // GET: Awards
        [HttpGet]
        public async Task<List<Award>> Index()
        {
            try
            {
                var awards = base.Index(_context.Award).Result;
                return awards;
            }

            catch (Exception ex)
            {
                throw ex;
            }


        }

        //[HttpGet]
        //public IEnumerable<Award> Get()
        //{
        //    return _context.Awards;
        //}

        //[HttpGet("{id}")]
        //public Award Get(int id)
        //{
        //    return _context.Awards.FirstOrDefault(s => s.Id == id);
        //}

        // POST: Awards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProfileId,place,location,compName,yearRec")] Award Award)
        {
            if (ModelState.IsValid)
            {
                _context.Add(Award);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProfileId"] = new SelectList(_context.Profiles, "Id", "address", Award.ProfileId);
            return View(Award);
        }

        // POST: Awards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ProfileId,place,location,compName,yearRec")] Award Award)
        {
            if (id != Award.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(Award);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AwardExists(Award.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProfileId"] = new SelectList(_context.Profiles, "Id", "address", Award.ProfileId);
            return View(Award);
        }

        // POST: Awards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Award == null)
            {
                return Problem("Entity set 'ResumeContext.Awards'  is null.");
            }
            var Award = await _context.Award.FindAsync(id);
            if (Award != null)
            {
                _context.Award.Remove(Award);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AwardExists(Guid id)
        {
            return (_context.Award?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
