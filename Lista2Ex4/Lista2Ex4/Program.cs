using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double baze, altura, area;
            Console.Write("Valor da Base: ");
            baze = Convert.ToDouble(Console.ReadLine());
            Console.Write("Valor da Altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            area = baze * altura;
            if (area > 100)
            {
                Console.WriteLine("Terreno Grande");
            }
        }
    }
}
