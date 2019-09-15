﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            var count = 0;
            for(var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine(string.Format("There are {0} numbers between 1 and 100 that leave remainder 0 when divided by 3",count));

            //Problem 2
            //float sum = 0;
            //while(true)
            //{
            //    Console.Write("Enter a number ");
            //    var input = Console.ReadLine();
            //    if(input == "ok")
            //    {
            //        break;
            //    }
            //    else
            //        sum += float.Parse(input);
            //}
            //Console.WriteLine("The sum is "+sum);

            //Problem 3
            Console.Write("Enter a number ");
            var input = Console.ReadLine();
            int factorial = 1;
            for (var i = Convert.ToInt32(input); i > 0; i--)
                factorial *= i;
            Console.WriteLine(string.Format("{0}! = {1}", input, factorial));

            //Problem 4
            var random = new Random();
            var rand = random.Next(1, 11);
            //Console.WriteLine(rand);
            var i1 = 0;
            while(i1 < 4)
            {
                Console.WriteLine("Enter your guess: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if(number == rand)
                    break;
                i1++;    
            }
            if(i1 == 4)
                Console.WriteLine("You lost");
            else
                Console.WriteLine("You Won!");
        }
    }
}
