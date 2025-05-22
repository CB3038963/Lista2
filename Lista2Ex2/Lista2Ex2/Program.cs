using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double V1;
            Double V2;
            Console.Write("Digite o 1° valor: ");
            V1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o 2° valor: ");
            V2 = Convert.ToDouble(Console.ReadLine());

            if (V1 > V2)
            {
                Console.WriteLine("O maior valor é:{0}", V1);
            }
            else if (V1 < V2)
            {
                Console.Write("O maio valor é: {0}", V2);
            }
            else
            {
                Console.WriteLine("Os dois valores são iguais.");
            }
        }
    }
}
