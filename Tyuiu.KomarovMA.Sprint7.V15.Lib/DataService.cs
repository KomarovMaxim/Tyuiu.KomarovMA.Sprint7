using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Tyuiu.KomarovMA.Sprint7.V15.Lib
{
    public class DataService
    { 

        
        public int People(string[,] array)
        {
            return array.GetLength(0);
        }
        

        public int MinDohod(string[,] array)
        {
            int min = 999999999;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    min = Math.Min(min, Convert.ToInt32(array[i, 5]));
                }
                catch
                {

                }

            }
            if (min == 999999999)
            {
                min = 0;
            }
            return min;
        }

        public int MaxDohod(string[,] array)
        {
            int max = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    max = Math.Max(max, Convert.ToInt32(array[i, 5]));
                }
                catch
                {

                }
            }
            return max;
        }
        public int SummDohod(string[,] array)
        {
            int Summ = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    Summ += Convert.ToInt32(array[i, 5]);
                }
                catch
                {

                }
            }
            return Summ;
        }
    }
}