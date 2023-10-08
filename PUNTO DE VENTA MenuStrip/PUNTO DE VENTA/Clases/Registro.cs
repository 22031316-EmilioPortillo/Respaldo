using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PUNTO_DE_VENTA
{
   public class SingUp : Conexion
   {
      
      public void Registrar_Usuario(string documento, string clave, ComboBox cmb, string nombre)
      {
         int tipoPer = cmb.SelectedIndex + 1;//Comienza en 0 y no hay 0 en tipo persona.
         String Query = $"INSERT INTO PERSONA(Documento, IdtipoPersona, Clave, Nombre) VALUES(@Documento, @IdtipoPersona, @Clave, @Nombre)";

         using (SqlCommand command = new SqlCommand(Query, Conexion2))
         {
            command.Parameters.AddWithValue("@Documento", documento);
            command.Parameters.AddWithValue("@IdtipoPersona", tipoPer);
            command.Parameters.AddWithValue("@Clave", clave);
            command.Parameters.AddWithValue("@Nombre", nombre);

            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected > 0)
               MessageBox.Show("Se Registro el Usuario", "Registro Exitoso!", MessageBoxButtons.OK);
            else
               MessageBox.Show("No se pudo Registrar el Usuario", "Registro fallido", MessageBoxButtons.OK);
         }
      }



      public void EliminarUsuario(string documento, string tipoPersona)
      {
         String Query = $"DELETE FROM PERSONA WHERE documento = '{documento}' AND nombre = '{tipoPersona}'";

         using (SqlCommand command = new SqlCommand(Query, Conexion2))
         {
            int RowsAfectados = command.ExecuteNonQuery();

            if (RowsAfectados > 0)
               MessageBox.Show("Usuario Borrado con Exito!", "Transaccion Exitosa", MessageBoxButtons.OK);
            else
               MessageBox.Show("Usuario no Valido!", "Transaccion Erronea", MessageBoxButtons.OK);
         }
      }


   }
}
