using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, med;
            Console.Write("Qual sua Nota na Primeira Avaliação: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual sua Nota na Segunda Avaliação: ");
            p2 = Convert.ToDouble(Console.ReadLine());

            med = (p1 + 2 * p2) / 3;
            Console.WriteLine("Sua média será:{0} ",med);

            if (med >= 5)
            {
                Console.WriteLine("Aluno Aprovado.");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado.");
            }

        }
    }
}
