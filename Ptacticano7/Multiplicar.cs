using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptacticano7
{
    internal class Multiplicar:Operacion
    {
        public int Resultado { get; internal set; }

        public void operar()
        {
            resultado = valorUno * getValorDos();    
        }
    }
}
