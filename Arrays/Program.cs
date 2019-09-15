using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 45, 9, 2, 10, 50, 30 };

            Console.WriteLine("numbers.Length: "+numbers.Length);

            //IndexOf()
            Console.WriteLine("Index of 9 is "+Array.IndexOf(numbers, 9));
            Console.WriteLine();

            // Clear()
            /*Array.Clear(numbers, 0, 2);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();*/

            // Copy()
            int[] copiedArray = new int[3];
            Array.Copy(numbers, copiedArray, 3);
            Console.WriteLine("Effect of Copy()");
            foreach (var item in copiedArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort() on numbers");
            foreach (var item in numbers)
                Console.WriteLine(item);
            Console.WriteLine();

            // Reverse()
            Array.Reverse(copiedArray);
            Console.WriteLine("Effect of Reverse() on copiedArray");
            foreach (var item in copiedArray)
                Console.WriteLine(item);
            Console.WriteLine();
            
            // Lists
            var nums = new List<int>() { 1, 2, 3, 4 };

            nums.Add(1);
            nums.AddRange(new int[3] { 6, 7, 8 });
            Console.WriteLine("List members");
            foreach(var num in nums)
                Console.WriteLine(num);
            Console.WriteLine();

            Console.WriteLine("Index of 1 is: "+nums.IndexOf(1));
            Console.WriteLine("Last Index of 1 is: " + nums.LastIndexOf(1));

            Console.WriteLine("Count: "+nums.Count);

            for(var i = 0; i < nums.Count; i++)
            {
                if(nums[i] == 1)
                    nums.Remove(nums[i]);
            }

            foreach (var num in nums)
                Console.WriteLine(num);
            Console.WriteLine();

            nums.Clear();
            Console.WriteLine("Count: " + nums.Count);
        }
    }
}
