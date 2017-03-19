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
            int amount = 26;
            string s1 ="My age is ";
            s1 = string.Concat(s1, amount.ToString());
        }
    }
}
