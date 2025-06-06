using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KordonKD.Sprint5.Task5.V17.Lib
{
    public class DataService : DataServiceBase, ISprint5Task5V17
    {
        private static bool IsPrime(int number)
        {
            if (number <= 1) return false; 
            if (number == 2) return true;
            if (number % 2 == 0) return false;

           
            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public double CalculateSumOfPrimeIntegersFromFile(string filePath)
        {
            double sumOfPrimes = 0.0;

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Файл не найден по пути: {filePath}");
            }

            try
            {
                string fileContent = File.ReadAllText(filePath);
               
                string[] stringNumbers = fileContent.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string sNum in stringNumbers)
                {
                    if (double.TryParse(sNum, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double value))
                    {
                        
                        if (Math.Abs(value - Math.Round(value)) < 0.0001)
                        {
                            int intValue = (int)Math.Round(value); 

                            if (IsPrime(intValue))
                            {
                                sumOfPrimes += intValue;
                            }
                        }
                    }
                   
                }
            }
            catch (Exception ex)
            {
                
                throw new FileLoadException($"Ошибка при чтении или обработке файла: {filePath}. Подробности: {ex.Message}", ex);
            }

           
            return Math.Round(sumOfPrimes, 3);


        }

    }
}