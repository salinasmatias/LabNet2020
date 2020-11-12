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

        public virtual Shipper GetByID(int id) 
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
            if(Entity.Phone.Substring(0,5) != "(503)")
            {
                throw new PhoneAreaCodeException();
            }
            this.context.Shippers.Add(Entity);
            this.context.SaveChanges();
        }

        public void Delete(Shipper Entity)
        {
            this.context.Shippers.Remove(Entity);
            this.context.SaveChanges();
        }

        public void Update(Shipper Entity)
        {
            if (Entity.Phone.Substring(0, 5) != "(503)")
            {
                throw new PhoneAreaCodeException();
            }
            var shippertoUpdate = this.context.Shippers.Find(Entity.ShipperID);
            shippertoUpdate.CompanyName = Entity.CompanyName;
            shippertoUpdate.Phone = Entity.Phone;
            context.SaveChanges();
        }
    }
}
