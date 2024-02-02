using Sistema_de_Ventas.Clases;
using Sistema_de_Ventas.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
   public partial class Menu : Form
   {

      ConexionBD conexion;

      public Menu(int tp)//Que controles voy a mostrar dependiendo el usuario.
      {
         InitializeComponent();
         switch(tp)
         {
            case 1:
               UsuariosTool.Visible = true;
               RegistrarTool.Visible = true;
               ActualizarTool.Visible = true;
               break;
            case 2:
               VentaTool.Visible = true;
               CompraTool.Visible = true;
               ProductosTool.Visible = true;
               break;
         }

      }

      private void Menu_FormClosing(object sender, FormClosingEventArgs e)
      {
         //Para que no de error ya que el login solo se oculta.
         Login login = new Login();
         login.Close();
      }

      private void UsuariosTool_Click(object sender, EventArgs e)
      {
         Dtgv.Update();
         Dtgv.Visible = true;
         btnActualizar.Visible = true;
         conexion = new ConexionBD();
         conexion.ConsultaUsuarios(Dtgv);
         UsuariosTool.Enabled = false;
      }

      private void RegistrarTool_Click(object sender, EventArgs e)
      {
         Registro registro = new Registro();
         registro.Show();
      }

      private void ActualizarTool_Click(object sender, EventArgs e)
      {
         ActualizarUser actualizar = new ActualizarUser();
         actualizar.Show();
      }

      private void ProductosTool_Click(object sender, EventArgs e)
      {
         Productos producto = new Productos();
         producto.Show();
      }

      private void Menu_FormClosed(object sender, FormClosedEventArgs e)
      {
         Application.Exit();
      }

      private void VentaTool_Click(object sender, EventArgs e)
      {
         Venta venta = new Venta();
         venta.Show();
      }
   }
}
