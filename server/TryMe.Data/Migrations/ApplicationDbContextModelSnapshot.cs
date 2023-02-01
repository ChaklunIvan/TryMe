﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TryMe.Data;

#nullable disable

namespace TryMe.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("TryMe.Domain.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("BOOLEAN");

                    b.Property<int>("QuestionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Body = "The special class which cannot be instantiated is known as abstract class, whereas the interface enables us to determine the functionality or functions but cannot implement that",
                            IsCorrect = true,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            Body = "There is no difference",
                            IsCorrect = false,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            Body = "When an object is preceded by the word new",
                            IsCorrect = true,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 4,
                            Body = "In order for CLR to allocate memory, you must explicitly specify the address in memory",
                            IsCorrect = false,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 5,
                            Body = "Its process whereby an entity or collection of entities is automatically loaded from the database the first time that a property referring to the entity/entities is accessed",
                            IsCorrect = true,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 6,
                            Body = "Its process when entities load from database by parts",
                            IsCorrect = false,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 7,
                            Body = "EF provides us with a ready-made implementation of Repository patterns: DbSet<T>",
                            IsCorrect = true,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 8,
                            Body = "Yes, we need to implement Repository pattern",
                            IsCorrect = false,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 9,
                            Body = "It is a piece of code in the application used to process requests and responses.",
                            IsCorrect = true,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 10,
                            Body = "Its static classes which are used to transfer data",
                            IsCorrect = false,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 11,
                            Body = "We need to specify controller with attribute [HttpGet('query')]",
                            IsCorrect = true,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 12,
                            Body = "We need to specify configuration of query routes in appsetting.json",
                            IsCorrect = false,
                            QuestionId = 6
                        },
                        new
                        {
                            Id = 13,
                            Body = "The ngModel directive is a directive that is used to bind the values of the HTML controls or any custom form controls, and stores the required user value",
                            IsCorrect = true,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 14,
                            Body = "ngModel its abstraction wrapper of some objects",
                            IsCorrect = false,
                            QuestionId = 7
                        },
                        new
                        {
                            Id = 15,
                            Body = "Components are the most basic UI building block of an Angular app",
                            IsCorrect = true,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 16,
                            Body = "Components are libraries with functionality for modules",
                            IsCorrect = false,
                            QuestionId = 8
                        },
                        new
                        {
                            Id = 17,
                            Body = "Its grid system, that makes app flexible and responsive",
                            IsCorrect = true,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 18,
                            Body = "Its a dynamic class creation system",
                            IsCorrect = false,
                            QuestionId = 9
                        },
                        new
                        {
                            Id = 19,
                            Body = "We need to use 'row' class as contrainer and use 'col' classes in him",
                            IsCorrect = true,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 20,
                            Body = "We need to use 'grid' class to define grid",
                            IsCorrect = false,
                            QuestionId = 10
                        },
                        new
                        {
                            Id = 21,
                            Body = "TypeScript is known as an Object-oriented programming language whereas JavaScript is a prototype based language",
                            IsCorrect = true,
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 22,
                            Body = "There is no difference",
                            IsCorrect = false,
                            QuestionId = 11
                        },
                        new
                        {
                            Id = 23,
                            Body = "An Interface is a structure which acts as a contract in our application.",
                            IsCorrect = true,
                            QuestionId = 12
                        },
                        new
                        {
                            Id = 24,
                            Body = "There is no interfaces in typescript",
                            IsCorrect = false,
                            QuestionId = 12
                        });
                });

            modelBuilder.Entity("TryMe.Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("TEXT");

                    b.Property<int>("TestId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TestId");

                    b.ToTable("Questions", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "What difference between abstract class and interface?",
                            TestId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "How CLR allocates memory for an object?",
                            TestId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "What is lazy loading?",
                            TestId = 2
                        },
                        new
                        {
                            Id = 4,
                            Description = "Do you need to use Repository pattern with Entity Framework?",
                            TestId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "Describe what is middleware pipeline",
                            TestId = 3
                        },
                        new
                        {
                            Id = 6,
                            Description = "How to specify query parameter for endpoint?",
                            TestId = 3
                        },
                        new
                        {
                            Id = 7,
                            Description = "What is ngModel?",
                            TestId = 4
                        },
                        new
                        {
                            Id = 8,
                            Description = "What is component in Angular?",
                            TestId = 4
                        },
                        new
                        {
                            Id = 9,
                            Description = "What is the main advantage of Bootstrap?",
                            TestId = 5
                        },
                        new
                        {
                            Id = 10,
                            Description = "How to define grid in Bootstrap",
                            TestId = 5
                        },
                        new
                        {
                            Id = 11,
                            Description = "What difference between javascript and typescript?",
                            TestId = 6
                        },
                        new
                        {
                            Id = 12,
                            Description = "What is interface in typescript?",
                            TestId = 6
                        });
                });

            modelBuilder.Entity("TryMe.Domain.Entities.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tests", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "This is a test for those who learn dotnet and want to test their knowledge",
                            Title = ".Net starter",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "This is a test for those who learn EF and want to test their knowledge",
                            Title = "Entity Framework",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "This is a test for those who learn asp.net and want to test their knowledge",
                            Title = "ASP.Net",
                            UserId = 1
                        },
                        new
                        {
                            Id = 4,
                            Description = "This is a test for those who learn Angular and want to test their knowledge",
                            Title = "Angular",
                            UserId = 2
                        },
                        new
                        {
                            Id = 5,
                            Description = "This is a test for those who learn Bootstrap and want to test their knowledge",
                            Title = "Bootstrap",
                            UserId = 2
                        },
                        new
                        {
                            Id = 6,
                            Description = "This is a test for those who learn typescript and want to test their knowledge",
                            Title = "Typescript",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("TryMe.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            PasswordHash = "$2a$11$lMPSsM6ToCB3kzOgLT9WcejHGnIbEuH92sPzMHJLnovw3sOQ.s6I6",
                            UserName = "James007"
                        },
                        new
                        {
                            Id = 2,
                            PasswordHash = "$2a$11$I/46nAJAlu2V/BCuIstjguLEDPoMiBqoX1J9OLD1B6/r.lJWmrnOe",
                            UserName = "ShteinerG42"
                        });
                });

            modelBuilder.Entity("TryMe.Domain.Entities.Answer", b =>
                {
                    b.HasOne("TryMe.Domain.Entities.Question", "Question")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("TryMe.Domain.Entities.Question", b =>
                {
                    b.HasOne("TryMe.Domain.Entities.Test", "Test")
                        .WithMany("Questions")
                        .HasForeignKey("TestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test");
                });

            modelBuilder.Entity("TryMe.Domain.Entities.Test", b =>
                {
                    b.HasOne("TryMe.Domain.Entities.User", "User")
                        .WithMany("Tests")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("TryMe.Domain.Entities.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("TryMe.Domain.Entities.Test", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("TryMe.Domain.Entities.User", b =>
                {
                    b.Navigation("Tests");
                });
#pragma warning restore 612, 618
        }
    }
}
