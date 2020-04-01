using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models.PG;
using System;
using System.Threading.Tasks;

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

        [HttpPost]
        public async Task<IActionResult> AddApparatus(Apparatus apparatus)
        {
            try
            {
                _context.dm_apparatuses.Add(apparatus);
                await _context.SaveChangesAsync();
                return Json("OK");
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
            
        }
        
    }
}