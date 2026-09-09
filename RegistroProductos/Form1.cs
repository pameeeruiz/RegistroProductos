using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroProductos.Entidades;
using RegistroProductos.Negocio;

namespace RegistroProductos
{
    /// <summary>
    /// Evelyn Pamela Gutierrez Ruiz 08/09/2026
    /// Esta clase representa el formulario principal de la aplicación, donde se pueden registrar y mostrar productos.
    /// </summary>

    public partial class Form1 : Form
    {
        //Instancia de la clase ProductosNegocio para manejar la lógica de negocio
        private readonly ProductosNegocio negocio;

        public Form1()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = true;
            negocio = new ProductosNegocio();
        }


        //boton para registrar un producto, que valida los datos y llama al método correspondiente en la clase ProductosNegocio
        private void btnRegist_Click(object sender, EventArgs e)
        {
          
                errorProvider1.Clear();

                bool valido = true;

                //valida codigo
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    errorProvider1.SetError(txtCodigo, "Ingresa el código.");
                    valido = false;
                }

                //valida nombre
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    errorProvider1.SetError(txtNombre, "Ingresa rl nombre.");
                    valido = false;
                }

                //valida precio
                double precio = 0;

                if (string.IsNullOrWhiteSpace(txtPrecio.Text)) 
                { 
                    errorProvider1.SetError(txtPrecio, "Ingresa el precio.");
                    valido = false; 
                }
                else if (!double.TryParse(txtPrecio.Text, out precio))
                {
                    errorProvider1.SetError(txtPrecio, "Ingresa un precio valido.");
                    valido = false;
                }
                else if (precio <= 0)
                {
                    errorProvider1.SetError(txtPrecio, "El precio debe ser mayor a cero.");
                    valido = false; // corregido desde 'valido |= false'
                }

                //valida existencia
                int existencia = 0; // o un valor por defecto apropiado
                if (string.IsNullOrWhiteSpace(txtExistencia.Text))
                {
                    errorProvider1.SetError(txtExistencia,"Ingresa la existencia.");
                    valido = false;
                }
                else if (!int.TryParse(txtExistencia.Text, out existencia))
                {
                    errorProvider1.SetError(txtExistencia, "Ingresa un valor valido.");
                    valido = false;
                }
                else if (existencia < 0)
                {
                    errorProvider1.SetError(txtExistencia, "La existencia no puede ser negativa.");
                    valido = false;
                }

                //si existe un error, se detiene el proceso
                if (!valido)
                {
                    return;
                }

                //crear objeto producto
                Producto producto = new Producto();

                //asignar valores a las propiedades del producto
                producto.Codigo = txtCodigo.Text.Trim();
                producto.Nombre = txtNombre.Text.Trim();
                producto.Precio = precio;
                producto.Existencia = existencia;

                // Enviar el producto a la capa de Negocio
                string mensaje; 
                bool resultado = negocio.AgregarProducto( producto, out mensaje );

                if (!resultado) 
                { 
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                    return; 
                }
                MessageBox.Show("Producto registrado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // actualizar la lista de productos en el DataGridView
                MostrarProductos();
        }

        //metodo para cargar los productos al iniciar el formulario
        private void MostrarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = negocio.ObtenerProductos();
        }

        //metodo para limpiar los campos del formulario
        private void LimpiarCampos() 
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtExistencia.Clear(); 
            errorProvider1.Clear(); 
            txtCodigo.Focus(); 
        }

        //boton para limpiar los campos del formulario
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        //boton para salir de la aplicacion
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
