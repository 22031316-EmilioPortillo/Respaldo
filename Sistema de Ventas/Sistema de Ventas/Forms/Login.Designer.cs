﻿namespace Sistema_de_Ventas
{
   partial class Login
   {
      /// <summary>
      /// Variable del diseñador necesaria.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Limpiar los recursos que se estén usando.
      /// </summary>
      /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Código generado por el Diseñador de Windows Forms

      /// <summary>
      /// Método necesario para admitir el Diseñador. No se puede modificar
      /// el contenido de este método con el editor de código.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
       
       
         
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.txtUsuario = new System.Windows.Forms.TextBox();
         this.txtContraseña = new System.Windows.Forms.TextBox();
         this.button1 = new System.Windows.Forms.Button();
      
         this.SuspendLayout();
         // 
         // dBPUNTO_VENTADataSet
         // 
      
         // 
         // pERSONABindingSource
         // 
   
         // 
         // pERSONATableAdapter
         // 
   
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.Location = new System.Drawing.Point(54, 47);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(73, 23);
         this.label1.TabIndex = 0;
         this.label1.Text = "Usuario";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
         this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.Location = new System.Drawing.Point(54, 109);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(101, 23);
         this.label2.TabIndex = 1;
         this.label2.Text = "Contraseña";
         // 
         // txtUsuario
         // 
         this.txtUsuario.Location = new System.Drawing.Point(173, 47);
         this.txtUsuario.Name = "txtUsuario";
         this.txtUsuario.Size = new System.Drawing.Size(140, 29);
         this.txtUsuario.TabIndex = 2;
         // 
         // txtContraseña
         // 
         this.txtContraseña.Location = new System.Drawing.Point(173, 106);
         this.txtContraseña.Name = "txtContraseña";
         this.txtContraseña.PasswordChar = '*';
         this.txtContraseña.Size = new System.Drawing.Size(140, 29);
         this.txtContraseña.TabIndex = 3;
         // 
         // button1
         // 
         this.button1.Location = new System.Drawing.Point(342, 151);
         this.button1.Name = "button1";
         this.button1.Size = new System.Drawing.Size(95, 38);
         this.button1.TabIndex = 4;
         this.button1.Text = "Entrar";
         this.button1.UseVisualStyleBackColor = true;
         this.button1.Click += new System.EventHandler(this.button1_Click);
         // 
         // Login
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.Silver;
         this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
         this.ClientSize = new System.Drawing.Size(485, 216);
         this.Controls.Add(this.button1);
         this.Controls.Add(this.txtContraseña);
         this.Controls.Add(this.txtUsuario);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
         this.MaximizeBox = false;
         this.Name = "Login";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";

         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion
      
    
     
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.TextBox txtUsuario;
      private System.Windows.Forms.TextBox txtContraseña;
      private System.Windows.Forms.Button button1;
   }
}

