using Btkt01.Models;
using Microsoft.AspNetCore.Mvc;

namespace Btkt01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BaiTap2()
        {
            // Tạo đối tượng sản phẩm
            var sanpham = new SanPhamViewModel()
            {
                TenSanPham = "Laptop Dell XPS 13",
                GiaBan = 25000000,
                AnhMoTa = "/images/laptop-dell-xps.jpg"
            };

            // Trả về View kèm với dữ liệu sản phẩm
            return View(sanpham);

        }

    }
}
