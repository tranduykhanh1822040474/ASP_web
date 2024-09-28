using BaiKiemTra02.Data;
using BaiKiemTra02.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BaiKiemTra02.Controllers
{
    public class LopHocController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LopHocController(ApplicationDbContext context)
        {
            _context = context;
        }

        // Hiển thị danh sách lớp học
        public async Task<IActionResult> Index()
        {
            return View(await _context.LopHocs.ToListAsync());
        }

        // Xem chi tiết lớp học
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var lopHoc = await _context.LopHocs.FirstOrDefaultAsync(m => m.Id == id);
            if (lopHoc == null)
                return NotFound();

            return View(lopHoc);
        }

        // Thêm mới lớp học
        public IActionResult Create()
        {
            var lopHoc = new LopHoc();
            return View(lopHoc); // Truyền một đối tượng mới tới View
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TenLopHoc,NamNhapHoc,NamRaTruong,SoLuongSinhVien")] LopHoc lopHoc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lopHoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lopHoc);
        }

        // Chỉnh sửa lớp học
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();

            var lopHoc = await _context.LopHocs.FindAsync(id);
            if (lopHoc == null)
                return NotFound();

            return View(lopHoc);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TenLopHoc,NamNhapHoc,NamRaTruong,SoLuongSinhVien")] LopHoc lopHoc)
        {
            if (id != lopHoc.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(lopHoc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lopHoc);
        }

        // Xóa lớp học - Hiển thị trang xác nhận xóa
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();

            var lopHoc = await _context.LopHocs.FirstOrDefaultAsync(m => m.Id == id);
            if (lopHoc == null)
                return NotFound();

            return View(lopHoc);
        }

        // Xác nhận và xóa lớp học
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lopHoc = await _context.LopHocs.FindAsync(id);

            if (lopHoc == null)
            {
                return NotFound();
            }

            _context.LopHocs.Remove(lopHoc);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
