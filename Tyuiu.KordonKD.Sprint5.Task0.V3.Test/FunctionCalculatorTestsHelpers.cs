using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary.Tests;
using System;
using System.Globalization;
using System.IO;
using Tyuiu.KordonKD.Sprint5.Task0.V3.Lib;

namespace MyLibrary.Tests
{
    internal static class FunctionCalculatorTestsHelpers
    {
        // Главный метод, который будет запускать тесты
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Запуск Unit-тестов для FunctionCalculator ---");
            FunctionCalculatorTestsHelpers.

                        // Запуск конкретного тестового метода
                        Test_SaveToFileTextData_With_X_Equals_3();

            Console.WriteLine("\n--- Тесты завершены ---");

            // Ожидание ввода, чтобы консоль не закрылась сразу
            // Console.ReadKey(); // Закомментируйте, если запускаете из CI/CD или не хотите ждать
        }

        // Тестовый метод для SaveToFileTextData при x = 3
        public static void Test_SaveToFileTextData_With_X_Equals_3()
        {
            Console.WriteLine("\nТест: SaveToFileTextData с x = 3");

            // 1. Arrange (Подготовка)
            var calculator = new FunctionCalculator();
            int x = 3;
            // Расчет ожидаемого значения вручную:
            // y = -0.25 * (3^3 - 3*3^2 + 4)
            // y = -0.25 * (27 - 3*9 + 4)
            // y = -0.25 * (27 - 27 + 4)
            // y = -0.25 * 4
            // y = -1.0
            // Округление до 3 знаков: -1.000
            string expectedContent = "-1.000";
            string expectedFileName = "OutPutFileTask0.txt";
            string expectedFilePath = Path.Combine(Path.GetTempPath(), expectedFileName);
            string actualFilePath = null; // Для сохранения пути к файлу, чтобы удалить его в finally

            try
            {
                // 2. Act (Действие)
                actualFilePath = calculator.SaveToFileTextData(x);

                // 3. Assert (Проверка)

                // Проверка 1: Возвращаемый путь к файлу
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

            }



        }
    }
}