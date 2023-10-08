using PUNTO_DE_VENTA.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTO_DE_VENTA
{
   public partial class Form2 : MaterialSkin.Controls.MaterialForm
   {

      Conexion obj;
      int tipoPersona;
      public Form2()
      {
         pnlRegistro.Visible = false;
         pnlEliminar.Visible = false;
         pnlEmpleados.Visible = false;
         InitializeComponent();
      }


      private void btnRegistro_Click(object sender, EventArgs e)
      {
         SingUp cliente = new SingUp();
         if(cmbCuenta.SelectedIndex == 0)
            cliente.Registrar_Usuario(txtUsuarioRegistro.Text, txtContraseñaRegistro.Text, cmbCuenta, "Admin");
         else
            cliente.Registrar_Usuario(txtUsuarioRegistro.Text, txtContraseñaRegistro.Text, cmbCuenta, "Empleado");



      }

      private void registrarNuevoUsuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
      {
         pnlRegistro.Visible = true; 
         pnlEliminar.Visible = false;
         pnlEmpleados.Visible = false;
      }

      private void eliminiarUnUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
      {
         pnlEliminar.Visible = true;
         pnlRegistro.Visible = false;
         pnlEmpleados.Visible = false;
      }

      private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
      {
         pnlEmpleados.Visible = true;
         pnlRegistro.Visible = false;      //Para llenar el DataGridView con los datos de los empleados.
         pnlEliminar.Visible = false;      //Datos obtenidos con el metodo consultaEmpleado de la clase Conexion.

         int n = dataGridView1.Rows.Add();
         obj = new Conexion();
         Empleado[] arreglo = obj.ConsultaEmpleados();


         for (int i = 0; i < arreglo.Length; i++)
         {
            dataGridView1.Rows[i].Cells[0].Value = arreglo[i].getDocumento();
            dataGridView1.Rows[i].Cells[1].Value = arreglo[i].getNombre();
            dataGridView1.Rows[i].Cells[2].Value = arreglo[i].getClave();
            dataGridView1.Rows.Add();
         }

      }

      private void btnEliminarUsuario_Click(object sender, EventArgs e)
      {
         SingUp obj = new SingUp();
         obj.EliminarUsuario(txtDocEliminar.Text, txtTipEliminar.Text);
      }
   }
}
