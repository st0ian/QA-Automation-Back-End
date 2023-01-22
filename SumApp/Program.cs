namespace SumApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Sum(int[] arr)
            {
                int sum = arr[0];
                for (int i = 1; i < arr
                  .Length; i++)
                    sum += arr[i];
                return sum;
            }
        }
    }
}