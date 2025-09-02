using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateToStringConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var todayDate = DateTime.Today;

            string strToday = todayDate.ToString(); // converts date to string as per current culture
            Console.WriteLine(strToday);

            string str1 = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            Console.WriteLine(str1);

            string str2 = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            Console.WriteLine(str2);

            string str3 = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm");
            Console.WriteLine(str3);

            string str4 = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
            Console.WriteLine(str4);

            string str5 = DateTime.Now.ToString("ddd, dd MMM yyy HH’:’mm’:’ss ‘GMT’");
            Console.WriteLine(str5);
            Console.ReadLine();
        }
    }
}
