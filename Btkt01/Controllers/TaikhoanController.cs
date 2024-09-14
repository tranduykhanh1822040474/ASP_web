using Microsoft.AspNetCore.Mvc;
using Btkt01.Models;

namespace Btkt01.Controllers
{
    public class TaiKhoanController : Controller
    {
        [HttpGet]
        [HttpGet]
        public IActionResult DangKy()
        {
            // Khởi tạo model rỗng khi hiển thị form
            var model = new TaiKhoanViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult DangKy(TaiKhoanViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Trả lại view cùng với dữ liệu đã nhập
                return View(model);
            }

            // Nếu model không hợp lệ, trả lại view cùng với dữ liệu hiện tại
            return View(model);
        }

    }
}
