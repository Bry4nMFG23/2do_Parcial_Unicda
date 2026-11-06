namespace Sistema_Venta_E_Inventario
{
    partial class FrmCobrar
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
            this.lblClienteAlContado = new System.Windows.Forms.Label();
            this.lblMontoAPagar = new System.Windows.Forms.Label();
            this.lblEfectivo = new System.Windows.Forms.Label();
            this.lblDevuelta = new System.Windows.Forms.Label();
            this.txtTotalCobrar = new System.Windows.Forms.TextBox();
            this.txtEfectivoRecibido = new System.Windows.Forms.TextBox();
            this.txtDevuelta = new System.Windows.Forms.TextBox();
            this.btnAceptarCobro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClienteAlContado
            // 
            this.lblClienteAlContado.AutoSize = true;
            this.lblClienteAlContado.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteAlContado.Location = new System.Drawing.Point(275, 43);
            this.lblClienteAlContado.Name = "lblClienteAlContado";
            this.lblClienteAlContado.Size = new System.Drawing.Size(235, 30);
            this.lblClienteAlContado.TabIndex = 0;
            this.lblClienteAlContado.Text = "Cliente al contado";
            // 
            // lblMontoAPagar
            // 
            this.lblMontoAPagar.AutoSize = true;
            this.lblMontoAPagar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMontoAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoAPagar.Location = new System.Drawing.Point(184, 114);
            this.lblMontoAPagar.Name = "lblMontoAPagar";
            this.lblMontoAPagar.Size = new System.Drawing.Size(144, 25);
            this.lblMontoAPagar.TabIndex = 1;
            this.lblMontoAPagar.Text = "Monto a pagar:";
            // 
            // lblEfectivo
            // 
            this.lblEfectivo.AutoSize = true;
            this.lblEfectivo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEfectivo.Location = new System.Drawing.Point(156, 182);
            this.lblEfectivo.Name = "lblEfectivo";
            this.lblEfectivo.Size = new System.Drawing.Size(160, 25);
            this.lblEfectivo.TabIndex = 2;
            this.lblEfectivo.Text = "Efectivo recibido:";
            // 
            // lblDevuelta
            // 
            this.lblDevuelta.AutoSize = true;
            this.lblDevuelta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblDevuelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevuelta.Location = new System.Drawing.Point(221, 243);
            this.lblDevuelta.Name = "lblDevuelta";
            this.lblDevuelta.Size = new System.Drawing.Size(95, 25);
            this.lblDevuelta.TabIndex = 3;
            this.lblDevuelta.Text = "Devuelta:";
            // 
            // txtTotalCobrar
            // 
            this.txtTotalCobrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalCobrar.Location = new System.Drawing.Point(334, 114);
            this.txtTotalCobrar.Name = "txtTotalCobrar";
            this.txtTotalCobrar.ReadOnly = true;
            this.txtTotalCobrar.Size = new System.Drawing.Size(176, 20);
            this.txtTotalCobrar.TabIndex = 4;
            // 
            // txtEfectivoRecibido
            // 
            this.txtEfectivoRecibido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEfectivoRecibido.Location = new System.Drawing.Point(334, 182);
            this.txtEfectivoRecibido.Name = "txtEfectivoRecibido";
            this.txtEfectivoRecibido.Size = new System.Drawing.Size(176, 20);
            this.txtEfectivoRecibido.TabIndex = 5;
            this.txtEfectivoRecibido.TextChanged += new System.EventHandler(this.txtEfectivoRecibido_TextChanged);
            // 
            // txtDevuelta
            // 
            this.txtDevuelta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDevuelta.Location = new System.Drawing.Point(334, 243);
            this.txtDevuelta.Name = "txtDevuelta";
            this.txtDevuelta.ReadOnly = true;
            this.txtDevuelta.Size = new System.Drawing.Size(176, 20);
            this.txtDevuelta.TabIndex = 6;
            // 
            // btnAceptarCobro
            // 
            this.btnAceptarCobro.Location = new System.Drawing.Point(361, 300);
            this.btnAceptarCobro.Name = "btnAceptarCobro";
            this.btnAceptarCobro.Size = new System.Drawing.Size(95, 37);
            this.btnAceptarCobro.TabIndex = 7;
            this.btnAceptarCobro.Text = "Aceptar";
            this.btnAceptarCobro.UseVisualStyleBackColor = true;
            this.btnAceptarCobro.Click += new System.EventHandler(this.btnAceptarCobro_Click);
            // 
            // FrmCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAceptarCobro);
            this.Controls.Add(this.txtDevuelta);
            this.Controls.Add(this.txtEfectivoRecibido);
            this.Controls.Add(this.txtTotalCobrar);
            this.Controls.Add(this.lblDevuelta);
            this.Controls.Add(this.lblEfectivo);
            this.Controls.Add(this.lblMontoAPagar);
            this.Controls.Add(this.lblClienteAlContado);
            this.Name = "FrmCobrar";
            this.Text = "FrmCobrar";
            this.Load += new System.EventHandler(this.FrmCobrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClienteAlContado;
        private System.Windows.Forms.Label lblMontoAPagar;
        private System.Windows.Forms.Label lblEfectivo;
        private System.Windows.Forms.Label lblDevuelta;
        private System.Windows.Forms.TextBox txtTotalCobrar;
        private System.Windows.Forms.TextBox txtEfectivoRecibido;
        private System.Windows.Forms.TextBox txtDevuelta;
        private System.Windows.Forms.Button btnAceptarCobro;
    }
}