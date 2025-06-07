using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KordonKD.Sprint5.Task7.V4.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KordonKD.Sprint5.Task7.V4

{
    internal class DataService
    {
       
        private static object ds;

        public static object DataSprint5 { get; private set; }

        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Кордон К.Д | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #4                                                             *");
            Console.WriteLine("* Выполнил: Кордон Ксения Дмитриевна | ИСТНб-24-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*     Дан файл С:\\DataSprint5\\InPutDataFileTask7V4.txt (файл взять из   *");
            Console.WriteLine("*архива согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ *");
            Console.WriteLine("*  и скопировать в неё файл) в котором есть набор символьных данных.      *");
            Console.WriteLine("* Заменить все русские буквы на #.Полученный результат  *");
            Console.WriteLine("*  сохранить в файл OutPutDataFileTask7V4.txt.                           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string inputPath = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask7V4.txt");
            Console.WriteLine($"Данные будут считаны из файла: {inputPath}");

           
            string dataSprintDir = @"C:\DataSprint5\";
            if (!Directory.Exists(dataSprintDir))
            {
                Console.WriteLine($"Внимание: Директория {dataSprintDir} не существует. Создаю ее.");
                try
                {
                    Directory.CreateDirectory(dataSprintDir);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при создании директории: {ex.Message}");
                    Console.WriteLine("Нажмите любую клавишу для выхода...");
                    Console.ReadKey();
                    return;
                }
            }

            if (!File.Exists(inputPath))
            {
                Console.WriteLine($"Внимание: Файл {inputPath} не найден. Создаю его с тестовыми данными.");
               
                File.WriteAllText(inputPath, "Привет, World! This моя Первая программа.");

                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
                Console.WriteLine("***************************************************************************");

            }
            try
            {

                string resultFilePath = ds.LoadDataAndSave(inputPath);
                Console.WriteLine("Обработка файла успешно завершена!");
                Console.WriteLine($"Обработанный файл сохранен по пути: {resultFilePath}");

                
                Console.WriteLine("\nСодержимое выходного файла:");
                Console.WriteLine(File.ReadAllText(resultFilePath));
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Ошибка: Входной файл не найден по пути: {ex.FileName}");
                Console.WriteLine("Убедитесь, что файл InPutDataFileTask7V4.txt находится в @C:DataSprint5");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
                Console.WriteLine("***************************************************************************");
                Console.WriteLine("Нажмите любую клавишу для завершения работы программы...");
                Console.ReadKey(); 
            }
        }
        



    }
}