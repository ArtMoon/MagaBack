using System.ComponentModel.DataAnnotations;


namespace DIMON_APP.Models
{
    public class Apparatus
    {
        [Key]
        public int Id_Ap { get; set; }
        public string App_name { get; set; }
        public int? Parent_id { get; set; }
       
    }
}
