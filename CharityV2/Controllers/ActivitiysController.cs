using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CharityV2.Data;

namespace CharityV2.Controllers
{
    public class ActivitiysController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ActivitiysController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Activitiys
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Activities.Include(a => a.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Activitiys/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activitiy = await _context.Activities
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activitiy == null)
            {
                return NotFound();
            }

            return View(activitiy);
        }

        // GET: Activitiys/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: Activitiys/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,EmployeeId,Name,Description,Place,Start,End,RedistrationTime,Photo,CategoryId,CountInterest,CountParticipants,Status")] Activitiy activitiy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activitiy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", activitiy.UserId);
            return View(activitiy);
        }

        // GET: Activitiys/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activitiy = await _context.Activities.FindAsync(id);
            if (activitiy == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", activitiy.UserId);
            return View(activitiy);
        }

        // POST: Activitiys/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,EmployeeId,Name,Description,Place,Start,End,RedistrationTime,Photo,CategoryId,CountInterest,CountParticipants,Status")] Activitiy activitiy)
        {
            if (id != activitiy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activitiy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActivitiyExists(activitiy.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", activitiy.UserId);
            return View(activitiy);
        }

        // GET: Activitiys/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activitiy = await _context.Activities
                .Include(a => a.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activitiy == null)
            {
                return NotFound();
            }

            return View(activitiy);
        }

        // POST: Activitiys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var activitiy = await _context.Activities.FindAsync(id);
            _context.Activities.Remove(activitiy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActivitiyExists(int id)
        {
            return _context.Activities.Any(e => e.Id == id);
        }
    }
}
