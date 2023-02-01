using Microsoft.EntityFrameworkCore;
using TryMe.Domain.Entities;

namespace TryMe.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User { Id = 1, UserName = "James007", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Bond7") },
                new User { Id = 2, UserName = "ShteinerG42", PasswordHash = BCrypt.Net.BCrypt.HashPassword("Gate4") });

            builder.Entity<Test>().HasData(
                new Test { Id = 1, UserId = 1, Title = ".Net starter", Description = "This is a test for those who learn dotnet and want to test their knowledge" },
                new Test { Id = 2, UserId = 1, Title = "Entity Framework", Description = "This is a test for those who learn EF and want to test their knowledge" },
                new Test { Id = 3, UserId = 1, Title = "ASP.Net", Description = "This is a test for those who learn asp.net and want to test their knowledge" },
                new Test { Id = 4, UserId = 2, Title = "Angular", Description = "This is a test for those who learn Angular and want to test their knowledge" },
                new Test { Id = 5, UserId = 2, Title = "Bootstrap", Description = "This is a test for those who learn Bootstrap and want to test their knowledge" },
                new Test { Id = 6, UserId = 2, Title = "Typescript", Description = "This is a test for those who learn typescript and want to test their knowledge" });

            builder.Entity<Question>().HasData(
                new Question { Id = 1, TestId = 1, Description = "What difference between abstract class and interface?",  },
                new Question { Id = 2, TestId = 1, Description = "How CLR allocates memory for an object?" },
                new Question { Id = 3, TestId = 2, Description = "What is lazy loading?" },
                new Question { Id = 4, TestId = 2, Description = "Do you need to use Repository pattern with Entity Framework?" },
                new Question { Id = 5, TestId = 3, Description = "Describe what is middleware pipeline" },
                new Question { Id = 6, TestId = 3, Description = "How to specify query parameter for endpoint?" },
                new Question { Id = 7, TestId = 4, Description = "What is ngModel?"},
                new Question { Id = 8, TestId = 4, Description = "What is component in Angular?" },
                new Question { Id = 9, TestId = 5, Description = "What is the main advantage of Bootstrap?" },
                new Question { Id = 10, TestId = 5, Description = "How to define grid in Bootstrap" },
                new Question { Id = 11, TestId = 6, Description = "What difference between javascript and typescript?" },
                new Question { Id = 12, TestId = 6, Description = "What is interface in typescript?" });

            builder.Entity<Answer>().HasData(
                new Answer { Id = 1, QuestionId = 1, IsCorrect = true, Body = "The special class which cannot be instantiated is known as abstract class, whereas the interface enables us to determine the functionality or functions but cannot implement that" },
                new Answer { Id = 2, QuestionId = 1, IsCorrect = false, Body = "There is no difference" },
                new Answer { Id = 3, QuestionId = 2, IsCorrect = true, Body = "When an object is preceded by the word new" },
                new Answer { Id = 4, QuestionId = 2, IsCorrect = false, Body = "In order for CLR to allocate memory, you must explicitly specify the address in memory" },
                new Answer { Id = 5, QuestionId = 3, IsCorrect = true, Body = "Its process whereby an entity or collection of entities is automatically loaded from the database the first time that a property referring to the entity/entities is accessed" },
                new Answer { Id = 6, QuestionId = 3, IsCorrect = false, Body = "Its process when entities load from database by parts" },
                new Answer { Id = 7, QuestionId = 4, IsCorrect = true, Body = "EF provides us with a ready-made implementation of Repository patterns: DbSet<T>" },
                new Answer { Id = 8, QuestionId = 4, IsCorrect = false, Body = "Yes, we need to implement Repository pattern" },
                new Answer { Id = 9, QuestionId = 5, IsCorrect = true, Body = "It is a piece of code in the application used to process requests and responses." },
                new Answer { Id = 10, QuestionId = 5, IsCorrect = false, Body = "Its static classes which are used to transfer data" },
                new Answer { Id = 11, QuestionId = 6, IsCorrect = true, Body = "We need to specify controller with attribute [HttpGet('query')]" },
                new Answer { Id = 12, QuestionId = 6, IsCorrect = false, Body = "We need to specify configuration of query routes in appsetting.json" },
                new Answer { Id = 13, QuestionId = 7, IsCorrect = true, Body = "The ngModel directive is a directive that is used to bind the values of the HTML controls or any custom form controls, and stores the required user value" },
                new Answer { Id = 14, QuestionId = 7, IsCorrect = false, Body = "ngModel its abstraction wrapper of some objects" },
                new Answer { Id = 15, QuestionId = 8, IsCorrect = true, Body = "Components are the most basic UI building block of an Angular app" },
                new Answer { Id = 16, QuestionId = 8, IsCorrect = false, Body = "Components are libraries with functionality for modules" },
                new Answer { Id = 17, QuestionId = 9, IsCorrect = true, Body = "Its grid system, that makes app flexible and responsive" },
                new Answer { Id = 18, QuestionId = 9, IsCorrect = false, Body = "Its a dynamic class creation system" },
                new Answer { Id = 19, QuestionId = 10, IsCorrect = true, Body = "We need to use 'row' class as contrainer and use 'col' classes in him" },
                new Answer { Id = 20, QuestionId = 10, IsCorrect = false, Body = "We need to use 'grid' class to define grid" },
                new Answer { Id = 21, QuestionId = 11, IsCorrect = true, Body = "TypeScript is known as an Object-oriented programming language whereas JavaScript is a prototype based language" },
                new Answer { Id = 22, QuestionId = 11, IsCorrect = false, Body = "There is no difference" },
                new Answer { Id = 23, QuestionId = 12, IsCorrect = true, Body = "An Interface is a structure which acts as a contract in our application." },
                new Answer { Id = 24, QuestionId = 12, IsCorrect = false, Body = "There is no interfaces in typescript" });

        }
    }
}
