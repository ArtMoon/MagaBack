using System;
using System.ComponentModel.DataAnnotations;


namespace DIMON_APP.Models.PG
{
    public class Alarm
    {
        [Key] public int al_id{get;set;}
        public DateTime al_date{get;set;}
        public float al_value{get;set;}
        [MaxLength(200)] public string al_text{get;set;}
        [MaxLength(200)] public string al_reason{get;set;}
        [MaxLength(200)] public string al_param{get;set;}
        [MaxLength(200)] public string sol_text{get;set;}
        [MaxLength(200)] public string sens_name{get;set;}
        public int sens_id{get;set;}
        public Sensor sensor{get;set;}
        public int ap_id{get;set;}
        public Apparatus apparatus {get;set;}


    }

}