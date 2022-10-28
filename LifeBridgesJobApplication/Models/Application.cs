using System.ComponentModel.DataAnnotations;

namespace LifeBridgesJobApplication.Models
{
    public class Application
    {
        [Key]
        public int autoid { get; set; }
        public DateTime? dateapplied { get; set; }
        public string? PasswordSalt { get; set; }
        public string? ApplicationID { get; set; }
        public string? firstname { get; set; }
        public string? middleinitial { get; set; }
        public string? lastname { get; set; }
        public string? authorizedinus { get; set; }
        public string? canprovidedoc { get; set; }
        public string? homeaddressStreet { get; set; }
        public string? homeaddressCity { get; set; }
        public string? homeaddressState { get; set; }
        public string? homeaddressZip { get; set; }
        public string? homephone { get; set; }
        public string? cellphone { get; set; }
        public string? cellcarrier { get; set; }
        public string? email { get; set; }
        public string? position { get; set; }
        public string? positionother { get; set; }
        public string? emergencyaddress { get; set; }
        public string? firstchoice { get; set; }
        public string? secondchoice { get; set; }
        public string? emergencycontact { get; set; }
        public string? emergencyrelationship { get; set; }
        public string? emergencytelephone { get; set; }
        public string? howfindout { get; set; }
        public string? driverslicense { get; set; }
        public string? trafficviolations { get; set; }
        public string? faultaccidents { get; set; }
        public string? convictedofcrime { get; set; }
        public string? priorconvictions { get; set; }
        public string? sexoffender { get; set; }
        public string? highschooldiploma { get; set; }
        public string? collegedegree { get; set; }
        public string? certificateorlicense { get; set; }
        public string? certificatelist { get; set; }
        public string? AppDisposition { get; set; }
    }
}
