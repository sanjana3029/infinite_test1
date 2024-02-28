using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(test("Python",1));
            //Console.WriteLine(test("Python", 0));
            //Console.WriteLine(test("Python", 4));



            //Largest_No lr = new Largest_No();
            //lr.Check();



            Exchange ex = new Exchange();
            ex.Characters();

            Console.ReadLine();
        }
        public static string test(string str, int n)
        {
            return str.Remove(n, 1);
        }

    }
}
