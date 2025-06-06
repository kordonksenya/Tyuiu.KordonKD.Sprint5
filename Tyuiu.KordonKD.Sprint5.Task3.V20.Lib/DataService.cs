using System;
using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KordonKD.Sprint5.Task3.V20.Lib
{
    public class DataService : ISprint5Task3V20
    {
        public string SaveToFileTextData(int x)
        {
            throw new NotImplementedException();

            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";
            string path = Path.Combine(tempPath, fileName);


            double y = x / (Math.Sqrt(x * x) + x);


            y = Math.Round(y, 3);


            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create), Encoding.UTF8))
            {
                writer.Write(y);
            }
        }
    }
}
