using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models.PG;
using System.IO;
using System;
using Microsoft.EntityFrameworkCore;


namespace DIMON_APP.Controllers
{

    public class ApparatusController : Controller
    {
        private PostgresDBContext _context;
        public ApparatusController(PostgresDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Apparatuses()
        {
            return Json(_context.dm_apparatuses);
        }


        [HttpPost]
        public IActionResult Aparatuses(int id)
        {
            return Json(_context.dm_apparatuses.Any(x => x.parent_ap_id == id));
        }
        
    }
}