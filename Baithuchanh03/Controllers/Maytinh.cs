using Microsoft.AspNetCore.Mvc;

namespace Baithuchanh03.Controllers
{
    public class MaytinhController : Controller
    {
        public IActionResult Index(double a, double b, string pheptinh)
        {
            double ketQua = 0;
            string thongBao = "";
            switch (pheptinh)
            {
                case "cong":
                    ketQua = a + b;
                    break;
                case "tru":
                    ketQua = a - b;
                    break;
                case "nhan":
                    ketQua = a * b;
                    break;
                case "chia":
                    if (b != 0)
                    {
                        ketQua = a / b;
                    }
                    else
                    {
                        thongBao = "Không thể chia cho 0.";
                    }
                    break;
                default:
                    thongBao = "Phép tính không hợp lệ.";
                    break;
            }

            if (string.IsNullOrEmpty(thongBao))
            {
                thongBao = $"Kết quả: {ketQua}";
            }
            ViewBag.KetQua = thongBao;
            return View();
        }
    }
}
