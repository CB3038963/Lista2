using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3, l1x2, l2x2, l3x2;
            Console.Write("Digite o tamanho do lado do triângulo: ");
            l1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o tamanho do lado do triângulo: ");
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o tamanho do lado do triângulo: ");
            l3 = Convert.ToDouble(Console.ReadLine());

            l1x2 = Math.Pow(l1, 2);
            l2x2 = Math.Pow(l2, 2);
            l3x2 = Math.Pow(l3, 2);


            if (l1x2 > (l2x2 + l3x2) || l2x2 > (l1x2 + l3x2) || l3x2 > (l1x2 + l2x2))
            {
                Console.WriteLine("Forma um triângulo Retângulo.");
            }
            else
            {
                Console.WriteLine("Nâo forma um triângulo Retângulo.");
            }

        }
    }
}
