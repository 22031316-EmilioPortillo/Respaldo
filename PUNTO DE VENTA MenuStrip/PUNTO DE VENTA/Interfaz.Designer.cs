namespace PUNTO_DE_VENTA
{
   partial class Form2
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
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
         this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.txtUsuarioRegistro = new System.Windows.Forms.TextBox();
         this.txtContraseñaRegistro = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.cmbCuenta = new System.Windows.Forms.ComboBox();
         this.btnRegistro = new System.Windows.Forms.Button();
         this.pnlRegistro = new System.Windows.Forms.Panel();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtDocEliminar = new System.Windows.Forms.TextBox();
         this.txtTipEliminar = new System.Windows.Forms.TextBox();
         this.pnlEliminar = new System.Windows.Forms.Panel();
         this.btnEliminarUsuario = new System.Windows.Forms.Button();
         this.menuStrip1 = new System.Windows.Forms.MenuStrip();
         this.adminTool = new System.Windows.Forms.ToolStripMenuItem();
         this.registrarNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.eliminiarUnUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.configracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.empleadoTool = new System.Windows.Forms.ToolStripMenuItem();
         this.realizarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.columnDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.column = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.columnClave = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.pnlEmpleados = new System.Windows.Forms.Panel();
         this.label6 = new System.Windows.Forms.Label();
         this.pnlRegistro.SuspendLayout();
         this.pnlEliminar.SuspendLayout();
         this.menuStrip1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.pnlEmpleados.SuspendLayout();
         this.SuspendLayout();
         // 
         // contextMenuStrip1
         // 
         this.contextMenuStrip1.Name = "contextMenuStrip1";
         this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.Color.Azure;
         this.label4.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(14, 50);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(83, 25);
         this.label4.TabIndex = 19;
         this.label4.Text = "Usuario";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.White;
         this.label3.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(14, 95);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(118, 25);
         this.label3.TabIndex = 20;
         this.label3.Text = "&Contraseña";
         // 
         // txtUsuarioRegistro
         // 
         this.txtUsuarioRegistro.Location = new System.Drawing.Point(158, 55);
         this.txtUsuarioRegistro.Name = "txtUsuarioRegistro";
         this.txtUsuarioRegistro.Size = new System.Drawing.Size(121, 20);
         this.txtUsuarioRegistro.TabIndex = 21;
         // 
         // txtContraseñaRegistro
         // 
         this.txtContraseñaRegistro.Location = new System.Drawing.Point(158, 100);
         this.txtContraseñaRegistro.Name = "txtContraseñaRegistro";
         this.txtContraseñaRegistro.Size = new System.Drawing.Size(121, 20);
         this.txtContraseñaRegistro.TabIndex = 22;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.BackColor = System.Drawing.Color.White;
         this.label5.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(14, 151);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(79, 25);
         this.label5.TabIndex = 23;
         this.label5.Text = "&Cuenta";
         // 
         // cmbCuenta
         // 
         this.cmbCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbCuenta.FormattingEnabled = true;
         this.cmbCuenta.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
         this.cmbCuenta.Location = new System.Drawing.Point(158, 151);
         this.cmbCuenta.Name = "cmbCuenta";
         this.cmbCuenta.Size = new System.Drawing.Size(121, 21);
         this.cmbCuenta.TabIndex = 24;
         // 
         // btnRegistro
         // 
         this.btnRegistro.BackColor = System.Drawing.Color.White;
         this.btnRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnRegistro.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnRegistro.ForeColor = System.Drawing.Color.Black;
         this.btnRegistro.Location = new System.Drawing.Point(353, 173);
         this.btnRegistro.Name = "btnRegistro";
         this.btnRegistro.Size = new System.Drawing.Size(95, 44);
         this.btnRegistro.TabIndex = 25;
         this.btnRegistro.Text = "Registrarse";
         this.btnRegistro.UseVisualStyleBackColor = false;
         this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
         // 
         // pnlRegistro
         // 
         this.pnlRegistro.BackColor = System.Drawing.SystemColors.MenuBar;
         this.pnlRegistro.Controls.Add(this.btnRegistro);
         this.pnlRegistro.Controls.Add(this.cmbCuenta);
         this.pnlRegistro.Controls.Add(this.label5);
         this.pnlRegistro.Controls.Add(this.txtContraseñaRegistro);
         this.pnlRegistro.Controls.Add(this.txtUsuarioRegistro);
         this.pnlRegistro.Controls.Add(this.label3);
         this.pnlRegistro.Controls.Add(this.label4);
         this.pnlRegistro.Location = new System.Drawing.Point(149, 139);
         this.pnlRegistro.Name = "pnlRegistro";
         this.pnlRegistro.Size = new System.Drawing.Size(463, 267);
         this.pnlRegistro.TabIndex = 1;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(15, 120);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(103, 21);
         this.label1.TabIndex = 0;
         this.label1.Text = "Tipo Cuenta";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(15, 55);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 21);
         this.label2.TabIndex = 1;
         this.label2.Text = "Documento";
         // 
         // txtDocEliminar
         // 
         this.txtDocEliminar.Location = new System.Drawing.Point(142, 55);
         this.txtDocEliminar.Name = "txtDocEliminar";
         this.txtDocEliminar.Size = new System.Drawing.Size(100, 20);
         this.txtDocEliminar.TabIndex = 2;
         // 
         // txtTipEliminar
         // 
         this.txtTipEliminar.Location = new System.Drawing.Point(142, 121);
         this.txtTipEliminar.Name = "txtTipEliminar";
         this.txtTipEliminar.Size = new System.Drawing.Size(100, 20);
         this.txtTipEliminar.TabIndex = 3;
         // 
         // pnlEliminar
         // 
         this.pnlEliminar.BackColor = System.Drawing.SystemColors.ControlLight;
         this.pnlEliminar.Controls.Add(this.btnEliminarUsuario);
         this.pnlEliminar.Controls.Add(this.txtTipEliminar);
         this.pnlEliminar.Controls.Add(this.txtDocEliminar);
         this.pnlEliminar.Controls.Add(this.label2);
         this.pnlEliminar.Controls.Add(this.label1);
         this.pnlEliminar.Location = new System.Drawing.Point(146, 136);
         this.pnlEliminar.Name = "pnlEliminar";
         this.pnlEliminar.Size = new System.Drawing.Size(463, 267);
         this.pnlEliminar.TabIndex = 26;
         // 
         // btnEliminarUsuario
         // 
         this.btnEliminarUsuario.BackColor = System.Drawing.Color.White;
         this.btnEliminarUsuario.Location = new System.Drawing.Point(312, 160);
         this.btnEliminarUsuario.Name = "btnEliminarUsuario";
         this.btnEliminarUsuario.Size = new System.Drawing.Size(96, 45);
         this.btnEliminarUsuario.TabIndex = 4;
         this.btnEliminarUsuario.Text = "Eliminar";
         this.btnEliminarUsuario.UseVisualStyleBackColor = false;
         this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
         // 
         // menuStrip1
         // 
         this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminTool,
            this.empleadoTool});
         this.menuStrip1.Location = new System.Drawing.Point(0, 0);
         this.menuStrip1.Name = "menuStrip1";
         this.menuStrip1.Size = new System.Drawing.Size(800, 24);
         this.menuStrip1.TabIndex = 27;
         this.menuStrip1.Text = "MENU PRINCIPAL";
         // 
         // adminTool
         // 
         this.adminTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarNuevoUsuarioToolStripMenuItem,
            this.eliminiarUnUsuarioToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.configracionToolStripMenuItem});
         this.adminTool.Image = ((System.Drawing.Image)(resources.GetObject("adminTool.Image")));
         this.adminTool.Name = "adminTool";
         this.adminTool.Size = new System.Drawing.Size(83, 20);
         this.adminTool.Text = "Acciones";
         // 
         // registrarNuevoUsuarioToolStripMenuItem
         // 
         this.registrarNuevoUsuarioToolStripMenuItem.Name = "registrarNuevoUsuarioToolStripMenuItem";
         this.registrarNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
         this.registrarNuevoUsuarioToolStripMenuItem.Text = "Registrar nuevo usuario";
         this.registrarNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoUsuarioToolStripMenuItem_Click_1);
         // 
         // eliminiarUnUsuarioToolStripMenuItem
         // 
         this.eliminiarUnUsuarioToolStripMenuItem.Name = "eliminiarUnUsuarioToolStripMenuItem";
         this.eliminiarUnUsuarioToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
         this.eliminiarUnUsuarioToolStripMenuItem.Text = "Eliminiar un Usuario";
         this.eliminiarUnUsuarioToolStripMenuItem.Click += new System.EventHandler(this.eliminiarUnUsuarioToolStripMenuItem_Click);
         // 
         // empleadosToolStripMenuItem
         // 
         this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
         this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
         this.empleadosToolStripMenuItem.Text = "Empleados";
         this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
         // 
         // configracionToolStripMenuItem
         // 
         this.configracionToolStripMenuItem.Name = "configracionToolStripMenuItem";
         this.configracionToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
         this.configracionToolStripMenuItem.Text = "Configracion";
         // 
         // empleadoTool
         // 
         this.empleadoTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarVentaToolStripMenuItem,
            this.historialToolStripMenuItem,
            this.perfilToolStripMenuItem,
            this.configuracionToolStripMenuItem});
         this.empleadoTool.Image = ((System.Drawing.Image)(resources.GetObject("empleadoTool.Image")));
         this.empleadoTool.Name = "empleadoTool";
         this.empleadoTool.Size = new System.Drawing.Size(83, 20);
         this.empleadoTool.Text = "Acciones";
         // 
         // realizarVentaToolStripMenuItem
         // 
         this.realizarVentaToolStripMenuItem.Name = "realizarVentaToolStripMenuItem";
         this.realizarVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.realizarVentaToolStripMenuItem.Text = "Realizar Venta";
         // 
         // historialToolStripMenuItem
         // 
         this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
         this.historialToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.historialToolStripMenuItem.Text = "Historial";
         // 
         // perfilToolStripMenuItem
         // 
         this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
         this.perfilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.perfilToolStripMenuItem.Text = "Perfil";
         // 
         // configuracionToolStripMenuItem
         // 
         this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
         this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
         this.configuracionToolStripMenuItem.Text = "Configuracion ";
         // 
         // dataGridView1
         // 
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnDoc,
            this.column,
            this.columnClave});
         this.dataGridView1.Location = new System.Drawing.Point(98, 79);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(345, 194);
         this.dataGridView1.TabIndex = 28;
         // 
         // columnDoc
         // 
         this.columnDoc.HeaderText = "Documento";
         this.columnDoc.Name = "columnDoc";
         this.columnDoc.ReadOnly = true;
         // 
         // column
         // 
         this.column.HeaderText = "Nombre";
         this.column.Name = "column";
         this.column.ReadOnly = true;
         // 
         // columnClave
         // 
         this.columnClave.HeaderText = "Clave";
         this.columnClave.Name = "columnClave";
         this.columnClave.ReadOnly = true;
         // 
         // pnlEmpleados
         // 
         this.pnlEmpleados.Controls.Add(this.label6);
         this.pnlEmpleados.Controls.Add(this.dataGridView1);
         this.pnlEmpleados.Location = new System.Drawing.Point(127, 135);
         this.pnlEmpleados.Name = "pnlEmpleados";
         this.pnlEmpleados.Size = new System.Drawing.Size(537, 303);
         this.pnlEmpleados.TabIndex = 29;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(200, 21);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(117, 26);
         this.label6.TabIndex = 29;
         this.label6.Text = "Empleados";
         // 
         // Form2
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.GrayText;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.pnlEmpleados);
         this.Controls.Add(this.menuStrip1);
         this.Controls.Add(this.pnlEliminar);
         this.Controls.Add(this.pnlRegistro);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "Form2";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "INTERFAZ PRINCIPAL";
         this.pnlRegistro.ResumeLayout(false);
         this.pnlRegistro.PerformLayout();
         this.pnlEliminar.ResumeLayout(false);
         this.pnlEliminar.PerformLayout();
         this.menuStrip1.ResumeLayout(false);
         this.menuStrip1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.pnlEmpleados.ResumeLayout(false);
         this.pnlEmpleados.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox txtUsuarioRegistro;
      private System.Windows.Forms.TextBox txtContraseñaRegistro;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.ComboBox cmbCuenta;
      private System.Windows.Forms.Button btnRegistro;
      public System.Windows.Forms.Panel pnlRegistro;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtDocEliminar;
      private System.Windows.Forms.TextBox txtTipEliminar;
      private System.Windows.Forms.Panel pnlEliminar;
      private System.Windows.Forms.Button btnEliminarUsuario;
      public System.Windows.Forms.MenuStrip menuStrip1;
      public System.Windows.Forms.ToolStripMenuItem adminTool;
      private System.Windows.Forms.ToolStripMenuItem registrarNuevoUsuarioToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem eliminiarUnUsuarioToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem configracionToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem empleadoTool;
      private System.Windows.Forms.ToolStripMenuItem realizarVentaToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
      private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
      private System.Windows.Forms.DataGridView dataGridView1;
      public System.Windows.Forms.Panel pnlEmpleados;
      private System.Windows.Forms.DataGridViewTextBoxColumn columnDoc;
      private System.Windows.Forms.DataGridViewTextBoxColumn column;
      private System.Windows.Forms.DataGridViewTextBoxColumn columnClave;
      private System.Windows.Forms.Label label6;
   }
}