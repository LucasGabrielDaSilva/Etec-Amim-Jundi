using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aladin2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite um numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro numnero: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a * b;

            Console.Write(a + "*" + b + "=" + c);

            Console.ReadKey();
        }
    }
}
