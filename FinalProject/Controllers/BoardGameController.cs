using FinalProject.Data;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        public IActionResult Filter(string priceFilter)
        {
            
            double selectedPrice;
            if (!double.TryParse(priceFilter, out selectedPrice))
            {
                
                return RedirectToAction("Filter");
            }

           
            var filteredBoardGames = _context.BoardGames.Where(g => g.Price == selectedPrice).ToList();

            
            return View(filteredBoardGames);
        }


        [Route("BoardGames")]
        public IActionResult BoardGame()
        {
            var games = _context.BoardGames.ToList();
            return View(games);
        }
    }
}
