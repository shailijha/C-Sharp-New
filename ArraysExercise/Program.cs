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
            Console.WriteLine("Reverse of "+name+": ");
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

            //Problem 4
            var nums1 = new List<int>();
            while(true)
            {
                Console.WriteLine("Enter a number or type Quit to exit ");
                var temp = Console.ReadLine();
                if(temp.ToLower() != "quit")
                {
                    int num = Convert.ToInt32(temp);
                    if (nums1.IndexOf(num) == -1)
                        nums1.Add(num);
                    continue;
                }
                else if(temp.ToLower() == "quit")
                    break;
            }
            //Console.WriteLine(nums1.Count);
            foreach (var num in nums1)
                Console.WriteLine(num);
            Console.WriteLine();

            //Problem 5

            while (true)
            {
                Console.WriteLine("Enter comma separated numbers :");
                var input = Console.ReadLine();
                string[] inputArray = input.Split(',');
                var numbers = new int[5];
                int i1 = 0;

                if (inputArray.Length == 0 || inputArray.Length < 5)
                {
                    Console.WriteLine("Invalid List");
                    continue;
                }
                else
                {
                    foreach (var str in inputArray)
                    {
                        numbers[i1] = Convert.ToInt32(str);
                        i1++;
                    }
                    Array.Sort(numbers);
                    var i2 = 0;
                    while (i2 < 3)
                    {
                        Console.Write(numbers[i2] + ", ");
                        i2++;
                    }
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
