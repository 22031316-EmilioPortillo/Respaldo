using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas.Forms
{
   public partial class ActualizarUser : Form
   {
      ConexionBD conexion = new ConexionBD();
      public ActualizarUser()
      {
         InitializeComponent();
         conexion.ConsultaUsuarios(DtgvActualizar);
      }

      private void DtgvActualizar_CellEndEdit(object sender, DataGridViewCellEventArgs e)
      {
         SqlConnection Conexion = new SqlConnection("server=HP-EMILIO\\SQLEXPRESS; database=DBPUNTO_VENTA; integrated security=true");
         var nuevoValor = DtgvActualizar[e.ColumnIndex, e.RowIndex].Value.ToString();
         var columna = DtgvActualizar.Columns[e.ColumnIndex].HeaderText;
         var fila = e.RowIndex;

         Conexion.Open();
         string Query = $"UPDATE PERSONA SET {columna} = @nuevoValor WHERE Documento = @Documento";
         SqlCommand cmd = new SqlCommand(Query, Conexion);
         cmd.Parameters.AddWithValue("@nuevoValor", nuevoValor);
         cmd.Parameters.AddWithValue("@Documento", DtgvActualizar.Rows[fila].Cells["Documento"].Value);

         if (cmd.ExecuteNonQuery() > 0)
            MessageBox.Show("Datos Actualizados", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
         else
            MessageBox.Show("¡Ocurrio un Error!", "Fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

         Conexion.Close();
         DtgvActualizar.Update();
        // conexion.ConsultaUsuarios(DtgvActualizar);
      }

      private void DtgvActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
      {
         DataGridViewRow row = DtgvActualizar.Rows[e.RowIndex];
         txtDocumento.Text = row.Cells["Documento"].Value.ToString();
         btnEliminar.Enabled = true;
      }

      private void btnEliminar_Click(object sender, EventArgs e)
      {

         SqlConnection Conexion = new SqlConnection("server=HP-EMILIO\\SQLEXPRESS; database=DBPUNTO_VENTA; integrated security=true");
         Conexion.Open();

         if (txtDocumento.Text == "10101010")
            MessageBox.Show("No se puede Borrar esta Cuenta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         else
         {
            string Query = $"DELETE FROM PERSONA WHERE Documento = '{txtDocumento.Text}'";
            SqlCommand command = new SqlCommand(Query, Conexion);

            if (command.ExecuteNonQuery() > 0)
               MessageBox.Show("Elimiando Correctamente", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
               MessageBox.Show("¡Ocurrio un Error!", "FALLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         Conexion.Close();
         conexion.ConsultaUsuarios(DtgvActualizar);
      }
   }
}
