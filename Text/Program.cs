using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var fullName = "Shaili Jha ";
            Console.WriteLine("Trim: '{0}'",fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper().Trim());

            Console.WriteLine(fullName.Split(' '));*/

            var sentence = "This is going to be a really really really really really long text";
            Console.WriteLine(StringUtility.SummarizeText(sentence, 25));
        }
    }
}
