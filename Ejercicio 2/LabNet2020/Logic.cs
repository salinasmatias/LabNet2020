using ExceptionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2020
{
    public class Logic
    {
        public void ILoveThrowingExceptions() 
        {
            throw new DivideByZeroException();
        }

        public void ILoveThrowingCustomExceptions()
        {
            throw new CustomException();
        }
    }
}
