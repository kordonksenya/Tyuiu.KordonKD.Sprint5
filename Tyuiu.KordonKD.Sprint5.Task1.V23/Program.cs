using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KordonKD.Sprint5.Task1.V23.Lib;

namespace Tyuiu.KordonKD.Sprint5.Task1.V23
{
    internal class DataService 
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнила: Кордон К.Д | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнила: Кордон К.Д | ИСТНб-24-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция произвести табурирование f(x) на заданном диапазоне [-5; 5]*");
            Console.WriteLine("* шагом 1. Произвести проверку деления на ноль. При делении на ноль       *");
            Console.WriteLine("* вернуть значение 0. Результат сохранить в текстовый файл                *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в таблицу.                     *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: = " + res);
            Console.WriteLine("Создан! ");
            Console.ReadKey();
        }
    }
}
