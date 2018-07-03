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
<<<<<<< HEAD
=======


>>>>>>> adb2ee5e957fdd1b1fee030ca6e3c8ee6b0e8f47
                    throw new Exception("Неизвестная операция");
            }
        }
     
    }
}
