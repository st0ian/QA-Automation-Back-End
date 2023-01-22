using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumApp
{
    internal class SumApp
    {
        public static int Sum(int[] arr)
        {
            int sum = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                sum += arr[i];
            }
                
            return sum;
        }

        public void Proba()
        {
            Console.WriteLine("Test");
        }
    }
}
