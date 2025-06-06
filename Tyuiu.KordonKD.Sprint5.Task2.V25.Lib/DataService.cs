using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KordonKD.Sprint5.Task2.V25.Lib
{
    public class DataService : ISprint5Task2V25

    {
        public string SaveToFileTextData(int[,] matrix)
        {
            throw new NotImplementedException();

            string[] paths = { $@"{Path.GetTempPath()}", "OutPutFileTask2.csv" };
            string path = Path.Combine(paths);

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
                File.Delete(path);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                        str += matrix[i, j] + ";";
                    else
                        str += matrix[i, j];


                }
            }
        }
    }

}

