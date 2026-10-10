using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3
{
    internal class Program
    {


        static void Factorial(ref uint fr, uint n)
        {
            fr = 1;
            try
            {
                bool result = true;
                checked
                {
                    for (uint f = 1; f <= n; f++)
                    {
                        fr *= f;
                        //Console.WriteLine(fr);

                    }
                }
                Console.WriteLine(result);
            }
            catch (OverflowException)
            {
                bool result = false;
                Console.WriteLine(result);
            }
        }
        static void Main(string[] args)
        {
            uint fr = 1;
            uint n = Convert.ToUInt32(Console.ReadLine());
            Factorial(ref fr, n);
           
        }
    }
}
