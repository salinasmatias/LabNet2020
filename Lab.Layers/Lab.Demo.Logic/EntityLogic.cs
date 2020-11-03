using Lab.Demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Logic
{
    public abstract class EntityLogic
    {
        protected readonly NorthwindContext context;

        public EntityLogic() 
        {
            this.context = new NorthwindContext();
        }
    }
}
