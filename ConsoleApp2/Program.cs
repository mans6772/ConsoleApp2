using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            int n = 10;
            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a);
                int temp = a + b;
                a = b;
                b = temp;
            }

            Console.ReadLine();
        }




    }

        

}

           