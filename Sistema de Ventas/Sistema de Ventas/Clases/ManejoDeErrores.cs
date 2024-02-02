using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//borrame
namespace Sistema_de_Ventas.Clases
{
   public class ManejoDeErrores
   {

      public bool CamposVacios(string a, string b, string c, string d, string e)
      {
         //Para el Dtgv Productos
         if (a == "" || b == "" || c == "" || d == "" || e == "")
            return true;

         return false;   
      }

      public bool DataGridVacio(double total) //Para validar el bntFInalizar en venta.
      {
         return total > 0;
      }



   }
}
