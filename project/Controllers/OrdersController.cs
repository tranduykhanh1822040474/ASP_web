using Microsoft.AspNetCore.Mvc;
using Project.Data;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.Controllers
{
    [Area("Customer")] // Adjust the area if necessary
    public class OrdersController : Controller
    {
        private readonly ApplicationDbContext _db;

        public OrdersController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Create Order action
        public IActionResult CreateOrder(int customerId, List<OrderDetail> orderDetails)
        {
            var order = new Order
            {
                CustomerId = customerId,
                OrderDate = DateTime.Now,
                Status = "Pending",
                TotalAmount = orderDetails.Sum(od => od.Quantity * od.UnitPrice),
                OrderDetails = orderDetails
            };

            _db.Orders.Add(order);
            _db.SaveChanges();

            return RedirectToAction("Index"); // Redirect to the index or any other action
        }

        // Other actions (e.g., Index, Details, etc.) can go here
    }
}
