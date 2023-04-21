using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ptacticano7
{
    internal class Libro : Iproductor
    {
        String name;
        private int precio, cantidad, total;

        public void libro(String name, int precio, int cantidad)
        {
            this.name = name;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public void calcularTotal()

        {
            total = precio + cantidad;
        }
        public void imprimirDatos()
        {
            Console.WriteLine("libro:" + name + "precio:" + precio + "total" + total);
        }
    }
}



