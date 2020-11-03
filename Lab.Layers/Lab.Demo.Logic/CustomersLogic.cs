﻿using Lab.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Logic
{
    public class CustomersLogic:EntityLogic
    {
        public List<Customer> GetCustomersList() 
        {
            return this.context.Customers.ToList();
        }

        public Customer GetCustomerByID(int id) 
        {
            try
            {
                return context.Customers.First(c => c.CustomerID.Equals(id));
            }
            catch (InvalidOperationException)
            {

                throw new InvalidOperationException("We Couldn't find a customer with the provided ID. Please, try introducing a valid ID.");
            }
            catch (FormatException)
            {
                throw new FormatException("That's not a valid input. Please, try introducing a valid ID");
            }
        }
    }
}
