using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project0.ConsoleApp.Library;
using Project0.DataModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;
using Project0.DataModel.Repository;

namespace Project0.ConsoleApp.ConsoleApp
{
    class Program
    {
        static DbContextOptions<Project0Context> s_dbContextOptions;
        static void Main(string[] args)
        {



            ////For the debugging the code for SQL
            using var logStream = new StreamWriter("ef-logs.txt");
            //// DbContextOptions is how we give the context its connection string (to log in to the sql server),
            //// tell it to use SQL server
            var optionsBuilder = new DbContextOptionsBuilder<Project0Context>();
            optionsBuilder.UseSqlServer(GetConnectionString());
            optionsBuilder.LogTo(logStream.Write, LogLevel.Information);
            using var context = new Project0Context(optionsBuilder.Options);


            StoreRepository storeRepo = new StoreRepository(context);

            int action = chooseAction();
            while (action != 0)
            {
                var random = new Random();
                Console.WriteLine("You chose " + action);
                switch (action)
                {
                    //place an order
                    case 2:
                        Console.WriteLine("let's place an order");
                        int Id = random.Next(1, 1000);
                        int OrderId = random.Next(1, 1000);
                        string ProductId;
                        int PID;
                        string Pr;
                        int Price;
                        string Qua;
                        int Quantity;
                        Console.WriteLine("Enter the Product Id");
                        ProductId = Console.ReadLine();
                        Console.WriteLine("Enter the Price");
                        Pr = Console.ReadLine();
                        Console.WriteLine("Enter the Quantity");
                        Qua = Console.ReadLine();
                        PID = Convert.ToInt32(ProductId);
                        Price = Convert.ToInt32(Pr);
                        Quantity = Convert.ToInt32(Qua);
                        var newSales = new Library.Sale(Id, OrderId, PID, Price, Quantity);
                        storeRepo.AddSales(newSales);


                        break;
                    // add a new customer
                    case 1:
                        Console.WriteLine("Let's add a new customer");
                        string Name = "";
                        int CustomerId = random.Next(1, 10000);
                        Console.WriteLine("Enter the name");
                        Name = Console.ReadLine();

                        var newCustomer = new Library.Customer(CustomerId, Name);
                        storeRepo.AddCustomer(newCustomer);
                        Console.WriteLine(Name + " was added");
                        break;
                    // Search Customer by Name
                    case 6:
                        Console.WriteLine("Let's Search for a customer");
                        string SName = "";
                        Console.WriteLine("Enter the name");
                        SName = Console.ReadLine();

                        var oldCustomer = new Library.Customer(SName);
                      //storeRepo.SearchCustomers(oldCustomer);
                        
                        break;
                    // Display Details of An Order
                    case 3:
                        break;
                    // Display Order History of a Store
                    case 4:
                        break;
                    // Display Order History of a Customer
                    case 5:
                        break;
                    default:
                        break;
                }
                action = chooseAction();
            }

        }

        static public int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new customer (2) to place an order");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }

        static string GetConnectionString()
        {
            string path = "../../../../../Project0.json";
            string json;
            try
            {
                json = File.ReadAllText(path);
            }
            catch (IOException)
            {
                Console.WriteLine($"required file {path} not found. should just be the connection string in quotes.");
                throw;
            }
            string connectionString = JsonSerializer.Deserialize<string>(json);
            return connectionString;
        }
     
        




    }
}
