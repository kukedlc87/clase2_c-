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
        private Factura nueva;

        private int total;
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
            nueva = new Factura();
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataRowView item = (DataRowView)cboArticulo.SelectedItem;
            Articulo articulo = new Articulo();

            articulo.Id_articulo = Convert.ToInt32(item.Row.ItemArray[0]);
            articulo.Descripcion = item.Row.ItemArray[1].ToString();
            articulo.Pre_unitario = Convert.ToInt32(item.Row.ItemArray[2]);
            int cantidad = Convert.ToInt32(numericUpDown1.Value);

            int subtotal = articulo.Pre_unitario * cantidad;


            //MessageBox.Show($"{articulo.Id_articulo}");
            //MessageBox.Show($"{articulo.Descripcion}");
            //MessageBox.Show($"{articulo.Pre_unitario}");


            dgVenta.Rows.Add(new object[] { articulo.Descripcion, articulo.Pre_unitario, cantidad, subtotal , "Quitar"  });
            total = 0;
            foreach (DataGridViewRow row in dgVenta.Rows)
            {
                total += Convert.ToInt32(row.Cells[3].Value); 
            
            }

            lbTotal.Text = "TOTAL: " + (total).ToString();

            Detalle det = new Detalle(articulo, cantidad);
            nueva.AgregarDetalle(det);
            nueva.Cliente.Id_cliente = (int)cboCliente.SelectedValue;
            


            //total = total + subtotal;
            //lbTotal.Text = (total).ToString();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        //private void btnConfirmar_Click(object sender, EventArgs e)
        //{
        //    helper.facturar(nueva);
        //    MessageBox.Show("Transacción exitosa");
        //}
    }
}
