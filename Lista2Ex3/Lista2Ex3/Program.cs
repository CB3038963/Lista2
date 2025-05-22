using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double V1, V2, V3;
            Console.Write("Digite o 1° valor:");
            V1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o 2° valor:");
            V2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o 3° valor:");
            V3 = Convert.ToDouble(Console.ReadLine());
            if (V1 == V2 && V2 == V3)
            {
                Console.Write("Todos os valores são iguais.");
            }
            if (V1 > V2 && V2 > V3)
            {
                Console.Write("O maior valor é:{0}", V1);
            }
            if (V2 > V1 && V2 > V3)
            {
                Console.Write("O maior valor é:{0}", V2);
            }
            if (V3 > V1 && V3 > V2)
            {
                Console.Write("O maior valor é:{0}", V3);
            }

        }
    }
}
