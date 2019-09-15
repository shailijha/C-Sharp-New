using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            string number;
            Console.WriteLine("Enter a number between 1 and 10 ");
            number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            if (num >= 1 && num <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

            //Problem 2
            string numbers;
            Console.WriteLine("Enter the 2 numbers ");
            numbers = Console.ReadLine();
            string[] nums = numbers.Split(',');
            float num1 = float.Parse(nums[0]);
            float num2 = float.Parse(nums[1]);

            if (num1 > num2)
                Console.WriteLine(string.Format("{0} is the maximum of the two", nums[0]));
            else if (num1 < num2)
                Console.WriteLine(string.Format("{0} is the maximum of the two", nums[1]));
            else
                Console.WriteLine(string.Format("{0} and {1} are equal", nums[0], nums[1]));

            //Problem 3
            string dimensions;
            Console.WriteLine("Enter image width and height ");
            dimensions = Console.ReadLine();
            string[] dims = dimensions.Split(',');
            float width = float.Parse(dims[0]);
            float ht = float.Parse(dims[1]);
            if (width > ht)
                Console.WriteLine("Image is landscape");
            else
                Console.WriteLine("Image is portrait");

            //Problem 4
            string spdLmt, carSpd;
            var demerit=0;

            Console.Write("Enter the speed limit ");
            spdLmt = Console.ReadLine();
            Console.Write("Enter car speed ");
            carSpd = Console.ReadLine();
            int speedLmt = Convert.ToInt32(spdLmt);
            int carSpeed = Convert.ToInt32(carSpd);

            if(carSpeed < speedLmt)
            {
                Console.WriteLine("Ok");
            }
            else
            {
                demerit = (carSpeed - speedLmt) / 5;
            }

            if (demerit > 12)
                Console.WriteLine("License Suspended");
            else
                Console.WriteLine(demerit);
        }
    }
}
