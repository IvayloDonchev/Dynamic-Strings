// http://www.c-sharpcorner.com/article/how-to-create-dynamic-strings-in-c-sharp/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 45;
            string s1 ="My age is ";
            s1 = string.Concat(s1, amount.ToString());
            Console.WriteLine(s1);

            StringBuilder sb = new StringBuilder("My age is ");
            sb.Append(amount);
            Console.WriteLine(sb);

            sb = new StringBuilder("ABCD");
            sb.Append("EF");
            Console.WriteLine(sb);
            sb.AppendFormat(" {0:n}", 1100);
            Console.WriteLine(sb);
            sb.Insert(2, 'Z');
            Console.WriteLine(sb);
            sb.Remove(8, 6);
            Console.WriteLine(sb);
            sb.Replace("0", "x");
            Console.WriteLine(sb);


            Console.ReadKey();
        }
    }
}
