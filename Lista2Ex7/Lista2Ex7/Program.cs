using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double l1, l2, l3;
            Console.Write("Digite o tamanho do lado do triângulo: ");
            l1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o tamanho do lado do triângulo: ");
            l2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o tamanho do lado do triângulo: ");
            l3 = Convert.ToDouble(Console.ReadLine());

            if (l1 + l2 > l3 && l2 + l3 > l1 && l3 + l1 > l2)
            {


                if (l1 == l2 && l2 == l3)

                    Console.WriteLine("Forma um triângulo Equilatero.");

                if (l1 != l2 && l1 != l3 && l2 != l3)

                    Console.WriteLine("Forma um triângulo Escaleno.");

                if (l1 == l2 && l2 != l3 || l2 == l3 && l3 != l1 || l1 == l3 && l3 != l2)

                    Console.WriteLine("Forma um triângulo Isósceles.");
            }
            else
            {
                Console.WriteLine("Nâo forma um triângulo.");
            }
        }
    }
}
