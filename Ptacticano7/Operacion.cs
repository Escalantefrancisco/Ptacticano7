using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptacticano7
{
    internal class Operacion
    {
        public int valorUno;
        private int valorDos;
        protected int resultado;

        public void imprimirResultado()
        {
            Console.WriteLine("El resultado es: " + resultado);
        
        }
        public void setValorDos(int valorDos)
        {
            this.valorDos = valorDos;
        }
        public int getValorDos() 
        {
            return valorDos;
        }
    }
}
