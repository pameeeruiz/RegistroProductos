using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroProductos.Entidades;
using RegistroProductos.Datos;
namespace RegistroProductos.Negocio
{
    public class ProductosNegocio
    {

        private ProductoDatos datos = new ProductoDatos();

        public bool AgregarProducto(Producto producto, out string mensaje)
        {
            mensaje = "";
            if (string.IsNullOrWhiteSpace(producto.Codigo))
            {
                mensaje = "El código del producto no puede estar vacío.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(producto.Nombre))
            {
                mensaje = "El nombre del producto no puede estar vacío.";
                return false;
            }
            if (producto.Precio <= 0)
            {
                mensaje = "El precio del producto debe ser un valor positivo.";
                return false;
            }
            if (producto.Existencia < 0)
            {
                mensaje = "La existencia del producto no puede ser un valor negativo.";
                return false;
            }

            return true;

        }

        public void registrarProducto( Producto producto) 
        {
            datos.AgregarProducto(producto);
        }

        public List<Producto> ObtenerProductos()
        {
            return datos.ObtenerProductos();
        }

    }
}
