using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AlumniManagement.Server.Migrations
{
    /// <inheritdoc />
    public partial class adddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Lastname",
                table: "User",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Firstname",
                table: "User",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "GraduationYear",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "CurrentJobTitle", "Email", "FirstName", "GithubProfile", "GraduationSemester", "GraduationYear", "LastName", "LinkedInProfile", "LookingForMentor", "Organization", "Password", "PhoneNumber", "ProfileImage", "UserType" },
                values: new object[,]
                {
                    { 1, "QA Engineer", "zmarshall@gmail.com", "Zaros", "zmarsh01", "Spring", "2020", "Marshall", "ZarosMarshall", true, "Pet Smart", "", "000-000-0000", "", 2 },
                    { 2, "Software Engineer", "osamson@gmail.com", "Olivia", "osams02", "Fall", "2021", "Samson", "OliviaMarshall", true, "Bee Inc.", "", "111-111-1111", "", 2 },
                    { 3, "College Administrator", "rtyler@gmail.com", "Rose", "rtyler78", "Summer", "1998", "Tyler", "RoseTyler", false, "Augusta Technical College", "", "222-222-2222", "", 0 },
                    { 4, "College Administrator", "apond@gmail.com", "Amy", "apond55", "WInter", "1999", "Pond", "AmyPond", false, "Augusta Technical College", "", "444-444-4444", "", 0 },
                    { 5, "Scrum Master", "msantos@gmail.com", "Maria", "msantos8", "Spring", "2010", "Santos", "MariaSantos", false, "Orange.Inc", "", "555-555-5555", "", 1 },
                    { 6, "Project Mnager", "jcruz@gmail.com", "Jose", "jcruz11", "Fall", "2011", "Cruz", "JoseCruz", false, "Text.Inc", "", "777-777-7777", "", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "User",
                newName: "Lastname");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "User",
                newName: "Firstname");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "GraduationYear",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
