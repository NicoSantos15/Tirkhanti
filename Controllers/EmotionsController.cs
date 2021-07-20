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
    public class EmotionsController : Controller
    {
        private readonly Tirkhanti_R12Context _context;

        public EmotionsController(Tirkhanti_R12Context context)
        {
            _context = context;
        }

        // GET: Emotions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Emotion.ToListAsync());
        }

        // GET: Emotions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emotions = await _context.Emotion
                .FirstOrDefaultAsync(m => m.EmotionID == id);
            if (emotions == null)
            {
                return NotFound();
            }

            return View(emotions);
        }

        // GET: Emotions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Emotions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmotionID,StudentEmotion")] Emotions emotions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emotions);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(emotions);
        }

        // GET: Emotions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emotions = await _context.Emotion.FindAsync(id);
            if (emotions == null)
            {
                return NotFound();
            }
            return View(emotions);
        }

        // POST: Emotions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmotionID,StudentEmotion")] Emotions emotions)
        {
            if (id != emotions.EmotionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emotions);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmotionsExists(emotions.EmotionID))
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
            return View(emotions);
        }

        // GET: Emotions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emotions = await _context.Emotion
                .FirstOrDefaultAsync(m => m.EmotionID == id);
            if (emotions == null)
            {
                return NotFound();
            }

            return View(emotions);
        }

        // POST: Emotions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emotions = await _context.Emotion.FindAsync(id);
            _context.Emotion.Remove(emotions);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmotionsExists(int id)
        {
            return _context.Emotion.Any(e => e.EmotionID == id);
        }
    }
}
