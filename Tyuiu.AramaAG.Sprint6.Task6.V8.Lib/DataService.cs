using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AramaAG.Sprint6.Task6.V8.Lib
{
    public class DataService : ISprint6Task6V8
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    string[] mas = line.Split(' ');
                    for (int i = 0; i < mas.Length; i++)
                    {
                        if (mas[i].Contains("z") || mas[i].Contains("Z"))
                        {
                            resStr += mas[i] + " ";
                        }
                    }

                }
            }
            return resStr.Trim();
        }
    }
}
