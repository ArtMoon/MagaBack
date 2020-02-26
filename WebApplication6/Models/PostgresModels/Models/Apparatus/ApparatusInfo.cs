using System;
using System.ComponentModel.DataAnnotations; 

namespace DIMON_APP.Models.PG
{
    public class ApparatusInfo
    {
        [Key] public int ap_id{get;set;}
        public string description{get;set;}
        public DateTime launch_date{get;set;}
        public float power{get;set;}
        
    }
}