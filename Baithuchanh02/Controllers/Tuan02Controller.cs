using Microsoft.AspNetCore.Mvc;

namespace Baithuchanh02.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Trần Duy Khánh";
            ViewBag.MSSV = " 1822040474";
            ViewBag.Nam = "Năm 3";
            return View();
        }
    }
}
