using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DROGAS_SA
{
    internal class Detalle
    {
        private int id_detalle;
        private Articulo articulo;
        private int cantidad;
        private int pre_unitario;

        public Detalle()
        {
            id_detalle = 0;
            articulo = null;
            cantidad = 0;
            pre_unitario = 0;
        }

        public Detalle(Articulo articulo, int cantidad)
        {
            this.Articulo = articulo;
            this.Cantidad = cantidad;
        }

        public int Id_detalle { get => id_detalle; set => id_detalle = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Pre_unitario { get => pre_unitario; set => pre_unitario = value; }
        internal Articulo Articulo { get => articulo; set => articulo = value; }


        public int CalcularTotal()
        { 
        
        return pre_unitario * cantidad;
                
        }
    }
}
