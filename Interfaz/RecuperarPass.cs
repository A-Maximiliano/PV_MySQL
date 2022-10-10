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
    public partial class RecuperarPass : Form
    {
        public RecuperarPass()
        {
            InitializeComponent();
        }

        Funciones fn = new Funciones();

        //Devuelve a la pantalla de Login
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lg = new Login();
            lg.Show();
        }

        //Recupera la contrasena del vendedor
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvVendedor.DataSource = fn.ConsultarDato("select * from b_d_punto_venta_vendedores where Ced_Ven_B_D_Punto_Venta_Vendedores = '" + txtCedulaPag.Text +
                                                            "' AND Preg_Ven_B_D_Punto_Venta_Vendedores = '" + cmbPregunta.Text + "' AND Resp_Ven_B_D_Punto_Venta_Vendedores = '" + txtRespuesta.Text + "'");
            }
                                                                                                               
            catch                          
            {
                MessageBox.Show("Parámetros incorrectos");
            }
        }
    }
}
