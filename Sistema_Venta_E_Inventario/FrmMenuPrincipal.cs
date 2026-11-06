using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Venta_E_Inventario
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnVentanaProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frmproductos = new FrmProductos();

            frmproductos.Show();
            this.Hide();
        }

        private void FrmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnVentanaFacturar_Click(object sender, EventArgs e)
        {
            FrmFacturar frmfacturar = new FrmFacturar();

            frmfacturar.Show();
            this.Hide();
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            FrmReporteVenta frmreporteventa = new FrmReporteVenta();
            frmreporteventa.ShowDialog();
            this.Hide();
        }
    }
}
