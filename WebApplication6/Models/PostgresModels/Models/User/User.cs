using System.ComponentModel.DataAnnotations;

namespace DIMON_APP.Models.PG
{
    public class User
    {
        [Key] public int user_id { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public string password { get; set; }
        public string email{get;set;}
        public int table_num{get;set;}
        public string photo_url{get;set;}

    }
}