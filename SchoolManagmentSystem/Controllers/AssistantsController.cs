using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolManagmentSystem.Data;
using SchoolManagmentSystem.Models;

namespace SchoolManagmentSystem.Controllers
{
    public class AssistantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AssistantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Assistants
        public async Task<IActionResult> Index()
        {
              return _context.Assistants != null ? 
                          View(await _context.Assistants.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Assistants'  is null.");
        }

        // GET: Assistants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Assistants == null)
            {
                return NotFound();
            }

            var assistant = await _context.Assistants
                .FirstOrDefaultAsync(m => m.ID == id);
            if (assistant == null)
            {
                return NotFound();
            }

            return View(assistant);
        }

        // GET: Assistants/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Assistants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Surname,Email,BirthDate,HireDate,Address")] Assistant assistant)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assistant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assistant);
        }

        // GET: Assistants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Assistants == null)
            {
                return NotFound();
            }

            var assistant = await _context.Assistants.FindAsync(id);
            if (assistant == null)
            {
                return NotFound();
            }
            return View(assistant);
        }

        // POST: Assistants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Surname,Email,BirthDate,HireDate,Address")] Assistant assistant)
        {
            if (id != assistant.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assistant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssistantExists(assistant.ID))
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
            return View(assistant);
        }

        // GET: Assistants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Assistants == null)
            {
                return NotFound();
            }

            var assistant = await _context.Assistants
                .FirstOrDefaultAsync(m => m.ID == id);
            if (assistant == null)
            {
                return NotFound();
            }

            return View(assistant);
        }

        // POST: Assistants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Assistants == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Assistants'  is null.");
            }
            var assistant = await _context.Assistants.FindAsync(id);
            if (assistant != null)
            {
                _context.Assistants.Remove(assistant);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssistantExists(int id)
        {
          return (_context.Assistants?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
