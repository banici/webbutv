using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientSide.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientSide.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}