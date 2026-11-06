using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Text;

namespace Sistema_Venta_E_Inventario
{
    public partial class FrmProductos : Form
    {
       //Conexion conexion = new Conexion();

        private int idProductoSeleccionado = 0;
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombreProducto.Text)||
                string.IsNullOrWhiteSpace(txtPrecioCompraProducto.Text)||
                string.IsNullOrWhiteSpace(txtPrecioVentaProducto.Text)||
                string.IsNullOrWhiteSpace(txtStockProducto.Text))
            {
                MessageBox.Show("Favor llenar las casillas!", "ERROR ESPACIO EN BLANCO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                using (SqlConnection cn = Conexion.abrirConexion())
                {
                    cn.Open();

                    string query = "Insert Into Productos(Nombre, Descripcion, PrecioCompra, PrecioVenta, StockActual, IdCategoria)" +
                        "Values(@nombre, @descripcion, @precioCompra, @precioventa, @stock, @idcategoria)";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcionProducto.Text.Trim());
                        cmd.Parameters.AddWithValue("@precioCompra", decimal.Parse(txtPrecioCompraProducto.Text.Trim()));
                        cmd.Parameters.AddWithValue("@precioventa", decimal.Parse(txtPrecioVentaProducto.Text.Trim()));
                        cmd.Parameters.AddWithValue("@stock", int.Parse(txtStockProducto.Text.Trim()));
                        cmd.Parameters.AddWithValue("@idCategoria", 1);

                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Producto guardado correctamente!", "PRODUCTO GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ListarProductos();

                LimpiarCampos();
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Favor verificar que los campos esten bien escritos!", "ERROR DE FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al guardar los productos!: " + ex.Message, "ERROR AL GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }    

        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                return;
            }
            ListarProductos();
            CargarCategorias();

        }

        public void ListarProductos()
        {
            try
            {
                using(SqlConnection cn = Conexion.abrirConexion())
                {
                    string query = "Select * from Productos";
                    SqlDataAdapter da = new SqlDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dtgvPanelProductos.DataSource = dt;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los productos!: " + ex.ToString(), "ERROR AL CARGAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection cn = Conexion.abrirConexion())
                {
                    cn.Open();

                    string query = "Select IdCategoria, Nombre FROM Categoria";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cbxCategoria.DataSource = dt;
                        cbxCategoria.DisplayMember = "Nombre";
                        cbxCategoria.ValueMember = "IdCategoria";
                    }

                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar los productos!: " + ex.Message, "MENSAJE DE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            
        }

        public void LimpiarCampos()
        {
            txtNombreProducto.Clear();
            txtDescripcionProducto.Clear();
            txtPrecioCompraProducto.Clear();
            txtPrecioVentaProducto.Clear();
            txtStockProducto.Clear();
            txtNombreProducto.Focus();
        }

        private void dtgvPanelProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dtgvPanelProductos.Rows[e.RowIndex];

                idProductoSeleccionado = Convert.ToInt32(fila.Cells["IdProductos"].Value);

                txtNombreProducto.Text = fila.Cells["Nombre"].Value.ToString();
                txtDescripcionProducto.Text = fila.Cells["Descripcion"].Value.ToString();
                txtPrecioCompraProducto.Text = fila.Cells["PrecioCompra"].Value.ToString();
                txtPrecioVentaProducto.Text = fila.Cells["PrecioVenta"].Value.ToString();
                txtStockProducto.Text = fila.Cells["StockActual"].Value.ToString();
                cbxCategoria.SelectedValue = fila.Cells["IdCategoria"].Value;
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text))
            {
                MessageBox.Show("Favor de seleccionar un producto de la tabla!", "ERROR AL MODIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection cn = Conexion.abrirConexion())
                {
                    cn.Open();

                    string query = "UPDATE Productos SET Descripcion = @descripcion, PrecioCompra = @preciocompra, PrecioVenta = @precioventa, StockActual = @stock " +
                        "WHERE Nombre = @nombre";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", txtNombreProducto.Text.Trim());
                        cmd.Parameters.AddWithValue("@descripcion", txtDescripcionProducto.Text.Trim());
                        cmd.Parameters.AddWithValue("@preciocompra", decimal.Parse(txtPrecioCompraProducto.Text.Trim()));
                        cmd.Parameters.AddWithValue("@precioventa", decimal.Parse(txtPrecioVentaProducto.Text.Trim()));
                        cmd.Parameters.AddWithValue("@stock", int.Parse(txtStockProducto.Text.Trim()));

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Productos modificados correctamente!", "PRODUCTOS MODIFICADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            MessageBox.Show("No se encontro el producto a modificar!", "ERROR MODIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    
                }
                ListarProductos();
                LimpiarCampos();

            }
            catch(FormatException)
            {
                MessageBox.Show("Favor verificar los campos que esten bien escritos!", "ERROR FORMATO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar los productos!: " + ex.Message, "ERROR MODIFICAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Favor de seleccionar un producto de la tabla para eliminar!", "ERROR AL ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("Estas seguro que deseas eliminar este producto?", "CONFIRMAR ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                   using (SqlConnection cn = Conexion.abrirConexion())
                    {
                        cn.Open();

                        string query = "DELETE FROM Productos WHERE IdProductos = @idproductos";

                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            cmd.Parameters.AddWithValue("@idproductos", idProductoSeleccionado);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Producto eliminado correctamente!", "PRODUCTO ELIMINADO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    ListarProductos();
                    LimpiarCampos();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al eliminar el producto!: " + ex.Message, "ERROR AL ELIMINAR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void FrmProductos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSalirProductos_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal menuprincipal = new FrmMenuPrincipal();

            menuprincipal.Show();
            this.Hide();
        }
    }
}
