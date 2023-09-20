using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DROGAS_SA
{
    internal class Articulo
    {
        private int id_articulo;
        private string descripcion;
        private int pre_unitario;

        public Articulo()

        {   id_articulo = 0;
            descripcion = string.Empty;
            pre_unitario = 0;

        }

        public Articulo(int id_articulo, string descripcion, int pre_unitario)
        {
            this.Id_articulo = id_articulo;
            this.Descripcion = descripcion;
            this.Pre_unitario = pre_unitario;
        }

        public int Id_articulo { get => id_articulo; set => id_articulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Pre_unitario { get => pre_unitario; set => pre_unitario = value; }

        public override string ToString()
        {
            return descripcion;
        }

    }
}
