namespace Sistema_de_Ventas.Forms
{
   partial class Productos
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
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Productos));
         this.DtgvProducto = new System.Windows.Forms.DataGridView();
         this.btnAgregar = new System.Windows.Forms.Button();
         this.btnEliminar = new System.Windows.Forms.Button();
         this.txtStock = new System.Windows.Forms.TextBox();
         this.txtPrecioVent = new System.Windows.Forms.TextBox();
         this.txtPrecioComp = new System.Windows.Forms.TextBox();
         this.txtDescripcion = new System.Windows.Forms.TextBox();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
         this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
         this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
         this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
         this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
         this.txtId = new System.Windows.Forms.TextBox();
         this.btnLimpiar = new System.Windows.Forms.Button();
         ((System.ComponentModel.ISupportInitialize)(this.DtgvProducto)).BeginInit();
         this.SuspendLayout();
         // 
         // DtgvProducto
         // 
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.DeepSkyBlue;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.MediumBlue;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.DtgvProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
         this.DtgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightBlue;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(1);
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.DtgvProducto.DefaultCellStyle = dataGridViewCellStyle2;
         this.DtgvProducto.Location = new System.Drawing.Point(12, 12);
         this.DtgvProducto.Name = "DtgvProducto";
         this.DtgvProducto.Size = new System.Drawing.Size(637, 232);
         this.DtgvProducto.TabIndex = 0;
         this.DtgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvProducto_CellClick);
         this.DtgvProducto.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvProducto_CellEndEdit);
         // 
         // btnAgregar
         // 
         this.btnAgregar.Location = new System.Drawing.Point(352, 343);
         this.btnAgregar.Name = "btnAgregar";
         this.btnAgregar.Size = new System.Drawing.Size(91, 39);
         this.btnAgregar.TabIndex = 12;
         this.btnAgregar.Text = "Agregar";
         this.btnAgregar.UseVisualStyleBackColor = true;
         this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
         // 
         // btnEliminar
         // 
         this.btnEliminar.Enabled = false;
         this.btnEliminar.Location = new System.Drawing.Point(473, 343);
         this.btnEliminar.Name = "btnEliminar";
         this.btnEliminar.Size = new System.Drawing.Size(91, 39);
         this.btnEliminar.TabIndex = 14;
         this.btnEliminar.Text = "Eliminar";
         this.btnEliminar.UseVisualStyleBackColor = true;
         this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
         // 
         // txtStock
         // 
         this.txtStock.BackColor = System.Drawing.Color.LightGray;
         this.txtStock.Location = new System.Drawing.Point(204, 351);
         this.txtStock.Name = "txtStock";
         this.txtStock.Size = new System.Drawing.Size(100, 20);
         this.txtStock.TabIndex = 6;
         // 
         // txtPrecioVent
         // 
         this.txtPrecioVent.BackColor = System.Drawing.Color.LightGray;
         this.txtPrecioVent.Location = new System.Drawing.Point(204, 433);
         this.txtPrecioVent.Name = "txtPrecioVent";
         this.txtPrecioVent.Size = new System.Drawing.Size(100, 20);
         this.txtPrecioVent.TabIndex = 10;
         // 
         // txtPrecioComp
         // 
         this.txtPrecioComp.BackColor = System.Drawing.Color.LightGray;
         this.txtPrecioComp.Location = new System.Drawing.Point(203, 396);
         this.txtPrecioComp.Name = "txtPrecioComp";
         this.txtPrecioComp.Size = new System.Drawing.Size(100, 20);
         this.txtPrecioComp.TabIndex = 8;
         // 
         // txtDescripcion
         // 
         this.txtDescripcion.BackColor = System.Drawing.Color.LightGray;
         this.txtDescripcion.Location = new System.Drawing.Point(204, 304);
         this.txtDescripcion.Name = "txtDescripcion";
         this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
         this.txtDescripcion.TabIndex = 4;
         // 
         // txtNombre
         // 
         this.txtNombre.BackColor = System.Drawing.Color.LightGray;
         this.txtNombre.Location = new System.Drawing.Point(204, 260);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(100, 20);
         this.txtNombre.TabIndex = 2;
         // 
         // materialLabel5
         // 
         this.materialLabel5.AutoSize = true;
         this.materialLabel5.Depth = 0;
         this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
         this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.materialLabel5.Location = new System.Drawing.Point(88, 434);
         this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialLabel5.Name = "materialLabel5";
         this.materialLabel5.Size = new System.Drawing.Size(91, 19);
         this.materialLabel5.TabIndex = 18;
         this.materialLabel5.Text = "PrecioVenta";
         // 
         // materialLabel4
         // 
         this.materialLabel4.AutoSize = true;
         this.materialLabel4.Depth = 0;
         this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
         this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.materialLabel4.Location = new System.Drawing.Point(88, 395);
         this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialLabel4.Name = "materialLabel4";
         this.materialLabel4.Size = new System.Drawing.Size(105, 19);
         this.materialLabel4.TabIndex = 17;
         this.materialLabel4.Text = "PrecioCompra";
         // 
         // materialLabel3
         // 
         this.materialLabel3.AutoSize = true;
         this.materialLabel3.Depth = 0;
         this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
         this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.materialLabel3.Location = new System.Drawing.Point(88, 303);
         this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialLabel3.Name = "materialLabel3";
         this.materialLabel3.Size = new System.Drawing.Size(89, 19);
         this.materialLabel3.TabIndex = 16;
         this.materialLabel3.Text = "Descripcion";
         // 
         // materialLabel1
         // 
         this.materialLabel1.AutoSize = true;
         this.materialLabel1.Depth = 0;
         this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
         this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.materialLabel1.Location = new System.Drawing.Point(88, 352);
         this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialLabel1.Name = "materialLabel1";
         this.materialLabel1.Size = new System.Drawing.Size(48, 19);
         this.materialLabel1.TabIndex = 15;
         this.materialLabel1.Text = "Stock";
         // 
         // materialLabel2
         // 
         this.materialLabel2.AutoSize = true;
         this.materialLabel2.Depth = 0;
         this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
         this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.materialLabel2.Location = new System.Drawing.Point(88, 259);
         this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
         this.materialLabel2.Name = "materialLabel2";
         this.materialLabel2.Size = new System.Drawing.Size(63, 19);
         this.materialLabel2.TabIndex = 14;
         this.materialLabel2.Text = "Nombre";
         // 
         // txtId
         // 
         this.txtId.Location = new System.Drawing.Point(549, 250);
         this.txtId.Name = "txtId";
         this.txtId.Size = new System.Drawing.Size(100, 20);
         this.txtId.TabIndex = 24;
         this.txtId.Visible = false;
         // 
         // btnLimpiar
         // 
         this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
         this.btnLimpiar.Location = new System.Drawing.Point(352, 260);
         this.btnLimpiar.Name = "btnLimpiar";
         this.btnLimpiar.Size = new System.Drawing.Size(46, 45);
         this.btnLimpiar.TabIndex = 16;
         this.btnLimpiar.UseVisualStyleBackColor = true;
         this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
         // 
         // Productos
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Coral;
         this.ClientSize = new System.Drawing.Size(661, 464);
         this.Controls.Add(this.btnLimpiar);
         this.Controls.Add(this.txtId);
         this.Controls.Add(this.txtStock);
         this.Controls.Add(this.txtPrecioVent);
         this.Controls.Add(this.txtPrecioComp);
         this.Controls.Add(this.txtDescripcion);
         this.Controls.Add(this.txtNombre);
         this.Controls.Add(this.materialLabel5);
         this.Controls.Add(this.materialLabel4);
         this.Controls.Add(this.materialLabel3);
         this.Controls.Add(this.materialLabel1);
         this.Controls.Add(this.materialLabel2);
         this.Controls.Add(this.btnEliminar);
         this.Controls.Add(this.btnAgregar);
         this.Controls.Add(this.DtgvProducto);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Productos";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Productos";
         ((System.ComponentModel.ISupportInitialize)(this.DtgvProducto)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView DtgvProducto;
      private System.Windows.Forms.Button btnAgregar;
      private System.Windows.Forms.Button btnEliminar;
      private System.Windows.Forms.TextBox txtStock;
      private System.Windows.Forms.TextBox txtPrecioVent;
      private System.Windows.Forms.TextBox txtPrecioComp;
      private System.Windows.Forms.TextBox txtDescripcion;
      private System.Windows.Forms.TextBox txtNombre;
      private MaterialSkin.Controls.MaterialLabel materialLabel5;
      private MaterialSkin.Controls.MaterialLabel materialLabel4;
      private MaterialSkin.Controls.MaterialLabel materialLabel3;
      private MaterialSkin.Controls.MaterialLabel materialLabel1;
      private MaterialSkin.Controls.MaterialLabel materialLabel2;
      private System.Windows.Forms.TextBox txtId;
      private System.Windows.Forms.Button btnLimpiar;
   }
}