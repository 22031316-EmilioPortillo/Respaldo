using System;
using System.Windows.Forms;

namespace Sistema_de_Ventas.Forms
{
   public partial class ProductoVenta : Form
   {
      ConexionBD conexion = new ConexionBD();
      Venta venta = new Venta();
      public string IdProducto { get; set; }
      public string Nombre { get; set; }
      public string Descripcion { get; set; }
      public string Precio { get; set; }
      public double total { get; set; }
      public string Cantidad { get; set; }
      public double Importe { get; set; }
      public int stock { get; set; }

      public ProductoVenta()
      {
         InitializeComponent();
         conexion.ConsultaProductosVenta(DtgvProductoVenta);
         txtCantidad.Text = "1";
      }


      private void DtgvProductoVenta_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         DataGridViewRow row = DtgvProductoVenta.Rows[e.RowIndex];
         txtId.Text = row.Cells["IdProducto"].Value.ToString();
         txtNombre.Text = row.Cells["Nombre"].Value.ToString();
         txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
         txtPrecio.Text = row.Cells["PrecioVenta"].Value.ToString();
         txtTotal.Text = row.Cells["PrecioVenta"].Value.ToString();
         txtStock.Text = row.Cells["Stock"].Value.ToString();
         btnAgregar.Enabled = true;
      }

      private void btnAgregar_Click(object sender, EventArgs e)
      {
         if (int.Parse(txtStock.Text) >= int.Parse(txtCantidad.Text))
         {
            IdProducto = txtId.Text;
            Nombre = txtNombre.Text;
            Descripcion = txtDescripcion.Text;
            Precio = txtPrecio.Text;
            total = Convert.ToDouble(txtTotal.Text) * Convert.ToDouble(txtCantidad.Text);
            Cantidad = txtCantidad.Text;
            Importe = Convert.ToDouble(Cantidad) * Convert.ToDouble(Precio);
            this.DialogResult = DialogResult.OK;
            venta.btnFinalizar.Enabled = true;
            this.Close();
         }
         else
            MessageBox.Show("No hay Stock Suficiente para esta venta!", "OCURRIO UN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
   }
}
