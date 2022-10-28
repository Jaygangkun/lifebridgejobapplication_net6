using System.ComponentModel.DataAnnotations;

namespace LifeBridgesJobApplication.Models
{
    public class EmpReference
    {
        [Key]
        public int autoid { get; set; }
        public int appid { get; set; }
        public string? name { get; set; }
        public string? place { get; set; }
        public string? employersphone { get; set; }
        public string? street { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? zip { get; set; }
        public string? employmentdatefrom { get; set; }
        public string? employmentdateto { get; set; }
        public string? position { get; set; }
        public string? supervisor { get; set; }
        public string? duties { get; set; }
        public string? salary { get; set; }
        public string? reasonforleaving { get; set; }
    }
}
