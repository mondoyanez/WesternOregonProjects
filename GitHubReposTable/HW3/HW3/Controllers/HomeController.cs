﻿using Microsoft.AspNetCore.Mvc;

namespace HW3.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
