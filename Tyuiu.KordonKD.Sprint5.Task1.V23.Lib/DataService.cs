using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KordonKD.Sprint5.Task1.V23.Lib
{
    public class DataService : ISprint5Task1V23
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.GetTempFileName();
            for (int x = startValue; x <= stopValue; x++)
            {
                double res;
                if ((x + 2) == 0)
                {
                    res = 0;
                    File.AppendAllText(path, Convert.ToString(res) + Environment.NewLine);
                    continue;

                }
                res = Math.Cos(x) + (Math.Cos(x) / (x + 2)) - (3 * x);
                res = Math.Round(res, 2);
                File.AppendAllText(path, Convert.ToString(res) + Environment.NewLine);
            }
            return path;
        }
    }
}
