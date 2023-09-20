using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YangolenkoDS.Sprint1.Task2.V2.Lib;

namespace Tyuiu.YangolenkoDS.Sprint1.Task2.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Янголенко Д. С. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                         *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                               *");
            Console.WriteLine("* Задание #2                                                                        *");
            Console.WriteLine("* Вариант #2                                                                        *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя угол в градусах,           *");
            Console.WriteLine("* переводит угол в радианы по формуле x * (pi / 180)                                *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int x;
            Console.WriteLine("Угол в градусах:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine("Угол в радианах = " + Math.Round(ds.ConvertAngleToRad(x), 3));
            Console.ReadLine();
        }
    }
}
