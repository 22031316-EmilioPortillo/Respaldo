namespace Sistema_de_Ventas.Forms
{
   partial class Registro
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
         this.btnRegistrar = new System.Windows.Forms.Button();
         this.cmbTipoPersona = new System.Windows.Forms.ComboBox();
         this.txtNombre = new System.Windows.Forms.TextBox();
         this.txtDireccion = new System.Windows.Forms.TextBox();
         this.txtTelefono = new System.Windows.Forms.TextBox();
         this.txtClave = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtDocumento = new System.Windows.Forms.TextBox();
         this.lbl = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // btnRegistrar
         // 
         this.btnRegistrar.BackColor = System.Drawing.Color.PaleGreen;
         this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
         this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
         this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
         this.btnRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Image")));
         this.btnRegistrar.Location = new System.Drawing.Point(322, 183);
         this.btnRegistrar.Name = "btnRegistrar";
         this.btnRegistrar.Size = new System.Drawing.Size(57, 45);
         this.btnRegistrar.TabIndex = 28;
         this.btnRegistrar.UseVisualStyleBackColor = false;
         this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
         // 
         // cmbTipoPersona
         // 
         this.cmbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.cmbTipoPersona.FormattingEnabled = true;
         this.cmbTipoPersona.Items.AddRange(new object[] {
            "Administrador\t",
            "Empleado"});
         this.cmbTipoPersona.Location = new System.Drawing.Point(300, 102);
         this.cmbTipoPersona.Name = "cmbTipoPersona";
         this.cmbTipoPersona.Size = new System.Drawing.Size(107, 29);
         this.cmbTipoPersona.TabIndex = 27;
         // 
         // txtNombre
         // 
         this.txtNombre.BackColor = System.Drawing.Color.LightGray;
         this.txtNombre.Location = new System.Drawing.Point(109, 115);
         this.txtNombre.Name = "txtNombre";
         this.txtNombre.Size = new System.Drawing.Size(107, 29);
         this.txtNombre.TabIndex = 19;
         // 
         // txtDireccion
         // 
         this.txtDireccion.BackColor = System.Drawing.Color.LightGray;
         this.txtDireccion.Location = new System.Drawing.Point(109, 164);
         this.txtDireccion.Name = "txtDireccion";
         this.txtDireccion.Size = new System.Drawing.Size(107, 29);
         this.txtDireccion.TabIndex = 22;
         // 
         // txtTelefono
         // 
         this.txtTelefono.BackColor = System.Drawing.Color.LightGray;
         this.txtTelefono.Location = new System.Drawing.Point(109, 208);
         this.txtTelefono.Name = "txtTelefono";
         this.txtTelefono.Size = new System.Drawing.Size(107, 29);
         this.txtTelefono.TabIndex = 25;
         // 
         // txtClave
         // 
         this.txtClave.BackColor = System.Drawing.Color.LightGray;
         this.txtClave.Location = new System.Drawing.Point(300, 67);
         this.txtClave.Name = "txtClave";
         this.txtClave.Size = new System.Drawing.Size(107, 29);
         this.txtClave.TabIndex = 26;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.Location = new System.Drawing.Point(242, 102);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(35, 19);
         this.label6.TabIndex = 24;
         this.label6.Text = "Tipo";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.Location = new System.Drawing.Point(242, 66);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(42, 19);
         this.label5.TabIndex = 23;
         this.label5.Text = "&Clave";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.Location = new System.Drawing.Point(21, 209);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(62, 19);
         this.label4.TabIndex = 21;
         this.label4.Text = "&Telefono";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.Location = new System.Drawing.Point(21, 163);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(67, 19);
         this.label3.TabIndex = 20;
         this.label3.Text = "&Direccion";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(21, 115);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(60, 19);
         this.label2.TabIndex = 18;
         this.label2.Text = "&Nombre";
         // 
         // txtDocumento
         // 
         this.txtDocumento.BackColor = System.Drawing.Color.LightGray;
         this.txtDocumento.Location = new System.Drawing.Point(109, 67);
         this.txtDocumento.Name = "txtDocumento";
         this.txtDocumento.Size = new System.Drawing.Size(107, 29);
         this.txtDocumento.TabIndex = 17;
         // 
         // lbl
         // 
         this.lbl.AutoSize = true;
         this.lbl.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbl.Location = new System.Drawing.Point(21, 66);
         this.lbl.Name = "lbl";
         this.lbl.Size = new System.Drawing.Size(82, 19);
         this.lbl.TabIndex = 16;
         this.lbl.Text = "&Documento";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(127, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(170, 30);
         this.label1.TabIndex = 15;
         this.label1.Text = "Registar Usuario";
         // 
         // Registro
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.PeachPuff;
         this.ClientSize = new System.Drawing.Size(441, 263);
         this.Controls.Add(this.btnRegistrar);
         this.Controls.Add(this.cmbTipoPersona);
         this.Controls.Add(this.txtNombre);
         this.Controls.Add(this.txtDireccion);
         this.Controls.Add(this.txtTelefono);
         this.Controls.Add(this.txtClave);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.txtDocumento);
         this.Controls.Add(this.lbl);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.Name = "Registro";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Registrar Usuario";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Button btnRegistrar;
      private System.Windows.Forms.ComboBox cmbTipoPersona;
      private System.Windows.Forms.TextBox txtNombre;
      private System.Windows.Forms.TextBox txtDireccion;
      private System.Windows.Forms.TextBox txtTelefono;
      private System.Windows.Forms.TextBox txtClave;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtDocumento;
      private System.Windows.Forms.Label lbl;
      private System.Windows.Forms.Label label1;
   }
}