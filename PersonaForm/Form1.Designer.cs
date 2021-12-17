namespace PersonaForm
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Monto = new System.Windows.Forms.Label();
            this.txt_Motivo = new System.Windows.Forms.TextBox();
            this.lbl_Motivo = new System.Windows.Forms.Label();
            this.txt_TipoTransaccion = new System.Windows.Forms.TextBox();
            this.lbl_TipoTransaccion = new System.Windows.Forms.Label();
            this.txt_Fecha = new System.Windows.Forms.TextBox();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.txt_Monto = new System.Windows.Forms.TextBox();
            this.txt_cvv = new System.Windows.Forms.TextBox();
            this.lbl_cvv = new System.Windows.Forms.Label();
            this.txt_IdTarjetaDestino = new System.Windows.Forms.TextBox();
            this.lbl_IdTarjetaDestino = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IdTarjetaOrigen = new System.Windows.Forms.TextBox();
            this.lbl_IdTarjetaOrigen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_Monto
            // 
            this.lbl_Monto.AutoSize = true;
            this.lbl_Monto.Location = new System.Drawing.Point(68, 232);
            this.lbl_Monto.Name = "lbl_Monto";
            this.lbl_Monto.Size = new System.Drawing.Size(37, 13);
            this.lbl_Monto.TabIndex = 31;
            this.lbl_Monto.Text = "Monto";
            // 
            // txt_Motivo
            // 
            this.txt_Motivo.Location = new System.Drawing.Point(116, 196);
            this.txt_Motivo.Name = "txt_Motivo";
            this.txt_Motivo.Size = new System.Drawing.Size(149, 20);
            this.txt_Motivo.TabIndex = 30;
            // 
            // lbl_Motivo
            // 
            this.lbl_Motivo.AutoSize = true;
            this.lbl_Motivo.Location = new System.Drawing.Point(68, 196);
            this.lbl_Motivo.Name = "lbl_Motivo";
            this.lbl_Motivo.Size = new System.Drawing.Size(39, 13);
            this.lbl_Motivo.TabIndex = 29;
            this.lbl_Motivo.Text = "Motivo";
            // 
            // txt_TipoTransaccion
            // 
            this.txt_TipoTransaccion.Location = new System.Drawing.Point(116, 157);
            this.txt_TipoTransaccion.Name = "txt_TipoTransaccion";
            this.txt_TipoTransaccion.Size = new System.Drawing.Size(149, 20);
            this.txt_TipoTransaccion.TabIndex = 28;
            // 
            // lbl_TipoTransaccion
            // 
            this.lbl_TipoTransaccion.AutoSize = true;
            this.lbl_TipoTransaccion.Location = new System.Drawing.Point(16, 157);
            this.lbl_TipoTransaccion.Name = "lbl_TipoTransaccion";
            this.lbl_TipoTransaccion.Size = new System.Drawing.Size(87, 13);
            this.lbl_TipoTransaccion.TabIndex = 27;
            this.lbl_TipoTransaccion.Text = "TipoTransaccion";
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Location = new System.Drawing.Point(116, 274);
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Size = new System.Drawing.Size(149, 20);
            this.txt_Fecha.TabIndex = 26;
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(68, 274);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(37, 13);
            this.lbl_Fecha.TabIndex = 25;
            this.lbl_Fecha.Text = "Fecha";
            // 
            // txt_Monto
            // 
            this.txt_Monto.Location = new System.Drawing.Point(116, 232);
            this.txt_Monto.Name = "txt_Monto";
            this.txt_Monto.Size = new System.Drawing.Size(149, 20);
            this.txt_Monto.TabIndex = 24;
            // 
            // txt_cvv
            // 
            this.txt_cvv.Location = new System.Drawing.Point(116, 123);
            this.txt_cvv.Name = "txt_cvv";
            this.txt_cvv.Size = new System.Drawing.Size(149, 20);
            this.txt_cvv.TabIndex = 23;
            // 
            // lbl_cvv
            // 
            this.lbl_cvv.AutoSize = true;
            this.lbl_cvv.Location = new System.Drawing.Point(68, 123);
            this.lbl_cvv.Name = "lbl_cvv";
            this.lbl_cvv.Size = new System.Drawing.Size(25, 13);
            this.lbl_cvv.TabIndex = 22;
            this.lbl_cvv.Text = "cvv";
            // 
            // txt_IdTarjetaDestino
            // 
            this.txt_IdTarjetaDestino.Location = new System.Drawing.Point(116, 84);
            this.txt_IdTarjetaDestino.Name = "txt_IdTarjetaDestino";
            this.txt_IdTarjetaDestino.Size = new System.Drawing.Size(149, 20);
            this.txt_IdTarjetaDestino.TabIndex = 21;
            // 
            // lbl_IdTarjetaDestino
            // 
            this.lbl_IdTarjetaDestino.AutoSize = true;
            this.lbl_IdTarjetaDestino.Location = new System.Drawing.Point(18, 84);
            this.lbl_IdTarjetaDestino.Name = "lbl_IdTarjetaDestino";
            this.lbl_IdTarjetaDestino.Size = new System.Drawing.Size(85, 13);
            this.lbl_IdTarjetaDestino.TabIndex = 20;
            this.lbl_IdTarjetaDestino.Text = "IdTarjetaDestino";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mandar informacion al banco";
            // 
            // txt_IdTarjetaOrigen
            // 
            this.txt_IdTarjetaOrigen.Location = new System.Drawing.Point(116, 44);
            this.txt_IdTarjetaOrigen.Name = "txt_IdTarjetaOrigen";
            this.txt_IdTarjetaOrigen.Size = new System.Drawing.Size(149, 20);
            this.txt_IdTarjetaOrigen.TabIndex = 18;
            // 
            // lbl_IdTarjetaOrigen
            // 
            this.lbl_IdTarjetaOrigen.AutoSize = true;
            this.lbl_IdTarjetaOrigen.Location = new System.Drawing.Point(23, 44);
            this.lbl_IdTarjetaOrigen.Name = "lbl_IdTarjetaOrigen";
            this.lbl_IdTarjetaOrigen.Size = new System.Drawing.Size(80, 13);
            this.lbl_IdTarjetaOrigen.TabIndex = 17;
            this.lbl_IdTarjetaOrigen.Text = "IdTarjetaOrigen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 361);
            this.Controls.Add(this.lbl_Monto);
            this.Controls.Add(this.txt_Motivo);
            this.Controls.Add(this.lbl_Motivo);
            this.Controls.Add(this.txt_TipoTransaccion);
            this.Controls.Add(this.lbl_TipoTransaccion);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.txt_Monto);
            this.Controls.Add(this.txt_cvv);
            this.Controls.Add(this.lbl_cvv);
            this.Controls.Add(this.txt_IdTarjetaDestino);
            this.Controls.Add(this.lbl_IdTarjetaDestino);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_IdTarjetaOrigen);
            this.Controls.Add(this.lbl_IdTarjetaOrigen);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Monto;
        private System.Windows.Forms.TextBox txt_Motivo;
        private System.Windows.Forms.Label lbl_Motivo;
        private System.Windows.Forms.TextBox txt_TipoTransaccion;
        private System.Windows.Forms.Label lbl_TipoTransaccion;
        private System.Windows.Forms.TextBox txt_Fecha;
        private System.Windows.Forms.Label lbl_Fecha;
        private System.Windows.Forms.TextBox txt_Monto;
        private System.Windows.Forms.TextBox txt_cvv;
        private System.Windows.Forms.Label lbl_cvv;
        private System.Windows.Forms.TextBox txt_IdTarjetaDestino;
        private System.Windows.Forms.Label lbl_IdTarjetaDestino;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IdTarjetaOrigen;
        private System.Windows.Forms.Label lbl_IdTarjetaOrigen;
    }
}

