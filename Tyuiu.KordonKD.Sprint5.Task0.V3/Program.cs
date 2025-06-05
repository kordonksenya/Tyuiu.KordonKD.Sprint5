using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KordonKD.Sprint5.Task0.V3.Lib;
using System.IO;

namespace Tyuiu.KordonKD.Sprint5.Task0.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Кордон К.Д | ИСТНб-24-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #5                                                              *");
            Console.WriteLine("* Тема: Запись данных в текстовый файл                                       *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* Выполнил: Кордон Ксения Дмитриевна | ИСТНб-24-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine(@"*     Дано выражение вычислить его значение при x = 3,                  *");
            Console.WriteLine("*    результат сохранить в текстовый файл OutPutFileTask0.txt            *");
            Console.WriteLine(" и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x = 3;
            Console.WriteLine("Значение X = " + x);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            double result = ds.Calculate(x);
            
            string filePath = ds.SaveToFile(result);

            Console.WriteLine("Полученный результат: " + result);
            Console.WriteLine("Файл с результатом сохранен по пути: " + filePath);
            Console.WriteLine("Создан!");

            Console.ReadKey();

        }
    }
}
