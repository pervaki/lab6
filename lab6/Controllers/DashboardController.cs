﻿using Microsoft.AspNetCore.Mvc;

namespace lab6.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
