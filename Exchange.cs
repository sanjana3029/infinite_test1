using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_code
{
    class Exchange
    {
        public void Characters()
        {
            Console.WriteLine("enter a string");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || (input.Length < 2))
            {
                Console.WriteLine("str len is less than2 not possible");
            }
            char firstchar = input[0];
            char lastchar = input[input.Length - 1];
            string swappedstring = lastchar + input.Substring(1, input.Length - 2) + firstchar;
            Console.WriteLine($" original string  {input} ");
            Console.WriteLine($"swapped string  {swappedstring}");
        }

    }
}
