using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DIMON_APP.Models.PG;
using System;
using System.Threading.Tasks;



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
            return Json(_context.dm_sensor_vals.Where((x) => x.sens_id == sens_id && b_d <= x.val_date && d_e > x.val_date ));
        }

         [HttpGet]
        public IActionResult SensorValSens(int sens_id)
        {           
            return Json(_context.dm_sensor_vals.Where((x)=> x.sens_id == sens_id));
        }

        [HttpPost]
        public async Task<IActionResult> AddSensor(Sensor sensor,int ap_id)
        {
            try
            {
                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        _context.dm_sensors.Add(sensor);
                        await _context.SaveChangesAsync();
                        await _context.Entry(sensor).GetDatabaseValuesAsync();
                        var link = new Apparatus2SensLink();
                        link.ap_id = ap_id;
                        link.sens_id = sensor.sens_id;
                        _context.dm_apparatus_2_sens_link.Add(link);
                        await _context.SaveChangesAsync();
                        transaction.Commit();
                    }
                    catch(Exception e)
                    {
                        
                        transaction.Rollback();
                        return Json(e.Message);
                    }
                }
                
                return Json(200);
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddSensorApparatusLink(Apparatus2SensLink link)
        {
            try
            {
                _context.dm_apparatus_2_sens_link.Add(link);
                await _context.SaveChangesAsync();
                return Json(200);
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> AddSensorVal(SensorVal sensorVal)
        {
            try
            {
                _context.dm_sensor_vals.Add(sensorVal);
                await _context.SaveChangesAsync();
                return Json(200);
            }
            catch(Exception e)
            {
                return Json(e.Message);
            }
        }


    }
}