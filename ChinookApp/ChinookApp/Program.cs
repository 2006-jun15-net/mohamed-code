using Microsoft.EntityFrameworkCore;
using System;
using ChinookApp.DataAccess;
using ChinookApp.DataAccess.Model;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace ChinookApp
{
    class Program
    {
        // Entity Framework Core
        // database-first approach steps...
        /*
         * 1. have a data access library project separate from the startup application project.
         *    (with a project reference from the latter to the former).
         * 2. install Microsoft.EntityFrameworkCore.Design and Microsoft.EntityFrameworkCore.SqlServer
         *    to both projects.
         * 3. using Git Bash / terminal, from the data access project folder run (split into several lines for clarity):
         *    dotnet ef dbcontext scaffold <connection-string-in-quotes>
         *      Microsoft.EntityFrameworkCore.SqlServer
         *      --startup-project <path-to-startup-project-folder>
         *      --force
         *      --output-dir Entities
         *    https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet#dotnet-ef-dbcontext-scaffold
         *    (if you don't have dotnet ef installed, run: "dotnet tool install --global dotnet-ef")
         *    (this will fail if your projects do not compile)
         * 4. delete the DbContext.OnConfiguring method from the scaffolded code.
         *    (so that the connection string is not put on the public internet)
         * 5. any time you change the structure of the tables (DDL), go to step 3.
         */



        // Entity Framework configures itself at runtime
        // from three sources -
        // (1) OnModelConfiguring method (fluent API)
        // (2) DataAnnotations attributes on the entity classes
        // (3) conventions
        //      - e.g.: if a type named "X" has a property named either "Id" or "XId",
        //            it will be assumed to be the primary key

        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });

        public static readonly DbContextOptions<ChinookContext> Options = new DbContextOptionsBuilder<ChinookContext>()
            .UseLoggerFactory(MyLoggerFactory)
            .UseSqlServer(SecretConfiguration.ConnectionString)
            .Options;
        static void Main(string[] args)
        {

            DisplayData();

            //Console.WriteLine("\nAdding some data...");
            //AddSomeDataFromUserInput();

            //DisplayData();

            //Console.WriteLine("\nUpdating some data...");
            //UpdateSomeData();

            //DisplayData();

            //Console.WriteLine("\nDeleting some data...");
            //DeleteSomeData();

            //DisplayData();
        }


        public static void DeleteSomeData()
        {
            throw new NotImplementedException();
        }

        public static void UpdateSomeData()
        {
            throw new NotImplementedException();
        }

        public static void AddSomeDataFromUserInput()
        {
            throw new NotImplementedException();
        }



        public static void DisplayData()
        {
            using var context = new ChinookContext(Options);

            List<Employee> salespeople = context.Employee
                .Where(e => e.Title.Contains("sales"))
                .ToList();

            foreach (Employee person in salespeople)
            {
                Console.WriteLine($"{ person.Title} {person.FirstName} {person.LastName}");
            }
        }
    }
}
