﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    public class add : ICalculateTwoArguments
    {
         public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
