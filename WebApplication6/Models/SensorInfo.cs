using System;
namespace DIMON_APP.Models
{
    public class SensorInfo
    {
        public int Id { get; set; }
        public int ParentId{get;set;}
        public string SensorName { get; set; }
        public string Description { get; set; }
    }
}