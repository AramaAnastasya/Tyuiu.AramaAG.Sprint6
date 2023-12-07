using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AramaAG.Sprint6.Task7.V8.Lib
{
    public class DataService : ISprint6Task7V8
    {
        public int[,] GetMatrix(string path)
        {
            string fileDta = File.ReadAllText(path);
            fileDta = fileDta.Replace('\n', '\r');
            string[] lines = fileDta.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;
            int[,] arrayValues = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i, j] = Convert.ToInt32(line_r[j]);

                }
            }
            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    if (arrayValues[i,7] != 5)
                    {
                        arrayValues[i, 7] = -1;
                    }
                }
            }
            return arrayValues;
        }
    }
}
