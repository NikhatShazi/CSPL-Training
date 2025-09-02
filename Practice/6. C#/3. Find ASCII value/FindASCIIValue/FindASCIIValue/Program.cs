using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindASCIIValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c;
            int ascii;
            Console.Write("\nEnter any character : ");
            c = char.Parse(Console.ReadLine());
            ascii = test(c);
            Console.Write("\nASCII value is :" + ascii );
            Console.ReadLine();
        }

        public static int test(char ch)
        {
            return (int)ch;
        }
    }
}
