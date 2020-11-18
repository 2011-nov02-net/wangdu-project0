using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Project0.DataModel;
using Project0.ConsoleApp.Library;
using System;

namespace Project0.DataModel.Repository
{
    // the job of a repository class is to expose simple data access operations and implement them with data access logic.
    // but business logic is not its job

    // two different styles - either each method does savechanges itself
    //  (downside, no transaction logic available "through" the repository)
    //  (upside, the calling code doesn't have to remember to call some save method)
    // ..or, the context is a field, shared among the methods, and it doesn't save unless 
    //    calling code calls your Save mehtod.
    public class StoreRepository 
    {
        private readonly Project0Context _dbContext;

        public StoreRepository(Project0Context contextOptions)
        {
            _dbContext = contextOptions;
        }
        /// <summary>
        /// Add a customer to SQL database
        /// </summary>
        
        public void AddCustomer(ConsoleApp.Library.Customer customer)
        {
            var dbCustomer = new Customer()
            {
                Name = customer.Name,
                Id = customer.Id,
                
            };
            _dbContext.Customers.Add(dbCustomer);
            _dbContext.SaveChanges();
        }
        public void AddSales(ConsoleApp.Library.Sale sale)
        {
            var dbSale = new Sale()
            {
                OrderId = sale.OrderId,
                ProductId = sale.ProductId,
                Price = sale.Price,
                Quantity = sale.Quantity

            };

            _dbContext.Sales.Add(dbSale);

            _dbContext.SaveChanges();
        }
        //public Customer GetCustomerByName(string name)
        //{
        //    using var context = new Project0Context(_dbContext);
        //    DataModel.Customer dbCustomer = context.Customers
        //        .Include(c => c.Name)
        //            .ThenInclude(cs => cs.
        //        .First(c => c.Id == c.Id);

        //    var course = new Customer(dbCustomer.Id, dbCustomer.Name);
        //    foreach (Customer c in dbCustomer
        //    {
                
        //    }

        //    return course;
        //}









        public void Save()
        {
            _dbContext.SaveChanges();
        }

  
    }
}
