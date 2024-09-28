using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project.Data;
using project.Models;

namespace project.Controllers
{
    [Area("Admin")]
    public class SanPhamController : Controller
    {
        public readonly ApplicationDbContext _db;
        public SanPhamController(ApplicationDbContext db)
        {

            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<SanPham> sanpham =_db.SanPham.Include("TheLoai").ToList();  
            return View(sanpham);
        }
        [HttpGet]
        public IActionResult Upsert(int id)
        {
           SanPham sanpham =
        }
    }
}
