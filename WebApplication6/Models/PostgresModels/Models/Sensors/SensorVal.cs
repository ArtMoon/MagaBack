using System;
using System.ComponentModel.DataAnnotations;
namespace DIMON_APP.Models.PG
{
    public class SensorVal
    {
        
        [Key] public int val_id{get;set;}
        public int sens_id{get;set;}
        public DateTime val_date{get;set;}
        public float val{get;set;}

        

    }
}