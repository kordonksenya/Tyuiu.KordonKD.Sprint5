using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KordonKD.Sprint5.Task6.V1.Lib;

namespace Tyuiu.KordonKD.Sprint5.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dp = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Кордон К.Д| ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил Кордон Ксения Дмитриевна  | ИСТНб-24-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл @С:\\DataSprint5\\InPutDataFileTask5V17.txt в котором есть      *");
            Console.WriteLine("* набор значений. Найти сумму всех простых целых чисел в файле.           *");
            Console.WriteLine("* Полученный результат вывести на консоль. У вещественных значений        *");
            Console.WriteLine("*  округлить до трёх знаков после запятой.                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = @"C:\DataSprint5\InPutDataFileTask5V17.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            string fileContent = "-9 13 -0.71 19.24 2.73 -0.5 -8 12.8 -3.01 11.69 -7 -1 11.8 7 -4 5.33 18.96 12.16 -5 -8.15";
            Console.WriteLine($"Содержимое файла: {fileContent}");
            string fileName = "InPutDataFileTask5V17.txt";
            string filePath = Path.Combine(path, fileName);

            Console.WriteLine($"Файл будет создан по пути: {filePath}");

            try
            {

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }


                File.WriteAllText(filePath, fileContent);
                Console.WriteLine("Файл успешно создан и заполнен данными.");

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");


                double result = dp.CalculateSumOfPrimeIntegersFromFile(filePath);


                Console.WriteLine($"Сумма простых целых чисел: {result.ToString("F3")}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine($"Ошибка при обработке файла: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }

        private double CalculateSumOfPrimeIntegersFromFile(string filePath)
        {
            throw new NotImplementedException();
        }
    }
    
}
