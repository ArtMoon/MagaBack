using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models.PG;
using System;
using System.Threading.Tasks;
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

        [HttpPost]
        public async Task<IActionResult> AddApparatus(Apparatus apparatus)
        {
            try
            {
                _context.dm_apparatuses.Add(apparatus);
                await _context.SaveChangesAsync();
                return Json("200");
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> ExecuteAlarmsSearch(int apID, DateTime dateBegin,DateTime dateEnd)
        {
            try
            {  
                await _context.Database.ExecuteSqlRawAsync($"call dm_get_app_problems({apID.ToString()},"+
                        $"'{dateBegin.ToString("yyyy-MM-dd hh:mm")}','{dateEnd.ToString("yyyy-MM-dd hh:mm")}')"); 
                return Json("200");
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpGet]
        public IActionResult GetAlarms(int sens_id,DateTime dateBegin,DateTime dateEnd)
        {
            return Json(_context.dm_alarms.Where((x)=> x.sens_id == sens_id && x.al_date >= dateBegin && x.al_date <= dateEnd));
        }
      
        
    }
}