using BaiKiemTra03_04.Data;
using BaiKiemTra03_04.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BaiKiemTra03_04.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Order
        public async Task<IActionResult> Index()
        {
            var orders = await _context.Orders.Include(o => o.Supplier).ToListAsync();
            return View(orders);
        }

        // GET: Order/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var order = await _context.Orders.Include(o => o.Supplier)
                                              .FirstOrDefaultAsync(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // GET: Order/Create
        public IActionResult Create()
        {
            ViewBag.Suppliers = new SelectList(_context.Suppliers, "SupplierId", "SupplierName");
            return View();
        }

        // POST: Order/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Add(order);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Suppliers = new SelectList(_context.Suppliers, "SupplierId", "SupplierName", order.SupplierId);
            return View(order);
        }

        // GET: Order/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }
            ViewBag.Suppliers = new SelectList(_context.Suppliers, "SupplierId", "SupplierName", order.SupplierId);
            return View(order);
        }

        // POST: Order/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Order order)
        {
            if (id != order.OrderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(order);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderExists(order.OrderId))
                    {
                        return NotFound();
                    }
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Suppliers = new SelectList(_context.Suppliers, "SupplierId", "SupplierName", order.SupplierId);
            return View(order);
        }

        // GET: Order/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var order = await _context.Orders.Include(o => o.Supplier)
                                              .FirstOrDefaultAsync(o => o.OrderId == id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        // POST: Order/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }
    }
}
