using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, total;

            a = 20;
            b = 10;

            Console.WriteLine(a + "+" + b + "=" + (a + b));
            Console.WriteLine("{0} + {1} = {2:N1}", a, b, (a / b));

            total = a - b;

            Console.WriteLine(a + "-" + b + "=" + total);
            Console.WriteLine(a + "*" + b + "=" + (a * b));
            Console.WriteLine(a + "/" + b + "=" + (a / b));
            Console.WriteLine(a + "%" + b + "=" + (a % b));
            Console.ReadKey();
        }
    }
}
