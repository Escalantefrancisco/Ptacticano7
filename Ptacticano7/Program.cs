using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptacticano7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // esta intruccion es un objeto 
            Multiplicar multiplicar = new Multiplicar();
            Multiplicar multiplicarDos = new Multiplicar();
            Sumar sumar = new Sumar();

            multiplicar.valorUno = 5;
            multiplicar.setValorDos (7);
            multiplicar.operar();
            multiplicar.Resultado = 80;
            multiplicar.imprimirResultado();

            Console.ReadLine();
        }
    }
}
