using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNet2020
{
    public class ExceptionsPractice
    {
        public int AttemptToDivideByZero(int number) 
        {
            try
            {
                return number / 0; 
            }
            catch(DivideByZeroException ex)
            {
                throw new DivideByZeroException("You attempted to divide by Zero!", ex );
            }
        }

        public int IntegerDivision(int numerator, int denominator)
        {
            return numerator / denominator;
        }
    }
}
