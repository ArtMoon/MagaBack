using System.ComponentModel.DataAnnotations; 
using System.Collections.Generic;

namespace DIMON_APP.Models.PG
{
    public class Reason
    {
        [Key] public int rs_id{get;set;}
        public int pr_id{get;set;}   
        [MaxLength(200)] public string rs_text{get;set;}
        [MaxLength(1)] public string rs_cond{get;set;}
        public float rs_value{get;set;}
        public int sens_id{get;set;}
        public string nn_rs{get;set;}
        public float rs_probability{get;set;}
        public Problem problem{get;set;}
        public List<Solution> solutions{get;set;}

    }
}