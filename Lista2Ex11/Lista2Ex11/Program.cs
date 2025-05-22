using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, qf, med, p2;

            Console.Write("Qual sua Nota na Primeira Avaliação: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            p2 = 0;

            do

            {
                p2++;
                med = (p1 + (p2 * 2)) / 3;
            }

            while (med < 5);
            {

            }

            Console.WriteLine("A nota da sua Segunda Avaliação deverá ser {0}.", p2);
        }
    }
}
