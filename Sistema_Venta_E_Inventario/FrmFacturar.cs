using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Venta_E_Inventario
{
    public partial class FrmFacturar : Form
    {
        public FrmFacturar()
        {
           
            InitializeComponent();

        }

        private void txtCodigoClienteFacturacion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtCodigoClienteFacturacion.Text))
                {
                    MessageBox.Show("Favor poner el codigo del cliente!", "ERROR FACTURAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                try
                {
                    using (SqlConnection cn  = Conexion.abrirConexion())
                    {
                        cn.Open();

                        string query = "Select Documento, NombreCompleto, Telefono, Correo, Direccion, Ciudad, Sector From Clientes Where IdCliente = @IdCliente";

                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(txtCodigoClienteFacturacion.Text.Trim()));

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtDocumentoFacturacion.Text = reader["Documento"].ToString();
                                    txtClienteFacturacion.Text = reader["NombreCompleto"].ToString();
                                    txtTelefonoFacturacion.Text = reader["Telefono"].ToString();
                                    txtCorreoFacturacion.Text = reader["Correo"].ToString();
                                    txtDireccionFacturacion.Text = reader["Direccion"].ToString();
                                    txtCiudadFacturacion.Text = reader["Ciudad"].ToString();
                                    txtSectorFacturacion.Text = reader["Sector"].ToString();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontro el codigo del cliente!", "ERRO AL ENCONTRAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    txtDocumentoFacturacion.Clear();
                                    txtClienteFacturacion.Clear();
                                    txtTelefonoFacturacion.Clear();
                                    txtCorreoFacturacion.Clear();
                                    txtDireccionFacturacion.Clear();
                                    txtCiudadFacturacion.Clear();
                                    txtSectorFacturacion.Clear();
                                    
                                }
                            }
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al encontrar el cliente!" + ex.Message, "ERROR AL BUSCAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                e.SuppressKeyPress = true;
            }
        }

        private void FrmFacturar_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalirFacturacion_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmmenuprincipal = new FrmMenuPrincipal();

            frmmenuprincipal.Show();
            this.Hide();
        }

        private void txtCodigoProductoFacturacion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtCodigoProductoFacturacion.Text))
                {
                    MessageBox.Show("Favor colocar el codigo del producto!", "ERROR AL FACTURAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (SqlConnection cn = Conexion.abrirConexion())
                    {
                        cn.Open();

                        string query = "Select IdProductos, Nombre, Descripcion, PrecioVenta, StockActual From Productos Where IdProductos = @IdProducto";

                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@IdProducto", Convert.ToInt32(txtCodigoProductoFacturacion.Text.Trim()));

                            using(SqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    txtCodigoProductoFacturacion.Text = reader["IdProductos"].ToString();
                                    txtNombreProductoFacturacion.Text = reader["Nombre"].ToString();
                                    txtUnidadFacturacion.Text = "0000";
                                    txtCantidadFacturacion.Text = "1";
                                    txtUnidadFacturacion.Text = reader["StockActual"].ToString();
                                    txtItebisFacturacion.Text = "1.18%";
                                    txtPrecioFacturacion.Text = reader["PrecioVenta"].ToString();


                                    txtCantidadFacturacion.Focus();
                                    

                                }
                                else
                                {
                                    MessageBox.Show("No se encontro ningun producto con ese codigo!", "ERROR AL BUSCAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtCodigoProductoFacturacion.Clear();
                                }
                            }

                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al buscar los productos: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                e.SuppressKeyPress = true;
            }

        }

        private void txtCantidadFacturacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtCantidadFacturacion.Text))
                {
                    MessageBox.Show("Debe indicar una cantidad!", "ERROR AL FACTURAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtPrecioFacturacion.Focus();
                txtPrecioFacturacion.SelectAll();

                e.SuppressKeyPress = true;

            }
        }

        private void txtPrecioFacturacion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(txtPrecioFacturacion.Text))
                {
                    MessageBox.Show("Favor ponga el precio del producto!", "ERROR FACTURAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                      
                }

                try
                {
                    decimal cantidad = Convert.ToDecimal(txtCantidadFacturacion.Text.Trim());
                    decimal precio = Convert.ToDecimal(txtPrecioFacturacion.Text.Trim());

                    decimal subtotal = cantidad * precio;
                    decimal itbis = subtotal * 0.18m;
                    decimal total = subtotal + itbis;

                    txtTotalFacturacion.Text = total.ToString("N2");

                    dtgvProductosFacturacion.Rows.Add(
                        txtCodigoProductoFacturacion.Text.Trim(),
                        txtNombreProductoFacturacion.Text.Trim(),
                        txtCantidadFacturacion.Text.Trim(),
                        txtPrecioFacturacion.Text.Trim(),
                        subtotal.ToString("N2"),
                        itbis.ToString("N2"),
                        total.ToString("N2")
                        );

                    CalcularTotal();

                    

                    txtCodigoProductoFacturacion.Clear();
                    txtNombreProductoFacturacion.Clear();
                    txtCantidadFacturacion.Clear();
                    txtPrecioFacturacion.Clear();
                    txtUnidadFacturacion.Clear();

                    txtCodigoProductoFacturacion.Focus();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar los productos!" + ex.Message, "ERROR AL FACTURAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                e.SuppressKeyPress = true;
            }
        }

        private void CalcularTotal()
        {
            decimal subtotalGeneral = 0;
            decimal itbisGeneral = 0;
            decimal totalGeneral = 0;

            foreach(DataGridViewRow row in dtgvProductosFacturacion.Rows)
            {
                if (row.IsNewRow) continue;

                decimal subTotalFila = Convert.ToDecimal(row.Cells[4].Value ?? 0);
                decimal itbisFila = Convert.ToDecimal(row.Cells[5].Value ?? 0);
                decimal totalFila = Convert.ToDecimal(row.Cells[6].Value ?? 0);

                subtotalGeneral += subTotalFila;
                itbisGeneral += itbisFila;
                totalGeneral += totalFila;
            }
            lblTotalFactura.Text = totalGeneral.ToString("N2");
        }

        private void btnAplicarFactura_Click(object sender, EventArgs e)
        {
            if (dtgvProductosFacturacion.Rows.Count < 1 || (dtgvProductosFacturacion.Rows.Count == 1 && dtgvProductosFacturacion.Rows[0].IsNewRow))
            {
                MessageBox.Show("No hay productos para aplicar!", "ERROR AL FACTURAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal montoTotal = 0;
            foreach(DataGridViewRow row in dtgvProductosFacturacion.Rows)
            {
                if (row.IsNewRow) continue;
                montoTotal += Convert.ToDecimal(row.Cells[6].Value ?? 0);
            }

            string tipoVenta = cbxTipoFacturacion.SelectedItem?.ToString() ?? "Contado";
            decimal montoPago = 0;
            decimal montoCambio = 0;

            if (tipoVenta == "Contado")
            {
                FrmCobrar frmcobrar = new FrmCobrar(montoTotal);

                if (frmcobrar.ShowDialog() == DialogResult.OK)
                {
                    montoPago = frmcobrar.MontoPago;
                    montoCambio = frmcobrar.MontoDevuelta;
                }
                else
                {
                    return;
                }
            }
            else
            {
                montoPago = 0;
                montoCambio = 0;


            }

            using (SqlConnection cn = Conexion.abrirConexion())
            {
                if(cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }

                SqlTransaction transaccion = cn.BeginTransaction();

                try
                {
                    string queryVentas = @"Insert Into Ventas(IdCliente, FechaRegistro, MontoTotal, MontoPago, MontoCambio)
                                            Output INSERTED.IdVenta
                                             Values(@IdCliente, GetDate(), @MontoTotal, @MontoPago, @MontoCambio)";

                    int idVentaGenerada = 0;
                    using (SqlCommand cmdVenta = new SqlCommand(queryVentas, cn, transaccion))
                    {
                        cmdVenta.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(txtCodigoClienteFacturacion.Text));
                        cmdVenta.Parameters.AddWithValue("@MontoTotal", montoTotal);
                        cmdVenta.Parameters.AddWithValue("@MontoPago", montoPago);
                        cmdVenta.Parameters.AddWithValue("@MontoCambio", montoCambio);

                        idVentaGenerada = (int)cmdVenta.ExecuteScalar();
                    }

                    foreach(DataGridViewRow row in dtgvProductosFacturacion.Rows)
                    {
                        if (row.IsNewRow) continue;

                        int idProducto = Convert.ToInt32(row.Cells[0].Value);
                        int cantidad = Convert.ToInt32(row.Cells[2].Value);
                        decimal precioVenta = Convert.ToDecimal(row.Cells[3].Value);
                        decimal subTotal = Convert.ToDecimal(row.Cells[4].Value);

                        string queryDetalle = @"Insert Into DetalleVentas (IdVenta, IdProducto, PrecioVentas, Cantidad, Subtotal)
                                                Values(@IdVenta, @IdProducto, @PrecioVentas, @Cantidad, @SubTotal)";

                        using (SqlCommand cmdDetalle = new SqlCommand(queryDetalle, cn, transaccion))
                        {
                            cmdDetalle.Parameters.AddWithValue("@IdVenta", idVentaGenerada);
                            cmdDetalle.Parameters.AddWithValue("@IdProducto", idProducto);
                            cmdDetalle.Parameters.AddWithValue("@PrecioVentas", precioVenta);
                            cmdDetalle.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmdDetalle.Parameters.AddWithValue("@SubTotal", subTotal);
                            cmdDetalle.ExecuteNonQuery();
                        }

                        string queryStock = "Update Productos SET StockActual = StockActual - @Cantidad WHERE IdProductos = @IdProducto";
                        using(SqlCommand cmdStock = new SqlCommand(queryStock, cn, transaccion))
                        {
                            cmdStock.Parameters.AddWithValue("@Cantidad", cantidad);
                            cmdStock.Parameters.AddWithValue("@IdProducto", idProducto);
                            cmdStock.ExecuteNonQuery();
                        }

                    }
                    transaccion.Commit();
                    MessageBox.Show("Venta registrada correctamente!", "VENTA REGISTRADA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtNumeroFactura.Text = idVentaGenerada.ToString("D5");

                    //Vincula la ventana o vista previa a facturar
                    printPreviewDialog1.Document = printDocument1;

                    //Esto abre la ventana previa a imprimir
                    printPreviewDialog1.ShowDialog();



                }
                catch(Exception ex)
                {
                    transaccion.Rollback();
                    MessageBox.Show("Error al facturar la venta!: " + ex.Message, "ERROR AL FACTURAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font fuenteTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fuenteNegrita = new Font("Arial", 10, FontStyle.Bold);
            Font fuenteNormal = new Font("Arial", 10, FontStyle.Regular);
            Brush pincel = Brushes.Black;

            float x = 20;
            float y = 20;

            //Encabezado
            e.Graphics.DrawString("SISTEMA DE FACTURACION", fuenteTitulo, pincel, x + 80, y);
            y += 25;

            e.Graphics.DrawString("RNC/Cedula: 123456789", fuenteNormal, pincel, x + 130, y);
            y += 20;

            e.Graphics.DrawString("------------------------------------------------------------------------", fuenteNormal, pincel, x, y);
            y += 20;

            //Datos de la factura
            e.Graphics.DrawString("NroFactura: " + txtNumeroFactura.Text, fuenteNegrita, pincel, x, y);
            e.Graphics.DrawString("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fuenteNormal, pincel, x + 230, y);
            y += 20;
            e.Graphics.DrawString("Cliente: " + txtClienteFacturacion.Text, fuenteNormal, pincel, x, y);
            y += 25;

            //Cabecera de la tabla producto
            e.Graphics.DrawString("Cant: ", fuenteNegrita, pincel, x, y);
            e.Graphics.DrawString("Descripcion: ", fuenteNegrita, pincel, x + 60, y);
            e.Graphics.DrawString("Precio: ", fuenteNegrita, pincel, x + 260, y);
            e.Graphics.DrawString("SubTotal: ", fuenteNegrita, pincel, x + 360, y);
            y += 15;
            e.Graphics.DrawString("--------------------------------------------------------------------------", fuenteNegrita, pincel, x, y);
            y += 20;

            foreach(DataGridViewRow row in dtgvProductosFacturacion.Rows)
            {
                if (row.IsNewRow) continue;

                string cantidad = row.Cells["clnCantidadProducto"].Value?.ToString() ?? "";
                string producto = row.Cells["clnProducto"].Value?.ToString() ?? "";
                string precio = row.Cells["clnPrecioProducto"].Value?.ToString() ?? "";
                string subtotal = row.Cells["clnSubTotalProducto"].Value?.ToString() ?? "";

                e.Graphics.DrawString(cantidad, fuenteNormal, pincel, x, y);

                if (producto.Length > 25) producto = producto.Substring(0, 19) + "...";
                e.Graphics.DrawString(producto, fuenteNormal, pincel, x + 60, y);
                e.Graphics.DrawString(precio, fuenteNormal, pincel, x + 260, y);
                e.Graphics.DrawString(subtotal, fuenteNormal, pincel, x + 360, y);

                y += 20;
            }

            y += 10;
            e.Graphics.DrawString("----------------------------------------------------------------------------", fuenteNormal, pincel, x, y);
            y += 25;

            e.Graphics.DrawString("TOTAL A PAGAR: " + lblTotalFactura.Text, fuenteTitulo, pincel, x + 150, y);




        }
    }
}
