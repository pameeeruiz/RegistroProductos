using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroProductos.Entidades
{
    /// <summary>
    /// Evelyn Pamela Gutierrez Ruiz 08/09/2026
    /// Esta clase representa un producto con propiedades como código, nombre, precio y existencia.
    /// </summary>
    public class Producto
    {
        ///Propiedades de la clase Producto
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        public int Existencia { get; set; }

    }
}
