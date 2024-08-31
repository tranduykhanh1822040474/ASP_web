using Microsoft.AspNetCore.Mvc;

namespace BT03.Controllers
{
    public class NhomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
