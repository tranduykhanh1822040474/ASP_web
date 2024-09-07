using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BT04.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            return Ok("Id: " + id);
        }

        public IActionResult Detail(int id, string ten)
        {
            return Content(String.Format("id: {0};ten:{1}", id, ten));
        }

        public IActionResult Show(List<string> categories)
        {
            string content = "Danh sách Thể Loại: ";
            foreach (var category in categories)
            {
                content = content + category + ", ";
            }

            // Trim the last comma and space
            content = content.TrimEnd(',', ' ');

            return Content(content);
        }
    }
}
