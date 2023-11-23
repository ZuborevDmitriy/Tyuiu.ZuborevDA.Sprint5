using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.ZuborevDA.Sprint5.Task4.V27.Lib;

namespace Tyuiu.ZuborevDA.Sprint5.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                    *");
            Console.WriteLine("* Задание #4                                                                 *");
            Console.WriteLine("* Вариант #27                                                                *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дан файл С:/DataSprint5/InPutDataFileTask4V27.txt в котором есть           *");
            Console.WriteLine("* вещественное значение. Прочитать значение из файла и подставить вместо Х   *");
            Console.WriteLine("* в формуле y = ((x^3)-4x)/cosx. Вычислить значение по формуле (Полученное   *");
            Console.WriteLine("* значение округлить до трёх знаков после запятой) и вернуть полученный      *");
            Console.WriteLine("* результат на консоль.                                                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask4V27.txt";

            Console.WriteLine($"Данные находятся в файле: {path}");

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
