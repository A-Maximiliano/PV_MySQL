using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Interfaz
{
    public partial class RegistroVendedores : Form
    {
        public RegistroVendedores()
        {
            InitializeComponent();
        }

        Funciones fn = new Funciones();

        //Metodo para registrar un nuevo vendedor a la tabla vendedores
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //string obtenerRepuesto = cmbPregunta.SelectedIndex.ToString();
            string insert = "insert into b_d_punto_venta_vendedores values('" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','"
                                                            + txtPassword.Text + "','" + cmbPregunta.Text + "','" + txtRespuesta.Text + "')";

            if (fn.Insertar(insert))
            {
                MessageBox.Show("Usuario agregado");
            }
            else
            {
                MessageBox.Show("Error al agregar o el usuario ya existe");
            }
        }

        //Devuelve a la pantalla de Login
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login lg = new Login();
            lg.Show();
        }
    }
}
