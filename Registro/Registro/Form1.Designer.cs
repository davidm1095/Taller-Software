namespace Registro
{
    partial class frmRegistro
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.txtCostoServicio = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.cbRango = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rbSexoFemenino = new System.Windows.Forms.RadioButton();
            this.rbSexoMasculino = new System.Windows.Forms.RadioButton();
            this.cbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.btnCalcularPago = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(105, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre del paciente";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(150, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(341, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(25, 82);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(90, 13);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de Docueno";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(150, 179);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(341, 20);
            this.txtNroDocumento.TabIndex = 5;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(25, 182);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(115, 13);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "Número de documento";
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Location = new System.Drawing.Point(25, 232);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(39, 13);
            this.lblRango.TabIndex = 6;
            this.lblRango.Text = "Rango";
            // 
            // txtCostoServicio
            // 
            this.txtCostoServicio.Location = new System.Drawing.Point(150, 279);
            this.txtCostoServicio.Name = "txtCostoServicio";
            this.txtCostoServicio.Size = new System.Drawing.Size(341, 20);
            this.txtCostoServicio.TabIndex = 7;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(25, 282);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(73, 13);
            this.lblCosto.TabIndex = 8;
            this.lblCosto.Text = "Costo servicio";
            // 
            // cbRango
            // 
            this.cbRango.FormattingEnabled = true;
            this.cbRango.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cbRango.Location = new System.Drawing.Point(150, 229);
            this.cbRango.MaxDropDownItems = 6;
            this.cbRango.Name = "cbRango";
            this.cbRango.Size = new System.Drawing.Size(341, 21);
            this.cbRango.TabIndex = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(416, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(324, 333);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(25, 132);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 13;
            this.lblSexo.Text = "Sexo";
            // 
            // rbSexoFemenino
            // 
            this.rbSexoFemenino.AutoSize = true;
            this.rbSexoFemenino.Checked = true;
            this.rbSexoFemenino.Location = new System.Drawing.Point(150, 130);
            this.rbSexoFemenino.Name = "rbSexoFemenino";
            this.rbSexoFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbSexoFemenino.TabIndex = 3;
            this.rbSexoFemenino.TabStop = true;
            this.rbSexoFemenino.Text = "Femenino";
            this.rbSexoFemenino.UseVisualStyleBackColor = true;
            // 
            // rbSexoMasculino
            // 
            this.rbSexoMasculino.AutoSize = true;
            this.rbSexoMasculino.Location = new System.Drawing.Point(255, 130);
            this.rbSexoMasculino.Name = "rbSexoMasculino";
            this.rbSexoMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbSexoMasculino.TabIndex = 4;
            this.rbSexoMasculino.Text = "Masculino";
            this.rbSexoMasculino.UseVisualStyleBackColor = true;
            // 
            // cbTipoDocumento
            // 
            this.cbTipoDocumento.FormattingEnabled = true;
            this.cbTipoDocumento.Items.AddRange(new object[] {
            "Cedula de Ciudadanía",
            "NUIP",
            "Tarjeta de Extrangería",
            "Tarjeta de Identidad"});
            this.cbTipoDocumento.Location = new System.Drawing.Point(150, 79);
            this.cbTipoDocumento.MaxDropDownItems = 6;
            this.cbTipoDocumento.Name = "cbTipoDocumento";
            this.cbTipoDocumento.Size = new System.Drawing.Size(341, 21);
            this.cbTipoDocumento.TabIndex = 2;
            // 
            // btnCalcularPago
            // 
            this.btnCalcularPago.Location = new System.Drawing.Point(23, 333);
            this.btnCalcularPago.Name = "btnCalcularPago";
            this.btnCalcularPago.Size = new System.Drawing.Size(134, 23);
            this.btnCalcularPago.TabIndex = 14;
            this.btnCalcularPago.Text = "Calcular Pago";
            this.btnCalcularPago.UseVisualStyleBackColor = true;
            this.btnCalcularPago.Click += new System.EventHandler(this.btnCalcularPago_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 376);
            this.Controls.Add(this.btnCalcularPago);
            this.Controls.Add(this.cbTipoDocumento);
            this.Controls.Add(this.rbSexoMasculino);
            this.Controls.Add(this.rbSexoFemenino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbRango);
            this.Controls.Add(this.txtCostoServicio);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblRango);
            this.Controls.Add(this.txtNroDocumento);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmRegistro";
            this.Text = "Registro de prestación de servicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.TextBox txtCostoServicio;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.ComboBox cbRango;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rbSexoFemenino;
        private System.Windows.Forms.RadioButton rbSexoMasculino;
        private System.Windows.Forms.ComboBox cbTipoDocumento;
        private System.Windows.Forms.Button btnCalcularPago;
    }
}

