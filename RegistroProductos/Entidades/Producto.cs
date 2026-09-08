using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroProductos.Entidades
{
    public class Producto
    {
        ///Propiedades de la clase Producto
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }

    }
}
