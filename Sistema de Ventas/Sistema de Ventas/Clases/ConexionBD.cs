using Sistema_de_Ventas.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
   public class ConexionBD
   {
      SqlConnection Conexion = new SqlConnection("server=HP-EMILIO\\SQLEXPRESS; database=DBPUNTO_VENTA; integrated security=true");


      public int Consulta_TipoPersona(string Documento, string Clave)
      {
         Conexion.Open();
         int tipoPersona = 0;
         string Query = $"SELECT IdTipoPersona FROM PERSONA WHERE DOCUMENTO = '{Documento}' AND CLAVE = '{Clave}'";

         SqlCommand command = new SqlCommand(Query, Conexion);
         SqlDataReader reader = command.ExecuteReader();

         if (reader.Read())
            tipoPersona = reader.GetInt32(0);

         Conexion.Close();
         return tipoPersona;
      }


      public void Registrar_Usuario(string documento, string nombre, string direccion, string telefono, string clave, ComboBox cmbTP)
      {
         Conexion.Open();
         int tipoPer = cmbTP.SelectedIndex + 1;//Comienza en 0 y no hay 0 en tipo persona.
         String Query = $"INSERT INTO PERSONA(Documento, IdtipoPersona, Clave, Nombre, Direccion, Telefono ) VALUES(@Documento, @IdtipoPersona, @Clave, @Nombre, @Telefono, @Direccion)";

         SqlCommand command = new SqlCommand(Query, Conexion);

         command.Parameters.AddWithValue("@Documento", documento);
         command.Parameters.AddWithValue("@IdtipoPersona", tipoPer);
         command.Parameters.AddWithValue("@Clave", clave);
         command.Parameters.AddWithValue("@Nombre", nombre);
         command.Parameters.AddWithValue("@Telefono", direccion);
         command.Parameters.AddWithValue("@Direccion", telefono);


         if (command.ExecuteNonQuery() > 0)
            MessageBox.Show("Se Registro el Usuario", "REGISTRO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
         else
            MessageBox.Show("No se pudo Registrar el Usuario", "REGISTRO FALLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);

         Conexion.Close();
      }



      public void ConsultaUsuarios(DataGridView Dtgv)
      {
         Conexion.Open();
         string Query = "SELECT Documento, Clave, IdTipoPersona, Direccion, Telefono FROM PERSONA";
         SqlDataAdapter adapter = new SqlDataAdapter(Query, Conexion);

         DataTable dataTable = new DataTable();
         adapter.Fill(dataTable);
         Dtgv.DataSource = dataTable;
         Conexion.Close();
      }


      public void ConsultaProductos(DataGridView Dtgv)
      {

         Conexion.Open();
         string Query = "SELECT IdProducto, Nombre, Descripcion, Stock, PrecioCompra, PrecioVenta FROM PRODUCTO";
         SqlDataAdapter adapter = new SqlDataAdapter(Query, Conexion);

         DataTable dataTable = new DataTable();
         adapter.Fill(dataTable);
         Dtgv.DataSource = dataTable;
         Conexion.Close();
      }



      public void ConsultaProductosVenta(DataGridView Dtgv)
      {

         Conexion.Open();
         string Query = "SELECT IdProducto, Nombre, Descripcion, Stock, PrecioVenta FROM PRODUCTO";
         SqlDataAdapter adapter = new SqlDataAdapter(Query, Conexion);

         DataTable dataTable = new DataTable();
         adapter.Fill(dataTable);
         Dtgv.DataSource = dataTable;
         Conexion.Close();
      }


      public void AgregarProducto(string Nombre, string Descripcion, int Stock, double precioCompra, double precioVenta)
      {
         Conexion.Open();
         string Query = $"INSERT INTO PRODUCTO(Nombre, Descripcion, Stock, PrecioCompra, PrecioVenta) VALUES(@Nombre, @Descripcion, @Stock, @PrecioCompra, @precioVenta)";

         SqlCommand command = new SqlCommand(Query, Conexion);


         command.Parameters.AddWithValue("@Nombre", Nombre);
         command.Parameters.AddWithValue("@Descripcion", Descripcion);
         command.Parameters.AddWithValue("@Stock", Stock);
         command.Parameters.AddWithValue("@PrecioCompra", precioCompra);
         command.Parameters.AddWithValue("@PrecioVenta", precioVenta);

         if (command.ExecuteNonQuery() > 0)
            MessageBox.Show("Producto Registrado!", "REGISTRO EXITOSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
         else
            MessageBox.Show("Error al Registrar!", "REGISTRO FALLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);

         Conexion.Close();
      }


      public void Eliminar(string tabla,string atributo, string ID)
      {
         Conexion.Open();

         string Query = $"DELETE FROM {tabla} WHERE {atributo} = {ID}";
         SqlCommand command = new SqlCommand(Query, Conexion);

         if (command.ExecuteNonQuery() > 0)
            MessageBox.Show("Elimiando Correctamente", "CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
         else
            MessageBox.Show("¡Ocurrio un Error!", "FALLIDO", MessageBoxButtons.OK, MessageBoxIcon.Error);

         Conexion.Close();
      }


    


   }
}
