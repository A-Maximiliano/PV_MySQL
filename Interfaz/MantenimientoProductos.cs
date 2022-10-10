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
    public partial class MantenimientoProductos : Form
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        Funciones fn = new Funciones();

        //permite volver al form de facturacion
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Facturacion fc = new Facturacion();
            fc.Show();
        }

        //permite guardar los datos de registro del producto
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string insert = "insert into b_d_punto_venta_productos values('" + txtID.Text + "','" + txtDescripcion.Text + "','" + txtCantidad.Text + "','"
                           + txtProv1.Text + "','" + txtProv2.Text + "','" + txtPrecioSinIVA.Text + "','" + txtIVA.Text + "','" + txtPrecioConIVA.Text + "')";

            //MessageBox.Show(insert);

            if (fn.Insertar(insert))
            {
                MessageBox.Show("Producto agregado");
            }
            else
            {
                MessageBox.Show("Error al agregar el producto o ya existe");
            }

            //dgvProductos.DataSource = null;
            consultarDataGrid();
            LimpiarCampos();
        }

        //permite modificar los datos del producto
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string modificar = "update b_d_punto_venta_productos set `Des_Prod_ B_D_Punto_Venta_Productos` = '" + txtDescripcion.Text + "', `Cant_Prod_ B_D_Punto_Venta_Productos` = '" + txtCantidad.Text +
                              "', `Prov1_Prod_ B_D_Punto_Venta_Productos` ='" + txtProv1.Text + "', `Prov2_Prod_ B_D_Punto_Venta_Productos` ='" + txtProv2.Text +
                              "', `Pre_Sin_IVA_Prod_ B_D_Punto_Venta_Productos`='" + txtPrecioSinIVA.Text.Replace(",", ".") + "', `Iva_Prod_ B_D_Punto_Venta_Productos` ='" + txtIVA.Text.Replace(",", ".") +
                              "', `Pre_Con_IVA_Prod_ B_D_Punto_Venta_Productos` ='" + txtPrecioConIVA.Text.Replace(",", ".") + "' where " + " `Id_Prod_ B_D_Punto_Venta_Productos` = '" + txtID.Text + "'";


            if (fn.Modificar(modificar))
            {
                MessageBox.Show("Modificación exitosa");
            }
            else
            {
                MessageBox.Show("Error al intentar modificar los datos");
            }

            //dgvProductos.DataSource = null;
            consultarDataGrid();
            LimpiarCampos();
        }

        //permite eliminar los datos del producto
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "Delete from b_d_punto_venta_productos where `Id_Prod_ B_D_Punto_Venta_Productos` = '" + txtID.Text + "'";

            if (fn.Eliminar(eliminar))
            {
                MessageBox.Show("Eliminación exitosa");
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar el producto");
            }
            consultarDataGrid();
            LimpiarCampos();
        }

        //permite buscar el producto de acuerdo al ID
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty)
            {
                try
                {
                    //dgvProductos.DataSource = fn.ConsultarDato("select * from b_d_punto_venta_productos");
                    consultarDataGrid();
                }
                catch
                {
                    MessageBox.Show("Parámetros incorrectos");
                }
            }
            else
            {
                try
                {
                    dgvProductos.DataSource = fn.ConsultarDato("select * from b_d_punto_venta_productos where `Id_Prod_ B_D_Punto_Venta_Productos` = '" + txtBuscar.Text + "'");
                }
                catch
                {
                    MessageBox.Show("Parámetros incorrectos");
                }
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                txtDescripcion.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                txtCantidad.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                txtProv1.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
                txtProv2.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
                txtPrecioSinIVA.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
                txtIVA.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
                txtPrecioConIVA.Text = dgvProductos.CurrentRow.Cells[7].Value.ToString();
            }

            catch

            {
                MessageBox.Show("Parámetros incorrectos");
            }
        }

        private void consultarDataGrid()
        {
            dgvProductos.DataSource = fn.ConsultarDato("select * from b_d_punto_venta_productos");
        }

        private void LimpiarCampos()
        {
            txtID.Clear();
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtProv1.Clear();
            txtProv2.Clear();
            txtPrecioSinIVA.Clear();
            txtIVA.Clear();
            txtPrecioConIVA.Clear();
            txtBuscar.Clear();
        }
    }
}
