using System;
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
    public class AccountsController : Controller
    {
        private readonly EshopContext _context;

        public AccountsController(EshopContext context)
        {
            _context = context;
        }

        // GET: Accounts
        public async Task<IActionResult> Index(string Username, string Email, string Phonenumber, string Address, string Fullname)
        {
            var search = (from s in _context.Account
                         select s);
            if (!String.IsNullOrEmpty(Username))
            {
                search = search.Where(s => s.Username.Contains(Username));
            }
            if (!String.IsNullOrEmpty(Email))
            {
                search = search.Where(s => s.Username.Contains(Email));
            }
            if (!String.IsNullOrEmpty(Phonenumber))
            {
                search = search.Where(s => s.Username.Contains(Phonenumber));
            }
            if (!String.IsNullOrEmpty(Address))
            {
                search = search.Where(s => s.Username.Contains(Address));
            }
            if (!String.IsNullOrEmpty(Address))
            {
                search = search.Where(s => s.Username.Contains(Fullname));
            }
            return View(await _context.Account.ToListAsync());
        }
        public async Task<IActionResult> ByAddress()
        {
            var byAddress = (from acc in _context.Account
                             where acc.Address.Contains("Tp.Hồ Chí Minh")
                             select acc);

            return View(await byAddress.ToListAsync());
        }
        public async Task<IActionResult> ByEmail()
        {
            var byEmail = (from acc in _context.Account
                             where acc.Email.Contains("Gmail")
                             select acc);

            return View(await byEmail.ToListAsync());
        }
        // GET: Accounts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // GET: Accounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Username,Password,Email,Phone,Address,FullName,IsAdmin,Avatar,TrangThai")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(account);
        }
        public IActionResult Create_customer()
        {
            return View();
        }

        // POST: Accounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create_customer([Bind("Id,Username,Password,Email,Phone,Address,FullName,IsAdmin,Avatar,TrangThai")] Account account)
        {
            if (ModelState.IsValid)
            {
                _context.Add(account);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return View(account);
        }
        // GET: Accounts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account.FindAsync(id);
            if (account == null)
            {
                return NotFound();
            }
            return View(account);
        }

        // POST: Accounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Username,Password,Email,Phone,Address,FullName,IsAdmin,Avatar,TrangThai")] Account account)
        {
            if (id != account.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(account);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AccountExists(account.Id))
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
            return View(account);
        }

        // GET: Accounts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var account = await _context.Account
                .FirstOrDefaultAsync(m => m.Id == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Accounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var account = await _context.Account.FindAsync(id);
            _context.Account.Remove(account);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(int id)
        {
            return _context.Account.Any(e => e.Id == id);
    
        
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string Username, string Password)
        {
            Account checkAmin = _context.Account.Where(a => a.Username == Username && a.Password == Password&&a.IsAdmin==true).FirstOrDefault();
            Account checkCustomer = _context.Account.Where(a => a.Username == Username && a.Password == Password).FirstOrDefault();
            Account checkpass = _context.Account.Where(a => a.Username == Username).FirstOrDefault();
            if (checkAmin!=null)
            {
                CookieOptions cookieOptions = new CookieOptions()
                {
                    Expires = DateTime.Now.AddDays(7)
                };
                HttpContext.Response.Cookies.Append("AccountID", checkAmin.Id.ToString());
                HttpContext.Response.Cookies.Append("AccountUsername", checkAmin.Username.ToString());
                HttpContext.Response.Cookies.Append("AccountFullname", checkAmin.FullName.ToString());
                return RedirectToAction("Index", "Home");
            }
            else
            {
                if(checkCustomer!=null)
                {
                    CookieOptions cookieOptions = new CookieOptions()
                    {
                        Expires = DateTime.Now.AddDays(7)
                    };
                    HttpContext.Response.Cookies.Append("AccountID", checkCustomer.Id.ToString());
                    HttpContext.Response.Cookies.Append("AccountUsername", checkCustomer.Username.ToString());
                    HttpContext.Response.Cookies.Append("AccountFullname", checkCustomer.FullName.ToString());
                    return RedirectToAction("Index_Customer", "Home");
                }    
            }
            if (checkpass != null)
            {
                ViewBag.ErrorMessage = "Sai mật khẩu";
                return View();
            }
            ViewBag.ErrorMessage = "Sai tài khoản";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Response.Cookies.Append("AccountID", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            HttpContext.Response.Cookies.Append("AccountUsername", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            HttpContext.Response.Cookies.Append("AccountFullname", "", new CookieOptions { Expires = DateTime.Now.AddDays(-1) });
            return RedirectToAction("Login", "Accounts");
        }

    }



   



}
