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
    public partial class MantenimientoClientes : Form
    {
        public MantenimientoClientes()
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

        //permite guardar los datos del cliente
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string insert = "insert into b_d_punto_venta_clientes values('" + txtCedula.Text + "','" + txtNombre.Text + "','" + txtDomicilio.Text + "','"
                            + txtTel1.Text + "','" + txtTel2.Text + "','" + txtCodPos.Text + "','" + txtEmail.Text + "','" + txtDomicilioF.Text + "')";

            //MessageBox.Show(insert);

            if (fn.Insertar(insert))
            {
                MessageBox.Show("Cliente agregado");
            }
            else
            {
                MessageBox.Show("Error al agregar el cliente o ya existe");
            }
            LimpiarCampos();
            RefrescarDataGrid();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            string modificar = "update b_d_punto_venta_clientes set `Nom_Clie_ B_D_Punto_Venta_Clientes` = '" + txtNombre.Text + "', `Direc_Clie_ B_D_Punto_Venta_Clientes` = '" + txtDomicilio.Text +
                               "', `Tel1_Clie_ B_D_Punto_Venta_Clientes` ='" + txtTel1.Text + "', `Tel2_Clie_ B_D_Punto_Venta_Clientes` ='" + txtTel2.Text +
                               "', `Cod_Pos_Clie_ B_D_Punto_Venta_Clientes`='" + txtCodPos.Text + "', `Email_Clie_ B_D_Punto_Venta_Clientes` ='" + txtEmail.Text +
                               "', `Dom_Fis_Clie_ B_D_Punto_Venta_Clientes` ='" + txtDomicilioF.Text+ "' where " + " `Ced_Clie_ B_D_Punto_Venta_Clientes` = '" + txtCedula.Text+"'";


            if (fn.Modificar(modificar))
            {
                MessageBox.Show("Modificación exitosa");
            }
            else
            {
                MessageBox.Show("Error al intentar modificar datos");
            }

            LimpiarCampos();
            RefrescarDataGrid();
        }

        //permite buscar el cliente de acuerdo al ID ingresado
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text == string.Empty )
            {
                try
                {
                    //dgvCliente.DataSource = fn.ConsultarDato("select * from b_d_punto_venta_clientes");
                    RefrescarDataGrid();

                   /* int fila = 0;
                    Clientes clie = new Clientes();
                    string cliente = "";
                    Ventas vt = new Ventas(cliente);
                    int num = 0;

                    do
                    {
                        dgvCliente.DataSource = fn.ConsultarDato("select * from b_d_punto_venta_clientes");

                        num = dgvCliente.RowCount - 1;

                        clie.Cedula = dgvCliente.Rows[fila].Cells[0].Value.ToString();
                        clie.Nombre = dgvCliente.Rows[fila].Cells[1].Value.ToString();
                        clie.Direccion = dgvCliente.Rows[fila].Cells[2].Value.ToString();
                        clie.Telefono_1 = dgvCliente.Rows[fila].Cells[3].Value.ToString();
                        clie.Telefono_2 = dgvCliente.Rows[fila].Cells[4].Value.ToString();
                        clie.Cod_Postal = dgvCliente.Rows[fila].Cells[5].Value.ToString();
                        clie.Correo = dgvCliente.Rows[fila].Cells[6].Value.ToString();
                        clie.Domicilio_Fiscal = dgvCliente.Rows[fila].Cells[7].Value.ToString();

                        vt.AgregarCliente(clie);
                        dgvCliente.DataSource = null;
                        //dgvCliente.DataSource = vt.Clien;
                        fila++;

                    } while (fila < num);
                    dgvCliente.DataSource = vt.Clien;*/


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
                    dgvCliente.DataSource = fn.ConsultarDato("select * from b_d_punto_venta_clientes where `Ced_Clie_ B_D_Punto_Venta_Clientes` = '" + txtBuscar.Text + "'");
                }
                catch
                {
                    MessageBox.Show("Parámetros incorrectos");
                }
            }
           
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCedula.Text= dgvCliente.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text= dgvCliente.CurrentRow.Cells[1].Value.ToString();
                txtDomicilio.Text= dgvCliente.CurrentRow.Cells[2].Value.ToString();
                txtTel1.Text= dgvCliente.CurrentRow.Cells[3].Value.ToString();
                txtTel2.Text= dgvCliente.CurrentRow.Cells[4].Value.ToString();
                txtCodPos.Text= dgvCliente.CurrentRow.Cells[5].Value.ToString();
                txtEmail.Text= dgvCliente.CurrentRow.Cells[6].Value.ToString();
                txtDomicilioF.Text= dgvCliente.CurrentRow.Cells[7].Value.ToString();
            }
                       
            catch
                       
            {
                MessageBox.Show("Parámetros incorrectos");
            }
        }

        //permite eliminar los datos del cliente
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string eliminar = "Delete from b_d_punto_venta_clientes where `Ced_Clie_ B_D_Punto_Venta_Clientes` = '" + txtCedula.Text + "'";

            if (fn.Eliminar(eliminar))
            {
                MessageBox.Show("Eliminación exitosa");
            }
            else
            {
                MessageBox.Show("Error al intentar eliminar el cliente");
            }

            LimpiarCampos();
            RefrescarDataGrid();
        }

        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtDomicilio.Clear();
            txtDomicilioF.Clear();
            txtTel1.Clear();
            txtTel2.Clear();
            txtCodPos.Clear();
            txtEmail.Clear();
            txtBuscar.Clear();
        }

        private void RefrescarDataGrid()
        {
            dgvCliente.DataSource = fn.ConsultarDato("select * from b_d_punto_venta_clientes");
        }
    }
}
