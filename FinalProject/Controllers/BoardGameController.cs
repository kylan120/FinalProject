﻿using FinalProject.Data;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Ajax.Utilities;

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
                return RedirectToAction("BoardGame");
            }

            var filteredBoardGames = _context.BoardGames.Where(g => g.Price == selectedPrice).Distinct().ToList();
            return View(filteredBoardGames);
        }

      

        [Route("BoardGames")]
        public IActionResult BoardGame()
        {
            var games = _context.BoardGames.ToList();
            return View(games);
        }

        public IActionResult AddToCart(int id, int quantity)
        {
            var game = _context.BoardGames.Find(id);
            if (game == null)
            {
                return NotFound();
            }

            var cartItems = TempData["CartItems"] as string ?? "";
            var newItem = $"{id}:{quantity}";
            if (!string.IsNullOrEmpty(cartItems))
            {
                cartItems += "," + newItem;
            }
            else
            {
                cartItems = newItem;
            }

            TempData["CartItems"] = cartItems;

            return RedirectToAction("Cart");
        }


        [Authorize]
        public IActionResult Cart()
        {
            var cartItemsString = TempData["CartItems"] as string ?? "";
            var cart = new Cart();
            var items = cartItemsString.Split(',');
            foreach (var item in items)
            {
                var parts = item.Split(':');
                if (parts.Length == 2 && int.TryParse(parts[0], out int gameId) && int.TryParse(parts[1], out int quantity))
                {
                    var game = _context.BoardGames.Find(gameId);
                    if (game != null)
                    {
                        cart.Items.Add(new CartItem { BoardGame = game, Quantity = quantity });
                    }
                }
            }

            return View(cart);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.SelectedGenre = "";
            return View("Edit", new BoardGame());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var boardGame = _context.BoardGames.Find(id);
            return View(boardGame);
        }

        [HttpPost]
        public IActionResult Edit(BoardGame boardGame)
        {
            if (ModelState.IsValid)
            {
                if (boardGame.ID == 0)
                    _context.BoardGames.Add(boardGame);
                else
                    _context.BoardGames.Update(boardGame);
                _context.SaveChanges();
                return RedirectToAction("BoardGame");
            }
            else
            {
                ViewBag.Action = (boardGame.ID == 0) ? "Add" : "Edit";
                return View(boardGame);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var game = _context.BoardGames.Find(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Delete(BoardGame boardGame)
        {
            _context.BoardGames.Remove(boardGame);
            _context.SaveChanges();
            return RedirectToAction("BoardGame");
        }


    }
}
