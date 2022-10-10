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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Funciones fn = new Funciones();
        static string usu1;

        private void Login_Load(object sender, EventArgs e)
        {
            bool conectado = fn.Conectar();

            if (conectado == true)
            {
                //MessageBox.Show("Conexión realizada");
            }
            else
            {
                MessageBox.Show("Conexión Fallida");
            }
        }

        //Abre formulario para ingresar un nuevo vendedor
        private void lblIngresarNuevoVend_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroVendedores frm = new RegistroVendedores();
            frm.Show();
        }

        //Abre form para recuperar contrasena
        private void lblOlvidoPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecuperarPass frm = new RecuperarPass();
            frm.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            usu1 = txtUsuario.Text;
            //usuarioLogin();

            try
            {
                if (fn.Ingresar(txtUsuario.Text, txtPassword.Text)==1) // tambien se puede hacer asi: if (fn.Ingresar(txtUsuario.Text, txtPassword.Text))
                {
                    //MessageBox.Show("Acceso concedido");
                    Facturacion fac = new Facturacion();
                    fac.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso denegado, usuario o contraseña inconrecto");
                }                
            }
            catch (Exception)
            {

                throw;
            }
            //usuarioLogin();
        }

        public string usuarioLogin()
        {
            fn.ObtenerVendedor(usu1);
            return usu1;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.OrangeRed;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.OrangeRed;
                txtPassword.UseSystemPasswordChar = false;
            }
        }
    }
}
