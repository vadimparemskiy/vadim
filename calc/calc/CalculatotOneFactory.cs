using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class CalculatotOneFactory
    {
        public static Ioneargument CreateCalculate(string caluclateName)
        {
            switch (caluclateName)
            {
                case "Sin":
                    return new Sin();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
