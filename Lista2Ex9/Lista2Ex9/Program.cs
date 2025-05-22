using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double alt, peso, r, gen;

            Console.Write("Qual seu genero? (1) Feminino / (2) Masculina: ");
            gen = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual sua altura? ");
            alt = Convert.ToDouble(Console.ReadLine());
            Console.Write("Qual seu peso? ");
            peso = Convert.ToDouble(Console.ReadLine());

            r = peso / (alt * alt);


            if (gen == 1)

            {
                if (r >= 24.00)

                    Console.WriteLine("Mulher:Acima do peso.");

                if (r < 19.00)

                    Console.WriteLine("Mulher:Abaixo do peso.");

                if (r >= 19.00 && r <= 24.00)

                    Console.WriteLine("Mulher:Peso ideal.");
            }

            if (gen == 2)
            {
                if (r >= 25.00)

                    Console.WriteLine("Homem:Acima do peso.");

                if (r < 20.00)

                    Console.WriteLine("Homem:Abaixo do peso.");

                if (r >= 20.00 && r <= 25.00)

                    Console.WriteLine("Homem:Peso ideal.");
            }

        }
    }
}
