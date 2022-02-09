using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask.Data.Interfaces;

namespace TestTask.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IOrders _orders;
        public OrdersController(IOrders orders)
        {
            _orders = orders;
        }
        public ViewResult List()
        {
            var orders = _orders.Orders;
            return View(orders);
        }
        
    }
}
