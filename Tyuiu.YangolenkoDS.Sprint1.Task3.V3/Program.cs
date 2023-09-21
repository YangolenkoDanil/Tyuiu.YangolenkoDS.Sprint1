using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.YangolenkoDS.Sprint1.Task3.V3.Lib;

namespace Tyuiu.YangolenkoDS.Sprint1.Task3.V3
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
            Console.WriteLine("* Задание #3                                                                        *");
            Console.WriteLine("* Вариант #3                                                                        *");
            Console.WriteLine("* Выполнил: Янголенко Данил Сергеевич | АСОиУб-23-1                                 *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,           *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране                        *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            double length, width, height;
            Console.WriteLine("Введите длину(см):");
            length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите ширину(см):");
            width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту(см):");
            height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine($"Длина(см) = {length}");
            Console.WriteLine($"Ширина(см) = {width}");
            Console.WriteLine($"Высота(см) = {height}");
            Console.WriteLine("Объем: " + ds.ParallelepipedVolume(length, width, height) + " см.куб");

            Console.ReadKey();
        }
    }
}
