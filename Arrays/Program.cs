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
        }
    }
}
