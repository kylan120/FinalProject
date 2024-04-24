using FinalProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject.Controllers
{
    public class BoardGameController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BoardGameController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult BoardGame()
        {
            var games = _context.BoardGames.ToList();
            return View(games);
        }
    }
}
