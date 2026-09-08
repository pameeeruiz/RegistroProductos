using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroProductos.Entidades;
namespace RegistroProductos.Datos
{

   
    public class ProductoDatos
    {
        private static List<Producto> productos = new List<Producto>();

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }

    }
}
