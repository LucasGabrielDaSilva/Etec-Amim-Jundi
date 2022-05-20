using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, d, /4, media;
            Console.Write("Digite o primeiro numero: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o quarto numero: ");
            d = Convert.ToInt32(Console.ReadLine());
            
            media = (a + b + c + d) / 4;

            Console.WriteLine(a "+" b "+" c "+" d "/4"= media);

            Console.ReadKey();
        }
    }
}
