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

            //var sentence = "This is going to be a really really really really really long text";
            //Console.WriteLine(StringUtility.SummarizeText(sentence, 25));

            var builder = new StringBuilder("Hi there! How are you?");
            /*builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);
            
            builder.Replace('-', '=');
            builder.Remove(0, 10);
            builder.Insert(0, new string('-', 10));*/

            builder.Append('-', 10)
                   .AppendLine()
                   .Append("Header")
                   .AppendLine()
                   .Append('-', 10)
                   .Replace('-', '=')
                   .Remove(0, 10)
                   .Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First char: "+builder[0]);
        }
    }
}
