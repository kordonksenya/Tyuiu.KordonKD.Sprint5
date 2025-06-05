using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary.Tests;
using SolrNet.Utils;
using System;
using System.Globalization;
using System.IO;
using Tyuiu.KordonKD.Sprint5.Task0.V3.Lib;

namespace Tyuiu.KordonKD.Sprint5.Task0.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

    namespace MyLibrary
{
    public class FunctionCalculator
        {
            
            public string SaveToFileTextData(int x)
            {
                
                double y = -0.25 * (Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 4);

              
                y = Math.Round(y, 3, MidpointRounding.AwayFromZero);

               
                string fileName = "OutPutFileTask0.txt";

              
                string path = Path.GetTempPath();

                
                string filePath = Path.Combine(path, fileName);

               
                File.WriteAllText(filePath, y.ToString(CultureInfo.InvariantCulture));

                
                return filePath;
            }
        }
    }

   
    namespace MyLibrary.Tests
    {
        public class FunctionCalculatorTests
        {
           
            public static void Main(string[] args)
            {
                Console.WriteLine("--- Запуск Unit-тестов для FunctionCalculator ---");

              
                Test_SaveToFileTextData_With_X_Equals_3();

                Console.WriteLine("\n--- Тесты завершены ---");

               
            }

           
            public static void Test_SaveToFileTextData_With_X_Equals_3()
            {
                Console.WriteLine("\nТест: SaveToFileTextData с x = 3");

               
                var calculator = new FunctionCalculator();
                int x = 3;
                
                string expectedContent = "-1.000";
                string expectedFileName = "OutPutFileTask0.txt";
                string expectedFilePath = Path.Combine(Path.GetTempPath(), expectedFileName);
                string actualFilePath = null;

                try
                {
                   
                    actualFilePath = calculator.SaveToFileTextData(x);

                   
                    
                    if (actualFilePath == expectedFilePath)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("    [✓] Путь к файлу: PASS");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"    [X] Путь к файлу: FAIL (Ожидалось: {expectedFilePath}, Получено: {actualFilePath})");
                        Console.ResetColor();
                    }

               


            string fileContent = File.ReadAllText(actualFilePath);
                    if (fileContent == expectedContent)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("    [✓] Содержимое файла: PASS");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"    [X] Содержимое файла: FAIL (Ожидалось: {expectedContent}, Получено: {fileContent})");
                        Console.ResetColor();
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"    [X] Тест завершился с исключением: {ex.Message}");
                    Console.ResetColor();
                }
                finally
                {
                    
                    if (actualFilePath != null && File.Exists(actualFilePath))
                    {
                        try
                        {
                            File.Delete(actualFilePath);
                            Console.WriteLine("    [i] Временный файл удален.");
                        }
                        catch (Exception ex)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"    [!] Не удалось удалить временный файл: {ex.Message}");
                            Console.ResetColor();
                        }
                    }
                }
            }

           
            public static void Test_SaveToFileTextData_With_X_Equals_0()
            {
                Console.WriteLine("\nТест: SaveToFileTextData с x = 0");
                var calculator = new FunctionCalculator();
                int x = 0;

                string expectedContent = "-1.000";
                string actualFilePath = null;

                try
                {
                    actualFilePath = calculator.SaveToFileTextData(x);
                    string fileContent = File.ReadAllText(actualFilePath);
                    if (fileContent == expectedContent)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("    [✓] Тест для x=0: PASS");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"    [X] Тест для x=0: FAIL (Ожидалось: {expectedContent}, Получено: {fileContent})");
                        Console.ResetColor();
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"    [X] Тест для x=0 завершился с исключением: {ex.Message}");
                    Console.ResetColor();
                }
                finally
                {
                    if (actualFilePath != null && File.Exists(actualFilePath))
                    {
                        File.Delete(actualFilePath);
                    }
                }
            }
        }


    }



}


    












