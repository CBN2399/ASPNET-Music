using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicaBartolomeNavarroCesar.Data;
using MusicaBartolomeNavarroCesar.Models;

namespace MusicaBartolomeNavarroCesar.Controllers
{
    [Authorize]
    public class AlbumsController : Controller
    {

        private readonly ChinookContext _context;

        public AlbumsController(ChinookContext context)
        {
            _context = context;
        }

        // GET: Albums
        public async Task<IActionResult> Index(string searchString,string currentFilter,int? pageNumber)
        {
            var chinookContext = _context.Albums.Include(a => a.Artist).OrderByDescending(e => e.Title);
            ViewData["CurrentFilter"] = searchString;
            if (!String.IsNullOrEmpty(searchString))
            {
                chinookContext = chinookContext.Where(e => e.Title.Contains(searchString) || e.Artist.Name.Contains(searchString)).OrderByDescending(e => e.Title);
            }
            
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            if (pageNumber < 0)
            {
                pageNumber = 1;
            }
            int pageSize = 15;
            return View(await PaginatedList<Album>.CreateAsync(chinookContext.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: Albums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Albums == null)
            {
                return NotFound();
            }

            var album = await _context.Albums
                .Include(a => a.Artist)
                .Include(b => b.Tracks)
                .ThenInclude(g => g.Genre)
                .FirstOrDefaultAsync(m => m.AlbumId == id);

            /* La forma del Dios de Cristian
            await _context.Tracks.Include(t => t.Genre).ToListAsync();*/
           // ViewData["Genero"] = _context.Genres.Select(a => a.Name);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // GET: Albums/Create
        [Authorize(Roles = "Admin,Manager")]
        public IActionResult Create()
        {
            ViewData["ArtistName"] = new SelectList(_context.Artists, "ArtistId", "Name");
            return View();
        }

        // POST: Albums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Create([Bind("AlbumId,Title,ArtistId")] Album album)
        {
            if (ModelState.IsValid)
            {
                _context.Add(album);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArtistName"] = new SelectList(_context.Artists, "ArtistId", "Name", album.Artist);
            return View(album);
        }

        // GET: Albums/Edit/5
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Albums == null)
            {
                return NotFound();
            }

            var album = await _context.Albums.FindAsync(id);
            if (album == null)
            {
                return NotFound();
            }
            ViewData["ArtistName"] = new SelectList(_context.Artists, "ArtistId", "Name", album.Artist);
            return View(album);
        }

        // POST: Albums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Edit(int id, [Bind("AlbumId,Title,ArtistId")] Album album)
        {
            if (id != album.AlbumId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(album);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlbumExists(album.AlbumId))
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
            ViewData["ArtistName"] = new SelectList(_context.Artists, "ArtistId", "Name", album.Artist);
            return View(album);
        }

        // GET: Albums/Delete/5
        [Authorize(Roles = "Admin,Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Albums == null)
            {
                return NotFound();
            }

            var album = await _context.Albums
                .Include(a => a.Artist)
                .FirstOrDefaultAsync(m => m.AlbumId == id);
            if (album == null)
            {
                return NotFound();
            }

            return View(album);
        }

        // POST: Albums/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin,Manager")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Albums == null)
            {
                return Problem("Entity set 'ChinookContext.Albums'  is null.");
            }
            var album = await _context.Albums.FindAsync(id);
            if (album != null)
            {
                _context.Albums.Remove(album);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlbumExists(int id)
        {
          return _context.Albums.Any(e => e.AlbumId == id);
        }

    }   

}
