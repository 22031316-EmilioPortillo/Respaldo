using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Ventas.Clases
{
   public class Empleado
   {

      private string documento, nombre, clave, direccion, telefono;
      private int tipoPersona, idPersona;


      public Empleado(string documento, string nombre, string clave)
      {
         this.documento = documento;
         this.nombre = nombre;
         this.clave = clave;
      }


      public Empleado( string documento, string clave, int tipoPersona, string direccion, string telefono)
      {
         this.documento = documento;
         this.clave = clave;
         this.direccion = direccion;
         this.telefono = telefono;
         this.tipoPersona = tipoPersona;
      }



      public string getDocumento() { return documento; }

      public int gettipoPersona() { return tipoPersona; }

      public string getNombre() { return nombre; }

      public string getClave() { return clave; }

      public int getId() { return idPersona; }

      public string getTelefono() { return telefono; }

      public string getDireccion() { return direccion; }

   }
}
