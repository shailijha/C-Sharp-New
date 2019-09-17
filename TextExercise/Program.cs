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

            //Problem 3
            Console.WriteLine("Enter time in 24-hour format: ");
            var time = Console.ReadLine();

            if(String.IsNullOrEmpty(time))
                Console.WriteLine("Invalid Time");
            else
            {
                var timeSplit = time.Split(':');
                if(int.Parse(timeSplit[0]) >= 0 && int.Parse(timeSplit[0]) <= 23 && int.Parse(timeSplit[1]) >= 0 && int.Parse(timeSplit[1]) <= 59)
                {
                    Console.WriteLine("Ok");
                }
                else
                    Console.WriteLine("Invalid Time");
            }

            //Problem 4
            Console.WriteLine("Enter few words separated with a space: ");
            var input1 = Console.ReadLine();

            if(String.IsNullOrWhiteSpace(input1))
                Console.WriteLine("Error");
            else
            {
                var words = input1.ToLower().Split(' ');
                var pascalCase = new StringBuilder();

                foreach (var word in words)
                {
                    string firstChar = word[0].ToString().ToUpper();
                    pascalCase.Append(firstChar)
                           .Append(word.Substring(1));
                    //Console.WriteLine(word[0]);
                    //var firstChar = word[0].ToUpper();
                }
                Console.WriteLine("Pascal Case representation: " + pascalCase);
            }

            //Problem 5
            Console.WriteLine("Enter one English word ");
            var input2 = Console.ReadLine();
            var word1 = input2.ToLower().ToCharArray();

            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int vowelCount = 0;

            foreach (var character in word1)
            {
                if (vowels.Contains(character))
                    vowelCount++;
            }
            Console.WriteLine("The number of vowels in {0} is {1}", input2, vowelCount);
        }
    }
}
