using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.ZuborevDA.Sprint5.Task1.V28.Lib;

namespace Tyuiu.ZuborevDA.Sprint5.Task1.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Зуборев Д. А. | АСОиУБ-23-2";
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* Спринт #5                                                                  *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                    *");
            Console.WriteLine("* Задание #1                                                                 *");
            Console.WriteLine("* Вариант #28                                                                *");
            Console.WriteLine("* Выполнил: Зуборев Дмитрий Александрович | АСОиУБ-23-2                      *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                   *");
            Console.WriteLine("* Дана функция,F(x) = (cos(x)/(x-0,7))-sin(x)*12x+2 (произвести              *");
            Console.WriteLine("* табулирование) f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести    *");
            Console.WriteLine("* проверку деления на ноль. При делении на ноль вернуть значение 0. Результат*");
            Console.WriteLine("* сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль в      *");
            Console.WriteLine("* таблицу. Значения округлить до двух знаков после запятой.                  *");
            Console.WriteLine("*                                                                            *");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
            Console.WriteLine("******************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            Console.WriteLine($"startValue = {startValue}");
            Console.WriteLine($"stopValue = {stopValue}");

            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Файл: {res}");
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
