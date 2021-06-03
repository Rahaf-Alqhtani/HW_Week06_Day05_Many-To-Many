using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstApp.Controllers
{
    public class PStoresController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
