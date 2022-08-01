using Bai_8_View.Context;
using Bai_8_View.DomainClass;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Bai_8_View.Controllers
{
    public class NsxeController : Controller
    {
        private readonly FpolyDBContext _context;

        public NsxeController()
        {
            _context = new FpolyDBContext();
        }

        // GET: Nsxe
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nsx.ToListAsync());
        }

        // GET: Nsxe/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nsx = await _context.Nsx
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nsx == null)
            {
                return NotFound();
            }

            return View(nsx);
        }

        // GET: Nsxe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nsxe/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Ma,Ten")] Nsx nsx)
        {
            if (ModelState.IsValid)
            {
                nsx.Id = Guid.NewGuid();
                _context.Add(nsx);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nsx);
        }

        // GET: Nsxe/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nsx = await _context.Nsx.FindAsync(id);
            if (nsx == null)
            {
                return NotFound();
            }
            return View(nsx);
        }

        // POST: Nsxe/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Ma,Ten")] Nsx nsx)
        {
            if (id != nsx.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nsx);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NsxExists(nsx.Id))
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
            return View(nsx);
        }

        // GET: Nsxe/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nsx = await _context.Nsx
                .FirstOrDefaultAsync(m => m.Id == id);
            if (nsx == null)
            {
                return NotFound();
            }

            return View(nsx);
        }

        // POST: Nsxe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var nsx = await _context.Nsx.FindAsync(id);
            _context.Nsx.Remove(nsx);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NsxExists(Guid id)
        {
            return _context.Nsx.Any(e => e.Id == id);
        }
    }
}