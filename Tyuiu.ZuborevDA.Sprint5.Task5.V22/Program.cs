using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.ZuborevDA.Sprint5.Task5.V22.Lib;

namespace Tyuiu.ZuborevDA.Sprint5.Task5.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                             *");
            Console.WriteLine("* Задание #5                                                                 *");
            Console.WriteLine("* Вариант #22                                                                *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask5V22.txt в котором есть набор      ");
            Console.WriteLine("* значений. Найти минимальное целое число в файле, которое делится на 4.     *");
            Console.WriteLine("* Полученный результат вывести на консоль. У вещественных значений           *");
            Console.WriteLine("* округлить до трёх знаков после запятой.                                    *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask5V22.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine($"Минимальное целое число в файле: {res}");
            Console.ReadKey();
        }
    }
}
