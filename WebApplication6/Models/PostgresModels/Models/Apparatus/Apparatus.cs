using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 

namespace DIMON_APP.Models.PG
{
    public class Apparatus
    {
        [Key] public int ap_id{get;set;}
        public int parent_ap_id{get;set;}
        public string short_name{get;set;}
        public string full_name{get;set;}
        
        public List<Apparatus2SensLink> app_link{get;set;}
        public List<Alarm> alarms{get;set;}
    }
}