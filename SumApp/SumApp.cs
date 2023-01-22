using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumApp
{
    public static class SumApp
    {
        public static int Sum(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
                
            return sum;
        }

        public static void Proba()
        {
            Console.WriteLine("Test");
        }
    }
}
