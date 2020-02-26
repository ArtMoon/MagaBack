using System.ComponentModel.DataAnnotations; 

namespace DIMON_APP.Models.PG
{
    public class Sensor
    {
        [Key] public int sens_id{get;set;}
        public string sens_name{get;set;}
        public string description{get;set;}
        public Apparatus2SensLink app_link{get;set;}
    }

}