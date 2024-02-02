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

namespace Sistema_de_Ventas
{
   public partial class Login : Form
   {
      ConexionBD conexion = new ConexionBD();

      public Login()
      {
         InitializeComponent();
      }

      private void button1_Click(object sender, EventArgs e)
      {

         int tp = conexion.Consulta_TipoPersona(txtUsuario.Text, txtContraseña.Text);

         if (tp != 0)
         {
            Menu menu = new Menu(tp);
            menu.Show();
            this.Hide();
         }
         else if(txtUsuario.Text == "" || txtContraseña.Text == "")
            MessageBox.Show("Debes llenar Todos los Campos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
         else
            MessageBox.Show("Datos Incorrectos!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

      }
   }
}
