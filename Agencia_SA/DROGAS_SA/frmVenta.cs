using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DROGAS_SA
{
    public partial class frmVenta : Form
    {
        Conexion helper = new Conexion();
        public frmVenta()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            CargarCombo1();
            CargarCombo2();
        }

        private void CargarCombo2()
        {
            DataTable dt = new DataTable();
            dt = helper.ReadSp("Sp_articulos");
            cboArticulo.DataSource = dt;
            cboArticulo.ValueMember = "id_articulo";
            cboArticulo.DisplayMember = "descripccion";
            cboArticulo.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void CargarCombo1()
        {
            DataTable dt = new DataTable();
            dt = helper.ReadSp("Sp_Clientes");
            cboCliente.DataSource = dt;
            cboCliente.ValueMember = "id_cliente";
            cboCliente.DisplayMember = "nombre";
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;

        }
    }
}
