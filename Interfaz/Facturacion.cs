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
using Logica;

namespace Interfaz
{
    public partial class Facturacion : Form
    {
        #region  variables glabales

        private Facturaciones fct;
        private Ventas vt;
        Funciones fn = new Funciones();
        Login lg = new Login();
        string clie;
        decimal total;
        string tipoFact = "";
        string tipoPago = "";
        decimal desc = 0;
        #endregion

        public Facturacion()
        {
            InitializeComponent();
            List<string> ventas = new List<string>();
            txtNumFactura.Text = fn.IngresarNumFact1().ToString();
            string vendedor = lg.usuarioLogin();

            ventas = fn.ObtenerVendedor(vendedor);
            lblIdVendedor.Text = ventas[0];
            txtVendedor.Text = ventas[1];     
        }

        #region   Metodos

        //evento del boton que abre otro form
        private void btnCliente_Click(object sender, EventArgs e)
        {
            MantenimientoClientes mc = new MantenimientoClientes();
            this.Hide();
            mc.Show();
        }

        //evento del boton que abre otro form
        private void btnProducto_Click(object sender, EventArgs e)
        {
            MantenimientoProductos mp = new MantenimientoProductos();
            this.Hide();
            mp.Show();
        }

        //evento del boton que asigna el cliente a la factura
        private void btnAsignar_Click(object sender, EventArgs e)
        {          
            if (clie != string.Empty)
            {
                vt = new Ventas(clie);
                dgvFacturacion.DataSource = null;
                dgvFacturacion.DataSource = vt.Productos;

                if (cbCredito.Checked)
                {
                    tipoFact = "Credito";
                }
                else
                {
                    tipoFact = "Contado";
                }
                if (cbTarjeta.Checked)
                {
                    tipoPago = "Tarjeta";
                }
                else
                {
                    tipoPago = "Efectivo";
                }
            }
            else
            {
                MessageBox.Show("Usuario no existe, intente de nuevo");
            }   
        }

        //evento del boton que agrega el o los productos a la factura del cliente
        static decimal valorSubtotal; //variable estatica, valor no cambia
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Facturaciones fact = new Facturaciones();
                
                fact.Cantidad = Convert.ToInt32(txtCantidad.Text);
                fact.Descripcion = txtDescripcion.Text;
                fact.Precio_IVA = Convert.ToDecimal(txtPrecio.Text);

                vt.AgregarProducto(fact);
                dgvFacturacion.DataSource = null;
                dgvFacturacion.DataSource = vt.Productos;
                txtSubTotal.Text = vt.SubTotalVenta().ToString();
                valorSubtotal = Convert.ToDecimal(txtSubTotal.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Intente de nuevo");
            }
        }

        //evento del boton que se encarga de buscar el cliente en la base de datos (envia un msj si no existe)
        private void btnBuscarClie_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> clientes = new List<string>();
                string consulta = ("select * from b_d_punto_venta_clientes where `Ced_Clie_ B_D_Punto_Venta_Clientes` = '" + txtIdCliente.Text + "'");
                clientes = fn.HacerConsulta(consulta);

                txtIdCliente.Text = clientes[0];
                txtNombreClie.Text = clientes[1];
                clie = txtIdCliente.Text;
            }
            catch
            {
                MessageBox.Show("ID de cliente incorrecto");
            }
        }

        //evento del boton que se encarga de buscar el producto en la base de datos (envia un msj si no existe)
        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> productos = new List<string>();
                string consulta = ("select * from `b_d_punto_venta_productos` where `Id_Prod_ B_D_Punto_Venta_Productos` = '" + txtIdProd.Text + "'");
                productos = fn.HacerConsulta(consulta);

                txtIdProd.Text = productos[0];
                txtDescripcion.Text = productos[1];
                txtPrecio.Text = productos[7];
            }

            catch (Exception)
            {
                MessageBox.Show("Intente de nuevo");
            }
        }

        //metodo para aplicar descuento al subtotal de la factura
        private void btnAplicarDesc_Click(object sender, EventArgs e)
        {
            if (txtDescuento.Text != string.Empty)
            {     
                desc = Convert.ToDecimal(txtDescuento.Text);
            }

            vt.TotalSubVenta(valorSubtotal);
            total = vt.TotalVenta(desc);
            txtTotal.Text = total.ToString();
        }

        //Evento del boton que guarda los valores de las tablas Facturacion y Deta de factura en la base de datos
        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                string insert = "insert into b_d_punto_venta_facturacion values('" + txtNumFactura.Text + "','" + lblIdVendedor.Text + "','" + dtpFecha.Text + "','"
                + txtIdCliente.Text + "','" + tipoFact + "','" + tipoPago + "','" + txtSubTotal.Text.Replace("," , ".") + "','" + txtDescuento.Text + "','" + txtTotal.Text.Replace(",", ".") + "')";

                if (fn.InsertarFacturacion(insert))
                {
                    MessageBox.Show("Cobro exitoso");
                }
                else
                {
                    MessageBox.Show("Error al realizar la facturación, intente de nuevo, por favor");
                }

                string insert1 = "insert into b_d_punto_venta_detalle_facturacion values('" + txtNumFactura.Text + "','" + lblIdVendedor.Text + "','" + txtDescripcion.Text + "','" 
                                    + txtCantidad.Text + "','"  + txtPrecio.Text.Replace(",", ".") + "','" + txtSubTotal.Text.Replace(",", ".") + "')";

                if (fn.InsertarFacturacion(insert1))
                {
                    MessageBox.Show("La factura fue generada satisfactoriamente");
                }
                else
                {
                    MessageBox.Show("Error al realizar la facturación, intente de nuevo, por favor");
                }
                limpiarCampos();
                dgvFacturacion.DataSource = null;
            }
            catch (Exception)
            {

                throw;
            } 
        }

        //metodo que permite limpiar los campos del formulario
        private void limpiarCampos()
        {
            txtNumFactura.Text = fn.IngresarNumFact1().ToString();
            txtIdCliente.Clear();
            txtIdCliente.Focus();
            txtNombreClie.Clear();
            txtIdProd.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtSubTotal.Clear();
            txtDescuento.Clear();
            txtTotal.Clear();
            //txtIdProd.Focus();
        }


        //evento que realiza la accion de acuerdo a la tecla funcion 
        private void Facturacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
            {
                MantenimientoClientes mc = new MantenimientoClientes();
                this.Hide();
                mc.Show();
            }
            if (e.KeyData == Keys.F3)
            {
                MantenimientoProductos mp = new MantenimientoProductos();
                this.Hide();
                mp.Show();
            }
            if (e.KeyData == Keys.F4)
            {
                try
                {
                    string insert = "insert into b_d_punto_venta_facturacion values('" + txtNumFactura.Text + "','" + lblIdVendedor.Text + "','" + dtpFecha.Text + "','"
                    + txtIdCliente.Text + "','" + tipoFact + "','" + tipoPago + "','" + txtSubTotal.Text.Replace(",", ".") + "','" + txtDescuento.Text + "','" + txtTotal.Text.Replace(",", ".") + "')";

                    if (fn.InsertarFacturacion(insert))
                    {
                        MessageBox.Show("Cobro exitoso");
                    }
                    else
                    {
                        MessageBox.Show("Error al realizar la facturación, intente de nuevo, por favor");
                    }

                    string insert1 = "insert into b_d_punto_venta_detalle_facturacion values('" + txtNumFactura.Text + "','" + lblIdVendedor.Text + "','" + txtDescripcion.Text + "','"
                                        + txtCantidad.Text + "','" + txtPrecio.Text.Replace(",", ".") + "','" + txtSubTotal.Text.Replace(",", ".") + "')";

                    if (fn.InsertarFacturacion(insert1))
                    {
                        MessageBox.Show("La factura fue generada satisfactoriamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al realizar la facturación, intente de nuevo, por favor");
                    }
                    limpiarCampos();
                    dgvFacturacion.DataSource = null;
                }

                catch (Exception)
                {

                    throw;
                }
            }
        }
        #endregion
    }
}
