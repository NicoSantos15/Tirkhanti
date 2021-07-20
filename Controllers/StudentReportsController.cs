using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tirkhanti_R12.Data;
using Tirkhanti_R12.Models;

namespace Tirkhanti_R12.Controllers
{
    public class StudentReportsController : Controller
    {
        private readonly Tirkhanti_R12Context _context;

        public StudentReportsController(Tirkhanti_R12Context context)
        {
            _context = context;
        }

        // GET: StudentReports
        public async Task<IActionResult> Index()
        {
            return View(await _context.StudentReport.ToListAsync());
        }

        // GET: StudentReports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentReport = await _context.StudentReport
                .FirstOrDefaultAsync(m => m.ReportID == id);
            if (studentReport == null)
            {
                return NotFound();
            }

            return View(studentReport);
        }

        // GET: StudentReports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentReports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportID,ReportDate,StudentComment,AssignedDate,CompleteDate,Priority,IsComplete")] StudentReport studentReport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentReport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(studentReport);
        }

        // GET: StudentReports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentReport = await _context.StudentReport.FindAsync(id);
            if (studentReport == null)
            {
                return NotFound();
            }
            return View(studentReport);
        }

        // POST: StudentReports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportID,ReportDate,StudentComment,AssignedDate,CompleteDate,Priority,IsComplete")] StudentReport studentReport)
        {
            if (id != studentReport.ReportID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentReport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentReportExists(studentReport.ReportID))
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
            return View(studentReport);
        }

        // GET: StudentReports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var studentReport = await _context.StudentReport
                .FirstOrDefaultAsync(m => m.ReportID == id);
            if (studentReport == null)
            {
                return NotFound();
            }

            return View(studentReport);
        }

        // POST: StudentReports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentReport = await _context.StudentReport.FindAsync(id);
            _context.StudentReport.Remove(studentReport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentReportExists(int id)
        {
            return _context.StudentReport.Any(e => e.ReportID == id);
        }
    }
}
