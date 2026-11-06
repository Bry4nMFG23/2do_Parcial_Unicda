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
    public partial class FrmReporteVenta : Form
    {
        public FrmReporteVenta()
        {
            InitializeComponent();
        }

        private void FrmReporteVenta_Load(object sender, EventArgs e)
        {
            CargarVentas("");
        }

        private void CargarVentas(string filtroCliente)
        {
            try
            {
                using (SqlConnection cn = Conexion.abrirConexion())
                {
                    string query = @"Select v.IdVenta As [Nro Factura],
                                    c.NombreCompleto As [Cliente],
                                    v.FechaRegistro As [Fecha y hora],
                                    v.MontoTotal As [Total],
                                    v.MontoPago As [Monto Pagado],
                                    v.MontoCambio As [Devuelta]
                                    From Ventas v
                                    Inner Join Clientes c On v.IdCliente = c.IdCliente ";

                    if (!string.IsNullOrWhiteSpace(filtroCliente))
                    {
                        query += " Where c.NombreCompleto Like @Filtro";
                    }

                    query += " Order BY v.IdVenta Desc";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        if (!string.IsNullOrWhiteSpace(filtroCliente))
                        {
                            cmd.Parameters.AddWithValue("@Filtro", "%" + filtroCliente + "%");
                        }

                        using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);
                            dtgvDatosReporteVenta.DataSource = dt;
                        }
                    }
                        

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de ventas: " + ex.Message, "ERROR REPORTE VENTA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtBuscarReporteVenta_TextChanged(object sender, EventArgs e)
        {
            CargarVentas(txtBuscarReporteVenta.Text.Trim());
        }

        private void btnAtrasReporteVenta_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal();
            frmMenuPrincipal.Show();
            this.Hide();
        }

        private void FrmReporteVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private string idFacturaSeleccionada = "";
        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            if(dtgvDatosReporteVenta.SelectedRows.Count > 0)
            {
                idFacturaSeleccionada = dtgvDatosReporteVenta.SelectedRows[0].Cells["Nro Factura"].Value.ToString();

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una factura para imprimir!", "ERROR AL IMPRIMIR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------", fuenteNormal, pincel, x, y);
            y += 20;

            //Datos de la factura
            string clienteFactura = "";
            string totalFactura = "";
            string fechaFactura = "";
            decimal totalitbisGeneral = 0;

            using (SqlConnection cn = Conexion.abrirConexion())
            {
                if(cn.State == ConnectionState.Closed)
                {
                    cn.Open();

                }

                string queryVenta = @"Select c.NombreCompleto, v.FechaRegistro, v.MontoTotal
                                    From Ventas v
                                    Inner Join Clientes c On v.IdCliente = c.IdCliente
                                    Where v.IdVenta = @IdVenta";

                using(SqlCommand cmd = new SqlCommand(queryVenta, cn))
                {
                    cmd.Parameters.AddWithValue("@IdVenta", idFacturaSeleccionada);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            clienteFactura = reader["NombreCompleto"].ToString();
                            fechaFactura = Convert.ToDateTime(reader["FechaRegistro"]).ToString("dd/MM/yyyy HH:mm");
                            totalFactura = reader["MontoTotal"].ToString();
                        }

                    }
                }
            }

            e.Graphics.DrawString("Nro Factura: " + idFacturaSeleccionada.PadLeft(5, '0'), fuenteNegrita, pincel, x, y);
            e.Graphics.DrawString("Fecha: " + fechaFactura, fuenteNormal, pincel, x + 230, y);
            y += 20;
            e.Graphics.DrawString("Cliente: " + clienteFactura, fuenteNormal, pincel, x, y);
            y += 25;

            e.Graphics.DrawString("Cant: ", fuenteNegrita, pincel, x, y);
            e.Graphics.DrawString("Descripcion: ", fuenteNegrita, pincel, x + 60, y);
            e.Graphics.DrawString("Precio: ", fuenteNegrita, pincel, x + 260, y);
            //e.Graphics.DrawString("Itbis: ", fuenteNegrita, pincel, x + 430, y);
            e.Graphics.DrawString("SubTotal: ", fuenteNegrita, pincel, x + 360, y);
            y += 15;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------------------------", fuenteNormal, pincel, x, y);
            y += 20;

            //Aqui consulta los productos de la venta desde la base de datos
            using(SqlConnection cn = Conexion.abrirConexion())
            {
                if (cn.State == ConnectionState.Closed) cn.Open();

                string queryDetalle = @"Select d.Cantidad, p.Nombre, d.PrecioVentas, d.SubTotal
                                        From DetalleVentas d
                                        Inner Join Productos p On d.IdProducto = p.IdProductos
                                        Where d.IdVenta = @IdVenta";

                using (SqlCommand cmd = new SqlCommand(queryDetalle, cn))
                {
                    cmd.Parameters.AddWithValue("@IdVenta", idFacturaSeleccionada);

                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string cantidadStr = reader["Cantidad"].ToString();
                            string producto = reader["Nombre"].ToString();
                            string precio = reader["PrecioVentas"].ToString();
                            string subtotalStr = reader["SubTotal"].ToString();

                            decimal cantidad = Convert.ToDecimal(cantidadStr);
                            decimal subtotal = Convert.ToDecimal(subtotalStr);
                            decimal itbis = subtotal * 0.18m;
                            totalitbisGeneral += itbis;


                            e.Graphics.DrawString(cantidadStr, fuenteNormal, pincel, x, y);
                            if (producto.Length > 22) producto = producto.Substring(0, 19) + "...";
                            e.Graphics.DrawString(producto, fuenteNormal, pincel, x + 60, y);
                            e.Graphics.DrawString(precio, fuenteNormal, pincel, x + 260, y);
                            e.Graphics.DrawString(subtotalStr, fuenteNormal, pincel, x + 330, y);

                            y += 20;
                        }
                    }
                }

            }

            y += 10;
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------", fuenteNormal, pincel, x, y);
            y += 25;

            e.Graphics.DrawString("Impuestos total: " + totalitbisGeneral.ToString("N2"), fuenteNegrita, pincel, x + 155, y);
            y += 30;
            e.Graphics.DrawString("TOTAL A PAGAR: " + totalFactura, fuenteNegrita, pincel, x + 160, y);


        }
    }
}
