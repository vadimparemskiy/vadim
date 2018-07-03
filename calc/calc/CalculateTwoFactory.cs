using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
 class CalculateTwoFactory
    {
        public static ICalculateTwoArguments CreateCalculate(string caluclateName)
        {
            switch(caluclateName)
            {
                case "sum":
                    return new add();
                case "sabtraction":
                    return new sabtraction();
                case "multyplication":
                    return new multyplication();
                case "division":
                    return new division();
                    default:


                    throw new Exception("Неизвестная операция");
            }
        }
     
    }
}
