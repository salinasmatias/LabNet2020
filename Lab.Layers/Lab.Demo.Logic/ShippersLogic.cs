using Lab.Demo.Data;
using Lab.Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Logic
{
    public class ShippersLogic:EntityLogic, ILogic<Shipper>
    {
       
        public List<Shipper> GetAll() 
        {
            return this.context.Shippers.ToList();
        }

        public Shipper GetByID(int id) 
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

        public void Insert(Shipper Entity)
        {
            this.context.Shippers.Add(Entity);
            this.context.SaveChanges();
        }

        public void Delete(Shipper Entity)
        {
            this.context.Shippers.Remove(Entity);
            this.context.SaveChanges();
        }
    }
}
