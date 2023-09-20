using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DROGAS_SA
{
    internal class Conexion
    {
        private SqlConnection cnn = new SqlConnection("Data Source=kuke;Initial Catalog=Drogas_SA;Integrated Security=True");
        private SqlCommand cmd;

        public void Conectar()
        {
            cnn.Open();
            cmd = new SqlCommand();
            cmd.Connection = cnn;
        }

        public void Desconectar() { cnn.Close(); }

        public DataTable ReadSp(string procedure) 
        { 
            //conectar
            Conectar();
            //le digo quiero ejecutar un procedimiento a command
            cmd.CommandType = CommandType.StoredProcedure;
            //le paso el nombre del procedimiento
            cmd.CommandText = procedure;
            //creo una datable
            DataTable dt = new DataTable();
            //cargo los datos a traves de command
            dt.Load(cmd.ExecuteReader());
            //desconecto antes de return para que tenga efecto, despues de return no pasa naranja!
            Desconectar();
            //devuelvo la datatable
            return dt;

        }

    }
}
