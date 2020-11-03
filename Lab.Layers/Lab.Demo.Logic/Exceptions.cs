using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Demo.Logic
{
    public class PhoneAreaCodeException: Exception
    {
        public PhoneAreaCodeException() : base("An error has occurred while trying to add a new shipper: Phone area code must be (503)") { }
    }
}
