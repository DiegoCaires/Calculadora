using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace balta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------");
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("-----------");
            Console.WriteLine("Pressione ENTER para prosseguir...");
            string ENTER = Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ok, digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ok, captei os 2 números.");
            Console.WriteLine("Pressione ENTER para prosseguir...");
            string ENTER1 = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("------------------");
            Console.WriteLine("R E S U L T A D O");
            Console.WriteLine("------------------");

            Console.WriteLine(n1 + n2);
        }
    }
}
