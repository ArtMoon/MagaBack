using System.ComponentModel.DataAnnotations; 
using System.Collections.Generic;


namespace DIMON_APP.Models.PG
{
    public class Problem
    {
        [Key] public int pr_id{get;set;}
        
        [MaxLength(1)] public string pr_cond{get;set;}
        public float pr_value {get;set;}
        public int sens_id{get;set;}
        [MaxLength(200)] public string pr_text{get;set;}
        [MaxLength(1)] public string pr_color{get;set;}
        public string pr_nn{get;set;}
        public int ap_id{get;set;}
        public List<Reason> reasons{get;set;}
    }
}