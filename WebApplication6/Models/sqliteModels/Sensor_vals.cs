using System;
using System.ComponentModel.DataAnnotations;

namespace DIMON_APP.Models
{
    public class Sensor_vals
    {
        [Key]
        public int Value_id { get; set; }
        public string Sensor_name { get; set; }
        public float Sensor_value { get; set; }
        public int Parent_id { get; set; }
        public DateTime? Date_time { get; set; }
        public int Id_sensor { get; set; }
    }
}
