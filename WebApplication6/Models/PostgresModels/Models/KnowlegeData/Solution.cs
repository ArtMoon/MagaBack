using System.ComponentModel.DataAnnotations; 

namespace DIMON_APP.Models.PG
{
    public class Solution
    {
        [Key] public int sol_id{get;set;}
        public int rs_id{get;set;}
        [MaxLength(200)] public string sol_text{get;set;}
        [MaxLength(120)] public string sol_par{get;set;}
        public int sens_id{get;set;}
        public string sol_nn{get;set;}

        public Reason reason{get;set;}

    }


}