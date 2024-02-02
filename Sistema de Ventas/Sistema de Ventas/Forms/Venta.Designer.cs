namespace Sistema_de_Ventas.Forms
{
   partial class Venta
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
         this.DtgvVenta = new System.Windows.Forms.DataGridView();
         this.btnAgregar = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.lblTotal = new System.Windows.Forms.Label();
         this.txtPagoCon = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.btnFinalizar = new System.Windows.Forms.Button();
         this.label3 = new System.Windows.Forms.Label();
         this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
         ((System.ComponentModel.ISupportInitialize)(this.DtgvVenta)).BeginInit();
         this.SuspendLayout();
         // 
         // DtgvVenta
         // 
         this.DtgvVenta.BackgroundColor = System.Drawing.Color.PeachPuff;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCoral;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.DtgvVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.DtgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.DtgvVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Importe});
         this.DtgvVenta.Location = new System.Drawing.Point(14, 16);
         this.DtgvVenta.Margin = new System.Windows.Forms.Padding(4);
         this.DtgvVenta.Name = "DtgvVenta";
         this.DtgvVenta.ReadOnly = true;
         this.DtgvVenta.Size = new System.Drawing.Size(644, 305);
         this.DtgvVenta.TabIndex = 0;
         // 
         // btnAgregar
         // 
         this.btnAgregar.BackColor = System.Drawing.Color.LimeGreen;
         this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
         this.btnAgregar.Location = new System.Drawing.Point(676, 25);
         this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(60, 46);
         this.btnAgregar.TabIndex = 1;
         this.btnAgregar.UseVisualStyleBackColor = false;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(676, 300);
         this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(60, 21);
         this.label1.TabIndex = 2;
         this.label1.Text = "TOTAL:";
         // 
         // lblTotal
         // 
         this.lblTotal.AutoSize = true;
         this.lblTotal.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotal.Location = new System.Drawing.Point(754, 300);
         this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lblTotal.Name = "lblTotal";
         this.lblTotal.Size = new System.Drawing.Size(54, 21);
         this.lblTotal.TabIndex = 3;
         this.lblTotal.Text = "00.00";
         // 
         // txtPagoCon
         // 
         this.txtPagoCon.Location = new System.Drawing.Point(743, 106);
         this.txtPagoCon.Name = "txtPagoCon";
         this.txtPagoCon.Size = new System.Drawing.Size(100, 25);
         this.txtPagoCon.TabIndex = 4;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(672, 109);
         this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(64, 17);
         this.label2.TabIndex = 5;
         this.label2.Text = "Paga Con";
         // 
         // btnFinalizar
         // 
         this.btnFinalizar.BackColor = System.Drawing.Color.Turquoise;
         this.btnFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.Image")));
         this.btnFinalizar.Location = new System.Drawing.Point(767, 25);
         this.btnFinalizar.Margin = new System.Windows.Forms.Padding(4);
         this.btnFinalizar.Name = "btnFinalizar";
         this.btnFinalizar.Size = new System.Drawing.Size(60, 51);
         this.btnFinalizar.TabIndex = 6;
         this.btnFinalizar.UseVisualStyleBackColor = false;
         this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(735, 300);
         this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(20, 21);
         this.label3.TabIndex = 7;
         this.label3.Text = "$";
         // 
         // Codigo
         // 
         this.Codigo.HeaderText = "Codigo";
         this.Codigo.Name = "Codigo";
         this.Codigo.ReadOnly = true;
         // 
         // Nombre
         // 
         this.Nombre.HeaderText = "Nombre";
         this.Nombre.Name = "Nombre";
         this.Nombre.ReadOnly = true;
         // 
         // Descripcion
         // 
         this.Descripcion.HeaderText = "Descripcion";
         this.Descripcion.Name = "Descripcion";
         this.Descripcion.ReadOnly = true;
         // 
         // Precio
         // 
         this.Precio.HeaderText = "Precio";
         this.Precio.Name = "Precio";
         this.Precio.ReadOnly = true;
         // 
         // Cantidad
         // 
         this.Cantidad.HeaderText = "Cantidad";
         this.Cantidad.Name = "Cantidad";
         this.Cantidad.ReadOnly = true;
         // 
         // Importe
         // 
         this.Importe.HeaderText = "Importe";
         this.Importe.Name = "Importe";
         this.Importe.ReadOnly = true;
         // 
         // Venta
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.PaleGreen;
         this.ClientSize = new System.Drawing.Size(845, 355);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.btnFinalizar);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtPagoCon);
         this.Controls.Add(this.lblTotal);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnAgregar);
         this.Controls.Add(this.DtgvVenta);
         this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4);
         this.Name = "Venta";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Venta";
         this.Load += new System.EventHandler(this.Venta_Load);
         ((System.ComponentModel.ISupportInitialize)(this.DtgvVenta)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      public System.Windows.Forms.DataGridView DtgvVenta;
      private System.Windows.Forms.Button btnAgregar;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblTotal;
      private System.Windows.Forms.TextBox txtPagoCon;
      private System.Windows.Forms.Label label2;
      public System.Windows.Forms.Button btnFinalizar;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
      private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
      private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
      private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
      private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
      private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
   }
}