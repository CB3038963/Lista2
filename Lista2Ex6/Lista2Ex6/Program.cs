using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double peso, altura, R;
            Console.Write("Digite seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            altura = Convert.ToDouble(Console.ReadLine());
            R = peso / (altura * altura);
            if (R < 20)
            {
                Console.WriteLine("Abaixo do peso.");
            }
            if (R < 25 && R >= 20)
            {
                Console.WriteLine("Peso ideal.");
            }
            else
            {
                Console.WriteLine("Acima do peso.");
            }
        }
    }
}
