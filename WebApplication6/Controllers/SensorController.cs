using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models;
using System.IO;
using System;
using Microsoft.EntityFrameworkCore;


namespace DIMON_APP.Controllers
{

    public class SensorController : Controller
    {
        private MyWebApiDbContext _context;


        public SensorController(MyWebApiDbContext context)
        {
            _context = context;
        }

       [HttpGet]
        public IActionResult Sensor(int parent_id)
        {
            
            return Json((from  a in _context.sensorInfo where (a.ParentId == parent_id) select a).ToList());
        }



        [HttpGet]
        public IActionResult SensorVal(int sens_id,DateTime b_d,DateTime d_e)
        {           
            return Json((from a in _context.Sensor_Val where (a.Id_sensor == sens_id) && (a.Date_time > b_d) 
                && (a.Date_time <= d_e) select a).ToList());
        }

    }
}