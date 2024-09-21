﻿using BaiTap07.Data;
using BaiTap07.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTap07.Controllers
{
    public class TheLoaiController : Controller
    {
        private readonly ApplicationDbContext _db;
        public TheLoaiController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var theloai=_db.TheLoai.ToList();
            ViewBag.theloai = theloai;
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(TheLoai theLoai)
        {
            _db.TheLoai.Add(theLoai);
            _db.SaveChanges();

            return View();
        }
    }
}
