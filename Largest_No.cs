using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_code
{
    class Largest_No
    {
        public void Check()
        {
            int n1, n2, n3, largest;
            {
                Console.WriteLine("Enter the 1st number:");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the 2nd number:");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the 3rd number:");
                n3 = Convert.ToInt32(Console.ReadLine());

                largest = n1;
                if(n2>largest)
                {
                    largest = n2;
                }
                if(n3>largest)
                {
                    largest = n3;
                }
                Console.WriteLine($"largest no among three {n1},{n2},{n3} is {largest}");
            }
            
        }
        
    }
}
