using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TryMe.Data.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "PasswordHash", "UserName" },
                values: new object[,]
                {
                    { 1, "$2a$11$lMPSsM6ToCB3kzOgLT9WcejHGnIbEuH92sPzMHJLnovw3sOQ.s6I6", "James007" },
                    { 2, "$2a$11$I/46nAJAlu2V/BCuIstjguLEDPoMiBqoX1J9OLD1B6/r.lJWmrnOe", "ShteinerG42" }
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "Description", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "This is a test for those who learn dotnet and want to test their knowledge", ".Net starter", 1 },
                    { 2, "This is a test for those who learn EF and want to test their knowledge", "Entity Framework", 1 },
                    { 3, "This is a test for those who learn asp.net and want to test their knowledge", "ASP.Net", 1 },
                    { 4, "This is a test for those who learn Angular and want to test their knowledge", "Angular", 2 },
                    { 5, "This is a test for those who learn Bootstrap and want to test their knowledge", "Bootstrap", 2 },
                    { 6, "This is a test for those who learn typescript and want to test their knowledge", "Typescript", 2 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description", "TestId" },
                values: new object[,]
                {
                    { 1, "What difference between abstract class and interface?", 1 },
                    { 2, "How CLR allocates memory for an object?", 1 },
                    { 3, "What is lazy loading?", 2 },
                    { 4, "Do you need to use Repository pattern with Entity Framework?", 2 },
                    { 5, "Describe what is middleware pipeline", 3 },
                    { 6, "How to specify query parameter for endpoint?", 3 },
                    { 7, "What is ngModel?", 4 },
                    { 8, "What is component in Angular?", 4 },
                    { 9, "What is the main advantage of Bootstrap?", 5 },
                    { 10, "How to define grid in Bootstrap", 5 },
                    { 11, "What difference between javascript and typescript?", 6 },
                    { 12, "What is interface in typescript?", 6 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Body", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { 1, "The special class which cannot be instantiated is known as abstract class, whereas the interface enables us to determine the functionality or functions but cannot implement that", true, 1 },
                    { 2, "There is no difference", false, 1 },
                    { 3, "When an object is preceded by the word new", true, 2 },
                    { 4, "In order for CLR to allocate memory, you must explicitly specify the address in memory", false, 2 },
                    { 5, "Its process whereby an entity or collection of entities is automatically loaded from the database the first time that a property referring to the entity/entities is accessed", true, 3 },
                    { 6, "Its process when entities load from database by parts", false, 3 },
                    { 7, "EF provides us with a ready-made implementation of Repository patterns: DbSet<T>", true, 4 },
                    { 8, "Yes, we need to implement Repository pattern", false, 4 },
                    { 9, "It is a piece of code in the application used to process requests and responses.", true, 5 },
                    { 10, "Its static classes which are used to transfer data", false, 5 },
                    { 11, "We need to specify controller with attribute [HttpGet('query')]", true, 6 },
                    { 12, "We need to specify configuration of query routes in appsetting.json", false, 6 },
                    { 13, "The ngModel directive is a directive that is used to bind the values of the HTML controls or any custom form controls, and stores the required user value", true, 7 },
                    { 14, "ngModel its abstraction wrapper of some objects", false, 7 },
                    { 15, "Components are the most basic UI building block of an Angular app", true, 8 },
                    { 16, "Components are libraries with functionality for modules", false, 8 },
                    { 17, "Its grid system, that makes app flexible and responsive", true, 9 },
                    { 18, "Its a dynamic class creation system", false, 9 },
                    { 19, "We need to use 'row' class as contrainer and use 'col' classes in him", true, 10 },
                    { 20, "We need to use 'grid' class to define grid", false, 10 },
                    { 21, "TypeScript is known as an Object-oriented programming language whereas JavaScript is a prototype based language", true, 11 },
                    { 22, "There is no difference", false, 11 },
                    { 23, "An Interface is a structure which acts as a contract in our application.", true, 12 },
                    { 24, "There is no interfaces in typescript", false, 12 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
