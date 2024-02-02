namespace Sistema_de_Ventas
{
   partial class Menu
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
         System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
         this.toolStrip1 = new System.Windows.Forms.ToolStrip();
         this.UsuariosTool = new System.Windows.Forms.ToolStripButton();
         this.RegistrarTool = new System.Windows.Forms.ToolStripButton();
         this.ActualizarTool = new System.Windows.Forms.ToolStripButton();
         this.VentaTool = new System.Windows.Forms.ToolStripButton();
         this.CompraTool = new System.Windows.Forms.ToolStripButton();
         this.ProductosTool = new System.Windows.Forms.ToolStripButton();
         this.Dtgv = new System.Windows.Forms.DataGridView();
         this.btnActualizar = new System.Windows.Forms.Button();
         this.toolStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.Dtgv)).BeginInit();
         this.SuspendLayout();
         // 
         // toolStrip1
         // 
         this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsuariosTool,
            this.RegistrarTool,
            this.ActualizarTool,
            this.VentaTool,
            this.CompraTool,
            this.ProductosTool});
         this.toolStrip1.Location = new System.Drawing.Point(0, 0);
         this.toolStrip1.Name = "toolStrip1";
         this.toolStrip1.Size = new System.Drawing.Size(602, 25);
         this.toolStrip1.TabIndex = 0;
         this.toolStrip1.Text = "toolStrip1";
         // 
         // UsuariosTool
         // 
         this.UsuariosTool.AutoSize = false;
         this.UsuariosTool.Image = ((System.Drawing.Image)(resources.GetObject("UsuariosTool.Image")));
         this.UsuariosTool.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.UsuariosTool.Name = "UsuariosTool";
         this.UsuariosTool.Size = new System.Drawing.Size(75, 35);
         this.UsuariosTool.Text = "Usuarios";
         this.UsuariosTool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
         this.UsuariosTool.Visible = false;
         this.UsuariosTool.Click += new System.EventHandler(this.UsuariosTool_Click);
         // 
         // RegistrarTool
         // 
         this.RegistrarTool.Image = ((System.Drawing.Image)(resources.GetObject("RegistrarTool.Image")));
         this.RegistrarTool.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.RegistrarTool.Name = "RegistrarTool";
         this.RegistrarTool.Size = new System.Drawing.Size(105, 35);
         this.RegistrarTool.Text = "Nuevo Usuario";
         this.RegistrarTool.Visible = false;
         this.RegistrarTool.Click += new System.EventHandler(this.RegistrarTool_Click);
         // 
         // ActualizarTool
         // 
         this.ActualizarTool.Image = ((System.Drawing.Image)(resources.GetObject("ActualizarTool.Image")));
         this.ActualizarTool.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.ActualizarTool.Name = "ActualizarTool";
         this.ActualizarTool.Size = new System.Drawing.Size(122, 35);
         this.ActualizarTool.Text = "Actualizar Usuario";
         this.ActualizarTool.Visible = false;
         this.ActualizarTool.Click += new System.EventHandler(this.ActualizarTool_Click);
         // 
         // VentaTool
         // 
         this.VentaTool.AutoSize = false;
         this.VentaTool.Image = ((System.Drawing.Image)(resources.GetObject("VentaTool.Image")));
         this.VentaTool.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.VentaTool.Name = "VentaTool";
         this.VentaTool.Size = new System.Drawing.Size(80, 35);
         this.VentaTool.Text = "Venta";
         this.VentaTool.Visible = false;
         this.VentaTool.Click += new System.EventHandler(this.VentaTool_Click);
         // 
         // CompraTool
         // 
         this.CompraTool.AutoSize = false;
         this.CompraTool.Image = ((System.Drawing.Image)(resources.GetObject("CompraTool.Image")));
         this.CompraTool.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.CompraTool.Name = "CompraTool";
         this.CompraTool.Size = new System.Drawing.Size(80, 35);
         this.CompraTool.Text = "Compra";
         this.CompraTool.Visible = false;
         // 
         // ProductosTool
         // 
         this.ProductosTool.AutoSize = false;
         this.ProductosTool.Image = ((System.Drawing.Image)(resources.GetObject("ProductosTool.Image")));
         this.ProductosTool.ImageTransparentColor = System.Drawing.Color.Magenta;
         this.ProductosTool.Name = "ProductosTool";
         this.ProductosTool.Size = new System.Drawing.Size(90, 35);
         this.ProductosTool.Text = "Productos";
         this.ProductosTool.Visible = false;
         this.ProductosTool.Click += new System.EventHandler(this.ProductosTool_Click);
         // 
         // Dtgv
         // 
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
         this.Dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
         this.Dtgv.BackgroundColor = System.Drawing.Color.PeachPuff;
         dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
         dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
         dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
         dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
         this.Dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
         this.Dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.Dtgv.Location = new System.Drawing.Point(27, 125);
         this.Dtgv.Name = "Dtgv";
         dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
         dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleGreen;
         this.Dtgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
         this.Dtgv.Size = new System.Drawing.Size(546, 249);
         this.Dtgv.TabIndex = 5;
         this.Dtgv.Visible = false;
         // 
         // btnActualizar
         // 
         this.btnActualizar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
         this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
         this.btnActualizar.Location = new System.Drawing.Point(502, 380);
         this.btnActualizar.Name = "btnActualizar";
         this.btnActualizar.Size = new System.Drawing.Size(61, 39);
         this.btnActualizar.TabIndex = 6;
         this.btnActualizar.UseVisualStyleBackColor = false;
         this.btnActualizar.Visible = false;
         this.btnActualizar.Click += new System.EventHandler(this.UsuariosTool_Click);
         // 
         // Menu
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.ClientSize = new System.Drawing.Size(602, 431);
         this.Controls.Add(this.btnActualizar);
         this.Controls.Add(this.Dtgv);
         this.Controls.Add(this.toolStrip1);
         this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MaximizeBox = false;
         this.Name = "Menu";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "MENU";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
         this.toolStrip1.ResumeLayout(false);
         this.toolStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.Dtgv)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.ToolStrip toolStrip1;
      private System.Windows.Forms.ToolStripButton UsuariosTool;
      private System.Windows.Forms.ToolStripButton RegistrarTool;
      private System.Windows.Forms.ToolStripButton ActualizarTool;
      private System.Windows.Forms.ToolStripButton VentaTool;
      private System.Windows.Forms.ToolStripButton CompraTool;
      private System.Windows.Forms.ToolStripButton ProductosTool;
      public System.Windows.Forms.DataGridView Dtgv;
      private System.Windows.Forms.Button btnActualizar;
   }
}