using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptacticano7
{
    internal abstract class AProducto
    {
        String name;
        int precio, cantidad, total;

        public void calcularTotal()
        {
            total = precio * cantidad;
        }
        public abstract void imprimirResultado();

    }
}
