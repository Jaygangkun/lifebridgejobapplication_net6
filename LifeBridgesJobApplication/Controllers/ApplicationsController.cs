using LifeBridgesJobApplication.Data;
using LifeBridgesJobApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Net;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LifeBridgesJobApplication.Controllers
{
    [Route("api/applications")]
    [ApiController]
    public class ApplicationsController: ControllerBase
    {
        private DataContext _dataContext;
        public ApplicationsController(DataContext dataContext) : base()
        {
            _dataContext = dataContext;
        }
        // POST api/<ApplicationsController>
        [HttpPost]
        public async Task<IActionResult> Post()
        {
            JsonObject resp = new JsonObject();
            //resp.Add("error", "message");

            JsonNode reqData = null;
            using (StreamReader reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                string reqString = await reader.ReadToEndAsync();

                reqData = JsonValue.Parse(reqString);

            }

            if(reqData == null)
            {
                resp.Add("error", "No Data");
                return new JsonResult(resp);
            }

            //_dataContext.Database.ExecuteSqlRaw("SELECT * FROM applications");
            //_dataContext.Database.ExecuteSqlRaw("INSERT INTO Application(firstname, lastname) VALUES('tt', 'tt3')");
            var appObj = new Application() { 
                firstname = (reqData["firstanme"] != null ? reqData["firstname"].ToString() : ""),
                middleinitial = (reqData["middleinitial"] != null ? reqData["middleinitial"].ToString() : ""),
                lastname = (reqData["lastname"] != null ? reqData["lastname"].ToString() : ""),
                ApplicationID = (reqData["ssn"] != null ? reqData["ssn"].ToString() : ""),
                homeaddressStreet = (reqData["homeaddress-street"] != null ? reqData["homeaddress-street"].ToString() : ""),
                homeaddressCity = (reqData["homeaddress-city"] != null ? reqData["homeaddress-city"].ToString() : ""),
                homeaddressState = (reqData["homeaddress-state"] != null ? reqData["homeaddress-state"].ToString() : ""),
                homeaddressZip = (reqData["homeaddress-zip"] != null ? reqData["homeaddress-zip"].ToString() : ""),
                homephone = (reqData["homephone"] != null ? reqData["homephone"].ToString() : ""),
                cellphone = (reqData["cellphone"] != null ? reqData["cellphone"].ToString() : ""),
                cellcarrier = (reqData["cellcarrier"] != null ? reqData["cellcarrier"].ToString() : ""),
                email = (reqData["email"] != null ? reqData["email"].ToString() : ""),
                position  = (reqData["position"] != null ? reqData["position"].ToString() : ""),
                positionother = (reqData["positionother"] != null ? reqData["positionother"].ToString() : ""),
                firstchoice = (reqData["firstchoice"] != null ? reqData["firstchoice"].ToString() : ""),
                secondchoice = (reqData["secondchoice"] != null ? reqData["secondchoice"].ToString() : ""),
                emergencycontact = (reqData["emergencycontact"] != null ? reqData["emergencycontact"].ToString() : ""),
                emergencyrelationship = (reqData["emergencyrelationship"] != null ? reqData["emergencyrelationship"].ToString() : ""),
                emergencytelephone = (reqData["emergencytelephone"] != null ? reqData["emergencytelephone"].ToString() : ""),
                emergencyaddress = (reqData["emergencyaddress"] != null ? reqData["emergencyaddress"].ToString() : ""),
                howfindout = (reqData["howfindout"] != null ? reqData["howfindout"].ToString() : ""),
                driverslicense = (reqData["driverslicense"] != null ? reqData["driverslicense"].ToString() : ""),
                priorconvictions = (reqData["priorconvictions"] != null ? reqData["priorconvictions"].ToString() : ""),
                certificatelist = (reqData["certificatelist"] != null ? reqData["certificatelist"].ToString() : ""),
                trafficviolations = (reqData["trafficviolations"] != null ? reqData["trafficviolations"].ToString() : ""),
                faultaccidents = (reqData["faultaccidents"] != null ? reqData["faultaccidents"].ToString() : ""),
                convictedofcrime = (reqData["convictedofcrime"] != null ? reqData["convictedofcrime"].ToString() : ""),
                sexoffender = (reqData["sexoffender"] != null ? reqData["sexoffender"].ToString() : ""),
                highschooldiploma = (reqData["highschooldiploma"] != null ? reqData["highschooldiploma"].ToString() : ""),
                collegedegree = (reqData["collegedegree"] != null ? reqData["collegedegree"].ToString() : ""),
                certificateorlicense = (reqData["certificateorlicense"] != null ? reqData["certificateorlicense"].ToString() : ""),
                authorizedinus = (reqData["authorizedinus"] != null ? reqData["authorizedinus"].ToString() : ""),
                canprovidedoc = (reqData["canprovidedoc"] != null ? reqData["canprovidedoc"].ToString() : ""),
            };
            _dataContext.Applications.Add(appObj);
            _dataContext.SaveChanges();

            if (reqData["work-experience"] != null)
            {
                foreach (var empRef in reqData["work-experience"].AsArray())
                {
                    var empRefObj = new EmpReference()
                    {
                        appid = appObj.autoid,
                        place = (empRef["place"] != null ? empRef["place"].ToString() : ""),
                        employersphone = (empRef["employersphone"] != null ? empRef["employersphone"].ToString() : ""),
                        street = (empRef["street"] != null ? empRef["street"].ToString() : ""),
                        city = (empRef["city"] != null ? empRef["city"].ToString() : ""),
                        state = (empRef["state"] != null ? empRef["state"].ToString() : ""),
                        zip = (empRef["zip"] != null ? empRef["zip"].ToString() : ""),
                        employmentdatefrom = (empRef["employmentdatefrom"] != null ? empRef["employmentdatefrom"].ToString() : ""),
                        employmentdateto = (empRef["employmentdateto"] != null ? empRef["employmentdateto"].ToString() : ""),
                        position = (empRef["position"] != null ? empRef["position"].ToString() : ""),
                        supervisor = (empRef["supervisor"] != null ? empRef["supervisor"].ToString() : ""),
                        duties = (empRef["duties"] != null ? empRef["duties"].ToString() : ""),
                        salary = (empRef["salary"] != null ? empRef["salary"].ToString() : ""),
                        reasonforleaving = (empRef["reasonforleaving"] != null ? empRef["reasonforleaving"].ToString() : "")
                    };

                    _dataContext.EmpRefs.Add(empRefObj);
                    _dataContext.SaveChanges();
                }
            }

            if (reqData["personal-references"] != null)
            {
                foreach (var empRef in reqData["personal-references"].AsArray())
                {
                    var perRefObj = new PerReference()
                    {
                        appid = appObj.autoid,
                        name = (empRef["name"] != null ? empRef["name"].ToString() : ""),
                        phone = (empRef["phone"] != null ? empRef["phone"].ToString() : ""),
                        street = (empRef["street"] != null ? empRef["street"].ToString() : ""),
                        city = (empRef["city"] != null ? empRef["city"].ToString() : ""),
                        state = (empRef["state"] != null ? empRef["state"].ToString() : ""),
                        zip = (empRef["zip"] != null ? empRef["zip"].ToString() : ""),
                        yearsknown = (empRef["yearsknown"] != null ? empRef["yearsknown"].ToString() : "")
                    };

                    _dataContext.PerRefs.Add(perRefObj);
                    _dataContext.SaveChanges();
                }
            }
            resp.Add("appid", appObj.autoid);

            return new JsonResult(resp);
            //using (var ctx = new DataContext())
            //{
            //    var studentList = ctx.Database.ExecuteSqlRaw("SELECT * FROM applications");
            //}

            //return Ok(app.autoid.ToString());

            if (reqData != null)
            {
                if (reqData["firstname"] != null)
                {
                    Match m = Regex.Match(reqData["firstname"].ToString(), @"/^(\w+|)$/i");
                    if(!m.Success)
                    {

                    }
                }
            }
            return new JsonResult(resp);
            //return Ok("success");
        }
    }
}
