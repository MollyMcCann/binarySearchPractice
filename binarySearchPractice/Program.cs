using System;

namespace binarySearchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var Numbers = new[] { 1, 5, 0, 34, 3, 9 };

            Array.Sort(Numbers);

            var index = BinarySearch(Numbers, 3);
            Console.WriteLine(index);

            Console.ReadKey();
        }
        private static int LinearSearch(int[] array, int item)
        {
            //this is good but not as efficient as binary
            for (int i = 0; i < array.Length; i++)
            {
                if (array [i]== item)
                {
                    return i;
                } 
            }
            return -1;
        } 
        private static int BinarySearch (int[]array, int item)
        {
            //more efficient
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                var middle = (left + right) / 2;
                if (array[middle]== item)
                  return middle;
                if (item < array[middle])
                    right = middle - 1;
                else
                    left = middle + 1;
                
            }
            return -1;
        }
    } 



}
