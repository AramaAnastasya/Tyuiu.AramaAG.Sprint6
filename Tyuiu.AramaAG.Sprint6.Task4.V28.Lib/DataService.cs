﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AramaAG.Sprint6.Task4.V28.Lib
{
    public class DataService : ISprint6Task4V28
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y = 0;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x - 0.7 == 0)
                {
                    valueArray[count] = 0;
                    count++;
                    continue;
                }
                y = ((Math.Cos((double)x * 2) ) + ((double)Math.Sin(x)/ ((double)x +2.5)) + 2.0 * x);
                valueArray[count] = Math.Round(y, 2);
                count++;

            }
            return valueArray;
        }
    }
}
