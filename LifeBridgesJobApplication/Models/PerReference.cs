using System.ComponentModel.DataAnnotations;

namespace LifeBridgesJobApplication.Models
{
    public class PerReference
    {
        [Key]
        public int autoid { get; set; }
        public int appid { get; set; }
        public string? name { get; set; }
        public string? yearsknown { get; set; }
        public string? phone { get; set; }
        public string? street { get; set; }
        public string? city { get; set; }
        public string? state { get; set; }
        public string? zip { get; set; }
        public string? knowapp { get; set; }
        public string? strengths { get; set; }
        public string? weakness { get; set; }
        public string? teamoralone { get; set; }
        public string? teamoralonewhy { get; set; }
        public string? appposition { get; set; }
        public string? goodfit { get; set; }
        public string? goodfitwhy { get; set; }
    }
}
