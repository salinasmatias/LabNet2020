using Lab.Demo.Data;
using Lab.Demo.Entities;
using Lab.Demo.Logic;
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
            var shippersList = shippersLogic.GetAll();
            CustomersLogic customersLogic = new CustomersLogic();
            var customersList = customersLogic.GetAll();

            #region GetAll
            foreach (var shipper in shippersList) 
            {
                Console.WriteLine("Shipper ID: {0}\nCompany name: {1}\nPhone: {2}\n", shipper.ShipperID, shipper.CompanyName, shipper.Phone);
            }

            foreach (var customer in customersList) 
            {
                Console.WriteLine("Customer ID: {0}\nContact Name: {1}\nContactTitle:{2}\nAddreess: {3}\nCity: {4}\n",
                    customer.CustomerID, customer.ContactName, customer.ContactTitle, customer.Address, customer.City);
            }
            #endregion

            #region GetByID
            try
            {
                var shipper = shippersLogic.GetByID(4);
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
            #endregion

            #region Insert
           /*var std = new Shipper()
            {
                ShipperID = 4,
                CompanyName = "Amazon",
                Phone = "(503) 555-9999"
            };
            try 
            {
                shippersLogic.Insert(std);
            }
            catch (PhoneAreaCodeException e)
            {
                Console.WriteLine(e.Message);
            }*/
            #endregion

            #region Update
            using (var context = new NorthwindContext())
             {
                 var shipperToUpdate = context.Shippers.Find(6);
                 shipperToUpdate.CompanyName = "Neoris";
                 context.SaveChanges();
             }
            #endregion

            #region Delete
            var deleteShipper = shippersLogic.GetByID(6);
            shippersLogic.Delete(deleteShipper);
            
            #endregion
            Console.ReadKey(true);
        }
    }
}
