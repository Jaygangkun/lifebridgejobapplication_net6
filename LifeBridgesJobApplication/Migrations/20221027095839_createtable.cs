using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LifeBridgesJobApplication.Migrations
{
    public partial class createtable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    autoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dateapplied = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApplicationID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    middleinitial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorizedinus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    canprovidedoc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homeaddressStreet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homeaddressCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homeaddressState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homeaddressZip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    homephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cellphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cellcarrier = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    positionother = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emergencyaddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstchoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    secondchoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emergencycontact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emergencyrelationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    emergencytelephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    howfindout = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    driverslicense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    trafficviolations = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    faultaccidents = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    convictedofcrime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    priorconvictions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sexoffender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    highschooldiploma = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    collegedegree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    certificateorlicense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    certificatelist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppDisposition = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.autoid);
                });

            migrationBuilder.CreateTable(
                name: "EmpReference",
                columns: table => new
                {
                    autoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    appid = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employersphone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employmentdatefrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employmentdateto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    supervisor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    salary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    reasonforleaving = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpReference", x => x.autoid);
                });

            migrationBuilder.CreateTable(
                name: "PerReference",
                columns: table => new
                {
                    autoid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    appid = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    yearsknown = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    zip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    knowapp = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    strengths = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    weakness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teamoralone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    teamoralonewhy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    appposition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    goodfit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    goodfitwhy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerReference", x => x.autoid);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");

            migrationBuilder.DropTable(
                name: "EmpReference");

            migrationBuilder.DropTable(
                name: "PerReference");
        }
    }
}
