using System;

namespace Collections
{
    class CollectionsExamples
    {
        static void Main()
        {
            Console.WriteLine("Collection<T> Examples");
            Console.WriteLine("======================");
            Console.WriteLine();

            Collection<int> nums = new Collection<int>();
            Console.WriteLine($"Empty collection: {nums}");
            Console.WriteLine($"Count: {nums.Count}. Capacity: {nums.Capacity}");
            Console.WriteLine();


            Console.WriteLine(new string('=', 120));

            Collection<int> collection_10  = new Collection<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            Console.WriteLine($"Collection with 10 numbers: {collection_10}");
            Console.WriteLine($"Count: {collection_10.Count} | Capacity (is Count x 2): {collection_10.Capacity}");
            Console.WriteLine();

            int [] testWith5 = new int[5];
            collection_10.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 } );
            Console.WriteLine($"Adding new int [9] : {collection_10}");
            Console.WriteLine($"Count: {collection_10.Count} | Capacity: {collection_10.Capacity}");

            collection_10.AddRange(testWith5);
            Console.WriteLine($"Adding new int [5] : {collection_10}");
            Console.WriteLine($"Count: {collection_10.Count}| Capacity: {collection_10.Capacity}");

            Console.WriteLine(new string('=', 120) + Environment.NewLine);

            nums = new Collection<int>(new int[] { 10, 20, 30, 40, 50 });
            Console.WriteLine(nums);
            Console.WriteLine($"Count: {nums.Count}. Capacity: {nums.Capacity}");
            Console.WriteLine();

            nums.Add(60);
            Console.WriteLine("Added: 60");
            Console.WriteLine(nums);
            Console.WriteLine();

            nums[1] = 2000;
            nums[5] = 6000;
            Console.WriteLine("Changed: nums[1] and nums[5]");
            Console.WriteLine(nums);
            Console.WriteLine();

            Console.WriteLine($"num[0] = {nums[0]}");
            Console.WriteLine($"num[3] = {nums[3]}");
            Console.WriteLine();

            var removedItem = nums.RemoveAt(0);
            Console.WriteLine($"Removed item from position #0. Value = {removedItem}");
            Console.WriteLine(nums);
            Console.WriteLine();

            removedItem = nums.RemoveAt(4);
            Console.WriteLine($"Removed item from position #4. Value = {removedItem}");
            Console.WriteLine(nums);
            Console.WriteLine();

            nums.Exchange(0, 1);
            Console.WriteLine("Exchanged positions #0 and #1");
            Console.WriteLine(nums);
            Console.WriteLine();

            for (int i = 1; i <= 20; i++)
                nums.Add(i);
            Console.WriteLine("Added numbers [1...20]");
            Console.WriteLine(nums);
            Console.WriteLine();

            nums.InsertAt(0, 10);
            nums.InsertAt(1, 15);
            Console.WriteLine("Inserted 10 at the start and 15 after it");
            Console.WriteLine(nums);
            Console.WriteLine($"Count: {nums.Count}. Capacity: {nums.Capacity}");
            Console.WriteLine();
        }
    }
}
