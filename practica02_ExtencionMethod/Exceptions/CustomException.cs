﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica02_ExtencionMethod.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException() :base("Esta es la excepción personalizada")
        { 
        }
    }
}
