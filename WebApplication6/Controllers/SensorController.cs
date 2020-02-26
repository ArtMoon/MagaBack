using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models.PG;
using System;



namespace DIMON_APP.Controllers
{

    public class SensorController : Controller
    {
        private PostgresDBContext _context;


        public SensorController(PostgresDBContext context)
        {
            _context = context;
        }

       [HttpGet]
        public IActionResult Sensor(int parent_id)
        {     
            return Json((from  a in _context.dm_sensors where (a.app_link.ap_id == parent_id) select a).ToList());
        }

        [HttpGet]
        public IActionResult SensorVal(int sens_id,DateTime b_d,DateTime d_e)
        {           
            return Json((from a in _context.dm_sensor_vals where (a.sens_id == sens_id) && (a.val_date > b_d) 
                && (a.val_date <= d_e) select a).ToList());
        }

    }
}