using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Facturaciones
    {   
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_IVA { get; set; }
        public decimal Subtotal_IVA { get { return Precio_IVA * (decimal)Cantidad; } }

        static decimal valor;
        //metodo que obtiene el descuento segun el porcentaje digitado
        public decimal obtenerDesc(decimal monto, decimal desc)
        {
            decimal descuento = 0;
            descuento = (monto * desc) / 100;

            return descuento;
        }

        //metodo que pasa la cantidad a descontar segun el descuento
        public void pasarDesc(decimal porcentaje)
        {
            decimal descuento = 0;
            descuento = (Subtotal_IVA * porcentaje) / 100;
        }
    }
}
