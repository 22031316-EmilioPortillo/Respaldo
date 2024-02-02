using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sistema_de_Ventas.Clases;

namespace Sistema_de_Ventas.Forms
{
   public partial class Productos : Form
   {

      ConexionBD conexion = new ConexionBD();
      ManejoDeErrores error = new ManejoDeErrores();
      public Productos()
      {
         InitializeComponent();
         conexion.ConsultaProductos(DtgvProducto);
      }

      private void textBox1_TextChanged(object sender, EventArgs e)
      {

      }

     

      private void btnAgregar_Click(object sender, EventArgs e)
      {
         if (error.CamposVacios(txtNombre.Text, txtDescripcion.Text, txtPrecioComp.Text, txtPrecioVent.Text, txtStock.Text))
            MessageBox.Show("Primero debes rellenar todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
         else
            conexion.AgregarProducto(txtNombre.Text, txtDescripcion.Text, Convert.ToInt32(txtStock.Text), Convert.ToDouble(txtPrecioComp.Text), Convert.ToDouble(txtPrecioVent.Text));
            conexion.ConsultaProductos(DtgvProducto);

            txtNombre.Clear();
            txtDescripcion.Clear();
            txtStock.Clear();
            txtPrecioComp.Clear();
            txtPrecioVent.Clear();
      }

      private void DtgvProducto_CellEndEdit(object sender, DataGridViewCellEventArgs e)
      {

         SqlConnection Conexion = new SqlConnection("server=LAPTOP-QH6P1DLV\\SQLEXPRESS; database=DBPUNTO_VENTA; integrated security=true");
         var nuevoValor = DtgvProducto[e.ColumnIndex, e.RowIndex].Value.ToString();
         var columna = DtgvProducto.Columns[e.ColumnIndex].HeaderText;
         var fila = e.RowIndex;
         //var ID = DtgvProducto.Rows[fila].Cells["IdProducto"].Value;

         Conexion.Open();
         string Query = $"UPDATE PRODUCTO SET {columna} = @nuevoValor WHERE IdProducto = @IdProducto";
         SqlCommand cmd = new SqlCommand(Query, Conexion);
         cmd.Parameters.AddWithValue("@nuevoValor", nuevoValor);
         cmd.Parameters.AddWithValue("@IdProducto", DtgvProducto.Rows[fila].Cells["IdProducto"].Value);

         if (cmd.ExecuteNonQuery() > 0)
            MessageBox.Show("Datos Actualizados", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
         else
            MessageBox.Show("¡Ocurrio un Error!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

         Conexion.Close();

      }

      private void DtgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         DataGridViewRow row = DtgvProducto.Rows[e.RowIndex];
         txtNombre.Text = row.Cells["Nombre"].Value.ToString();
         txtDescripcion.Text = row.Cells["Descripcion"].Value.ToString();
         txtStock.Text = row.Cells["Stock"].Value.ToString();
         txtPrecioComp.Text = row.Cells["PrecioCompra"].Value.ToString();
         txtPrecioVent.Text = row.Cells["PrecioVenta"].Value.ToString();
         txtId.Text = row.Cells["IdProducto"].Value.ToString();
         btnEliminar.Enabled = true;
      }

      private void btnEliminar_Click(object sender, EventArgs e)
      {
         SqlConnection Conexion = new SqlConnection("server=LAPTOP-QH6P1DLV\\SQLEXPRESS; database=DBPUNTO_VENTA; integrated security=true");
         conexion.Eliminar("PRODUCTO", "IdProducto", txtId.Text);
         conexion.ConsultaProductos(DtgvProducto);
        
      }

      private void btnLimpiar_Click(object sender, EventArgs e)
      {
         txtNombre.Clear();
         txtDescripcion.Clear();
         txtStock.Clear();
         txtPrecioComp.Clear();
         txtPrecioVent.Clear();
      }
   }
}
