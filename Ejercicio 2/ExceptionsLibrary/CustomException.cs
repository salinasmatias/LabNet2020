﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsLibrary
{
    public class CustomException : Exception
    {
        public CustomException() : base("This is a custom message.") { }
    }
}
