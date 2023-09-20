using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DROGAS_SA
{
    internal class Clientes
    {
        private int id_cliente;
        private string nombre;

        public Clientes()
        {
           id_cliente = 0;
           nombre = string.Empty;
        }

        public Clientes(int id_cliente, string nombre)
        {
            this.id_cliente = id_cliente;
            this.nombre = nombre;
        }

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString() { return nombre; }
    }
}
