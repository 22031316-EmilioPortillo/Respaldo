using PUNTO_DE_VENTA.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA
{
   public class Conexion
   {
      public SqlConnection Conexion2;
      public void ConexionBD()
      {

         Conexion2 = new SqlConnection("server=LAPTOP-QH6P1DLV\\SQLEXPRESS; database= DBPUNTO_VENTA; integrated security = true");
         Conexion2.Open();

      }

      public int ConsultaLogin(string documento, string clave)
      {
         int tipoPer = 0;
         String Query = $"SELECT IdTipoPersona FROM PERSONA WHERE documento = '{documento}' AND clave = '{clave}'";

         using (SqlCommand command = new SqlCommand(Query, Conexion2))

         using (SqlDataReader reader = command.ExecuteReader())
         {
            while (reader.Read())
            {
               tipoPer = reader.GetInt32(0);
            }
         }

         return tipoPer;
      }



      public Empleado[] ConsultaEmpleados()
      {
         string Query = $"SELECT Documento, nombre, clave  FROM PERSONA";
         Empleado[] arreglo = new Empleado[0];
         int i = 0;

         using (SqlCommand command = new SqlCommand(Query, Conexion2))

         using (SqlDataReader reader = command.ExecuteReader())
         {
            while (reader.Read())
            {
               Array.Resize(ref arreglo, arreglo.Length + 1);
               Empleado emp = new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2));
               arreglo[i] = emp;
               i++;
            }
         }

         return arreglo;

      }
    


      public Conexion()
      {
         ConexionBD();
      }

   }
}
