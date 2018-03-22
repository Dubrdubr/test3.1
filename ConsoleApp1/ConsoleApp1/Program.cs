using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Введите A");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите B");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(a + b);


            Console.WriteLine(a / b);


            Console.WriteLine(a - b);

            Console.WriteLine(a * b);

        }
    }
}
