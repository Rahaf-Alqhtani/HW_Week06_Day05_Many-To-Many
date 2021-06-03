using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstApp.Data;
using CodeFirstApp.Models;

namespace CodeFirstApp.Controllers
{
    public class CustomerController : Controller
    {
        private readonly AppDbContext _dbc;
        public CustomerController(AppDbContext context)
        {
            _dbc = context;
        }
        public IActionResult Index()
        {
            var customer = _dbc.Customers.ToList();
            ViewData["Customers"] = customer;
          

         
            return View();
        }
    }
}
