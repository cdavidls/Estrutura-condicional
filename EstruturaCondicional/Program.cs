using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o primeiro número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("[ + ] Somar | [ * ] Multiplicar");
            string opcao = Console.ReadLine();

            Console.Clear();

            if(opcao == "+")
            {
                Console.WriteLine("Resultado da Soma: " + (numero1 + numero2));
            }else if (opcao == "*")            
            {
                Console.WriteLine("Resultado da Multiplicação: " + (numero1 * numero2));
            }
            else
            {
                Console.WriteLine("Operador Inválido!");
            }

            Console.ReadKey();
        }
    }
}
