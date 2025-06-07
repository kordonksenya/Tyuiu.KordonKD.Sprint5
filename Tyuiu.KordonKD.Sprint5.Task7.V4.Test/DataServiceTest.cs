using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KordonKD.Sprint5.Task7.V4.Lib;
using System.IO;

namespace Tyuiu.KordonKD.Sprint5.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();

          
            string inputFilePath = Path.Combine(@"C:\DataSprint5\", "InPutDataFileTask7V4.txt");
            string outputFilePath = Path.Combine(@"C:\DataSprint5\", "OutPutDataFileTask7V4.txt");

           
            string dataSprintDir = @"C:\DataSprint5\";
            if (!Directory.Exists(dataSprintDir))
            {
                Directory.CreateDirectory(dataSprintDir);
            }

           
            string inputFileContent = "Привет, World! This моя Первая программа.";
          
            string expectedOutputFileContent = "######, World! This ### ####### программа.";

          
            File.WriteAllText(inputFilePath, inputFileContent);

           
            string actualOutputFilePath = ds.LoadDataAndSave(inputFilePath);

          
            Assert.IsTrue(File.Exists(outputFilePath), "Выходной файл должен быть создан.");

          
            string actualOutputFileContent = File.ReadAllText(outputFilePath);

           
            Assert.AreEqual(expectedOutputFileContent, actualOutputFileContent, "Содержимое выходного файла не соответствует ожидаемому.");

            
            Assert.AreEqual(outputFilePath, actualOutputFilePath, "Возвращенный путь не соответствует ожидаемому пути выходного файла.");

            
            if (File.Exists(inputFilePath))
            {
                File.Delete(inputFilePath);
            }
            if (File.Exists(outputFilePath))
            {
                File.Delete(outputFilePath);
            }
           
        }
    }
}
        
    

