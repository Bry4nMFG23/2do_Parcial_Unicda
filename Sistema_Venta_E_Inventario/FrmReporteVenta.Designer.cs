namespace Sistema_Venta_E_Inventario
{
    partial class FrmReporteVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteVenta));
            this.lblMenuBusquedaReporteVentas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarReporteVenta = new System.Windows.Forms.TextBox();
            this.dtgvDatosReporteVenta = new System.Windows.Forms.DataGridView();
            this.btnAtrasReporteVenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimirFactura = new System.Windows.Forms.Button();
            this.btnEliminarFactura = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosReporteVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuBusquedaReporteVentas
            // 
            this.lblMenuBusquedaReporteVentas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMenuBusquedaReporteVentas.Location = new System.Drawing.Point(0, -1);
            this.lblMenuBusquedaReporteVentas.Name = "lblMenuBusquedaReporteVentas";
            this.lblMenuBusquedaReporteVentas.Size = new System.Drawing.Size(799, 63);
            this.lblMenuBusquedaReporteVentas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // txtBuscarReporteVenta
            // 
            this.txtBuscarReporteVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarReporteVenta.Location = new System.Drawing.Point(193, 28);
            this.txtBuscarReporteVenta.Name = "txtBuscarReporteVenta";
            this.txtBuscarReporteVenta.Size = new System.Drawing.Size(159, 20);
            this.txtBuscarReporteVenta.TabIndex = 2;
            this.txtBuscarReporteVenta.TextChanged += new System.EventHandler(this.txtBuscarReporteVenta_TextChanged);
            // 
            // dtgvDatosReporteVenta
            // 
            this.dtgvDatosReporteVenta.AllowUserToAddRows = false;
            this.dtgvDatosReporteVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvDatosReporteVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDatosReporteVenta.Location = new System.Drawing.Point(3, 66);
            this.dtgvDatosReporteVenta.Name = "dtgvDatosReporteVenta";
            this.dtgvDatosReporteVenta.Size = new System.Drawing.Size(796, 290);
            this.dtgvDatosReporteVenta.TabIndex = 3;
            // 
            // btnAtrasReporteVenta
            // 
            this.btnAtrasReporteVenta.Location = new System.Drawing.Point(5, 12);
            this.btnAtrasReporteVenta.Name = "btnAtrasReporteVenta";
            this.btnAtrasReporteVenta.Size = new System.Drawing.Size(75, 23);
            this.btnAtrasReporteVenta.TabIndex = 4;
            this.btnAtrasReporteVenta.Text = "Atras";
            this.btnAtrasReporteVenta.UseVisualStyleBackColor = true;
            this.btnAtrasReporteVenta.Click += new System.EventHandler(this.btnAtrasReporteVenta_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(0, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(799, 90);
            this.label2.TabIndex = 5;
            // 
            // btnImprimirFactura
            // 
            this.btnImprimirFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirFactura.Location = new System.Drawing.Point(596, 12);
            this.btnImprimirFactura.Name = "btnImprimirFactura";
            this.btnImprimirFactura.Size = new System.Drawing.Size(64, 36);
            this.btnImprimirFactura.TabIndex = 6;
            this.btnImprimirFactura.Text = "🖨️ Imprimir";
            this.btnImprimirFactura.UseVisualStyleBackColor = true;
            this.btnImprimirFactura.Click += new System.EventHandler(this.btnImprimirFactura_Click);
            // 
            // btnEliminarFactura
            // 
            this.btnEliminarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarFactura.Location = new System.Drawing.Point(684, 12);
            this.btnEliminarFactura.Name = "btnEliminarFactura";
            this.btnEliminarFactura.Size = new System.Drawing.Size(64, 36);
            this.btnEliminarFactura.TabIndex = 7;
            this.btnEliminarFactura.Text = "✖️ Eliminar";
            this.btnEliminarFactura.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // FrmReporteVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarFactura);
            this.Controls.Add(this.btnImprimirFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAtrasReporteVenta);
            this.Controls.Add(this.dtgvDatosReporteVenta);
            this.Controls.Add(this.txtBuscarReporteVenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMenuBusquedaReporteVentas);
            this.Name = "FrmReporteVenta";
            this.Text = "FrmReporteVenta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmReporteVenta_FormClosed);
            this.Load += new System.EventHandler(this.FrmReporteVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDatosReporteVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMenuBusquedaReporteVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscarReporteVenta;
        private System.Windows.Forms.DataGridView dtgvDatosReporteVenta;
        private System.Windows.Forms.Button btnAtrasReporteVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimirFactura;
        private System.Windows.Forms.Button btnEliminarFactura;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}