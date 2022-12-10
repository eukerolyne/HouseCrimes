using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HouseCrimes.Models;

namespace HouseCrimes.Controllers
{
    public class FilmesController : Controller
    {
        private readonly Contexto _context;

        public FilmesController(Contexto context)
        {
            _context = context;
        }

        // GET: Filmes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Filme.ToListAsync());
        }

        // GET: Filmes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Filme == null)
            {
                return NotFound();
            }

            var filme = await _context.Filme
                .FirstOrDefaultAsync(m => m.filmeId == id);
            if (filme == null)
            {
                return NotFound();
            }

            return View(filme);
        }

        // GET: Filmes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Filmes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("filmeId,titulo,descricao,classificacao,tipo,duracao")] Filme filme, IFormFile arquivo)
        {
            var fileName = arquivo.FileName;
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/video/", fileName);
            if (filme.titulo != null)
            {
                using (var localFile = System.IO.File.OpenWrite(filePath))
                using (var uploadedFile = arquivo.OpenReadStream())
                {
                    uploadedFile.CopyTo(localFile);
                }

                _context.Add(filme);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(filme);
        }

        // GET: Filmes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Filme == null)
            {
                return NotFound();
            }

            var filme = await _context.Filme.FindAsync(id);
            if (filme == null)
            {
                return NotFound();
            }
            return View(filme);
        }

        // POST: Filmes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("filmeId,titulo,descricao,classificacao,tipo,duracao")] Filme filme)
        {
            if (id != filme.filmeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(filme);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmeExists(filme.filmeId))
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
            return View(filme);
        }

        // GET: Filmes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Filme == null)
            {
                return NotFound();
            }

            var filme = await _context.Filme
                .FirstOrDefaultAsync(m => m.filmeId == id);
            if (filme == null)
            {
                return NotFound();
            }

            return View(filme);
        }

        // POST: Filmes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Filme == null)
            {
                return Problem("Entity set 'Contexto.Filme'  is null.");
            }
            var filme = await _context.Filme.FindAsync(id);
            if (filme != null)
            {
                _context.Filme.Remove(filme);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FilmeExists(int id)
        {
            return _context.Filme.Any(e => e.filmeId == id);
        }
    }
}
