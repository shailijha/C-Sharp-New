using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            Console.WriteLine("Enter hyphen separated numbers ");
            var input = Console.ReadLine();
            var numbers = input.Split('-');
            int diff = Math.Abs(int.Parse(numbers[1]) - int.Parse(numbers[0]));
            bool flag = false;
            //Console.WriteLine("Diff b/w 1st and 2nd elt: "+diff);
            if(diff != 1)
                Console.WriteLine("Not Consecutive");
            else
            {
                for (int i = 1; i+1 < numbers.Length; i++)
                {
                    diff += Math.Abs(int.Parse(numbers[i + 1]) - int.Parse(numbers[i]));
                    if(diff > i+1)
                    {
                        Console.WriteLine("Not Consecutive");
                        flag = true;
                        break;
                    }
                    //Console.WriteLine("diff in for loop: "+diff);
                }
                //Console.WriteLine("Final diff: "+diff);
                if (!flag && diff == numbers.Length - 1)
                    Console.WriteLine("Consecutive");
            }
        }
    }
}
