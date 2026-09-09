using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroProductos.Entidades;
using RegistroProductos.Datos;
namespace RegistroProductos.Negocio
{
    /// <summary>
    /// Evelyn Pamela Gutierrez Ruiz 08/09/2026
    /// Esta clase se encarga de manejar la lógica de negocio relacionada con los productos, incluyendo agregar y obtener productos.
    /// </summary>
    public class ProductosNegocio
    {

        //Instancia de la clase ProductoDatos para acceder a los métodos de datos
        private ProductoDatos datos = new ProductoDatos();

        //Metodo para agregar un producto, que llama al método correspondiente en la clase ProductoDatos
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
            datos.AgregarProducto(producto);
            return true;

        }

        //Metodo para obtener la lista de productos, que llama al método correspondiente en la clase ProductoDatos
        public void RegistrarProducto(Producto producto)
        {
            datos.AgregarProducto(producto);
        }

        //Metodo para obtener la lista de productos, que llama al método correspondiente en la clase ProductoDatos
        public List<Producto> ObtenerProductos()
        {
            return datos.ObtenerProductos();
        }

    }
}
