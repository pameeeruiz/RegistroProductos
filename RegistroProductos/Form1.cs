using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroProductos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvProductos.AutoGenerateColumns = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
           

            try
            {
                errorProvider1.Clear();

                bool valido = true;

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    errorProvider1.SetError(txtNombre, "Ingresa rl nombre.");
                    valido = false;
                }
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    errorProvider1.SetError(txtCodigo, "Ingresa el código.");
                    valido = false;
                }
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    errorProvider1.SetError(txtNombre, "Ingresa rl nombre.");
                    valido = false;
                }



            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
