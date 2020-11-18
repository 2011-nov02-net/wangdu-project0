using System;
using Project0.ConsoleApp.Library;
using System.Collections.Generic;
using System.Text;

namespace Project0.ConsoleApp.Library
{
    public interface IStoreRepository
    {

        
        void AddCustomer(Customer customer);
        void AddSales(Sale sale);




        void Save();

    }
}
