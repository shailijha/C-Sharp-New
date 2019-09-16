using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 2
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            char[] nameSplit = name.ToCharArray();
            Array.Reverse(nameSplit);

            foreach(var character in nameSplit)
                Console.Write(character);
            Console.WriteLine();

            //Problem 3
            var i = 0;
            int[] nums = new int[5];
            while(true)
            {
                Console.WriteLine("Enter a number ");
                int num = Convert.ToInt32(Console.ReadLine());
                if(Array.IndexOf(nums, num) == -1)
                {
                    nums[i] = num;
                    i++;
                }
                else
                {
                    Console.WriteLine("This number is already present in the array. Please enter another number ");
                    continue;
                }
                if(i == 5)
                {
                    break;
                }
            }
            Array.Sort(nums);
            foreach (var item in nums)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
