using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirstApp.Data;
using CodeFirstApp.Models;



namespace CodeFirstApp.Controllers
{
    public class BranchesController : Controller
    {
        private readonly AppDbContext _db;
        public BranchesController (AppDbContext context)
            {
            _db = context;
        }

        public IActionResult Index()
        {
            var branches = _db.Branches.ToList();
            ViewData["Branches"] = branches;
            var searchId = _db.Branches.FirstOrDefault(a => a.ID == 2).Address;
            var searchId2 = _db.Branches.SingleOrDefault(a => a.ID == 2).Address;
            var greaterthanthree = _db.Branches.Where(a => a.ID > 3).ToList();


            ViewBag.Address = searchId;
            ViewBag["Branches"] = branches;
            return View();
        }
        public IActionResult Search(string txt)
        {
            var aa = _db.Branches.Where(a => a.Address.Contains(txt)).ToList();
            ViewBag.Branches = aa;
            return View("Index");
        }
    }
}
