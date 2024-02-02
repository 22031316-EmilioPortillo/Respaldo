namespace Sistema_de_Ventas.Forms
{
   partial class ProductoVenta
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoVenta));
         this.DtgvProductoVenta = new System.Windows.Forms.DataGridView();
         this.txtId = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.txtPrecio = new System.Windows.Forms.TextBox();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.txtDescripcion = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.btnAgregar = new System.Windows.Forms.Button();
         this.txtTotal = new System.Windows.Forms.TextBox();
         this.txtCantidad = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.txtStock = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.DtgvProductoVenta)).BeginInit();
         this.SuspendLayout();
         // 
         // DtgvProductoVenta
         // 
         this.DtgvProductoVenta.BackgroundColor = System.Drawing.Color.PeachPuff;
         this.DtgvProductoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.DtgvProductoVenta.Location = new System.Drawing.Point(12, 13);
         this.DtgvProductoVenta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.DtgvProductoVenta.Name = "DtgvProductoVenta";
         this.DtgvProductoVenta.ReadOnly = true;
         this.DtgvProductoVenta.Size = new System.Drawing.Size(523, 196);
         this.DtgvProductoVenta.TabIndex = 0;
         this.DtgvProductoVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvProductoVenta_CellClick);
         // 
         // txtId
         // 
         this.txtId.BackColor = System.Drawing.Color.MistyRose;
         this.txtId.Location = new System.Drawing.Point(653, 22);
         this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.txtId.Name = "txtId";
         this.txtId.ReadOnly = true;
         this.txtId.Size = new System.Drawing.Size(116, 25);
         this.txtId.TabIndex = 2;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(555, 22);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(20, 17);
         this.label1.TabIndex = 2;
         this.label1.Text = "ID";
         // 
         // txtPrecio
         // 
         this.txtPrecio.BackColor = System.Drawing.Color.MistyRose;
         this.txtPrecio.Location = new System.Drawing.Point(653, 171);
         this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.txtPrecio.Name = "txtPrecio";
         this.txtPrecio.ReadOnly = true;
         this.txtPrecio.Size = new System.Drawing.Size(116, 25);
         this.txtPrecio.TabIndex = 8;
         // 
         // txtNombre
         // 
         this.txtNombre.BackColor = System.Drawing.Color.MistyRose;
         this.txtNombre.Location = new System.Drawing.Point(653, 69);
         this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.ReadOnly = true;
         this.txtNombre.Size = new System.Drawing.Size(116, 25);
         this.txtNombre.TabIndex = 4;
         // 
         // txtDescripcion
         // 
         this.txtDescripcion.BackColor = System.Drawing.Color.MistyRose;
         this.txtDescripcion.Location = new System.Drawing.Point(653, 117);
         this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.txtDescripcion.Name = "txtDescripcion";
         this.txtDescripcion.ReadOnly = true;
         this.txtDescripcion.Size = new System.Drawing.Size(116, 25);
         this.txtDescripcion.TabIndex = 6;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(555, 174);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(44, 17);
         this.label2.TabIndex = 6;
         this.label2.Text = "Precio";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(555, 125);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(76, 17);
         this.label3.TabIndex = 7;
         this.label3.Text = "Descripcion";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(555, 77);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(57, 17);
         this.label4.TabIndex = 8;
         this.label4.Text = "Nombre";
         // 
         // btnAgregar
         // 
         this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
         this.btnAgregar.Enabled = false;
         this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
         this.btnAgregar.Location = new System.Drawing.Point(707, 264);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(62, 50);
         this.btnAgregar.TabIndex = 12;
         this.btnAgregar.UseVisualStyleBackColor = false;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // txtTotal
         // 
         this.txtTotal.Location = new System.Drawing.Point(337, 226);
         this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.txtTotal.Name = "txtTotal";
         this.txtTotal.Size = new System.Drawing.Size(116, 25);
         this.txtTotal.TabIndex = 10;
         this.txtTotal.Visible = false;
         // 
         // txtCantidad
         // 
         this.txtCantidad.BackColor = System.Drawing.Color.MistyRose;
         this.txtCantidad.Location = new System.Drawing.Point(653, 221);
         this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.txtCantidad.Name = "txtCantidad";
         this.txtCantidad.Size = new System.Drawing.Size(116, 25);
         this.txtCantidad.TabIndex = 10;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(555, 225);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(60, 17);
         this.label5.TabIndex = 12;
         this.label5.Text = "Cantidad";
         // 
         // txtStock
         // 
         this.txtStock.Location = new System.Drawing.Point(337, 265);
         this.txtStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.txtStock.Name = "txtStock";
         this.txtStock.Size = new System.Drawing.Size(116, 25);
         this.txtStock.TabIndex = 13;
         this.txtStock.Visible = false;
         // 
         // ProductoVenta
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.PaleGreen;
         this.ClientSize = new System.Drawing.Size(783, 327);
         this.Controls.Add(this.txtStock);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.txtCantidad);
         this.Controls.Add(this.txtTotal);
         this.Controls.Add(this.btnAgregar);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtDescripcion);
         this.Controls.Add(this.txtNombre);
         this.Controls.Add(this.txtPrecio);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.txtId);
         this.Controls.Add(this.DtgvProductoVenta);
         this.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
         this.Name = "ProductoVenta";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ProductoVenta";
         ((System.ComponentModel.ISupportInitialize)(this.DtgvProductoVenta)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView DtgvProductoVenta;
      private System.Windows.Forms.TextBox txtId;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox txtPrecio;
      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.TextBox txtDescripcion;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button btnAgregar;
      private System.Windows.Forms.TextBox txtTotal;
      private System.Windows.Forms.TextBox txtCantidad;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox txtStock;
   }
}