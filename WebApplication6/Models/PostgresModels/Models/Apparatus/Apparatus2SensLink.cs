using System.ComponentModel.DataAnnotations;

namespace DIMON_APP.Models.PG
{
    public class Apparatus2SensLink
    {
        [Key] public int rec_id{get;set;}
        public int sens_id{get;set;}
        public int ap_id{get;set;}
        public Sensor Sensor{get;set;}
        public Apparatus Apparatus{get;set;}
    }

  
}