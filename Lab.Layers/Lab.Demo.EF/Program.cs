﻿using Lab.Demo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.EF
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippersLogic shippersLogic = new ShippersLogic();
            var shippersList = shippersLogic.GetShippersList();
            CustomersLogic customersLogic = new CustomersLogic();
            var customersList = customersLogic.GetCustomersList();

            foreach (var shipper in shippersList) 
            {
                Console.WriteLine("Shipper ID: {0}\nCompany name: {1}\nPhone:{2}\n", shipper.ShipperID, shipper.CompanyName, shipper.Phone);
            }

            foreach (var customer in customersList) 
            {
                Console.WriteLine("Customer ID: {0}\nContact Name: {1}\nContactTitle:{2}\nAddreess: {3}\nCity: {4}\n",
                    customer.CustomerID, customer.ContactName, customer.ContactTitle, customer.Address, customer.City);
            }

            try
            {
                var shipper = shippersLogic.GetShipperByID(4);
                Console.WriteLine("Shipper ID: {0}\nCompany name: {1}\nPhone:{2}\n", shipper.ShipperID, shipper.CompanyName, shipper.Phone);
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
