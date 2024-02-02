namespace Sistema_de_Ventas.Forms
{
   partial class ActualizarUser
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarUser));
         this.DtgvActualizar = new System.Windows.Forms.DataGridView();
         this.btnEliminar = new System.Windows.Forms.Button();
         this.txtDocumento = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.DtgvActualizar)).BeginInit();
         this.SuspendLayout();
         // 
         // DtgvActualizar
         // 
         this.DtgvActualizar.BackgroundColor = System.Drawing.SystemColors.Control;
         this.DtgvActualizar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
         dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
         dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.PaleGreen;
         dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
         dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
         this.DtgvActualizar.DefaultCellStyle = dataGridViewCellStyle1;
         this.DtgvActualizar.Location = new System.Drawing.Point(48, 25);
         this.DtgvActualizar.Name = "DtgvActualizar";
         this.DtgvActualizar.Size = new System.Drawing.Size(546, 232);
         this.DtgvActualizar.TabIndex = 0;
         this.DtgvActualizar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvActualizar_CellClick);
         this.DtgvActualizar.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvActualizar_CellEndEdit);
         // 
         // btnEliminar
         // 
         this.btnEliminar.Enabled = false;
         this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
         this.btnEliminar.Location = new System.Drawing.Point(444, 265);
         this.btnEliminar.Name = "btnEliminar";
         this.btnEliminar.Size = new System.Drawing.Size(62, 51);
         this.btnEliminar.TabIndex = 1;
         this.btnEliminar.UseVisualStyleBackColor = true;
         this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
         // 
         // txtDocumento
         // 
         this.txtDocumento.Location = new System.Drawing.Point(63, 281);
         this.txtDocumento.Name = "txtDocumento";
         this.txtDocumento.Size = new System.Drawing.Size(100, 20);
         this.txtDocumento.TabIndex = 2;
         this.txtDocumento.Visible = false;
         // 
         // ActualizarUser
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightSalmon;
         this.ClientSize = new System.Drawing.Size(658, 328);
         this.Controls.Add(this.txtDocumento);
         this.Controls.Add(this.btnEliminar);
         this.Controls.Add(this.DtgvActualizar);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "ActualizarUser";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "ActualizarUser";
         ((System.ComponentModel.ISupportInitialize)(this.DtgvActualizar)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.DataGridView DtgvActualizar;
      private System.Windows.Forms.Button btnEliminar;
      private System.Windows.Forms.TextBox txtDocumento;
   }
}