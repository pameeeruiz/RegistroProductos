using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroProductos.Entidades;
namespace RegistroProductos.Datos
{
    /// <summary>
    /// Evelyn Pamela Gutierrez Ruiz 08/09/2026
    /// Esta clase se encarga de manejar los datos de los productos, incluyendo agregar y obtener productos.
    /// </summary>

    public class ProductoDatos
    {
        //lista para almacenar los productos
        private static List<Producto> productos = new List<Producto>();

        // metodo para agregar un producto a la lista
        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        // metodo para obtener la lista de productos
        public List<Producto> ObtenerProductos()
        {
            return productos;
        }

    }
}
