using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double baze, altura, area;
            Console.Write("Digite o valor da Base: ");
            baze = Convert.ToDouble(Console.ReadLine());
            Console.Write("Altura: ");
            Console.Write("Digite o valor da Altura:");
            altura = Convert.ToDouble(Console.ReadLine());
            area = baze * altura;
            if (area >= 100)
            {
                Console.WriteLine("Terreno Grande");
            }
            else
            {
                Console.WriteLine("Terreno Pequeno");
            }
        }
    }
}
