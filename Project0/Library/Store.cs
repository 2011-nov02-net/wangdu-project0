using System;
using System.Collections.Generic;
using System.Text;

namespace Project0.Library
{
    public class Store
    {
        public List<Product> ProductList;
        public List<Customer> CustomerList;
        
        public Store(List<Product> initalProduct, List<Customer> customerlist)
        {
            ProductList = initalProduct;
            CustomerList = customerlist;
        }

        public Store()
        {

        }

        public void AddCustomer(Customer C)
        {
            CustomerList.Add(C);
        }
        public void AddProduct(Product P)
        {
            ProductList.Add(P);
        }

    }
}
