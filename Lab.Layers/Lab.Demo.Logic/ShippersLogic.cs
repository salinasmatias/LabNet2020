using Lab.Demo.Data;
using Lab.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Logic
{
    public class ShippersLogic:EntityLogic
    {
       
        public List<Shipper> GetShippersList() 
        {
            return this.context.Shippers.ToList();
        }

        public Shipper GetShipperByID(int id) 
        {
            try
            {
                return context.Shippers.First(s => s.ShipperID.Equals(id));
            }
            catch (InvalidOperationException)
            {

                throw new InvalidOperationException("We couldn't find a shipper with the provided ID. Please, try introducing a valid ID.");
            }
            catch(FormatException)
            {
                throw new FormatException("That's not a valid input. Please, try introducing a valid ID.");
            }
        }
    }
}
