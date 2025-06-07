using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KordonKD.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        private string inputFilePath;

        public string LoadDataAndSave(string path)
        {
            string outputFilePath = Path.Combine(@"C:\DataSprint5\", "OutPutDataFileTask7V4.txt");

            
            string outputDirectory = Path.GetDirectoryName(outputFilePath);
            if (!Directory.Exists(outputDirectory))
            {
                Directory.CreateDirectory(outputDirectory);
            }

           
            string content = File.ReadAllText(inputFilePath);

           
            string processedContent = Regex.Replace(content, "[а-яА-ЯёЁ]", "#");

           
            File.WriteAllText(outputFilePath, processedContent);

            
            return outputFilePath;

        }
    }
}
