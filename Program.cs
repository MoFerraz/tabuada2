using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tabuada2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            
            Console.WriteLine("Qual tabuada você deseja calcular? ");
            int tabuada = int.Parse(Console.ReadLine());

            while (numero <= 10)
            {
                int resultado = tabuada * numero;
                Console.WriteLine($"{tabuada} x {numero} = {resultado} ");
                numero++;
                Thread.Sleep(500);
            }
           


        }
    }
}
