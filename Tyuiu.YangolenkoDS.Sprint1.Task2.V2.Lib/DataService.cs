using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.YangolenkoDS.Sprint1.Task2.V2.Lib
{
    public class DataService : ISprint1Task2V2
    {
        public const double pi = 3.1415926535897932384626433832795;

        public double ConvertAngleToRad(int value)
        {
            return value * (pi / 180); //
        }
    }
}
