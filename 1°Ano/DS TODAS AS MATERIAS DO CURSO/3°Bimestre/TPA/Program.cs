using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPA
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sobrenome;
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Digite seu sobrenome:");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Seu nome:" + nome);
            Console.WriteLine("Seu sobrenome:" + sobrenome);
            Console.ReadKey();
        }
    }
}
