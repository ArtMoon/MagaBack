using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models;
using System.IO;
using System;
using Microsoft.EntityFrameworkCore;


namespace DIMON_APP.Controllers
{

    public class ApparatusController : Controller
    {
        private MyWebApiDbContext _context;


        public ApparatusController(MyWebApiDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Apparatuses()
        {
            return Json(_context.Apparatus);
        }


        [HttpPost]
        public IActionResult Aparatuses(int id)
        {
            return Json(_context.Apparatus.Any(x => x.Parent_id == id));
        }


    }
}