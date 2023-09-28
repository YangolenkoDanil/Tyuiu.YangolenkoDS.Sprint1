using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YangolenkoDS.Sprint1.Task7.V16.Lib;

namespace Tyuiu.YangolenkoDS.Sprint1.Task7.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Янголенко Д. С. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                         *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                           *");
            Console.WriteLine("* Задание #7                                                                        *");
            Console.WriteLine("* Вариант #16                                                                       *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение                    *");
            Console.WriteLine("* по исходным значениям данных, вводимых пользователем.                             *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            double x;

            Console.WriteLine("Введите значение переменной X:");
            x = Convert.ToDouble(Console.ReadLine());

            var z = Math.Round(ds.Calculate(x), 3);
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine($"Z = {z}");
            Console.ReadKey();
        }
    }
}
