﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using buoi6.Data;
using buoi6.Models;
using Microsoft.AspNetCore.Http;

namespace buoi6.Controllers
{
    public class CartsController : Controller
    {
        private readonly EshopContext _context;

        public CartsController(EshopContext context)
        {
            _context = context;
        }

        // GET: Carts
        public async Task<IActionResult> Index()
        {

            var eshopContext = _context.Cart.Include(c => c.Account).Include(c => c.Product);
            return View(await eshopContext.ToListAsync());
        }
        public async Task<IActionResult> Giokhachhang()
        {

            var eshopContext = _context.Cart.Include(c => c.Account).Include(c => c.Product);
            return View(await eshopContext.ToListAsync());
        }
        // GET: Carts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart
                .Include(c => c.Account)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // GET: Carts/Create
        public IActionResult Create()
        {
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Id");
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id");
            return View();
        }

        // POST: Carts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,AccountId,ProductId,Quantity")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Id", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", cart.ProductId);
            return View(cart);
        }

        // GET: Carts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Id", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", cart.ProductId);
            return View(cart);
        }
        public async Task<IActionResult> Thaysoluong(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Id", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", cart.ProductId);
            return View(cart);
        }

        // POST: Carts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,AccountId,ProductId,Quantity")] Cart cart)
        {
            if (id != cart.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.Id))
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
            ViewData["AccountId"] = new SelectList(_context.Account, "Id", "Id", cart.AccountId);
            ViewData["ProductId"] = new SelectList(_context.Product, "Id", "Id", cart.ProductId);
            return View(cart);
        }

        // GET: Carts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart
                .Include(c => c.Account)
                .Include(c => c.Product)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cart = await _context.Cart.FindAsync(id);
            _context.Cart.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(int id)
        {
            return _context.Cart.Any(e => e.Id == id);
        }
        public IActionResult Add(int id)
        {
            return Add(id,1);
        }
        public string CookiesKeyName()
        {
            var name= HttpContext.Request.Cookies["AccountUsername"].ToString();
            return name;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(int productId,int Quantity)
        {
                int accId = _context.Account.FirstOrDefault(a => a.Username == CookiesKeyName()).Id;
                Cart cart = _context.Cart.FirstOrDefault(c => c.AccountId == accId && c.ProductId == productId);
                if (cart == null)
                {
                    cart = new Cart();
                    cart.AccountId = accId;
                    cart.ProductId = productId;
                    cart.Quantity = Quantity;
                    _context.Cart.Add(cart);
                }
                else
                {
                    cart.Quantity += Quantity;
                }
                _context.SaveChanges();
                return RedirectToAction("Index");
        }
        public IActionResult Add_cu(int id)
        {
            return Add_cu(id, 1);
        }
        public string CookiesKeyName_cu()
        {
            var name = HttpContext.Request.Cookies["AccountUsername"].ToString();
            return name;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add_cu(int productId, int Quantity)
        {
            int accId = _context.Account.FirstOrDefault(a => a.Username == CookiesKeyName()).Id;
            Cart cart = _context.Cart.FirstOrDefault(c => c.AccountId == accId && c.ProductId == productId);
            if (cart == null)
            {
                cart = new Cart();
                cart.AccountId = accId;
                cart.ProductId = productId;
                cart.Quantity = Quantity;
                _context.Cart.Add(cart);
            }
            else
            {
                cart.Quantity += Quantity;
            }
            _context.SaveChanges();
            return RedirectToAction("Giokhachhang");
        }
    }
    
}
