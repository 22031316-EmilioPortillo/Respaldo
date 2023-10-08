using System;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA
{
   public partial class Login : Form
   {
      Conexion obj = new Conexion();
      public Login()
      {
         InitializeComponent();
      }


      private void btnLogin_Click_1(object sender, EventArgs e)//CODIGO PARA EL LOGIN
      {
         Form2 interfaz = new Form2();
         int tipoPer = obj.ConsultaLogin(txtUsuario.Text, txtContraseña.Text);

         switch(tipoPer)
         {
            case 1:
               interfaz.menuStrip1.Items["empleadoTool"].Visible = false;
               this.Hide();
               interfaz.Show();
               break;
            case 2:
               interfaz.menuStrip1.Items["adminTool"].Visible = false;
               this.Hide();
               interfaz.Show();
               break;
            default:
               MessageBox.Show("Datos Incorrectos!");
               break;
         }


      }

   }
}
