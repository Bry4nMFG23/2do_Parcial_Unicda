namespace Sistema_Venta_E_Inventario
{
    partial class FrmFacturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFacturar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClienteFacturacion = new System.Windows.Forms.Label();
            this.lblDescripcionFacturacion = new System.Windows.Forms.Label();
            this.lblDireccionFacturacion = new System.Windows.Forms.Label();
            this.lblTelefonoFacturacion = new System.Windows.Forms.Label();
            this.lblCorreoFacturacion = new System.Windows.Forms.Label();
            this.lblCiudadFacturacion = new System.Windows.Forms.Label();
            this.lblSectorFacturacion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteFacturacion = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDireccionFacturacion = new System.Windows.Forms.TextBox();
            this.txtTelefonoFacturacion = new System.Windows.Forms.TextBox();
            this.txtCorreoFacturacion = new System.Windows.Forms.TextBox();
            this.txtCiudadFacturacion = new System.Windows.Forms.TextBox();
            this.txtSectorFacturacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipoFacturacion = new System.Windows.Forms.ComboBox();
            this.dtmFechaFacturacion = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMostrarProductos = new System.Windows.Forms.Label();
            this.lblCodigoProductoFacturacion = new System.Windows.Forms.Label();
            this.lblStockProductoFacturacion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCodigoProductoFacturacion = new System.Windows.Forms.TextBox();
            this.txtNombreProductoFacturacion = new System.Windows.Forms.TextBox();
            this.txtUnidadFacturacion = new System.Windows.Forms.TextBox();
            this.txtCantidadFacturacion = new System.Windows.Forms.TextBox();
            this.txtPrecioFacturacion = new System.Windows.Forms.TextBox();
            this.txtItebisFacturacion = new System.Windows.Forms.TextBox();
            this.txtTotalFacturacion = new System.Windows.Forms.TextBox();
            this.dtgvProductosFacturacion = new System.Windows.Forms.DataGridView();
            this.lblCodigoClienteFacturacion = new System.Windows.Forms.Label();
            this.txtCodigoClienteFacturacion = new System.Windows.Forms.TextBox();
            this.lblDocumentoFacturacion = new System.Windows.Forms.Label();
            this.txtDocumentoFacturacion = new System.Windows.Forms.TextBox();
            this.btnSalirFacturacion = new System.Windows.Forms.Button();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.lblTotalFactura = new System.Windows.Forms.Label();
            this.lblTotalFacturaGeneral = new System.Windows.Forms.Label();
            this.btnAplicarFactura = new System.Windows.Forms.Button();
            this.btnModificarFactura = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.clnIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrecioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnSubtotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnItbisProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTotalProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductosFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1092, 49);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.IndianRed;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(475, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Facturacion";
            // 
            // lblClienteFacturacion
            // 
            this.lblClienteFacturacion.AutoSize = true;
            this.lblClienteFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteFacturacion.Location = new System.Drawing.Point(13, 82);
            this.lblClienteFacturacion.Name = "lblClienteFacturacion";
            this.lblClienteFacturacion.Size = new System.Drawing.Size(63, 17);
            this.lblClienteFacturacion.TabIndex = 2;
            this.lblClienteFacturacion.Text = "Cliente:";
            // 
            // lblDescripcionFacturacion
            // 
            this.lblDescripcionFacturacion.AutoSize = true;
            this.lblDescripcionFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionFacturacion.Location = new System.Drawing.Point(13, 128);
            this.lblDescripcionFacturacion.Name = "lblDescripcionFacturacion";
            this.lblDescripcionFacturacion.Size = new System.Drawing.Size(98, 17);
            this.lblDescripcionFacturacion.TabIndex = 3;
            this.lblDescripcionFacturacion.Text = "Descripcion:";
            // 
            // lblDireccionFacturacion
            // 
            this.lblDireccionFacturacion.AutoSize = true;
            this.lblDireccionFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionFacturacion.Location = new System.Drawing.Point(13, 178);
            this.lblDireccionFacturacion.Name = "lblDireccionFacturacion";
            this.lblDireccionFacturacion.Size = new System.Drawing.Size(81, 17);
            this.lblDireccionFacturacion.TabIndex = 4;
            this.lblDireccionFacturacion.Text = "Direccion:";
            // 
            // lblTelefonoFacturacion
            // 
            this.lblTelefonoFacturacion.AutoSize = true;
            this.lblTelefonoFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefonoFacturacion.Location = new System.Drawing.Point(13, 221);
            this.lblTelefonoFacturacion.Name = "lblTelefonoFacturacion";
            this.lblTelefonoFacturacion.Size = new System.Drawing.Size(77, 17);
            this.lblTelefonoFacturacion.TabIndex = 5;
            this.lblTelefonoFacturacion.Text = "Telefono:";
            // 
            // lblCorreoFacturacion
            // 
            this.lblCorreoFacturacion.AutoSize = true;
            this.lblCorreoFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoFacturacion.Location = new System.Drawing.Point(328, 82);
            this.lblCorreoFacturacion.Name = "lblCorreoFacturacion";
            this.lblCorreoFacturacion.Size = new System.Drawing.Size(62, 17);
            this.lblCorreoFacturacion.TabIndex = 6;
            this.lblCorreoFacturacion.Text = "Correo:";
            // 
            // lblCiudadFacturacion
            // 
            this.lblCiudadFacturacion.AutoSize = true;
            this.lblCiudadFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudadFacturacion.Location = new System.Drawing.Point(327, 128);
            this.lblCiudadFacturacion.Name = "lblCiudadFacturacion";
            this.lblCiudadFacturacion.Size = new System.Drawing.Size(63, 17);
            this.lblCiudadFacturacion.TabIndex = 7;
            this.lblCiudadFacturacion.Text = "Ciudad:";
            // 
            // lblSectorFacturacion
            // 
            this.lblSectorFacturacion.AutoSize = true;
            this.lblSectorFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectorFacturacion.Location = new System.Drawing.Point(327, 178);
            this.lblSectorFacturacion.Name = "lblSectorFacturacion";
            this.lblSectorFacturacion.Size = new System.Drawing.Size(60, 17);
            this.lblSectorFacturacion.TabIndex = 8;
            this.lblSectorFacturacion.Text = "Sector:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 9;
            // 
            // txtClienteFacturacion
            // 
            this.txtClienteFacturacion.Location = new System.Drawing.Point(82, 82);
            this.txtClienteFacturacion.Name = "txtClienteFacturacion";
            this.txtClienteFacturacion.Size = new System.Drawing.Size(151, 20);
            this.txtClienteFacturacion.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 11;
            // 
            // txtDireccionFacturacion
            // 
            this.txtDireccionFacturacion.Location = new System.Drawing.Point(100, 178);
            this.txtDireccionFacturacion.Name = "txtDireccionFacturacion";
            this.txtDireccionFacturacion.Size = new System.Drawing.Size(151, 20);
            this.txtDireccionFacturacion.TabIndex = 12;
            // 
            // txtTelefonoFacturacion
            // 
            this.txtTelefonoFacturacion.Location = new System.Drawing.Point(100, 221);
            this.txtTelefonoFacturacion.Name = "txtTelefonoFacturacion";
            this.txtTelefonoFacturacion.Size = new System.Drawing.Size(151, 20);
            this.txtTelefonoFacturacion.TabIndex = 13;
            // 
            // txtCorreoFacturacion
            // 
            this.txtCorreoFacturacion.Location = new System.Drawing.Point(396, 82);
            this.txtCorreoFacturacion.Name = "txtCorreoFacturacion";
            this.txtCorreoFacturacion.Size = new System.Drawing.Size(151, 20);
            this.txtCorreoFacturacion.TabIndex = 14;
            // 
            // txtCiudadFacturacion
            // 
            this.txtCiudadFacturacion.Location = new System.Drawing.Point(396, 125);
            this.txtCiudadFacturacion.Name = "txtCiudadFacturacion";
            this.txtCiudadFacturacion.Size = new System.Drawing.Size(151, 20);
            this.txtCiudadFacturacion.TabIndex = 15;
            // 
            // txtSectorFacturacion
            // 
            this.txtSectorFacturacion.Location = new System.Drawing.Point(393, 178);
            this.txtSectorFacturacion.Name = "txtSectorFacturacion";
            this.txtSectorFacturacion.Size = new System.Drawing.Size(151, 20);
            this.txtSectorFacturacion.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tipo:";
            // 
            // cbxTipoFacturacion
            // 
            this.cbxTipoFacturacion.FormattingEnabled = true;
            this.cbxTipoFacturacion.Items.AddRange(new object[] {
            "Credito",
            "Contado"});
            this.cbxTipoFacturacion.Location = new System.Drawing.Point(372, 231);
            this.cbxTipoFacturacion.Name = "cbxTipoFacturacion";
            this.cbxTipoFacturacion.Size = new System.Drawing.Size(121, 21);
            this.cbxTipoFacturacion.TabIndex = 19;
            // 
            // dtmFechaFacturacion
            // 
            this.dtmFechaFacturacion.Location = new System.Drawing.Point(893, 56);
            this.dtmFechaFacturacion.Name = "dtmFechaFacturacion";
            this.dtmFechaFacturacion.Size = new System.Drawing.Size(200, 20);
            this.dtmFechaFacturacion.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(830, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha:";
            // 
            // lblMostrarProductos
            // 
            this.lblMostrarProductos.BackColor = System.Drawing.SystemColors.GrayText;
            this.lblMostrarProductos.Location = new System.Drawing.Point(4, 256);
            this.lblMostrarProductos.Name = "lblMostrarProductos";
            this.lblMostrarProductos.Size = new System.Drawing.Size(1089, 326);
            this.lblMostrarProductos.TabIndex = 22;
            // 
            // lblCodigoProductoFacturacion
            // 
            this.lblCodigoProductoFacturacion.AutoSize = true;
            this.lblCodigoProductoFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProductoFacturacion.Location = new System.Drawing.Point(7, 586);
            this.lblCodigoProductoFacturacion.Name = "lblCodigoProductoFacturacion";
            this.lblCodigoProductoFacturacion.Size = new System.Drawing.Size(154, 17);
            this.lblCodigoProductoFacturacion.TabIndex = 23;
            this.lblCodigoProductoFacturacion.Text = "Codigo del producto";
            // 
            // lblStockProductoFacturacion
            // 
            this.lblStockProductoFacturacion.AutoSize = true;
            this.lblStockProductoFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockProductoFacturacion.Location = new System.Drawing.Point(7, 618);
            this.lblStockProductoFacturacion.Name = "lblStockProductoFacturacion";
            this.lblStockProductoFacturacion.Size = new System.Drawing.Size(53, 17);
            this.lblStockProductoFacturacion.TabIndex = 24;
            this.lblStockProductoFacturacion.Text = "Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 615);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cantidad:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(321, 615);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Precio:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Itbis:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(591, 613);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "Total:";
            // 
            // txtCodigoProductoFacturacion
            // 
            this.txtCodigoProductoFacturacion.Location = new System.Drawing.Point(163, 586);
            this.txtCodigoProductoFacturacion.Name = "txtCodigoProductoFacturacion";
            this.txtCodigoProductoFacturacion.Size = new System.Drawing.Size(70, 20);
            this.txtCodigoProductoFacturacion.TabIndex = 29;
            this.txtCodigoProductoFacturacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProductoFacturacion_KeyDown);
            // 
            // txtNombreProductoFacturacion
            // 
            this.txtNombreProductoFacturacion.Location = new System.Drawing.Point(239, 585);
            this.txtNombreProductoFacturacion.Name = "txtNombreProductoFacturacion";
            this.txtNombreProductoFacturacion.Size = new System.Drawing.Size(151, 20);
            this.txtNombreProductoFacturacion.TabIndex = 30;
            // 
            // txtUnidadFacturacion
            // 
            this.txtUnidadFacturacion.Location = new System.Drawing.Point(77, 615);
            this.txtUnidadFacturacion.Name = "txtUnidadFacturacion";
            this.txtUnidadFacturacion.ReadOnly = true;
            this.txtUnidadFacturacion.Size = new System.Drawing.Size(70, 20);
            this.txtUnidadFacturacion.TabIndex = 31;
            // 
            // txtCantidadFacturacion
            // 
            this.txtCantidadFacturacion.Location = new System.Drawing.Point(239, 613);
            this.txtCantidadFacturacion.Name = "txtCantidadFacturacion";
            this.txtCantidadFacturacion.Size = new System.Drawing.Size(62, 20);
            this.txtCantidadFacturacion.TabIndex = 32;
            this.txtCantidadFacturacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidadFacturacion_KeyDown);
            // 
            // txtPrecioFacturacion
            // 
            this.txtPrecioFacturacion.Location = new System.Drawing.Point(386, 614);
            this.txtPrecioFacturacion.Name = "txtPrecioFacturacion";
            this.txtPrecioFacturacion.Size = new System.Drawing.Size(73, 20);
            this.txtPrecioFacturacion.TabIndex = 33;
            this.txtPrecioFacturacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPrecioFacturacion_KeyDown);
            // 
            // txtItebisFacturacion
            // 
            this.txtItebisFacturacion.Location = new System.Drawing.Point(527, 613);
            this.txtItebisFacturacion.Name = "txtItebisFacturacion";
            this.txtItebisFacturacion.ReadOnly = true;
            this.txtItebisFacturacion.Size = new System.Drawing.Size(47, 20);
            this.txtItebisFacturacion.TabIndex = 34;
            // 
            // txtTotalFacturacion
            // 
            this.txtTotalFacturacion.Location = new System.Drawing.Point(647, 612);
            this.txtTotalFacturacion.Name = "txtTotalFacturacion";
            this.txtTotalFacturacion.ReadOnly = true;
            this.txtTotalFacturacion.Size = new System.Drawing.Size(121, 20);
            this.txtTotalFacturacion.TabIndex = 35;
            // 
            // dtgvProductosFacturacion
            // 
            this.dtgvProductosFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductosFacturacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdProducto,
            this.clnProducto,
            this.clnCantidadProducto,
            this.clnPrecioProducto,
            this.clnSubtotalProducto,
            this.clnItbisProducto,
            this.clnTotalProducto});
            this.dtgvProductosFacturacion.Location = new System.Drawing.Point(4, 256);
            this.dtgvProductosFacturacion.Name = "dtgvProductosFacturacion";
            this.dtgvProductosFacturacion.Size = new System.Drawing.Size(1089, 326);
            this.dtgvProductosFacturacion.TabIndex = 36;
            // 
            // lblCodigoClienteFacturacion
            // 
            this.lblCodigoClienteFacturacion.AutoSize = true;
            this.lblCodigoClienteFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoClienteFacturacion.Location = new System.Drawing.Point(224, 56);
            this.lblCodigoClienteFacturacion.Name = "lblCodigoClienteFacturacion";
            this.lblCodigoClienteFacturacion.Size = new System.Drawing.Size(63, 17);
            this.lblCodigoClienteFacturacion.TabIndex = 37;
            this.lblCodigoClienteFacturacion.Text = "Codigo:";
            // 
            // txtCodigoClienteFacturacion
            // 
            this.txtCodigoClienteFacturacion.Location = new System.Drawing.Point(293, 56);
            this.txtCodigoClienteFacturacion.Name = "txtCodigoClienteFacturacion";
            this.txtCodigoClienteFacturacion.Size = new System.Drawing.Size(151, 20);
            this.txtCodigoClienteFacturacion.TabIndex = 38;
            this.txtCodigoClienteFacturacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoClienteFacturacion_KeyDown);
            // 
            // lblDocumentoFacturacion
            // 
            this.lblDocumentoFacturacion.AutoSize = true;
            this.lblDocumentoFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoFacturacion.Location = new System.Drawing.Point(565, 125);
            this.lblDocumentoFacturacion.Name = "lblDocumentoFacturacion";
            this.lblDocumentoFacturacion.Size = new System.Drawing.Size(99, 17);
            this.lblDocumentoFacturacion.TabIndex = 39;
            this.lblDocumentoFacturacion.Text = "RNC|Cedula:";
            // 
            // txtDocumentoFacturacion
            // 
            this.txtDocumentoFacturacion.Location = new System.Drawing.Point(670, 122);
            this.txtDocumentoFacturacion.Name = "txtDocumentoFacturacion";
            this.txtDocumentoFacturacion.Size = new System.Drawing.Size(151, 20);
            this.txtDocumentoFacturacion.TabIndex = 40;
            // 
            // btnSalirFacturacion
            // 
            this.btnSalirFacturacion.BackColor = System.Drawing.SystemColors.Menu;
            this.btnSalirFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirFacturacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirFacturacion.Location = new System.Drawing.Point(25, 16);
            this.btnSalirFacturacion.Name = "btnSalirFacturacion";
            this.btnSalirFacturacion.Size = new System.Drawing.Size(75, 23);
            this.btnSalirFacturacion.TabIndex = 41;
            this.btnSalirFacturacion.Text = "Atras";
            this.btnSalirFacturacion.UseVisualStyleBackColor = false;
            this.btnSalirFacturacion.Click += new System.EventHandler(this.btnSalirFacturacion_Click);
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(565, 57);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(148, 17);
            this.lblNumeroFactura.TabIndex = 42;
            this.lblNumeroFactura.Text = "Numero de factura:";
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumeroFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroFactura.Location = new System.Drawing.Point(719, 57);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.ReadOnly = true;
            this.txtNumeroFactura.Size = new System.Drawing.Size(66, 21);
            this.txtNumeroFactura.TabIndex = 43;
            this.txtNumeroFactura.Text = "00000";
            // 
            // lblTotalFactura
            // 
            this.lblTotalFactura.AutoSize = true;
            this.lblTotalFactura.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTotalFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFactura.Location = new System.Drawing.Point(997, 203);
            this.lblTotalFactura.Name = "lblTotalFactura";
            this.lblTotalFactura.Size = new System.Drawing.Size(45, 20);
            this.lblTotalFactura.TabIndex = 44;
            this.lblTotalFactura.Text = "0000";
            // 
            // lblTotalFacturaGeneral
            // 
            this.lblTotalFacturaGeneral.AutoSize = true;
            this.lblTotalFacturaGeneral.BackColor = System.Drawing.SystemColors.Info;
            this.lblTotalFacturaGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFacturaGeneral.Location = new System.Drawing.Point(829, 200);
            this.lblTotalFacturaGeneral.Name = "lblTotalFacturaGeneral";
            this.lblTotalFacturaGeneral.Size = new System.Drawing.Size(162, 24);
            this.lblTotalFacturaGeneral.TabIndex = 45;
            this.lblTotalFacturaGeneral.Text = "Total de la factura:";
            // 
            // btnAplicarFactura
            // 
            this.btnAplicarFactura.Location = new System.Drawing.Point(979, 94);
            this.btnAplicarFactura.Name = "btnAplicarFactura";
            this.btnAplicarFactura.Size = new System.Drawing.Size(76, 33);
            this.btnAplicarFactura.TabIndex = 46;
            this.btnAplicarFactura.Text = "🗂️ Aplicar";
            this.btnAplicarFactura.UseVisualStyleBackColor = true;
            this.btnAplicarFactura.Click += new System.EventHandler(this.btnAplicarFactura_Click);
            // 
            // btnModificarFactura
            // 
            this.btnModificarFactura.Location = new System.Drawing.Point(979, 143);
            this.btnModificarFactura.Name = "btnModificarFactura";
            this.btnModificarFactura.Size = new System.Drawing.Size(76, 33);
            this.btnModificarFactura.TabIndex = 47;
            this.btnModificarFactura.Text = "📝 Modificar";
            this.btnModificarFactura.UseVisualStyleBackColor = true;
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
            // clnIdProducto
            // 
            this.clnIdProducto.HeaderText = "Id producto";
            this.clnIdProducto.Name = "clnIdProducto";
            this.clnIdProducto.ReadOnly = true;
            // 
            // clnProducto
            // 
            this.clnProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnProducto.HeaderText = "Producto";
            this.clnProducto.Name = "clnProducto";
            this.clnProducto.ReadOnly = true;
            // 
            // clnCantidadProducto
            // 
            this.clnCantidadProducto.HeaderText = "Cantidad";
            this.clnCantidadProducto.Name = "clnCantidadProducto";
            this.clnCantidadProducto.ReadOnly = true;
            // 
            // clnPrecioProducto
            // 
            this.clnPrecioProducto.HeaderText = "Precio";
            this.clnPrecioProducto.Name = "clnPrecioProducto";
            this.clnPrecioProducto.ReadOnly = true;
            // 
            // clnSubtotalProducto
            // 
            this.clnSubtotalProducto.HeaderText = "Sub total";
            this.clnSubtotalProducto.Name = "clnSubtotalProducto";
            this.clnSubtotalProducto.ReadOnly = true;
            // 
            // clnItbisProducto
            // 
            this.clnItbisProducto.HeaderText = "Itbis";
            this.clnItbisProducto.Name = "clnItbisProducto";
            this.clnItbisProducto.ReadOnly = true;
            // 
            // clnTotalProducto
            // 
            this.clnTotalProducto.HeaderText = "Total";
            this.clnTotalProducto.Name = "clnTotalProducto";
            this.clnTotalProducto.ReadOnly = true;
            // 
            // FrmFacturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1093, 661);
            this.Controls.Add(this.btnModificarFactura);
            this.Controls.Add(this.btnAplicarFactura);
            this.Controls.Add(this.lblTotalFacturaGeneral);
            this.Controls.Add(this.lblTotalFactura);
            this.Controls.Add(this.txtNumeroFactura);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.btnSalirFacturacion);
            this.Controls.Add(this.txtDocumentoFacturacion);
            this.Controls.Add(this.lblDocumentoFacturacion);
            this.Controls.Add(this.txtCodigoClienteFacturacion);
            this.Controls.Add(this.lblCodigoClienteFacturacion);
            this.Controls.Add(this.dtgvProductosFacturacion);
            this.Controls.Add(this.txtTotalFacturacion);
            this.Controls.Add(this.txtItebisFacturacion);
            this.Controls.Add(this.txtPrecioFacturacion);
            this.Controls.Add(this.txtCantidadFacturacion);
            this.Controls.Add(this.txtUnidadFacturacion);
            this.Controls.Add(this.txtNombreProductoFacturacion);
            this.Controls.Add(this.txtCodigoProductoFacturacion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblStockProductoFacturacion);
            this.Controls.Add(this.lblCodigoProductoFacturacion);
            this.Controls.Add(this.lblMostrarProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtmFechaFacturacion);
            this.Controls.Add(this.cbxTipoFacturacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSectorFacturacion);
            this.Controls.Add(this.txtCiudadFacturacion);
            this.Controls.Add(this.txtCorreoFacturacion);
            this.Controls.Add(this.txtTelefonoFacturacion);
            this.Controls.Add(this.txtDireccionFacturacion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtClienteFacturacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSectorFacturacion);
            this.Controls.Add(this.lblCiudadFacturacion);
            this.Controls.Add(this.lblCorreoFacturacion);
            this.Controls.Add(this.lblTelefonoFacturacion);
            this.Controls.Add(this.lblDireccionFacturacion);
            this.Controls.Add(this.lblDescripcionFacturacion);
            this.Controls.Add(this.lblClienteFacturacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmFacturar";
            this.Text = "Facturar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmFacturar_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductosFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClienteFacturacion;
        private System.Windows.Forms.Label lblDescripcionFacturacion;
        private System.Windows.Forms.Label lblDireccionFacturacion;
        private System.Windows.Forms.Label lblTelefonoFacturacion;
        private System.Windows.Forms.Label lblCorreoFacturacion;
        private System.Windows.Forms.Label lblCiudadFacturacion;
        private System.Windows.Forms.Label lblSectorFacturacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClienteFacturacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDireccionFacturacion;
        private System.Windows.Forms.TextBox txtTelefonoFacturacion;
        private System.Windows.Forms.TextBox txtCorreoFacturacion;
        private System.Windows.Forms.TextBox txtCiudadFacturacion;
        private System.Windows.Forms.TextBox txtSectorFacturacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipoFacturacion;
        private System.Windows.Forms.DateTimePicker dtmFechaFacturacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMostrarProductos;
        private System.Windows.Forms.Label lblCodigoProductoFacturacion;
        private System.Windows.Forms.Label lblStockProductoFacturacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCodigoProductoFacturacion;
        private System.Windows.Forms.TextBox txtNombreProductoFacturacion;
        private System.Windows.Forms.TextBox txtUnidadFacturacion;
        private System.Windows.Forms.TextBox txtCantidadFacturacion;
        private System.Windows.Forms.TextBox txtPrecioFacturacion;
        private System.Windows.Forms.TextBox txtItebisFacturacion;
        private System.Windows.Forms.TextBox txtTotalFacturacion;
        private System.Windows.Forms.DataGridView dtgvProductosFacturacion;
        private System.Windows.Forms.Label lblCodigoClienteFacturacion;
        private System.Windows.Forms.TextBox txtCodigoClienteFacturacion;
        private System.Windows.Forms.Label lblDocumentoFacturacion;
        private System.Windows.Forms.TextBox txtDocumentoFacturacion;
        private System.Windows.Forms.Button btnSalirFacturacion;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.Label lblTotalFactura;
        private System.Windows.Forms.Label lblTotalFacturaGeneral;
        private System.Windows.Forms.Button btnAplicarFactura;
        private System.Windows.Forms.Button btnModificarFactura;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrecioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSubtotalProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnItbisProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTotalProducto;
    }
}