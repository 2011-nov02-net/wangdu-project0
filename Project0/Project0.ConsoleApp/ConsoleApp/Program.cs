using Project0.ConsoleApp.Library;
using System;
using System.Collections.Generic;



namespace Project0.ConsoleApp.ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            Store s = new Store();
            
            Console.WriteLine("Welcome to the store");
            int action = chooseAction();

            while(action != 0)
            {
                Console.WriteLine("You chose " + action);

                switch(action)
                {
                    //add a customer
                    case 1:
                        Console.WriteLine("You choose to add a new customer to the store");
                        String name = "";
                         

                        Console.WriteLine("What is the customer name?");
                        name = Console.ReadLine();
                        Customer newCustomer = new Customer(name);
                        s.CustomerList.Add(newCustomer);
                        printInventory(s);
                        break;

                    //add a product
                    case 2:
                        Console.WriteLine("You choose to add a product to the productlist");




                        break;

                    default:
                        break;
                }
                action = chooseAction();
            }
        }

        private static void printInventory(Store s)
        {
            foreach(Customer c in s.CustomerList)
            {
                Console.WriteLine(c);
            }
        }

        private static int chooseAction()
        {
            int choice = 0;
            Console.WriteLine("Choose an action (0) to quit (1) to add a new customer to store (2) to add a product to the order");
            choice = int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
