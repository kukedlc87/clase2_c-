using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DROGAS_SA
{
    internal class Factura
    {
        private Clientes cliente;
        private List<Detalle> detalles;
        private DateTime fecha;
        private int nro_factura;

        public Factura()
        {
            cliente = null;
            detalles = new List<Detalle>();
            fecha = DateTime.Now;
            nro_factura = 0;

        }

        public Factura(Clientes cliente, List<Detalle> detalles, DateTime fecha, int nro_factura)
        {
            this.Cliente = cliente;
            this.Detalles = detalles;
            this.Fecha = fecha;
            this.Nro_factura = nro_factura;
        }

        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Nro_factura { get => nro_factura; set => nro_factura = value; }
        internal Clientes Cliente { get => cliente; set => cliente = value; }
        internal List<Detalle> Detalles { get => detalles; set => detalles = value; }

        public int CalcularTotal()
        { 
            int total = 0;

            foreach (Detalle d in Detalles)
            {
                total += d.CalcularTotal();
            }


            return total;
        }
        public void AgregarDetalle(Detalle detalle)
        {

            detalles.Add(detalle);
        
        }
        public void QuitarDetalle(int posicion)
        {

            detalles.RemoveAt(posicion);
        
        }

    }
}
