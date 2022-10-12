using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class Ventas
    {

        private string cliente;
        private DateTime fecha;
        private List<Facturaciones> facturas;
        Facturaciones fc = new Facturaciones();
        private List<Clientes> clientes;
        Clientes clie = new Clientes();
        

        public Ventas(string cliente)
        {
            this.cliente = cliente;
            this.fecha = DateTime.Now;
            this.facturas = new List<Facturaciones>();
            this.clientes = new List<Clientes>();
        }

        public List<Facturaciones> Productos
        {
            get { return facturas; }
        }

        public List<Clientes> Clien
        {
            get { return clientes; }
        }

        public void AgregarProducto(Facturaciones producto)
        {
            facturas.Add(producto);
        }

        public void AgregarCliente(Clientes cliente)
        {
            clientes.Add(cliente);
        }

        decimal subtotal;
        //metodo que permite calcular el subtotal de la venta 
        public decimal SubTotalVenta()
        {
            subtotal = fc.Subtotal_IVA;
            foreach (Facturaciones producto in facturas)
            {

                subtotal = subtotal + producto.Subtotal_IVA;
            }
            calcular = subtotal;
            return subtotal;
        }

        static decimal calcular; // variable globa
        public void TotalSubVenta(decimal desc)
        {
            calcular = desc;
        }

        //metodo que permite calcular el total de la venta segun descuento
        public decimal TotalVenta(decimal desc)
        {
            decimal totalDesc = fc.obtenerDesc(calcular,desc);
            decimal total = calcular - totalDesc;
            return total;
        }
    }
}
