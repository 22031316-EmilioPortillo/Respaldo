using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUNTO_DE_VENTA.Clases
{
   public class Empleado
   {

      private string documento, nombre, clave;
      private int tipoPersona;


      public Empleado(string documento, string nombre, string clave)
      {
         this.documento = documento;
         this.nombre = nombre;
         this.clave = clave;
      }



      public string getDocumento() { return documento;}

      public int gettipoPersona() { return tipoPersona;}

      public string getNombre() { return nombre;}

      public string getClave() { return clave;}


   }
}
