using Sistema_de_Ventas.Clases;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_de_Ventas.Forms
{
   public partial class Venta : Form
   {
      double total = 0;
      ManejoDeErrores error = new ManejoDeErrores();
      public Venta()
      {
         InitializeComponent();
      }

      private void Venta_Load(object sender, EventArgs e)
      {

      }

      private void btnAgregar_Click(object sender, EventArgs e)
      {
         using(var form = new ProductoVenta())
         {
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
               DtgvVenta.Rows.Add(form.IdProducto, form.Nombre,form.Descripcion,form.Precio, form.Cantidad,form.Importe);
               total += form.total;
            }
            lblTotal.Text = total.ToString();
         }
      }

      private void btnFinalizar_Click(object sender, EventArgs e)
      {
         if (Convert.ToDouble(txtPagoCon.Text) >= Convert.ToDouble(lblTotal.Text))
         {
            SqlConnection conexiondb = new SqlConnection("server=HP-EMILIO\\SQLEXPRESS; database=DBPUNTO_VENTA; integrated security = true");
            conexiondb.Open();
            double cambio = Convert.ToDouble(txtPagoCon.Text) - Convert.ToDouble(lblTotal.Text);
            string cadena = "INSERT INTO VENTA OUTPUT Inserted.IdVenta VALUES('Boleta', '000001', 1, '1000', 'Publico en general', " + Convert.ToDecimal(lblTotal.Text) + ", " + Convert.ToDecimal(txtPagoCon.Text) + ", " + cambio.ToString() + ", getdate()); ";
            SqlCommand comando = new SqlCommand(cadena, conexiondb);
            //int id = comando.ExecuteNonQuery();
            int idVenta = (int)comando.ExecuteScalar();

            foreach (DataGridViewRow row in  DtgvVenta.Rows)
            {
               if (Convert.ToInt32(row.Cells["Cantidad"].Value) > 0)
               {
                  double subtotal = Convert.ToDouble(row.Cells["Cantidad"].Value) * Convert.ToDouble(row.Cells["Precio"].Value);
                  string cadenadetalle = "INSERT INTO DETALLE_VENTA VALUES(" + idVenta.ToString() + ", " + row.Cells["Codigo"].Value.ToString() + "," + row.Cells["Cantidad"].Value.ToString() + ", " + row.Cells["Precio"].Value.ToString() + ", " + subtotal.ToString() + ", GETDATE()); ";
                  SqlCommand comando2 = new SqlCommand(cadenadetalle, conexiondb);
                  comando2.ExecuteNonQuery();
                  string cadena2 = $"UPDATE PRODUCTO SET Stock = Stock - {Convert.ToInt32(row.Cells["Cantidad"].Value)} WHERE Codigo = {Convert.ToInt32(row.Cells["Codigo"].Value)}";
                  SqlCommand comando3 = new SqlCommand(cadena2, conexiondb);
                  comando3.ExecuteNonQuery();
               }
            }
            lblTotal.Text = "00.00";
            txtPagoCon.Clear();
            DtgvVenta.Rows.Clear();
            MessageBox.Show($"Cambio: ${cambio}", "CAMBIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }
      }
        
   }
}
