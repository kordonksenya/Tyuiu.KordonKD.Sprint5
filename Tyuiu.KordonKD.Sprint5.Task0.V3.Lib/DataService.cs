using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KordonKD.Sprint5.Task0.V3.Lib
{
    public class DataService : ISprint5Task0V3
    {
        public double Calculate(int x)
        {
            throw new NotImplementedException();
        }

        public string SaveToFile(double result)
        {
            throw new NotImplementedException();
        }

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
        
    

